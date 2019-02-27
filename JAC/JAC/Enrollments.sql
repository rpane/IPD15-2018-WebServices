CREATE TABLE [dbo].[Enrollments]
(
	[EnrollmentID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Grade] DECIMAL(3, 2) NULL, 
    [CourseID] INT NOT NULL, 
    [StudentID] INT NOT NULL, 
    CONSTRAINT [FK_Enrollments_Courses] FOREIGN KEY (CourseID) REFERENCES [Courses]([CourseID]), 
    CONSTRAINT [FK_Enrollments_Students] FOREIGN KEY (StudentID) REFERENCES [Students]([StudentID])
)
