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
    [update_profile] bit,
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
    [update_profile] bit,
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
    [update_profile],
    [update_address]
    FROM
        [deleted];
END;
GO

INSERT INTO [permissions]  VALUES (1, 1, 1, 1, 1, 1, 1, 1);
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
        [update_profile],
        [update_address]
    FROM
        [permissions]
    WHERE
        [id] = @permissions_id;
END;
GO

CREATE PROCEDURE GetPlanData
AS
BEGIN
    SELECT * FROM [plan];
END;
GO

CREATE PROCEDURE GetTimetableData
AS
BEGIN
    SELECT * FROM [timetable];
END;
GO

CREATE PROCEDURE UpdatePlanById
    @planId int,
    @name varchar(50),
    @description varchar(150),
    @price money,
    @type varchar(10),
    @status nvarchar(255)
AS
BEGIN
    UPDATE [plan]
    SET
        [name] = @name,
        [description] = @description,
        [price] = @price,
        [type] = @type,
        [status] = @status
    WHERE
        [id] = @planId;
END;
GO

CREATE PROCEDURE UpdateTimetableById
    @timetableId int,
    @weekDay tinyint,
    @startTime time,
    @endTime time
AS
BEGIN
    UPDATE [timetable]
    SET
        [week_day] = @weekDay,
        [start_time] = @startTime,
        [end_time] = @endTime
    WHERE
        [id] = @timetableId;
END;
GO

CREATE PROCEDURE CreateNewPlan
    @name varchar(50),
    @description varchar(150),
    @price money,
    @type varchar(10),
    @status nvarchar(255),
    @newPlanId int OUTPUT
AS
BEGIN
    INSERT INTO [plan] ([name], [description], [price], [type], [status])
    VALUES (@name, @description, @price, @type, @status);

    SET @newPlanId = SCOPE_IDENTITY(); -- Get the newly generated plan ID
END;
GO

CREATE PROCEDURE CreateNewTimetable
    @planId int,
    @weekDay tinyint,
    @startTime time,
    @endTime time,
    @newTimetableId int OUTPUT
AS
BEGIN
    INSERT INTO [timetable] ([plan_id], [week_day], [start_time], [end_time])
    VALUES (@planId, @weekDay, @startTime, @endTime);

    SET @newTimetableId = SCOPE_IDENTITY(); -- Get the newly generated timetable ID
END;
GO

CREATE PROCEDURE SearchUsers
    @keyword varchar(50)
AS
BEGIN
    SELECT *
    FROM [user]
    WHERE
        [name] LIKE '%' + @keyword + '%' OR
        [surname] LIKE '%' + @keyword + '%' OR
        [phone_number] LIKE '%' + @keyword + '%' OR
        [email] LIKE '%' + @keyword + '%';
END;
GO

CREATE PROCEDURE GetProfileNamesAndIds
AS
BEGIN
    SELECT id, name FROM [profile];
END;
GO

CREATE PROCEDURE InsertNewUser
    @name varchar(50),
    @surname nvarchar(50),
    @dateOfBirth date,
    @phone varchar(15),
    @email varchar(50),
    @password varchar(50),
    @profileId int,
    @newUserId int OUTPUT
AS
BEGIN
    INSERT INTO [user] ([name], [surname], [date_of_birth], [phone_number], [email], [password], [profile_id])
    VALUES (@name, @surname, @dateOfBirth, @phone, @email, @password, @profileId);

    SET @newUserId = SCOPE_IDENTITY(); -- Get the newly generated user ID
END;
GO

CREATE PROCEDURE GetUserById
    @userId int
AS
BEGIN
    SELECT * FROM [user] WHERE [id] = @userId;
END;
GO

CREATE PROCEDURE GetAllProfiles
AS
BEGIN
    SELECT * FROM [profile];
END;
GO

CREATE PROCEDURE UpdateProfileAndPermissions
    @profileId int,
    @name varchar(50),
    @viewPlans bit,
    @subscribePlan bit,
    @unsubscribePlan bit,
    @pay bit,
    @viewTimetable bit,
    @updateHealthStatus bit,
    @updateProfile bit,
    @updateAddress bit
AS
BEGIN
    UPDATE [profile]
    SET [name] = @name
    WHERE [id] = @profileId;

    UPDATE [permissions]
    SET [view_plans] = @viewPlans,
        [subscribe_plan] = @subscribePlan,
        [unsubscribe_plan] = @unsubscribePlan,
        [pay] = @pay,
        [view_timetable] = @viewTimetable,
        [update_health_status] = @updateHealthStatus,
        [update_profile] = @updateProfile,
        [update_address] = @updateAddress
    WHERE [id] = (SELECT [permissions_id] FROM [profile] WHERE [id] = @profileId);
END;
GO

CREATE PROCEDURE GetPermissionsById
    @permissionsId int
AS
BEGIN
    SELECT * FROM [permissions] WHERE [id] = @permissionsId;
END;
GO

CREATE PROCEDURE DeleteProfileAndPermissions
    @profileId int
AS
BEGIN
    DELETE FROM [permissions] WHERE [id] = (SELECT [permissions_id] FROM [profile] WHERE [id] = @profileId);
    DELETE FROM [profile] WHERE [id] = @profileId;
END;
GO

CREATE PROCEDURE InsertProfileAndPermissions
    @name varchar(50),
    @viewPlans bit,
    @subscribePlan bit,
    @unsubscribePlan bit,
    @pay bit,
    @viewTimetable bit,
    @updateHealthStatus bit,
    @updateProfile bit,
    @updateAddress bit
AS
BEGIN
    -- Insert into permissions table
    INSERT INTO [permissions] ([view_plans], [subscribe_plan], [unsubscribe_plan], [pay],
                               [view_timetable], [update_health_status], [update_profile], [update_address])
    VALUES (@viewPlans, @subscribePlan, @unsubscribePlan, @pay,
            @viewTimetable, @updateHealthStatus, @updateProfile, @updateAddress);

    -- Get the last identity (ID) inserted into the permissions table
    DECLARE @permissionsId int;
    SET @permissionsId = SCOPE_IDENTITY();

    -- Insert into profile table
    INSERT INTO [profile] ([name], [permissions_id])
    VALUES (@name, @permissionsId);
END;
GO
-- /procedure --

-- triggers --
CREATE TRIGGER InsteadOfUpdateAddressTrigger
ON [address]
INSTEAD OF UPDATE
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert the deleted addresses into the 'deleted_address' table
    INSERT INTO [deleted_address] ([id], [user_id], [city], [district], [neighborhood], [street])
    SELECT [id], [user_id], [city], [district], [neighborhood], [street]
    FROM deleted;

    -- Update the 'address' table with the new addresses
    UPDATE a
    SET
        [user_id] = i.[user_id],
        [city] = i.[city],
        [district] = i.[district],
        [neighborhood] = i.[neighborhood],
        [street] = i.[street]
    FROM [address] a
    INNER JOIN inserted i ON a.[id] = i.[id];
END;
-- /triggers --

INSERT INTO [user] ([name], [surname], [date_of_birth], [phone_number], [email], [password], [profile_id])
VALUES
    ('John', 'Doe', '1990-01-01', '123456789', 'john.doe@example.com', 'password123', 1),
    ('Jane', 'Smith', '1985-05-15', '987654321', 'jane.smith@example.com', 'pass456', 1),
    ('Alice', 'Johnson', '1988-08-20', '555555555', 'alice.johnson@example.com', 'secure789', 1),
    ('Bob', 'Williams', '1995-03-10', '111223344', 'bob.williams@example.com', 'userpass', 1),
    ('Emily', 'Brown', '1982-12-05', '999888777', 'emily.brown@example.com', 'letmein123', 1),
    ('David', 'Miller', '1998-07-18', '444433322', 'david.miller@example.com', 'mypassword', 1),
    ('Sophia', 'Davis', '1987-09-25', '777766655', 'sophia.davis@example.com', 'p@ssword', 1),
    ('Daniel', 'Wilson', '1993-06-30', '222211110', 'daniel.wilson@example.com', 'secret123', 1),
    ('Olivia', 'Taylor', '1980-04-12', '666655544', 'olivia.taylor@example.com', 'adminpass', 1),
    ('Michael', 'Anderson', '1991-11-08', '888877766', 'michael.anderson@example.com', 'access123', 1),
    ('Ella', 'Jones', '1997-02-28', '333322221', 'ella.jones@example.com', 'userpass123', 1),
    ('Matthew', 'Clark', '1984-10-14', '444455556', 'matthew.clark@example.com', 'securepass', 1),
    ('Emma', 'Moore', '1996-06-22', '999988877', 'emma.moore@example.com', '123456789', 1),
    ('Christopher', 'Lee', '1989-09-03', '777766655', 'chris.lee@example.com', 'letmein456', 1),
    ('Grace', 'Turner', '1992-04-19', '888877766', 'grace.turner@example.com', 'mypassword789', 1),
    ('Andrew', 'White', '1986-12-07', '555544443', 'andrew.white@example.com', 'p@ssword123', 1),
    ('Madison', 'Baker', '1994-08-26', '666655544', 'madison.baker@example.com', 'secret456', 1),
    ('Logan', 'Young', '1981-01-09', '111122223', 'logan.young@example.com', 'adminpass789', 1),
    ('Ava', 'Cooper', '1999-07-15', '222233334', 'ava.cooper@example.com', 'access456', 1),
    ('Joshua', 'Wright', '1983-05-31', '777788889', 'joshua.wright@example.com', 'password789', 1),
    ('Aiden', 'Hill', '1990-11-17', '555566667', 'aiden.hill@example.com', 'letmein789', 1),
    ('Sophie', 'Adams', '1988-03-02', '333344445', 'sophie.adams@example.com', 'secure123456', 1),
    ('Liam', 'Nelson', '1995-10-10', '111122223', 'liam.nelson@example.com', 'mypassword123', 1),
    ('Chloe', 'Carter', '1980-08-04', '666655544', 'chloe.carter@example.com', 'p@ssword456', 1),
    ('Jackson', 'Ward', '1993-12-12', '999988877', 'jackson.ward@example.com', 'adminpass123', 1),
    ('Harper', 'Fisher', '1987-06-18', '444455556', 'harper.fisher@example.com', 'access789', 1),
    ('Caleb', 'Evans', '1991-02-25', '555544443', 'caleb.evans@example.com', 'password456', 1),
    ('Addison', 'Reed', '1982-09-08', '777766655', 'addison.reed@example.com', 'letmein123456', 1),
    ('Owen', 'Cole', '1998-05-14', '222233334', 'owen.cole@example.com', 'secure789012', 1),
    ('Isabella', 'Woods', '1984-01-28', '888877766', 'isabella.woods@example.com', 'mypassword123456', 1);