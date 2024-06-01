# LibraryRIwi

# LibraryRIwi

comando SQL

agregar una columna a la tabla Authors
ALTER TABLE Authors
ADD COLUMN status VARCHAR(50);

///////////crear la tabla Editorials

CREATE TABLE Editorials (
Id INT PRIMARY KEY,
Name NVARCHAR(100),
Address NVARCHAR(255),
Phone NVARCHAR(20),
Email NVARCHAR(100),
Status TINYINT
);


/////////////////////////////////////////////////////////////////////////
crear tabla libros 
CREATE TABLE Books (
    Id INT PRIMARY KEY AUTO_INCREMENT,
    Title VARCHAR(255),
    Pages VARCHAR(50),
    Languages VARCHAR(50),
    PublicationDate DATE,
    Description TEXT,
    AuthorId INT,
    EditorialId INT,
    FOREIGN KEY (AuthorId) REFERENCES Authors(Id),
    FOREIGN KEY (EditorialId) REFERENCES Editorials(Id)
);
