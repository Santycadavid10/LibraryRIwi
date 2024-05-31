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

añadir editorial
