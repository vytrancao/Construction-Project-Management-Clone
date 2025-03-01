FROM nginx:1.25.3

# Install dependencies including Certbot and procps
RUN apt-get update && \
    apt-get install -y certbot python3-certbot-nginx procps && \
    apt-get clean && \
    rm -rf /var/lib/apt/lists/* /tmp/* /var/tmp/*

# Create necessary directories and set permissions
RUN mkdir -p /var/run /var/run/nginx /var/log/nginx && \
    chown nginx:nginx /var/run /var/log/nginx /var/run/nginx

# Copy configuration files and scripts
COPY configuration/custom_proxy_settings.conf /etc/nginx/conf.d/custom_proxy_settings.conf
COPY templates/default.conf.template /etc/nginx/templates/default.conf.template
COPY templates/ssl.conf.template /etc/nginx/templates/ssl.conf.template
COPY scripts/start-nginx.sh /start-nginx.sh

# Ensure the startup script is executable
RUN chmod +x /start-nginx.sh

# Set environment variables for Nginx templates
ENV NGINX_ENVSUBST_TEMPLATE_DIR=/etc/nginx/templates
ENV NGINX_ENVSUBST_OUTPUT_DIR=/etc/nginx/conf.d

# Start Nginx using the custom script
CMD ["/start-nginx.sh"]
