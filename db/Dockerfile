FROM mcr.microsoft.com/mssql/server:2019-latest

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Password1!
ENV MSSQL_PID=Developer

EXPOSE 1433

WORKDIR /src
COPY setup.sql ./setup.sql
RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" &&  \
    /opt/mssql-tools/bin/sqlcmd -S127.0.0.1 -Usa -P Password1! -i setup.sql