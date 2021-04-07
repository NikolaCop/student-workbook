USE gregslist10;

-- CREATE TABLE cars
-- (
-- id INT AUTO_INCREMENT,
-- make VARCHAR(255) NOT NULL UNIQUE,
-- model VARCHAR(255),
-- year INT NOT NULL,

-- PRIMARY KEY (id)
-- );


-- INSERT INTO cars
-- (make, model, year)
-- VALUES
-- ("Volkswagen", "GTI", 2007)


CREATE TABLE houses
(
id INT AUTO_INCREMENT,
name VARCHAR(255) NOT NULL UNIQUE,
bedrooms INT NOT NULL,
price INT NOT NULL,

PRIMARY KEY (id)
);


INSERT INTO houses
(name, bedrooms, price)
VALUES
("BigHouse", 5, 464000)



CREATE TABLE jobs
(
id INT AUTO_INCREMENT,
title VARCHAR(255) NOT NULL UNIQUE,
description VARCHAR(255),
rate INT NOT NULL,

PRIMARY KEY (id)
);


INSERT INTO jobs
(title, description, rate)
VALUES
("Developer", "Make der Softwares", 21)










-- Get All of a collection
-- SELECT * FROM cars;

-- Get a specific from a collection

-- SELECT * FROM cars WHERE model="GTI" OR id=1;

-- DELETE FROM cars WHERE id=1;

-- DELETE cars;
-- TRUNCATE cars;
