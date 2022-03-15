IF NOT EXISTS (SELECT * FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[Employees]') AND type in (N'U'))

CREATE TABLE Employees (
    id UNIQUEIDENTIFIER DEFAULT NEWID() NOT NULL,
	name VARCHAR(255) NOT NULL,

    PRIMARY KEY (id)
);
GO

IF NOT EXISTS (SELECT * FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[Clients]') AND type in (N'U'))
CREATE TABLE Clients (
    id UNIQUEIDENTIFIER DEFAULT NEWID() NOT NULL,
	name VARCHAR(255) NOT NULL,

    PRIMARY KEY (id)
);
GO

IF NOT EXISTS (SELECT * FROM sys.objects
WHERE object_id = OBJECT_ID(N'[dbo].[Engagements]') AND type in (N'U'))
CREATE TABLE Engagements (
    id UNIQUEIDENTIFIER DEFAULT NEWID() NOT NULL,
	name VARCHAR(255) NOT NULL,
	description VARCHAR(255) NOT NULL,
	started DATETIME NOT NULL,
	ended DATETIME,
	employee UNIQUEIDENTIFIER NOT NULL,
	client UNIQUEIDENTIFIER NOT NULL,

    PRIMARY KEY (id),
	FOREIGN KEY (employee) REFERENCES Employees(id),
	FOREIGN KEY (client) REFERENCES Clients(id),
);
GO

