#!/bin/sh

# Ensure replication slot name is provided
if [ -z "$REPLICATION_SLOT" ]; then
  echo "Error: REPLICATION_SLOT is not set!"
  exit 1
fi

if [ "$(ls -A /var/lib/postgresql/data)" ]; then
  echo "PostgreSQL data directory is not empty. Skipping base backup."
else 
  echo "Starting base backup from $MASTER_DB_HOST..."
  su-exec postgres pg_basebackup -h $MASTER_DB_HOST \
    -D /var/lib/postgresql/data \
    -U $POSTGRES_DB \
    -P -v -R -X stream -C -S "$REPLICATION_SLOT"

  echo "Setting permissions..."
  chown -R postgres:postgres /var/lib/postgresql/data
  chmod 0700 /var/lib/postgresql/data
fi

echo "Starting PostgreSQL..."
exec su-exec postgres postgres
