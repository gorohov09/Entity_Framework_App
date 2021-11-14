CREATE TABLE Source
(
	ID_Source int NOT NULL IDENTITY(1, 1),
	Name_Source nvarchar(50) NULL,
	Addres nvarchar(100) NULL,

	CONSTRAINT PK_Source_IdSource PRIMARY KEY(ID_Source)
);

CREATE TABLE Emission
(
	ID_Emission int NOT NULL IDENTITY(1, 1),
	ID_Source int NOT NULL,
	Count_Emission float NULL,
	Text_Emission nvarchar(100) NULL,
	Date_Emission datetime NULL,

	CONSTRAINT PK_Emission_IDEmission PRIMARY KEY(ID_Emission),
	CONSTRAINT FK_Emission_IDSource FOREIGN KEY(ID_Source) REFERENCES Source(ID_Source)
);