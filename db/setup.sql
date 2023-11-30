CREATE DATABASE sports_club
GO

USE sports_club
GO

CREATE TABLE [health_status] (
    [id] int PRIMARY KEY,
    [weight] int,
    [height] int
)
GO

CREATE TABLE [address] (
    [id] int PRIMARY KEY IDENTITY,
    [city] varchar(50),
    [district] varchar(50),
    [neighborhood] varchar(50),
    [street] varchar(50)
)
GO

CREATE TABLE [user] (
    [id] integer PRIMARY KEY IDENTITY,
    [name] varchar(50),
    [surname] nvarchar(50),
    [date_of_birth] date,
    CONSTRAINT ck_dob CHECK (date_of_birth <= getdate()),
    [gender] char(1),
    CONSTRAINT ck_gender CHECK (gender IN ('M', 'F')),
    [phone_number] varchar(15),
    [email] varchar(50),
    [password] varchar(50),
    [address_id] int,
    CONSTRAINT fk_address_id FOREIGN KEY (address_id) REFERENCES [address](id),
    [health_status_id] int,
    CONSTRAINT fk_health_status_id FOREIGN KEY (health_status_id) REFERENCES [health_status](id)
)
GO

CREATE TABLE [plan] (
    [id] int PRIMARY KEY IDENTITY,
    [name] varchar(50),
    [description] varchar(150),
    [price] money,
    [type] varchar(10),
    CONSTRAINT ck_type CHECK (type IN ('group', 'individual')),
    [status] nvarchar(255)
)
GO

CREATE TABLE [timetable] (
    [id] int PRIMARY KEY IDENTITY,
    [plan_id] int,
    [week_day] tinyint,
    CONSTRAINT ck_week_day CHECK (week_day >= 0 AND week_day <= 6),
    [start_time] time,
    [end_time] time
)
GO

CREATE TABLE [subscription] (
    [id] int PRIMARY KEY IDENTITY,
    [start_date] datetime,
    [expire_date] datetime,
    [next_pay_date] datetime,
    [user_id] int,
    CONSTRAINT fk_user_id FOREIGN KEY (user_id) REFERENCES [user](id),
    [plan_id] int,
    CONSTRAINT fk_plan_id FOREIGN KEY (plan_id) REFERENCES [plan](id)
)
GO

CREATE TABLE [admin] (
    [id] int PRIMARY KEY IDENTITY,
    [name] varchar,
    [password] varchar(50)
)
GO