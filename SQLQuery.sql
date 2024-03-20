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

insert into cost values('Nagpur Junction','Wardha Junction','General',70),
('Nagpur Junction','Wardha Junction','Sleeper',145),
('Nagpur Junction','Wardha Junction','Ac 3rd Tier',400),
('Nagpur Junction','Wardha Junction','Ac 2nd Tier',650),
('Nagpur Junction','Wardha Junction','1st AC',1000)

insert into cost values('Nagpur Junction','Badnera Junction','General',90),
('Nagpur Junction','Badnera Junction','Sleeper',175),
('Nagpur Junction','Badnera Junction','Ac 3rd Tier',555),
('Nagpur Junction','Badnera Junction','Ac 2nd Tier',760),
('Nagpur Junction','Badnera Junction','1st AC',1255)

insert into cost values('Nagpur Junction','Akola Junction','General',120),
('Nagpur Junction','Akola Junction','Sleeper',245),
('Nagpur Junction','Akola Junction','Ac 3rd Tier',600),
('Nagpur Junction','Akola Junction','Ac 2nd Tier',820),
('Nagpur Junction','Akola Junction','1st AC',1350)

select * from Cost
