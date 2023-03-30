CREATE DATABASE TVM
go
USE TVM
go

CREATE TABLE RouteP (
	IDRoute int NOT NULL PRIMARY KEY,
	Departure varchar(30),
	Arrival varchar(30),
	Price int,
);

CREATE TABLE Passenger (
	IDUser int NOT NULL PRIMARY KEY,
	PDeparture varchar(30),
	PArrival varchar(30),
	PPrice int,
	TimeUse DateTime,
);

CREATE TABLE AccountCredit (
	Username varchar(20),
	UserPin varchar(20),
	Balance int,
)

go

INSERT INTO RouteP (IDRoute, Departure, Arrival, Price)
VALUES
(1, 'Ben Thanh', 'Opera House', 10000),
(2, 'Ben Thanh', 'Ba Son', 12000),
(3, 'Ben Thanh', 'Phuoc Long', 13000),
(4, 'Ben Thanh', 'Rach Chiec', 15000),
(5, 'Ben Thanh', 'Thao Dien', 16000),
(6, 'Ben Thanh', 'Van Thanh Park', 16000),
(7, 'Ben Thanh', 'Thu Duc city', 16000),
(8, 'Ben Thanh', 'High-tech Park', 16000),
(9, 'Ben Thanh', 'Suoi Tien Park', 16000),
(10, 'Ben Thanh', 'University Campus', 16000),
(11, 'Ben Thanh', 'Suoi Tien Station', 16000);

INSERT INTO Passenger (IDUser, PDeparture, PArrival, PPrice, TimeUse)
VALUES
(1, 'Ben Thanh', 'Opera House', 1000, '2022-01-01 12:00:00'),
(2, 'Ben Thanh', 'Ba Son', 150, '2022-02-02 14:00:00'),
(3, 'Ben Thanh', 'Phuoc Long', 200, '2022-03-03 16:00:00'),
(4, 'Ben Thanh', 'Rach Chiec', 250, '2022-04-04 18:00:00'),
(5, 'Ben Thanh', 'Suoi Tien Station', 600, '2022-05-05 20:00:00');

INSERT INTO AccountCredit (Username, UserPin, Balance)
VALUES
('John123', 'abcd1234', 100000),
('Mary456', 'efgh5678', 50000),
('Alex789', 'ijkl9101', 750000),
('Emily012', 'mnop2345', 300000),
('Mark567', 'qrst6789', 900000);

Go

SELECT * FROM RouteP
SELECT * FROM Passenger
SELECT * FROM AccountCredit

--drop database TVM
