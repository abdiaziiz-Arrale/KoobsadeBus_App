CREATE DATABASE users;
CREATE TABLE cust
(
id INTEGER GENERATED ALWAYS AS IDENTITY, 
Name text ,
Email text unique, 
phone text 




);
SELECT *from cust ORDER BY DESC;


INSERT INTO users(name , Email,phone)VALUES(' arrale','abdi@gamil.com',4435656);

UPDATE users   SET phone=23456789 WHERE  id=2
DELETE FROM users WHERE id=2
DELETE FROM user COLUMN 
ALTER TABLE users DROP  COLUMN DATE_TIMEs timestamp default now();