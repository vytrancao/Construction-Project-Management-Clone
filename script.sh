docker exec -it idp_master_db psql -U postgres -d postgres -c "SELECT * FROM pg_replication_slots;"
docker exec -it slave_db2 pg_basebackup -h master_db -D /var/lib/postgresql/data -U cpm_db -P -v -R -X stream -C -S slave_2

docker network create \
  --driver bridge \
  --subnet 172.24.0.0/16 \
  cpm_network

dotnet ef migrations add --project Persistence/Persistence.csproj --startup-project Api/Api.csproj --context Persistence.Database.IdentityDbContext --configuration Debug Initial --output-dir Migrations
