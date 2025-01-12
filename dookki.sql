use master;
drop database DOOKKI;


-- CHẠY 2 DÒNG NÀY TRƯỚC
create database DOOKKI;

use DOOKKI;
--------------------------------------------------------------
-- chạy table trước r mới chạy proc sau đó là insert
CREATE TABLE [ACCOUNT]
(
	ID int identity(0,1) primary key, 
	UserName nvarchar(255) unique not null, -- phone
	[Password] nvarchar(255) not null,
	[Role] nvarchar(20) not null, -- admin, employee, customer,
	IsActive bit default 1
);
CREATE TABLE [Admin]
(
	ID int identity(1,1) primary key,
	Phone nvarchar(12) not null unique,
	[Name] nvarchar(255) not null,
	IDAccount int,
	foreign key (IDAccount) references Account(ID),
	IsActive bit default 1,
);


create table Customer
(
	ID int identity(0,1) primary key, -- khách hàng nào có id = 0 -> ko có tài khoản ( KHÁCH VÃNG LAI)
	Phone nvarchar(15) not null unique,
	Email nvarchar(255),
	[Address] nvarchar(255),
	[Name] nvarchar(255) not null,
	[Marks] int default(0), -- điểm của khách hàng.mỗi 300k thì được 1 điểm, và có thể dùng điểm để đổi discount
	IDAccount int,
	foreign key (IDAccount) references Account(ID),
	IsActive bit default 1,
);

-----------------------------------------------------
create table Category
(
	ID int identity(1,1) primary key,
	[Name] nvarchar(255) not null,
	IsActive bit default 1
);
create table [Product]
(
	ID int identity(1,1) primary key,
	[Name] nvarchar(255) not null,
	MFG Date not null, -- ngày sản xuất
	[EXP] Date not null, -- hạn sử dụng
	unitInStock int not null,
	categoryID int,
	constraint FK_Product_Category foreign KEY (categoryID)
	references Category(ID),

	check([EXP] > MFG),
	IsActive bit default 1
);

--------------------------------------------------------
create table PaymentMethod
(
	ID int identity(1,1) primary key,
	[Name] nvarchar(255) not null,
	IsActive bit default 1,
);
create table Payment
(
	ID int identity(1,1) primary key,
	[day] date not null,
	amount decimal(18,0) not null,
	paymentMethodID int,
	constraint FK_Payment_PaymentMethod foreign key (paymentMethodID)
	references PaymentMethod(ID),
		IsActive bit default 1,
);
------------------------------------
create table CategoryTicket(
	ID int identity(1,1) primary key,
	[Name] nvarchar(50),
	IsActive bit default 1,
);
insert into CategoryTicket([Name],IsActive) values
(N'Take-away',1),
(N'Stay-here',1);

create table Ticket
(
	ID int identity(1,1) primary key,
	[Name] nvarchar(255) not null,
	Price decimal(18,0) not null,
	IsActive bit default 1,
	[ID_Category] int foreign key ([ID_Category]) references CategoryTicket(ID)
);
create table [Table]
(
	ID int identity(1,1) primary key,
	[Name] nvarchar(255) not null,
	[Status] bit default 1,
	[IsActive] bit default 1,
);
create table [Order]
(
	ID int identity(1,1) primary key,
	[Time] Time not null,

	customerID int,
	constraint FK_Order_customerID foreign key(customerID)
	references Customer(ID),

	discount int default(0),
	IsActive bit default 1,
	-- dùng 0 điểm: 0%
	-- dùng 1 điểm: 5%
	-- dùng 2 điểm: 20%
	-- dùng 3 điểm: 25%
	-- dùng 4 điểm: 30%
	-- dùng 5 điểm: 40%
	[Status] int default 0,
	tableID int,
	constraint FK_Order_tableID foreign key(tableID)
	references [Table](ID),
	total decimal(18,2),
);

insert into [Table] ([Name]) values 
(N'Bàn 1'),
(N'Bàn 2'),
(N'Bàn 3'),
(N'Bàn 4'),
(N'Bàn 5'),
(N'Bàn 6'),
(N'Bàn 7'),
(N'Bàn 8'),
(N'Bàn 9'),
(N'Bàn 10'),
(N'Bàn 11'),
(N'Bàn 12'),
(N'Bàn 13'),
(N'Bàn 14'),
(N'Bàn 15'),
(N'Bàn 16'),
(N'Bàn 17'),
(N'Bàn 18'),
(N'Bàn 19'),
(N'Bàn 20'),
(N'Bàn 21'),
(N'Bàn 22'),
(N'Bàn 23'),
(N'Bàn 24'),
(N'Bàn 25'),
(N'Bàn 26'),
(N'Bàn 27'),
(N'Bàn 28'),
(N'Bàn 29');

create table OrderDetail
(
	ID int identity(1,1) primary key,
	quantily decimal(18,0) not null,
	ticketID int,
	paymentID int,
	orderID int,
	constraint FK_OrderDetail_Ticket foreign key (ticketID)
	references Ticket(ID),

	constraint FK_OrderDetail_Payment foreign key (paymentID)
	references Payment(ID),

	constraint FK_OrderDetail_Order foreign key (orderID)
	references [Order](ID),
	IsActive bit default 1,
);
create table Employee
(
	ID int identity(1,1) primary key,
	[Name] nvarchar(255) not null,
	phone nvarchar(12) not null unique,
	email nvarchar(255) not null unique,
	amountWage decimal not null check(amountWage > 0),
	position nvarchar(255) not null,
	IsActive bit default 1,
);

create table DayWork
(
	ID int identity(1,1) primary key,
	timeWork int,
	[day] DATE,
	employeeID int,
	constraint FK_DayWork_Employee foreign key (employeeID)
	references [Employee](ID),
	IsActive bit default 1,
);


---- insert values
insert into [ACCOUNT] (UserName,[Password],[Role],IsActive) values
('*&^D3Y#*^&T*Gd','1','non-customer',1),
('admin1','123111','admin',1),
('admin2','123111','admin',1),
('admin3','123111','admin',1),
('admin4','123111','admin',1),
('0967123456','123','employee',1),
('0967123499','123','customer',1);

insert into [Admin] ([Name],Phone,IDAccount,IsActive) values
(N'Nguyễn Đình Vương','0328651594', 1,1),
(N'Nguyễn Quốc Anh','0888672118', 2,1),
(N'Nguyễn Trần Công Lý','0972480249', 3,1),
(N'Dương Võ Anh Tài','0379616543', 4,1);


insert into Category ([Name],IsActive)values
(N'Bánh gạo',1),
(N'Đồ đông lạnh',1),
(N'Phô mai',1),
(N'Đồ khô/Đóng hộp',1),
(N'Đồ sống',1),
(N'Nước chấm',1),
(N'Dung dịch',1),
(N'Bột lẩu',1);

insert into [Product] ([Name],MFG,[EXP],unitInStock,categoryID,IsActive) values
(N'Bánh gạo phô mai','2024-9-15','2025-01-05',1,1,1),
(N'Bánh gạo bắp','2024-9-15','2025-01-05',0,1,1),
(N'Bánh gạo bí đỏ','2024-9-15','2025-01-05',3,1,1),
(N'Bánh gạo sợi dài','2024-9-15','2025-01-05',15,1,1),
(N'Bánh gạo hình','2024-9-15','2025-01-05',11,1,1),
(N'Bánh gạo ống','2024-9-15','2025-01-05',9,1,1),
(N'Bánh gạo darge','2024-9-15','2025-01-05',4,1,1),

(N'Khoai tây','2024-8-15','2025-01-05',7,2,1),
(N'Mini mandu','2024-8-15','2025-01-05',9,2,1),
(N'Miến cuộn','2024-8-15','2025-01-05',8,2,1),
(N'Hải sản sốt','2024-8-15','2025-01-05',14,2,1),
(N'Bún khoai tây','2024-8-15','2025-01-05',14,2,1),
(N'Hotdog','2024-8-15','2025-01-05',5,2,1),

(N'Phô mai sợi','2024-9-15','2025-01-05',6,3,1),
(N'Phô mai tảng','2024-9-15','2025-01-05',3,3,1),

(N'Rong biển sợi vụn','2024-9-15','2025-01-05',6,4,1),
(N'Rong biển lát','2024-9-15','2025-01-05',12,4,1),
(N'Cá ngừ đóng hộp','2024-9-15','2025-01-05',6,4,1),
(N'Dưa leo muối','2024-9-15','2025-01-05',6,4,1),
(N'Dưa cải muối sợi','2024-9-15','2025-01-05',12,4,1),
(N'Dưa cải muối lát','2024-9-15','2025-01-05',12,4,1),


(N'Xúc xích','2024-9-15','2025-01-05',16,5,1),
(N'Chân gà','2024-9-15','2025-01-05',18,5,1),
(N'Dồi','2024-9-15','2025-01-05',20,5,1),
(N'Bánh trứng','2024-9-15','2025-01-05',6,5,1),
(N'Thịt bò ba chỉ','2024-9-15','2025-01-05',10,5,1),
(N'Chả cá','2024-9-15','2025-01-05',40,5,1),
(N'Chả cá sợi','2024-9-15','2025-01-05',20,5,1),
(N'Kim chi','2024-9-15','2025-01-05',3,5,1),

(N'Tương ớt','2024-9-15','2025-01-05',4,6,1),
(N'Tương cà','2024-9-15','2025-01-05',4,6,1),
(N'Mạch nha','2024-9-15','2025-01-05',2,6,1),
(N'Mù tạt mật ong','2024-9-15','2025-01-05',6,6,1),
(N'Dầu mè','2024-9-15','2025-01-05',12,6,1),

(N'Dầu chiên','2024-9-15','2025-01-05',7,7,1),
(N'Dầu rửa chén','2024-9-15','2025-01-05',7,7,1),
(N'Dầu lau nhà','2024-9-15','2025-01-05',7,7,1),

(N'Bột Dookki','2024-9-15','2025-01-05',6,8,1),
(N'Bột Dukkmo','2024-9-15','2025-01-05',6,8,1),
(N'Bột Kem','2024-9-15','2025-01-05',5,8,1),
(N'Sốt hot','2024-9-15','2025-01-05',5,8,1),
(N'Sốt BBQ','2024-9-15','2025-01-05',8,8,1),
(N'Sốt chả cá','2024-9-15','2025-01-05',10,8,1);

insert into Ticket ([Name],Price,ID_Category,IsActive) values
(N'Giá vé trẻ em',70000,2,1),
(N'Giá vé người lớn',150000,2,1),
(N'Hotdog',15000,1,1),
(N'Vòng phô mai',80000,2,1),
(N'Phô mai hoa tuyết',45000,2,1),
(N'Bánh trứng',15000,1,1),
(N'Thịt bò ba chỉ',70000,2,1),
(N'Takeout Combo 1 (1 loại gà)',140000,1,1),
(N'Takeout Combo 2 (mix 2 vị)',140000,1,1),
(N'Takeout Combo 3 (mix 3 vị)',140000,1,1),
(N'Takeout Combo 4 (đầy đủ)',250000,1,1);


-- khách hàng không có tài khoản
insert into Customer ([Name],Phone,Email,[Address],Marks,IDAccount,IsActive) values
('','','','',0,0,1),
('Test customer','0967123499','email@gmail.com','HCM',0,6,1);

insert into PaymentMethod ([Name],IsActive)values
(N'Chuyển khoản',1),
(N'Tiền mặt',1);

insert into Payment ([day],amount,paymentMethodID,IsActive) values
('2024-10-03',300000,2,1),
('2024-10-03',600000,2,1),
('2024-10-04',500000,2,1),
('2024-10-30',450000,1,1),
('2024-10-30',450000,1,1);

insert into [Order]([Time],customerID) values
('13:00:00',0),
('14:45:00',0),
('15:21:00',0),
('18:32:11',1), -- test customer 
('20:21:13',1); -- test customer 

insert into OrderDetail (quantily,ticketID,paymentID,orderID) values
(2,2,1,1),
(4,2,2,2),
(2,2,3,3),
(1,1,3,3),

(2,2,4,4),
(1,1,4,4),
(1,4,4,4),
(2,2,5,5),
(1,1,5,5),
(1,4,5,5);

insert into Employee ([Name],phone,email,position,amountWage) values
(N'Trần Thị Minh Ngọc','0932446115','tranminhngoc@gmail.com','staff',22000),
(N'Phạm Văn An','0987265112','phamvanan12@gmail.com','staff',22000),
(N'Lê Hoàng Hải','0911223344','lehoanghai@gmail.com','staff',22000),
(N'Vũ Ngọc Lan','0945123786','vungoclan123@gmail.com','staff',22000),
(N'Trần Thanh Bình','0967123456','tranthanhbinh@gmail.com','cashier',23000),
(N'Nguyễn Thị Mai','0905127890','nguyenthimai@gmail.com','cashier',23000),
(N'Hoàng Văn Tùng','0987456123','hoangvantung@gmail.com','chef',24000),
(N'Bùi Thị Thảo','0923345567','buithithao@gmail.com','chef',24000),
(N'Ngô Thanh Sơn','0977345554','ngothanhson@gmail.com','chef',24000),
(N'Lê Minh Anh','0902123456','leminhanh@gmail.com','chef',24000);


insert into DayWork (employeeID,[day],timeWork) values
(1,'2024-10-01',6),
(2,'2024-10-01',6),
(3,'2024-10-01',7),
(4,'2024-10-01',7),
(5,'2024-10-01',13),
(7,'2024-10-01',13),
(9,'2024-10-01',8),
(10,'2024-10-01',13),

(2,'2024-10-02',6),
(3,'2024-10-02',6),
(1,'2024-10-02',7),
(4,'2024-10-02',7),
(6,'2024-10-02',13),
(8,'2024-10-02',13),
(9,'2024-10-02',13),
(10,'2024-10-02',8);


-- Declare variables for the loop
DECLARE @OrderCount INT = 100; -- Number of orders to generate
DECLARE @i INT = 1;

-- Generate Orders
WHILE @i <= @OrderCount
BEGIN
    DECLARE @CustomerID INT = FLOOR(RAND() * 2); -- Random customer ID (0-1)
    DECLARE @Time TIME = CAST(DATEADD(SECOND, FLOOR(RAND() * 86400), '00:00:00') AS TIME); -- Random time of day
    
    INSERT INTO [Order] ([Time], customerID)
    VALUES (@Time, @CustomerID);

    SET @i = @i + 1;
END;

-- Reset the loop counter
SET @i = 1;

-- Generate Payments
DECLARE @PaymentCount INT = 100; -- Number of payments to generate

WHILE @i <= @PaymentCount
BEGIN
    DECLARE @Day DATE = DATEADD(DAY, FLOOR(RAND() * 365), '2024-01-01'); -- Random day in the year 2024
    DECLARE @Amount DECIMAL(10, 2) = FLOOR(RAND() * 2000000 + 100000); -- Random amount between 100,000 and 1,100,000
    DECLARE @PaymentMethodID INT = FLOOR(RAND() * 2) + 1; -- Random payment method (1 or 2)

    INSERT INTO Payment ([day], amount, paymentMethodID, IsActive)
    VALUES (@Day, @Amount, @PaymentMethodID, 1);

    SET @i = @i + 1;
END;

-- Reset the loop counter
SET @i = 1;

-- Generate Order Details
DECLARE @OrderDetailCount INT = 200; -- Number of order details to generate

WHILE @i <= @OrderDetailCount
BEGIN
    DECLARE @Quantity INT = FLOOR(RAND() * 5) + 1; -- Random quantity (1-5)
    DECLARE @TicketID INT = FLOOR(RAND() * 10) + 1; -- Random ticket ID (1-10)
    DECLARE @PaymentID INT = FLOOR(RAND() * @PaymentCount) + 1; -- Random payment ID (1-100)
    DECLARE @OrderID INT = FLOOR(RAND() * @OrderCount) + 1; -- Random order ID (1-100)

    INSERT INTO OrderDetail (quantily, ticketID, paymentID, orderID)
    VALUES (@Quantity, @TicketID, @PaymentID, @OrderID);

    SET @i = @i + 1;
END;
