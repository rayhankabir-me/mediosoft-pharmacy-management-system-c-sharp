create database mediosoft




truncate table Users;
drop table Users;

CREATE TABLE Users (
  user_id INT identity(1,1) PRIMARY KEY,
  user_name VARCHAR(255) NOT NULL,
  user_fname VARCHAR(255),
  password VARCHAR(255) NOT NULL,
  user_role VARCHAR(255) NOT NULL,
  user_email VARCHAR(255),
  user_phone VARCHAR(20),
  address VARCHAR(255),
  user_status INT DEFAULT 1
);

SELECT * FROM Users;


INSERT INTO Users (user_name, user_fname, password, user_role, user_email, user_phone, address, user_status)
VALUES ('admin', 'Rayhan Kabir', 'rayhan', 'admin', 'admin@gmail.com', '+8801643163478', 'Nikunja 2, Khilkhet, Dhaka', 1);


INSERT INTO Users (user_name, user_fname, password, user_role, user_email, user_phone, address)
VALUES ('ashik', 'Ashikur Rahman', 'ashik', 'Customer', 'ashik@gmail.com', '+8801643163478', 'Jigatola, Dhaka');



-- create Categories table
CREATE TABLE Categories (
    category_id INT identity(1,1) PRIMARY KEY,
    category_name VARCHAR(255) NOT NULL,
);

SELECT * FROM Categories;

-- insert sample data into Categories table
SET IDENTITY_INSERT Categories OFF;
INSERT INTO Categories (category_id, category_name) VALUES (4,'Injections');

-- create Products table
CREATE TABLE Medicines (
    medicine_id INT identity(1,1) PRIMARY KEY,
    medicine_name VARCHAR(255) NOT NULL,
	medicine_code VARCHAR(255) NOT NULL,
    medicine_description VARCHAR(1000) NOT NULL,
    medicine_price DECIMAL(10,2) NOT NULL,
    medicine_quantity INT NOT NULL,
    category_id INT NOT NULL,
	manufacturing_date DATE,
	expire_date DATE,
	created_by INT NOT NULL,
    FOREIGN KEY (category_id) REFERENCES Categories(category_id),
	FOREIGN KEY (created_by) REFERENCES Users(user_id)
);



-- insert sample data into Products table
SET IDENTITY_INSERT Medicines ON;
INSERT INTO Medicines (medicine_id, medicine_name, medicine_code, medicine_description, medicine_price, medicine_quantity, category_id, manufacturing_date, expire_date, created_by)
VALUES
    (1,'Xeldrin 200mg', '8899', 'Apple iPhone 13 Pro with 128GB storage', 100.00, 10, 1, '2023-06-01', '2025-01-01', 1),
    (2,'Fenofex 500mg', '8899', 'Apple iPhone 13 Pro with 128GB storage', 100.00, 10, 1, '2023-06-01', '2025-01-01', 2),
    (3,'Napa 500ml', '8899', 'Apple iPhone 13 Pro with 128GB storage', 100.00, 10, 3, '2023-06-01', '2025-01-01', 2),
    (4,'Trilock 400mg', '8899', 'Apple iPhone 13 Pro with 128GB storage', 100.00, 10, 1, '2023-06-01', '2025-01-01', 2);

-- select products with their category names
SELECT m.medicine_id, m.medicine_name, m.medicine_code, m.medicine_description, m.medicine_price, m.medicine_quantity, c.category_name, m.manufacturing_date, m.expire_date, m.created_by
FROM Medicines m
INNER JOIN Categories c ON m.category_id = c.category_id
INNER JOIN Users u ON m.created_by = u.user_id;

drop table Categories;
drop table Medicines;

-- create orders table
CREATE TABLE Orders (
    order_id INT IDENTITY(1,1) PRIMARY KEY,
    order_date DATETIME NOT NULL,
    order_quantity INT NOT NULL,
	order_price DECIMAL(10,2) NOT NULL,
    medicine_id INT NOT NULL,
    created_by INT NOT NULL,
	order_status VARCHAR(50) NOT NULL DEFAULT 'pending',
    FOREIGN KEY (medicine_id) REFERENCES Medicines(medicine_id),
    FOREIGN KEY (created_by) REFERENCES Users(user_id)
);

-- insert sample data in the order table
INSERT INTO Orders (order_date, order_quantity, order_price, medicine_id, created_by)
VALUES ('2023-05-12 10:30:00', 5, 20.00, 1, 3);

-- select query
SELECT o.order_id, o.order_date, o.order_quantity, o.order_price, m.medicine_name, u.user_name, o.order_status
FROM Orders o
JOIN Medicines m ON o.medicine_id = m.medicine_id
JOIN Users u ON o.created_by = u.user_id;

drop table Orders;






