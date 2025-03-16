# Use the latest Alpine image
FROM alpine:latest

# Update package list and install openssh-keygen
RUN apk update && \
    apk add --no-cache openssh-keygen openssh-client

# Set the default command (optional, can be overridden)
CMD ["sh"]