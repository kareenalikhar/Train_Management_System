create table TrainMaster(Train_ID int primary key,
Train_Name varchar(500),
Train_Capacity int not null,
Train_Status varchar(500))


Create table Travel_Master(Travel_ID int primary key,
Travel_Date datetime,
Train_ID int foreign key references TrainMaster(Train_ID),
Source varchar(500),
Destination varchar(500),
Class varchar(500),
Cost int)