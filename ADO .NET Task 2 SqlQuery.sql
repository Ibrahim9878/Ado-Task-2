CREATE DATABASE DBCars

GO

USE DBCars

GO

CREATE TABLE Cars
(
[Id] int NOT NULL PRIMARY KEY IDENTITY(1,1),
[Marka] nvarchar(50) NOT NULL,
[Model] nvarchar(50) NOT NULL,
)

INSERT INTO Cars(Marka,Model)
VALUES('BWM','M5')