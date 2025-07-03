CREATE TABLE customer (
	customer_id SERIAL PRIMARY KEY,
	first_name VARCHAR(100) NOT NULL,
	last_name VARCHAR(100) NOT NULL,
	email VARCHAR(100) UNIQUE NOT NULL,
	created_data TIMESTAMPTZ NOT NULL DEFAULT NOW(),
	updated_data TIMESTAMPTZ
);

SELECT*FROM customer;

ALTER TABLE customer ADD COLUMN active BOOLEAN;

SELECT*FROM customer;

ALTER TABLE customer DROP COLUMN active;

SELECT*FROM customer;

ALTER TABLE customer RENAME COLUMN email TO email_adress;

SELECT*FROM customer;
ALTER TABLE customer RENAME COLUMN email_adress TO email;

CREATE TABLE orders (
	order_id SERIAL PRIMARY KEY,
	customer_id INTEGER NOT NULL REFERENCES customer(customer_id),
	order_date TIMESTAMPTZ NOT NULL DEFAULT NOW(),
	order_number VARCHAR(50) NOT NULL,
	order_amount DECIMAL(10,2) NOT NULL
);

ALTER TABLE customer RENAME COLUMN created_data TO created_date;
ALTER TABLE customer RENAME COLUMN updated_data TO updated_date;

ALTER TABLE customer ADD COLUMN active BOOLEAN;

INSERT INTO customer(first_name, last_name, email, created_date, updated_date, active)
VALUES ('manoj', 'patel', 'manoj123@gmail.com', NOW(), NULL, true);

INSERT INTO customer (first_name, last_name, email, created_date, updated_date, active)
VALUES
    ('Amit', 'Shah', 'amit.shah@gmail.com', NOW(), NULL, true),
    ('Neha', 'Desai', 'neha.desai@gmail.com', NOW(), NULL, false),
    ('Ravi', 'Mehta', 'ravi.mehta@yahoo.com', NOW(), NULL, true),
    ('Pooja', 'Joshi', 'pooja.joshi@hotmail.com', NOW(), NULL, true),
    ('Suresh', 'Patil', 'suresh.patil@gmail.com', NOW(), NULL, false),
    ('Meena', 'Kapoor', 'meena.kapoor@gmail.com', NOW(), NULL, true),
    ('Vikas', 'Rao', 'vikas.rao@yahoo.com', NOW(), NULL, true),
    ('Anjali', 'Singh', 'anjali.singh@gmail.com', NOW(), NULL, false),
    ('Deepak', 'Trivedi', 'deepak.trivedi@hotmail.com', NOW(), NULL, true),
    ('Kavita', 'Gandhi', 'kavita.gandhi@gmail.com', NOW(), NULL, true);

INSERT INTO orders (customer_id, order_date, order_number, order_amount)
VALUES
    (1, NOW(), 'ORD-1001', 2500.50),
    (2, NOW(), 'ORD-1002', 1350.00),
    (3, NOW(), 'ORD-1003', 499.99),
    (4, NOW(), 'ORD-1004', 7890.75),
    (5, NOW(), 'ORD-1005', 120.25),
    (6, NOW(), 'ORD-1006', 250.00),
    (7, NOW(), 'ORD-1007', 999.90),
    (8, NOW(), 'ORD-1008', 430.00),
    (9, NOW(), 'ORD-1009', 1575.10),
    (10, NOW(), 'ORD-1010', 300.00);


SELECT first_name,last_name from customer;

SELECT first_name, last_name FROM customer ORDER BY first_name ASC;
SELECT first_name, last_name FROM customer ORDER BY first_name DESC;

SELECT first_name, last_name FROM customer WHERE first_name='Deepak';
SELECT first_name, last_name FROM customer WHERE first_name IN('Deepak','Pooja');

SELECT first_name, last_name FROM customer WHERE first_name like '%D%';