#!/bin/sh

# Ensure replication slot name is provided
if [ -z "$REPLICATION_SLOT" ]; then
  echo "Error: REPLICATION_SLOT is not set!"
  exit 1
fi

echo "Clearing existing PostgreSQL data..."
rm -rf /var/lib/postgresql/data/*

echo "Starting base backup from master_db..."
su-exec postgres pg_basebackup -h master_db \
  -D /var/lib/postgresql/data \
  -U $POSTGRES_DB \
  -P -v -R -X stream -C -S "$REPLICATION_SLOT"

echo "Setting permissions..."
chown -R postgres:postgres /var/lib/postgresql/data
chmod 0700 /var/lib/postgresql/data

echo "Starting PostgreSQL..."
exec su-exec postgres postgres
