
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/04/2019 20:37:50
-- Generated from EDMX file: D:\WPF_Employee\Employee\Employee\Model\EMDB.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [EMDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_CityCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customers] DROP CONSTRAINT [FK_CityCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_CityEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_CityEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_CustomerCompany]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customers] DROP CONSTRAINT [FK_CustomerCompany];
GO
IF OBJECT_ID(N'[dbo].[FK_ComputingEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_ComputingEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_FolkCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customers] DROP CONSTRAINT [FK_FolkCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_JobCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customers] DROP CONSTRAINT [FK_JobCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_NationnalityCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customers] DROP CONSTRAINT [FK_NationnalityCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_ReligionCustomer]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Customers] DROP CONSTRAINT [FK_ReligionCustomer];
GO
IF OBJECT_ID(N'[dbo].[FK_DeparmantEployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_DeparmantEployee];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeForeignLanguage]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_EmployeeForeignLanguage];
GO
IF OBJECT_ID(N'[dbo].[FK_EmployeeLearning]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_EmployeeLearning];
GO
IF OBJECT_ID(N'[dbo].[FK_EployeePosition]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_EployeePosition];
GO
IF OBJECT_ID(N'[dbo].[FK_FolkEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_FolkEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_JobEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_JobEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_NationnalityEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_NationnalityEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_ReligionEmployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_ReligionEmployee];
GO
IF OBJECT_ID(N'[dbo].[FK_TypeStaffEployee]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_TypeStaffEployee];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Cities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Cities];
GO
IF OBJECT_ID(N'[dbo].[Companies]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Companies];
GO
IF OBJECT_ID(N'[dbo].[Computings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Computings];
GO
IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Deparmants]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Deparmants];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO
IF OBJECT_ID(N'[dbo].[Folks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Folks];
GO
IF OBJECT_ID(N'[dbo].[ForeignLanguages]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ForeignLanguages];
GO
IF OBJECT_ID(N'[dbo].[Jobs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Jobs];
GO
IF OBJECT_ID(N'[dbo].[Learnings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Learnings];
GO
IF OBJECT_ID(N'[dbo].[Nationnalities]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Nationnalities];
GO
IF OBJECT_ID(N'[dbo].[Positions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Positions];
GO
IF OBJECT_ID(N'[dbo].[Religions]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Religions];
GO
IF OBJECT_ID(N'[dbo].[sysdiagrams]', 'U') IS NOT NULL
    DROP TABLE [dbo].[sysdiagrams];
GO
IF OBJECT_ID(N'[dbo].[TypeStaffs]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TypeStaffs];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cities'
CREATE TABLE [dbo].[Cities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CityName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ComanyName] nvarchar(max)  NOT NULL,
    [BankId] char(50)  NULL,
    [Bank] nchar(50)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Computings'
CREATE TABLE [dbo].[Computings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Level] nchar(50)  NOT NULL
);
GO

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nchar(50)  NOT NULL,
    [NickName] nchar(50)  NULL,
    [Gender] bit  NOT NULL,
    [Married] bit  NOT NULL,
    [BirthDay] datetime  NULL,
    [BirthPlace] nchar(50)  NULL,
    [PersonId] nchar(15)  NULL,
    [TakenPIPlace] nchar(50)  NULL,
    [TakenPIDate] datetime  NULL,
    [Address] nchar(150)  NULL,
    [NativeLand] nchar(50)  NULL,
    [Tabernacle] nchar(150)  NULL,
    [BankId] char(50)  NULL,
    [Bank] nchar(50)  NULL,
    [Image] varbinary(max)  NULL,
    [Mobie] nchar(15)  NULL,
    [Phone] nchar(15)  NULL,
    [Email] nchar(100)  NULL,
    [Income] nvarchar(max)  NOT NULL,
    [Company_Id] int  NULL,
    [City_Id] int  NULL,
    [Religion_Id] int  NULL,
    [Nationnality_Id] int  NULL,
    [Job_Id] int  NULL,
    [Folk_Id] int  NULL
);
GO

-- Creating table 'Deparmants'
CREATE TABLE [dbo].[Deparmants] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [DeparmentName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nchar(50)  NOT NULL,
    [NickName] nchar(50)  NULL,
    [Gender] bit  NOT NULL,
    [Married] bit  NOT NULL,
    [BirthDay] datetime  NULL,
    [BirthPlace] nchar(50)  NULL,
    [PersonId] nchar(15)  NULL,
    [TakenPIPlace] nchar(50)  NULL,
    [TakenPIDate] datetime  NULL,
    [Address] nchar(150)  NULL,
    [NativeLand] nchar(50)  NULL,
    [Tabernacle] nchar(150)  NULL,
    [BankId] char(50)  NULL,
    [Bank] nchar(50)  NULL,
    [Image] varbinary(max)  NULL,
    [Mobie] nchar(15)  NULL,
    [Phone] nchar(15)  NULL,
    [Email] nchar(100)  NULL,
    [PublicId] char(15)  NOT NULL,
    [BaseSalary] int  NOT NULL,
    [FactorySalary] float  NULL,
    [AllowedSalary] int  NULL,
    [StartDay] datetime  NULL,
    [LaborId] nchar(15)  NULL,
    [LaborDay] datetime  NULL,
    [LaborPlace] nchar(50)  NULL,
    [Password] nchar(50)  NOT NULL,
    [Computing_Id] int  NULL,
    [Deparmant_Id] int  NOT NULL,
    [ForeignLanguage_Id] int  NULL,
    [Learning_Id] int  NULL,
    [Position_Id] int  NOT NULL,
    [TypeStaff_Id] int  NOT NULL,
    [City_Id] int  NULL,
    [Religion_Id] int  NULL,
    [Nationnality_Id] int  NULL,
    [Job_Id] int  NULL,
    [Folk_Id] int  NULL
);
GO

-- Creating table 'Folks'
CREATE TABLE [dbo].[Folks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FolkName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ForeignLanguages'
CREATE TABLE [dbo].[ForeignLanguages] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Language] nchar(50)  NOT NULL
);
GO

-- Creating table 'Jobs'
CREATE TABLE [dbo].[Jobs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [JobName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Learnings'
CREATE TABLE [dbo].[Learnings] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Level] nchar(50)  NOT NULL
);
GO

-- Creating table 'Nationnalities'
CREATE TABLE [dbo].[Nationnalities] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [NationnalityName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Positions'
CREATE TABLE [dbo].[Positions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [PositionName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Religions'
CREATE TABLE [dbo].[Religions] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ReligionName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'sysdiagrams'
CREATE TABLE [dbo].[sysdiagrams] (
    [name] nvarchar(128)  NOT NULL,
    [principal_id] int  NOT NULL,
    [diagram_id] int IDENTITY(1,1) NOT NULL,
    [version] int  NULL,
    [definition] varbinary(max)  NULL
);
GO

-- Creating table 'TypeStaffs'
CREATE TABLE [dbo].[TypeStaffs] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TypeName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Cities'
ALTER TABLE [dbo].[Cities]
ADD CONSTRAINT [PK_Cities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Computings'
ALTER TABLE [dbo].[Computings]
ADD CONSTRAINT [PK_Computings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Deparmants'
ALTER TABLE [dbo].[Deparmants]
ADD CONSTRAINT [PK_Deparmants]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Folks'
ALTER TABLE [dbo].[Folks]
ADD CONSTRAINT [PK_Folks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ForeignLanguages'
ALTER TABLE [dbo].[ForeignLanguages]
ADD CONSTRAINT [PK_ForeignLanguages]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Jobs'
ALTER TABLE [dbo].[Jobs]
ADD CONSTRAINT [PK_Jobs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Learnings'
ALTER TABLE [dbo].[Learnings]
ADD CONSTRAINT [PK_Learnings]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Nationnalities'
ALTER TABLE [dbo].[Nationnalities]
ADD CONSTRAINT [PK_Nationnalities]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Positions'
ALTER TABLE [dbo].[Positions]
ADD CONSTRAINT [PK_Positions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Religions'
ALTER TABLE [dbo].[Religions]
ADD CONSTRAINT [PK_Religions]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [diagram_id] in table 'sysdiagrams'
ALTER TABLE [dbo].[sysdiagrams]
ADD CONSTRAINT [PK_sysdiagrams]
    PRIMARY KEY CLUSTERED ([diagram_id] ASC);
GO

-- Creating primary key on [Id] in table 'TypeStaffs'
ALTER TABLE [dbo].[TypeStaffs]
ADD CONSTRAINT [PK_TypeStaffs]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [City_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_CityCustomer]
    FOREIGN KEY ([City_Id])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CityCustomer'
CREATE INDEX [IX_FK_CityCustomer]
ON [dbo].[Customers]
    ([City_Id]);
GO

-- Creating foreign key on [City_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_CityEmployee]
    FOREIGN KEY ([City_Id])
    REFERENCES [dbo].[Cities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CityEmployee'
CREATE INDEX [IX_FK_CityEmployee]
ON [dbo].[Employees]
    ([City_Id]);
GO

-- Creating foreign key on [Company_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_CustomerCompany]
    FOREIGN KEY ([Company_Id])
    REFERENCES [dbo].[Companies]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CustomerCompany'
CREATE INDEX [IX_FK_CustomerCompany]
ON [dbo].[Customers]
    ([Company_Id]);
GO

-- Creating foreign key on [Computing_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_ComputingEmployee]
    FOREIGN KEY ([Computing_Id])
    REFERENCES [dbo].[Computings]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ComputingEmployee'
CREATE INDEX [IX_FK_ComputingEmployee]
ON [dbo].[Employees]
    ([Computing_Id]);
GO

-- Creating foreign key on [Folk_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_FolkCustomer]
    FOREIGN KEY ([Folk_Id])
    REFERENCES [dbo].[Folks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FolkCustomer'
CREATE INDEX [IX_FK_FolkCustomer]
ON [dbo].[Customers]
    ([Folk_Id]);
GO

-- Creating foreign key on [Job_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_JobCustomer]
    FOREIGN KEY ([Job_Id])
    REFERENCES [dbo].[Jobs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JobCustomer'
CREATE INDEX [IX_FK_JobCustomer]
ON [dbo].[Customers]
    ([Job_Id]);
GO

-- Creating foreign key on [Nationnality_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_NationnalityCustomer]
    FOREIGN KEY ([Nationnality_Id])
    REFERENCES [dbo].[Nationnalities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NationnalityCustomer'
CREATE INDEX [IX_FK_NationnalityCustomer]
ON [dbo].[Customers]
    ([Nationnality_Id]);
GO

-- Creating foreign key on [Religion_Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [FK_ReligionCustomer]
    FOREIGN KEY ([Religion_Id])
    REFERENCES [dbo].[Religions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReligionCustomer'
CREATE INDEX [IX_FK_ReligionCustomer]
ON [dbo].[Customers]
    ([Religion_Id]);
GO

-- Creating foreign key on [Deparmant_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_DeparmantEployee]
    FOREIGN KEY ([Deparmant_Id])
    REFERENCES [dbo].[Deparmants]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_DeparmantEployee'
CREATE INDEX [IX_FK_DeparmantEployee]
ON [dbo].[Employees]
    ([Deparmant_Id]);
GO

-- Creating foreign key on [ForeignLanguage_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_EmployeeForeignLanguage]
    FOREIGN KEY ([ForeignLanguage_Id])
    REFERENCES [dbo].[ForeignLanguages]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeForeignLanguage'
CREATE INDEX [IX_FK_EmployeeForeignLanguage]
ON [dbo].[Employees]
    ([ForeignLanguage_Id]);
GO

-- Creating foreign key on [Learning_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_EmployeeLearning]
    FOREIGN KEY ([Learning_Id])
    REFERENCES [dbo].[Learnings]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EmployeeLearning'
CREATE INDEX [IX_FK_EmployeeLearning]
ON [dbo].[Employees]
    ([Learning_Id]);
GO

-- Creating foreign key on [Position_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_EployeePosition]
    FOREIGN KEY ([Position_Id])
    REFERENCES [dbo].[Positions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EployeePosition'
CREATE INDEX [IX_FK_EployeePosition]
ON [dbo].[Employees]
    ([Position_Id]);
GO

-- Creating foreign key on [Folk_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_FolkEmployee]
    FOREIGN KEY ([Folk_Id])
    REFERENCES [dbo].[Folks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FolkEmployee'
CREATE INDEX [IX_FK_FolkEmployee]
ON [dbo].[Employees]
    ([Folk_Id]);
GO

-- Creating foreign key on [Job_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_JobEmployee]
    FOREIGN KEY ([Job_Id])
    REFERENCES [dbo].[Jobs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_JobEmployee'
CREATE INDEX [IX_FK_JobEmployee]
ON [dbo].[Employees]
    ([Job_Id]);
GO

-- Creating foreign key on [Nationnality_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_NationnalityEmployee]
    FOREIGN KEY ([Nationnality_Id])
    REFERENCES [dbo].[Nationnalities]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_NationnalityEmployee'
CREATE INDEX [IX_FK_NationnalityEmployee]
ON [dbo].[Employees]
    ([Nationnality_Id]);
GO

-- Creating foreign key on [Religion_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_ReligionEmployee]
    FOREIGN KEY ([Religion_Id])
    REFERENCES [dbo].[Religions]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ReligionEmployee'
CREATE INDEX [IX_FK_ReligionEmployee]
ON [dbo].[Employees]
    ([Religion_Id]);
GO

-- Creating foreign key on [TypeStaff_Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_TypeStaffEployee]
    FOREIGN KEY ([TypeStaff_Id])
    REFERENCES [dbo].[TypeStaffs]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TypeStaffEployee'
CREATE INDEX [IX_FK_TypeStaffEployee]
ON [dbo].[Employees]
    ([TypeStaff_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------