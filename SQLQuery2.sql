CREATE TABLE Products(
	PID INT PRIMARY KEY,
	PName VARCHAR(255),
	Price INT
);

CREATE TABLE Imports(
	ImportID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ImportDate DATE
);

CREATE TABLE ImportDetails(
	ImportID INT NOT NULL FOREIGN KEY REFERENCES Imports(ImportID),
	PID INT NOT NULL FOREIGN KEY REFERENCES Products(PID),
	Pname VARCHAR(255),
	Quantity INT,
	Price INT
);



CREATE TABLE Company(
	PID INT FOREIGN KEY REFERENCES Products(PID),
	PName VARCHAR(50),
	Quantity INT,
	Price INT,
	PRIMARY KEY(PID)
);

CREATE TABLE Agents(
	AgentID VARCHAR(50) PRIMARY KEY,
	AgentName VARCHAR(255)
);

CREATE TABLE AgentStorage(
	AgentID VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Agents(AgentID),
	PID INT,
	PName VARCHAR(50),
	Quantity INT
)

CREATE TABLE Deliveries(
	DeliveryID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	DeliveryDate DATE,
	DeliveryStatus VARCHAR(50),
	PaymentStatus VARCHAR(50),
	PaymentMethod VARCHAR(50)
);

CREATE TABLE DeliveryDetails(
	DeliveryID INT NOT NULL FOREIGN KEY REFERENCES Deliveries(DeliveryID),
	AgentID VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Agents(AgentID),
	PID INT NOT NULL FOREIGN KEY REFERENCES Company(PID),
	Pname VARCHAR(50),
	Quantity INT,
	Price INT
);


CREATE TABLE Users(
	UserID VARCHAR(50) PRIMARY KEY,
	UserName VARCHAR(255)
);

CREATE TABLE Orders(
	OrderID INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	UserID VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Users(UserID),
	AgentID VARCHAR(50) NOT NULL FOREIGN KEY REFERENCES Agents(AgentID)
);

CREATE TABLE OrderDetails(
	OrderID INT NOT NULL FOREIGN KEY REFERENCES Orders(OrderID),
	PID INT,
	PName VARCHAR(50),
	Price INT,
	Quantity INT
)




INSERT INTO Products (PID,PName,Price) VALUES (1,'Probiotic 10',30)
INSERT INTO Products (PID,PName,Price) VALUES (2,'Co Q-10 for Heart Health',60)
INSERT INTO Products (PID,PName,Price) VALUES (3,'Triple Strength Omega-3 Fish Oil',45)
INSERT INTO Products (PID,PName,Price) VALUES (4,'Lutein Antioxidant for Eye Health',28)
INSERT INTO Products (PID,PName,Price) VALUES (5,'Alpha Lipoic Acid 300 mg.',34)
INSERT INTO Products (PID,PName,Price) VALUES (6,'Triple Omega 3 6 9',16)
INSERT INTO Products (PID,PName,Price) VALUES (7,'Quercetin 600mg',59)
INSERT INTO Products (PID,PName,Price) VALUES (8,'Codeage Liposomal Glutathione',40)
INSERT INTO Products (PID,PName,Price) VALUES (9,'L-Arginine 1000 mg',27)


INSERT INTO Imports(ImportDate) VALUES (GETDATE())


INSERT INTO ImportDetails(ImportID,PID,Pname,Quantity,Price) VALUES ( (SELECT MAX(ImportID) FROM Imports),1,'Probiotic 10',100,30)

INSERT INTO Imports(ImportDate) VALUES (GETDATE())

INSERT INTO ImportDetails(ImportID,PID,Pname,Quantity,Price) VALUES ( (SELECT MAX(ImportID) FROM Imports),3,'Triple Strength Omega-3 Fish Oil',50,45)
INSERT INTO ImportDetails(ImportID,PID,Pname,Quantity,Price) VALUES ( (SELECT MAX(ImportID) FROM Imports),5,'Alpha Lipoic Acid 300 mg.',70,34)



INSERT INTO Company(PID,PName,Quantity,Price) Values (1,'Probiotic 10',0,35)
INSERT INTO Company(PID,PName,Quantity,Price) Values (3,'Triple Strength Omega-3 Fish Oil',0,40)
INSERT INTO Company(PID,PName,Quantity,Price) Values (2,'Co Q-10 for Heart Health',0,63)
INSERT INTO Company(PID,PName,Quantity,Price) VALUES (4,'Lutein Antioxidant for Eye Health',0,30)
INSERT INTO Company(PID,PName,Quantity,Price) VALUES (5,'Alpha Lipoic Acid 300 mg.',0,30)
INSERT INTO Company(PID,PName,Quantity,Price) VALUES (6,'Triple Omega 3 6 9',0,18)
INSERT INTO Company(PID,PName,Quantity,Price) VALUES (7,'Quercetin 600mg',0,62)
INSERT INTO Company(PID,PName,Quantity,Price) VALUES (8,'Codeage Liposomal Glutathione',0,45)
INSERT INTO Company(PID,PName,Quantity,Price) VALUES (9,'L-Arginine 1000 mg',0,30)


INSERT INTO Agents(AgentID,AgentName) VALUES ('TK001','A Store')
INSERT INTO Agents(AgentID,AgentName) VALUES ('VA001','B Store')


INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('TK001',1,'Probiotic 10',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('TK001',2,'Co Q-10 for Heart Health',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('TK001',3,'Triple Strength Omega-3 Fish Oil',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('TK001',4,'Lutein Antioxidant for Eye Health',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('TK001',5,'Alpha Lipoic Acid 300 mg.',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('TK001',6,'Triple Omega 3 6 9',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('TK001',7,'Quercetin 600mg',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('TK001',8,'Codeage Liposomal Glutathione',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('TK001',9,'L-Arginine 1000 mg',0)


INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('VA001',1,'Probiotic 10',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('VA001',2,'Co Q-10 for Heart Health',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('VA001',3,'Triple Strength Omega-3 Fish Oil',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('VA001',4,'Lutein Antioxidant for Eye Health',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('VA001',5,'Alpha Lipoic Acid 300 mg.',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('VA001',6,'Triple Omega 3 6 9',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('VA001',7,'Quercetin 600mg',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('VA001',8,'Codeage Liposomal Glutathione',0)
INSERT INTO AgentStorage(AgentID,PID,PName,Quantity) VALUES ('VA001',9,'L-Arginine 1000 mg',0)



INSERT INTO Deliveries(DeliveryDate,DeliveryStatus,PaymentStatus,PaymentMethod) VALUES (GETDATE(),'Arriving','Paid','Momo')
INSERT INTO DeliveryDetails(DeliveryID,AgentID,PID,Pname,Quantity,Price) VALUES ( 1,'TK001',1,'Probiotic 10',50,35)

INSERT INTO Deliveries(DeliveryDate,DeliveryStatus,PaymentStatus,PaymentMethod) VALUES (GETDATE(),'Arriving','Paid','Momo')
INSERT INTO DeliveryDetails(DeliveryID,AgentID,PID,Pname,Quantity,Price) VALUES (2,'TK001',3,'Triple Strength Omega-3 Fish Oil',100,45)

INSERT INTO Deliveries(DeliveryDate,DeliveryStatus,PaymentStatus,PaymentMethod) VALUES (GETDATE(),'Arriving','Paid','Momo')
INSERT INTO DeliveryDetails(DeliveryID,AgentID,PID,Pname,Quantity,Price) VALUES (3,'VA001',3,'Triple Strength Omega-3 Fish Oil',100,45)

INSERT INTO Deliveries(DeliveryDate,DeliveryStatus,PaymentStatus,PaymentMethod) VALUES (GETDATE(),'Arriving','Paid','Momo')
INSERT INTO DeliveryDetails(DeliveryID,AgentID,PID,Pname,Quantity,Price) VALUES (4,'VA001',3,'Triple Strength Omega-3 Fish Oil',100,45)
