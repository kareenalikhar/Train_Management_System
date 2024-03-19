create table TrainMaster(Train_ID int primary key,
Train_Name varchar(500),
Train_Capacity int not null,
Train_Status varchar(500))


Create table TravelMaster(Travel_ID int primary key,
Travel_Date datetime,
Train_ID int foreign key references TrainMaster(Train_ID),
Source varchar(500),
Destination varchar(500),
Class varchar(500),
Cost int)

create table Cost(Source varchar(500),
Destination varchar(500),
Class varchar(500),
Cost int);

insert into cost values('Nagpur','Pune','General',245),
('Nagpur','Pune','Sleeper',300),
('Nagpur','Pune','Ac 3rd Tier',765),
('Nagpur','Pune','Ac 2nd Tier',1080),
('Nagpur','Pune','1st AC',1200)

