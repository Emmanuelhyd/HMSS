CREATE TABLE Menu (
    Id INT PRIMARY KEY IDENTITY(1,1),
	Createdby VARCHAR(100) NULL,
	CreatedDateTime DATETIME NULL,
	Updatedby VARCHAR(100) NULL,
	UpdatedDateTime DATETIME NULL,
    Name VARCHAR(100) NOT NULL,
    Url VARCHAR(255) NOT NULL,
    ParentId INT NULL,
    IsActive BIT NOT NULL
);
INSERT INTO Menu (Createdby,CreatedDateTime,Name, Url, ParentId, IsActive) VALUES ('Ramu',GETDATE(),'Home', '/', NULL, 1);
INSERT INTO Menu (Createdby,CreatedDateTime,Name, Url, ParentId, IsActive) VALUES ('Ramu',GETDATE(),'About Us', '/about', NULL, 1);
INSERT INTO Menu (Createdby,CreatedDateTime,Name, Url, ParentId, IsActive) VALUES ('Ramu',GETDATE(),'Student Services', '/services', NULL, 1);
INSERT INTO Menu (Createdby,CreatedDateTime,Name, Url, ParentId, IsActive) VALUES ('Ramu',GETDATE(),'Contact', '/contact', NULL, 1);
INSERT INTO Menu (Createdby,CreatedDateTime,Name, Url, ParentId, IsActive) VALUES ('Ramu',GETDATE(),'Web Development', '/services/web-development', 3, 1);
INSERT INTO Menu (Createdby,CreatedDateTime,Name, Url, ParentId, IsActive) VALUES ('Ramu',GETDATE(),'Mobile Development', '/services/mobile-development', 3, 1);
INSERT INTO Menu (Createdby,CreatedDateTime,Name, Url, ParentId, IsActive) VALUES ('Ramu',GETDATE(),'Api Services', '/services/seo', 3, 1);
INSERT INTO Menu (Createdby,CreatedDateTime,Name, Url, ParentId, IsActive) VALUES ('Ramu',GETDATE(),'Social Media', '/contact/social-media', 4, 1);
INSERT INTO Menu (Createdby,CreatedDateTime,Name, Url, ParentId, IsActive) VALUES ('Ramu',GETDATE(),'Email', '/contact/email', 4, 1);

SELECT * FROM Menu
