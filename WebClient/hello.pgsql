CREATE DATABASE abdi;
CREATE TABLE customers(
      id int GENERATED ALWAYS AS IDENTITY,
      Email text 
)
SELECT *FROM customers

INSERT INTO customers (email) VALUES('abdiaziiz');
UPDATE customers SET (email)