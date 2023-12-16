CREATE DATABASE sports_club
GO

USE [sports_club];
GO

CREATE LOGIN [admin] WITH PASSWORD = 'Password1!';
CREATE USER [admin] FOR LOGIN [admin];
ALTER ROLE [db_owner] ADD MEMBER [admin];
GO

-- permissions --
CREATE TABLE [permissions] (
    [id] int PRIMARY KEY IDENTITY,
    [view_plans] bit,
    [subscribe_plan] bit,
    [unsubscribe_plan] bit,
    [pay] bit,
    [view_timetable] bit,
    [update_health_status] bit,
    [update_phone_number] bit,
    [update_email] bit,
    [update_password] bit,
    [update_address] bit
)
GO

CREATE TABLE [deleted_permissions] (
    [id] int PRIMARY KEY,
    [view_plans] bit,
    [subscribe_plan] bit,
    [unsubscribe_plan] bit,
    [pay] bit,
    [view_timetable] bit,
    [update_health_status] bit,
    [update_phone_number] bit,
    [update_email] bit,
    [update_password] bit,
    [update_address] bit
);
GO

CREATE TRIGGER [trg_permissions_deleted]
ON [permissions]
AFTER DELETE
AS
BEGIN
    INSERT INTO deleted_permissions
    SELECT
    [id],
    [view_plans],
    [subscribe_plan],
    [unsubscribe_plan],
    [pay],
    [view_timetable],
    [update_health_status],
    [update_phone_number],
    [update_email],
    [update_password],
    [update_address]
    FROM
        [deleted];
END;
GO

INSERT INTO [permissions]  VALUES (1, 1, 1, 1, 1, 1, 1, 1, 1, 1);
GO
-- /permissions --

-- profile --
CREATE TABLE [profile] (
    [id] int PRIMARY KEY IDENTITY,
    [name] varchar(50),
    [permissions_id] int,
    CONSTRAINT fk_profile_permissions_id FOREIGN KEY (permissions_id) REFERENCES [permissions](id)
)
GO

CREATE TABLE [deleted_profile] (
    [id] int PRIMARY KEY,
    [name] varchar(50),
    [permissions_id] int,
);
GO

CREATE TRIGGER [trg_permissions_profile]
ON [profile]
AFTER DELETE
AS
BEGIN
    INSERT INTO deleted_profile
    SELECT
    [id],
    [name],
    [permissions_id]
    FROM
        [deleted];
END;
GO

INSERT INTO [profile] VALUES ('user', 1)
GO
-- /profile --

-- /user --
CREATE TABLE [user] (
    [id] int PRIMARY KEY IDENTITY,
    [name] varchar(50),
    [surname] nvarchar(50),
    [date_of_birth] date,
    CONSTRAINT ck_dob CHECK (date_of_birth <= getdate()),
    [phone_number] varchar(15),
    [email] varchar(50),
    CONSTRAINT ck_email CHECK (email LIKE '%_@__%.__%'),
    [password] varchar(50),
    [profile_id] int DEFAULT(1),
    CONSTRAINT fk_user_profile_id FOREIGN KEY (profile_id) REFERENCES [profile](id)
)
GO

CREATE TABLE [deleted_users] (
    [id] int PRIMARY KEY,
    [name] varchar(50),
    [surname] nvarchar(50),
    [date_of_birth] date,
    [phone_number] varchar(15),
    [email] varchar(50),
    [password] varchar(50),
    [profile_id] int,
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
        [phone_number],
        [email],
        [password],
        [profile_id]
    FROM
        [deleted];
END;
GO
-- /user --

-- health_status --
CREATE TABLE [health_status] (
    [id] int PRIMARY KEY IDENTITY,
    [user_id] int,
    CONSTRAINT fk_health_status_user_id FOREIGN KEY (user_id) REFERENCES [user](id) ON DELETE CASCADE,
    [weight] int,
    [height] int,
    [measurement_day] datetime DEFAULT(getdate())
);
GO

CREATE TABLE [deleted_health_status] (
    [id] int PRIMARY KEY,
    [user_id] int,
    [weight] int,
    [height] int,
    [measurement_day] datetime
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
        [height],
        [measurement_day]
    FROM
        [deleted];
END;
GO
-- /health_status --

-- address --
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
-- /address --

-- plan --
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
-- /plan --

-- timetable --
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
-- /timetable --

-- subscription --
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
-- /subscription --

-- procedure --
CREATE PROCEDURE GetUsersByKeyword @Keyword varchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM [user]
    WHERE [name] LIKE '%' + @Keyword + '%' OR [surname] LIKE '%' + @Keyword + '%';
END;
GO

CREATE PROCEDURE InsertUser
    @name varchar(50),
    @surname nvarchar(50),
    @date_of_birth date,
    @phone_number varchar(15),
    @email varchar(50),
    @password varchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [user] (
        [name],
        [surname],
        [date_of_birth],
        [phone_number],
        [email],
        [password]
    ) VALUES (
        @name,
        @surname,
        @date_of_birth,
        @phone_number,
        @email,
        @password
    );
END;
GO

CREATE PROCEDURE UpdateUser
    @id int,
    @name varchar(50),
    @surname nvarchar(50),
    @date_of_birth date,
    @phone_number varchar(15),
    @email varchar(50),
    @password varchar(50),
    @profile_id int
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [user]
    SET
        [name] = @name,
        [surname] = @surname,
        [date_of_birth] = @date_of_birth,
        [phone_number] = @phone_number,
        [email] = @email,
        [password] = @password,
        [profile_id] = @profile_id
    WHERE
        [id] = @id;
END;
GO

CREATE PROCEDURE GetLatestAddressByUserId
    @user_id int
AS
BEGIN
    SET NOCOUNT ON;

    SELECT TOP 1
        [city],
        [district],
        [neighborhood],
        [street]
    FROM
        [address]
    WHERE
        [user_id] = @user_id
    ORDER BY
        [id] DESC;
END;
GO

CREATE PROCEDURE InsertNewAddress
    @user_id int,
    @city varchar(50),
    @district varchar(50),
    @neighborhood varchar(50),
    @street varchar(50)
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [address] ([user_id], [city], [district], [neighborhood], [street])
    VALUES (@user_id, @city, @district, @neighborhood, @street);
END;
GO

CREATE PROCEDURE InsertHealthStatus
    @user_id int,
    @weight int,
    @height int
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO [health_status] ([user_id], [weight], [height])
    VALUES (@user_id, @weight, @height);
END;
GO

CREATE PROCEDURE GetHealthRecordsByUserId
    @user_id int
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        [id],
        [weight],
        [height],
        [measurement_day]
    FROM
        [health_status]
    WHERE
        [user_id] = @user_id
    ORDER BY
        [measurement_day] DESC;
END;
GO

CREATE PROCEDURE GetSubscriptionInfoByUserId
    @user_id int
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @subscription_id int;

    -- Check if there is an active subscription for the user
    SELECT TOP 1
        @subscription_id = [id]
    FROM
        [subscription]
    WHERE
        [user_id] = @user_id
        AND [expire_date] > GETDATE()
        AND [start_date] <= GETDATE()
    ORDER BY
        [start_date] DESC;

    IF @subscription_id IS NOT NULL
    BEGIN
        -- Return subscription details
        SELECT
            [id],
            [start_date],
            [expire_date],
            [next_pay_date],
            [user_id],
            [plan_id]
        FROM
            [subscription]
        WHERE
            [id] = @subscription_id;
    END
    ELSE
    BEGIN
        -- Throw an error if no active subscription is found
        raiserror('No active subscription found for the user.', 16, 1);
    END
END;
GO

CREATE PROCEDURE GetPlanById
    @plan_id int
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        [id],
        [name],
        [description],
        [price],
        [type],
        [status]
    FROM
        [plan]
    WHERE
        [id] = @plan_id;
END;
GO

CREATE PROCEDURE GetWeeklyTimetableByPlanId
    @plan_id int
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        [id],
        [plan_id],
        [week_day],
        [start_time],
        [end_time]
    FROM
        [timetable]
    WHERE
        [plan_id] = @plan_id;
END;
GO

CREATE PROCEDURE DelayNextPayDateByOneMonth
    @user_id int
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE [subscription]
    SET [next_pay_date] = DATEADD(MONTH, 1, [next_pay_date])
    WHERE [user_id] = @user_id;
END;
GO

CREATE PROCEDURE UnsubscribeUser
    @user_id int
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM [subscription]
    WHERE [user_id] = @user_id;
END;
GO

CREATE PROCEDURE GetActivePlans
AS
BEGIN
    SET NOCOUNT ON;

    SELECT
        [id],
        [name],
        [description],
        [price],
        [type],
        [status]
    FROM
        [plan]
    WHERE
        [status] = 'active';
END;
GO

CREATE PROCEDURE StartNewSubscription
    @user_id int,
    @plan_id int
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @currentDate datetime = GETDATE();

    INSERT INTO [subscription] ([start_date], [expire_date], [next_pay_date], [user_id], [plan_id])
    VALUES (@currentDate, DATEADD(YEAR, 1, @currentDate), DATEADD(MONTH, 1, @currentDate), @user_id, @plan_id);
END;
GO

CREATE PROCEDURE GetPermissionDetailsByProfileId
    @profile_id int
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @permissions_id int;

    -- Get permissions_id from the profile record
    SELECT @permissions_id = [permissions_id]
    FROM [profile]
    WHERE [id] = @profile_id;

    -- Get permission details based on permissions_id
    SELECT
        [id],
        [view_plans],
        [subscribe_plan],
        [unsubscribe_plan],
        [pay],
        [view_timetable],
        [update_health_status],
        [update_phone_number],
        [update_email],
        [update_password],
        [update_address]
    FROM
        [permissions]
    WHERE
        [id] = @permissions_id;
END;
GO
-- /procedure --

-- triggers --
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
-- /triggers --

BACKUP DATABASE sports_club TO DISK = '/var/opt/mssql/backups/sample_backup.bak' WITH FORMAT;