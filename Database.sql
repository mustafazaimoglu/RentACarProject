CREATE TABLE [dbo].[Brands] (
    [BrandId]   INT  IDENTITY (1, 1) NOT NULL,
    [BrandName] TEXT NULL,
    PRIMARY KEY CLUSTERED ([BrandId] ASC)
);

CREATE TABLE [dbo].[CarImages] (
    [Id]        INT      IDENTITY (1, 1) NOT NULL,
    [CarId]     INT      NULL,
    [ImagePath] TEXT     NULL,
    [Date]      DATETIME NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Cars] (
    [Id]          INT  IDENTITY (1, 1) NOT NULL,
    [BrandId]     INT  NULL,
    [ColorID]     INT  NULL,
    [ModelYear]   INT  NULL,
    [DailyPrice]  INT  NULL,
    [Description] TEXT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Colors] (
    [ColorId]   INT  IDENTITY (1, 1) NOT NULL,
    [ColorName] TEXT NULL,
    PRIMARY KEY CLUSTERED ([ColorId] ASC)
);

CREATE TABLE [dbo].[Customers] (
    [CustomerId]  INT  IDENTITY (1, 1) NOT NULL,
    [UserId]      INT  NULL,
    [CompanyName] TEXT NULL,
    PRIMARY KEY CLUSTERED ([CustomerId] ASC)
);

CREATE TABLE [dbo].[Rentals] (
    [RentalId]   INT      IDENTITY (1, 1) NOT NULL,
    [CarId]      INT      NULL,
    [CustomerId] INT      NULL,
    [RentDate]   DATETIME NULL,
    [ReturnDate] DATETIME NULL,
    PRIMARY KEY CLUSTERED ([RentalId] ASC)
);

CREATE TABLE [dbo].[Users] (
    [Id]           INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]    VARCHAR (50) NOT NULL,
    [LastName]     VARCHAR (50) NOT NULL,
    [Email]        VARCHAR (50) NOT NULL,
    [PasswordHash] BINARY (500) NOT NULL,
    [PasswordSalt] BINARY (500) NOT NULL,
    [Status]       BIT          NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[UserOperationClaims] (
    [Id]               INT IDENTITY (1, 1) NOT NULL,
    [UserId]           INT NOT NULL,
    [OperationClaimId] INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[OperationClaims] (
    [Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Name] VARCHAR (250) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);




