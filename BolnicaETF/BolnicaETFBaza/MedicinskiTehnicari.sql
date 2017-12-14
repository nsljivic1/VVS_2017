CREATE TABLE [dbo].[MedicinskiTehnicari]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ime] CHAR(20) NULL, 
    [prezime] CHAR(10) NULL, 
    [jmgb] CHAR(10) NULL, 
    [korisnickoIme] CHAR(10) NULL, 
    [sifra] CHAR(10) NULL, 
    [koeficjentPlate] FLOAT NULL
)
