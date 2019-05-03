# EF Core + PostegreSQL + HiLo Sequences
This repo is a sample ASP.NET Core API which access a PostgreSQL database using EF Core.

The repo demonstrates how to configure [HiLo Sequences](https://www.npgsql.org/efcore/value-generation.html#hilo-autoincrement-generation) on EF Core. The motivation is to answer this SO question: [How to resolve EF Core migration error with HiLo?](https://stackoverflow.com/questions/55965928/how-to-resolve-ef-core-migration-error-with-hilo)


## Requirements:

- .NET SDK 2.2.x
- Docker and Docker Compose

## How to run this sample:

1. Clone the repo: `git clone git@github.com:joaopgrassi/efcore-postgres-hilo-sequence.git`
2. Go to the root folder and run `docker-compose up` to fire up both `PostgresSQL` and `pgAdmin 4`.
3. Create the database: `dotnet ef database update`
4. Run the ASP.NET Core app: `dotnet run` from the `src\Web` folder

## Credentials

The credentials for both PostgreSQL and pgAdmin can be found in the `docker-compose.yml` file.

### Login to pgAdmin

1. Navigate to `http://localhost:5050`
2. Enter the credentials found on `PGADMIN_DEFAULT_EMAIL` and `PGADMIN_DEFAULT_PASSWORD`
3. Create a connection: Host: `postgres_efcoresequence_container` and default user `postgres`




