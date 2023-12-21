# sports-club-management
Simple application for sport club management

### Goals: 

- [x] Entity-Relationship Model
- [x] Schema Diagram
- [x] Min 4 Tables
- [x] Min 3 Triggers
- [x] Min 2 Stored Procedure
- [x] Export Results as pdf/doc/xls
- [ ] Import Data From Files from txt/csv/xls
- [x] Authentication With Username and Password
- [x] User Identification and Authorization (Read/Enter/Update/Delete) with Admin User
- [x] Back up & Restore DB
- [ ] PDF
- [ ] DVD

Use [draw.io](https://app.diagrams.net/) to design and edit entity relationship diagram ([ER_Diagram.drawio](https://github.com/batuhannoz/sports-club-management/blob/main/ER_Diagram.drawio))

### Build and run sql server in a docker container
##### /db
```bash
 docker build -t sports-club-db .
```
```bash
 docker run -v backups:/var/opt/mssql/backups -p 1433:1433 -d sports-club-db
```
    
