CREATE DATABASE sports_club
GO

USE [sports_club];
GO

CREATE LOGIN [admin] WITH PASSWORD = 'Password1!';
CREATE USER [admin] FOR LOGIN [admin];
ALTER ROLE [db_owner] ADD MEMBER [admin];
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
)
GO

CREATE TABLE [deleted_users] (
    [id] integer PRIMARY KEY,
    [name] varchar(50),
    [surname] nvarchar(50),
    [date_of_birth] date,
    [gender] char(1),
    [phone_number] varchar(15),
    [email] varchar(50),
    [password] varchar(50)
);
GO

CREATE TRIGGER [trg_user_deleted]
ON [user]
AFTER DELETE
AS
BEGIN
    INSERT INTO deleted_users
    SELECT
        [id],
        [name],
        [surname],
        [date_of_birth],
        [gender],
        [phone_number],
        [email],
        [password]
    FROM
        deleted;
END;
GO

CREATE TABLE [health_status] (
    [id] int PRIMARY KEY IDENTITY,
    [user_id] int,
    CONSTRAINT fk_health_status_user_id FOREIGN KEY (user_id) REFERENCES [user](id) ON DELETE CASCADE,
    [weight] int,
    [height] int
)
GO

CREATE TABLE [deleted_health_status] (
    [id] int PRIMARY KEY,
    [user_id] int,
    [weight] int,
    [height] int
);
GO

CREATE TRIGGER [trg_health_status_deleted]
ON [health_status]
AFTER DELETE
AS
BEGIN
    INSERT INTO [deleted_health_status]
    SELECT
        [id],
        [user_id],
        [weight],
        [height]
    FROM
        [deleted];
END;
GO

CREATE TABLE [address] (
    [id] int PRIMARY KEY IDENTITY,
    [user_id] int,
    CONSTRAINT fk_address_id FOREIGN KEY (user_id) REFERENCES [user](id) ON DELETE CASCADE,
    [city] varchar(50),
    [district] varchar(50),
    [neighborhood] varchar(50),
    [street] varchar(50)
)
GO

CREATE TABLE [deleted_address] (
    [id] int PRIMARY KEY,
    [user_id] int,
    [city] varchar(50),
    [district] varchar(50),
    [neighborhood] varchar(50),
    [street] varchar(50)
);
GO

CREATE TRIGGER [trg_address_deleted]
ON [address]
AFTER DELETE
AS
BEGIN
    INSERT INTO [deleted_address]
    SELECT
        [id],
        [user_id],
        [city],
        [district],
        [neighborhood],
        [street]
    FROM
        [deleted];
END;
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

CREATE TABLE [deleted_plan] (
    [id] int PRIMARY KEY,
    [name] varchar(50),
    [description] varchar(150),
    [price] money,
    [type] varchar(10),
    [status] nvarchar(255)
);
GO

CREATE TRIGGER [trg_plan_deleted]
ON [plan]
AFTER DELETE
AS
BEGIN
    INSERT INTO [deleted_plan]
    SELECT
        [id],
        [name],
        [description],
        [price],
        [type],
        [status]
    FROM
        [deleted];
END;
GO

CREATE TABLE [timetable] (
    [id] int PRIMARY KEY IDENTITY,
    [plan_id] int,
    CONSTRAINT fk_timetable_plan_id FOREIGN KEY (plan_id) REFERENCES [plan](id) ON DELETE CASCADE,
    [week_day] tinyint,
    CONSTRAINT ck_week_day CHECK (week_day >= 0 AND week_day <= 6),
    [start_time] time,
    [end_time] time
)
GO

CREATE TABLE [deleted_timetable] (
    [id] int PRIMARY KEY,
    [plan_id] int,
    [week_day] tinyint,
    [start_time] time,
    [end_time] time
);
GO

CREATE TRIGGER [trg_timetable_deleted]
ON [timetable]
AFTER DELETE
AS
BEGIN
    INSERT INTO [deleted_timetable]
    SELECT
        [id],
        [plan_id],
        [week_day],
        [start_time],
        [end_time]
    FROM
        [deleted];
END;
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

CREATE TABLE [deleted_subscriptions] (
    [id] int PRIMARY KEY,
    [start_date] datetime,
    [expire_date] datetime,
    [next_pay_date] datetime,
    [user_id] int,
    [plan_id] int
);
GO

CREATE TRIGGER [trg_subscription_deleted]
ON [subscription]
AFTER DELETE
AS
BEGIN
    INSERT INTO [deleted_subscriptions]
    SELECT
        [id],
        [start_date],
        [expire_date],
        [next_pay_date],
        [user_id],
        [plan_id]
    FROM
        [deleted];
END;
GO

CREATE PROCEDURE GetUsersByKeyword @Keyword varchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM [user]
    WHERE [name] LIKE '%' + @Keyword + '%' OR [surname] LIKE '%' + @Keyword + '%';
END;
GO


CREATE TRIGGER trg_health_status_update
ON [health_status]
INSTEAD OF UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [health_status] ([user_id], [weight], [height])
    SELECT [user_id], [weight], [height]
    FROM INSERTED;
END;