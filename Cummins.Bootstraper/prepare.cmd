rmdir Migrations /s /q

set psql=c:\DispenSenseEnvironment\PgSQL\bin\psql.exe 
set dbName=cummins
set scriptsDir=Scripts\InitDataBase\Postgres

set connString=postgresql://postgres:postgres@localhost 

%psql% -a -c "ALTER DATABASE %dbName% CONNECTION LIMIT 0;" %connString%
%psql% -a -c "SELECT pg_terminate_backend(pid) FROM pg_stat_activity WHERE datname = '%dbName%';" %connString%
%psql% -a -c "drop database if exists %dbName%" %connString%

dotnet ef migrations add InitialCreate
dotnet ef database update