CREATE TABLE Categories
(
    ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Products
(
    ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Price DECIMAL(5,2) NOT NULL,
    Quantity INT,
    CategoryID INT,
    CONSTRAINT FK_Products_Category FOREIGN KEY (CategoryID) REFERENCES Categories(ID)
);

CREATE TABLE Roles
(
    ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL
);

CREATE TABLE Users
(
    ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Password NVARCHAR(max) NOT NULL,
    Age INT,
    Address NVARCHAR(100) NOT NULL,
    FavouriteSport NVARCHAR(100) NOT NULL,
    RoleID INT,
    CONSTRAINT FK_Users_Roles FOREIGN KEY (RoleID) REFERENCES Roles(ID),
    CONSTRAINT UQ_Users_Email UNIQUE (Email)
);

CREATE TABLE UserFavorites
(
    UserID INT NOT NULL,
    ProductID INT NOT NULL,
    CONSTRAINT FK_UserFavorites_Users FOREIGN KEY (UserID) REFERENCES Users(ID),
    CONSTRAINT FK_UserFavorites_Products FOREIGN KEY (ProductID) REFERENCES Products(ID),
    CONSTRAINT PK_UserFavorites PRIMARY KEY (UserID, ProductID)
);