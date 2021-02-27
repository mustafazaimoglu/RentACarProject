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
    [UserId]    INT  IDENTITY (1, 1) NOT NULL,
    [FirstName] TEXT NULL,
    [LastName]  TEXT NULL,
    [Email]     TEXT NULL,
    [Password]  TEXT NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);




