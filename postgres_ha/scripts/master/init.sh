#!/bin/bash
set -e

# Append replication rule dynamically
echo "Adding replication rule for database: $POSTGRES_DB"
echo "host    replication     $POSTGRES_DB      172.23.0.0/16     md5" >> /var/lib/postgresql/data/pg_hba.conf
# echo "host    replication     $POSTGRES_DB      all     md5" >> /var/lib/postgresql/data/pg_hba.conf
psql -U postgres <<EOSQL
    CREATE ROLE $POSTGRES_DB WITH REPLICATION LOGIN PASSWORD '$POSTGRES_PASSWORD';
EOSQL