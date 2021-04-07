USE gregslist10;

/CREATE TABLE cars
(
id INT AUTO_INCREMENT,
make VARCHAR(255) NOT NULL UNIQUE,
model VARCHAR(255),
year NOT NULL,

PRIMARY KEY (id)
); */


INSERT INTO cars
(make, model, year)
VALUES
("Volkswagen", "GTI", 1999)

-- Get All of a collection
SELECT * FROM cars;

-- Get a specific from a collection

SELECT * FROM cars WHERE model="GTI" OR id=1;

DELETE FROM cars WHERE id=1;

DELETE cars;
TRUNCATE cars;
