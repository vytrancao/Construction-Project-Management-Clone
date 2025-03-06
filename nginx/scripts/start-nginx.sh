#!/bin/bash

# Stop NGINX gracefully if it's running
if pgrep nginx > /dev/null; then
  echo "Stopping NGINX..."
  nginx -s stop
fi

# Ensure necessary directories exist and have correct permissions
mkdir -p /var/run /var/log/nginx /var/run/nginx
chown -R nginx:nginx /var/run /var/log/nginx /var/run/nginx

# Select the correct Nginx configuration template based on the environment
if [ "$ENVIRONMENT" == "production" ]; then
  NGINX_TEMPLATE_PATH="/etc/nginx/templates/ssl.conf.template"
  echo "Using SSL configuration for production environment."
else
  NGINX_TEMPLATE_PATH="/etc/nginx/templates/default.conf.template"
  echo "Using default configuration for non-production environment."
fi

# Replace domain placeholders in the selected Nginx configuration template with actual values
echo "Replacing domain placeholders in Nginx configuration..."
envsubst '' < $NGINX_TEMPLATE_PATH > /etc/nginx/conf.d/nginx.conf

# Ensure the user directive is not present in /etc/nginx/conf.d/nginx.conf
sed -i '/user/d' /etc/nginx/conf.d/nginx.conf

# Run Certbot to obtain or renew SSL certificates without interaction
echo "Running Certbot to obtain SSL certificates..."
#certbot certonly --standalone \
#  -d "${API_DOMAIN}" -d "${UI_DOMAIN}" -d "${ADDIN_DOMAIN}" \
#  --email "${CERTBOT_EMAIL}" --agree-tos --no-eff-email \
#  --non-interactive --renew-with-new-domains --force-renewal -v

# Check for Certbot errors and handle them
if [ $? -ne 0 ]; then
  echo "Certbot failed to obtain certificates. Please check the arguments and ensure the ports are available."
  exit 1
fi

# Start NGINX in the foreground
echo "Starting NGINX..."
nginx -g 'daemon off;'
