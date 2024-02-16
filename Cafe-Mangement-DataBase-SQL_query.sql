
--&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&
--((((((((((((())))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))))
--%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%5555555555555555555

INSERT INTO users (firstname, lastname, emailaddress, username, password, category)
VALUES 
('Zeeshan', 'Bashir', 'zeeshanzaki786@gmail.com', 'admin', 'admin', 'admin'),
('Usman', 'Mehmood', 'usmanbhatti89@gmail.com', 'cashier', 'cashier123', 'cashier'),
('Usama', 'Imran', 'usamaimran43234@gmail.com', 'bob_smith', 'securepass', 'chef');
alter table payments 
add constraint fkUser references chef(chef_username)
delete  from users;
 ------Add more rows as needed


CREATE TABLE Feedback (
    FeedbackID INT PRIMARY KEY,
    ProductName varchar (250) not null,
	CustomerName varchar (250) not null,
    FeedbackText varchar (250) not null,
);
CREATE TABLE payments (
    payment_id INT IDENTITY(1,1) PRIMARY KEY,
    method VARCHAR(50),
    

	
total_amount DECIMAL(18, 2),
accountNo DECIMAL(18, 2),

    
    time DATETIME
);

create table admin(
 id int primary key identity (1,1),
	 firstname VARCHAR(50),
    lastname VARCHAR(50),
     username VARCHAR(50) UNIQUE,
    password VARCHAR(50)
);

 drop table users
CREATE TABLE users (
    id INT PRIMARY KEY IDENTITY(1,1),
    firstname VARCHAR(50),
    lastname VARCHAR(50),
    emailaddress VARCHAR(100),
    username VARCHAR(50) UNIQUE,
    password VARCHAR(50),
    category VARCHAR(50) -- Add a new column for user category
);

CREATE TABLE cashiers (
    cashier_id INT PRIMARY KEY IDENTITY(1,1),
    cashier_name VARCHAR(50),
    cashier_username VARCHAR(50) UNIQUE,
    cashier_password VARCHAR(50),
    cashier_role VARCHAR(50),
    cashier_salary DECIMAL(10, 2)
);

CREATE TABLE Orders (
    OrderID INT PRIMARY KEY IDENTITY(1,1),
    ItemName NVARCHAR(255),
    Price INT,
    Quantity INT,
    Total INT,
    OrderDate DATETIME
);

CREATE TABLE chefs (
    chef_id INT PRIMARY KEY IDENTITY(1,1),
    chef_name VARCHAR(50),
    chef_username VARCHAR(50) UNIQUE,
    chef_password VARCHAR(50),
    chef_specialty VARCHAR(50),
    chef_salary DECIMAL(10, 2)
);

CREATE TABLE items (
    item_id INT IDENTITY(1,1) PRIMARY KEY,
    name VARCHAR(50),
    category VARCHAR(50),
    price DECIMAL(18,2)
   -- quantity INT
);

--select queries
select * from Feedback
select * from items
select * from users
select * from payments
select * from admin
select * from cashiers
select * from Orders
select * from chefs

--drop table queries
drop table Feedback
drop table items
drop table users
drop table payments
drop table admin
drop table cashiers
drop table Orders
drop table chefs



