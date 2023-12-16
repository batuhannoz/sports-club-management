FROM mcr.microsoft.com/mssql/server:2019-latest

ENV ACCEPT_EULA=Y
ENV SA_PASSWORD=Password1!
ENV MSSQL_PID=Developer

EXPOSE 1433

USER root

RUN mkdir -p /var/opt/mssql/backups
RUN chown -R mssql: /var/opt/mssql/backups

USER mssql

WORKDIR /src
COPY setup.ddl ./setup.ddl
COPY data.dml ./data.dml

RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" &&  \
    /opt/mssql-tools/bin/sqlcmd -S127.0.0.1 -U sa -P Password1! -i setup.ddl

RUN (/opt/mssql/bin/sqlservr --accept-eula & ) | grep -q "Service Broker manager has started" &&  \
    /opt/mssql-tools/bin/sqlcmd -S127.0.0.1 -U sa -P Password1! -i data.dml