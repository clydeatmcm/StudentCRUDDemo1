CREATE TABLE [dbo].[Student] (
    [Student_pk]   INT           IDENTITY (1, 1) NOT NULL,
    [Student_id]   NVARCHAR (50) NULL,
    [Student_bday] DATE          NULL,
    [Student_gpa]  FLOAT (53)    NULL,
    PRIMARY KEY CLUSTERED ([Student_pk] ASC)
);

INSERT INTO [dbo].[Student] (Student_id, Student_bday, Student_gpa) VALUES
('S001', '2000-01-15', 3.5),
('S002', '2001-03-22', 3.8),
('S003', '1999-06-30', 2.9),
('S004', '2002-11-05', 3.2),
('S005', '2000-12-12', 3.9);
