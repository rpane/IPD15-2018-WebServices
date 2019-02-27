CREATE TABLE [dbo].[Students]
(
	[StudentID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [EnrollmentDate] DATETIME NULL
)
