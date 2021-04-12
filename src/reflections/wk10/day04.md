Read Dotnet WebAPI's > Welcome to SQL, and answer the following questions
In a SQL table, what is the difference between information in a row and information in a column?
``
Information in a row is information across the X axis of the table.
Information in a Column is information along the Y axis of the table.
``

Demonstrate the basic structure for creating a new table called characters with the values name, age, description as strings, and an int id.
``
-- CREATE TABLE homies(
       name VARCHAR(255) NOT NULL UNIQUE,
       age INT NOT NULL
       description VARCHAR(255) NOT NULL UNIQUE
       id INT NOT NULL AUTO_INCREMENT,
);
``

What is the difference between the following statements:
DELETE FROM table_name;
DROP TABLE table_name;
``
DELETE FROM deletes information from a row or column from the table. 
DROP TABLE deletes the whole, actual table. 
``