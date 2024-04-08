create table TrainMaster(Train_ID int primary key,
Train_Name varchar(500),
Train_Capacity int not null,
Train_Status varchar(500))
SELECT * FROM TrainMaster

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

insert into Cost values('Nagpur Junction','Malkapur','General',80),
  ('Nagpur Junction','Malkapur','Sleeper',255),
  ('Nagpur Junction','Malkapur','Ac 3rd Tier',660),
  ('Nagpur Junction','Malkapur','Ac 2nd Tier',910),
  ('Nagpur Junction','Malkapur','1st Ac',1160)

insert into Cost values('Nagpur Junction','Busaval Junction','General',165),
  ('Nagpur Junction','Busaval Junction','Sleeper',275),
  ('Nagpur Junction','Busaval Junction','Ac 3rd Tier',720),
  ('Nagpur Junction','Busaval Junction','Ac 2nd Tier',995),
  ('Nagpur Junction','Busaval Junction','1st Ac',1665)

insert into Cost values('Nagpur Junction','Manmad Junction','General',195),
  ('Nagpur Junction','Manmad Junction','Sleeper',365),
  ('Nagpur Junction','Manmad Junction','Ac 3rd Tier',955),
  ('Nagpur Junction','Manmad Junction','Ac 2nd Tier',1340),
  ('Nagpur Junction','Manmad Junction','1st Ac',2230)

insert into Cost values('Nagpur Junction','Ahmednagar Junction','General',235),
  ('Nagpur Junction','Ahmednagar Junction','Sleeper',425),
  ('Nagpur Junction','Ahmednagar Junction','Ac 3rd Tier',1110),
  ('Nagpur Junction','Ahmednagar Junction','Ac 2nd Tier',1565),
  ('Nagpur Junction','Ahmednagar Junction','1st Ac',2620)

  insert into Cost values('Nagpur Junction','Daund Junction','General',285),
  ('Nagpur Junction','Daund Junction','Sleeper',455),
  ('Nagpur Junction','Daund Junction','Ac 3rd Tier',1190),
  ('Nagpur Junction','Daund Junction','Ac 2nd Tier',1685),
  ('Nagpur Junction','Daund Junction','1st Ac',2825)


  insert into Cost values('Nagpur Junction','Pune Junction','General',325),
  ('Nagpur Junction','Pune Junction','Sleeper',475),
  ('Nagpur Junction','Pune Junction','Ac 3rd Tier',1255),
  ('Nagpur Junction','Pune Junction','Ac 2nd Tier',1775),
  ('Nagpur Junction','Pune Junction','1st Ac',2985)

  insert into Cost values('Nagpur Junction','Kolhapur','General',415),
  ('Nagpur Junction','Kolhapur','Sleeper',545),
  ('Nagpur Junction','Kolhapur','Ac 3rd Tier',1460),
  ('Nagpur Junction','Kolhapur','Ac 2nd Tier',2100),
  ('Nagpur Junction','Kolhapur','1st Ac',3195)
  
  insert into Cost values('Nagpur Junction','CSMT','General',315),
  ('Nagpur Junction','CSMT','Sleeper',460),
  ('Nagpur Junction','CSMT','Ac 3rd Tier',1210),
  ('Nagpur Junction','CSMT','Ac 2nd Tier',1710),
  ('Nagpur Junction','CSMT','1st Ac',2850)

  insert into Cost values('Nagpur Junction','Thane','General',295),
  ('Nagpur Junction','Thane','Sleeper',450),
  ('Nagpur Junction','Thane','Ac 3rd Tier',1180),
  ('Nagpur Junction','Thane','Ac 2nd Tier',1670),
  ('Nagpur Junction','Thane','1st Ac',2805)

  insert into Cost values('Nagpur Junction','Dadar','General',310),
  ('Nagpur Junction','Dadar','Sleeper',455),
  ('Nagpur Junction','Dadar','Ac 3rd Tier',1200),
  ('Nagpur Junction','Dadar','Ac 2nd Tier',1695),
  ('Nagpur Junction','Dadar','1st Ac',2850)

  insert into Cost values('Nagpur Junction','Nasik Road','General',275),
  ('Nagpur Junction','Nasik Road','Sleeper',390),
  ('Nagpur Junction','Nasik Road','Ac 3rd Tier',1025),
  ('Nagpur Junction','Nasik Road','Ac 2nd Tier',1445),
  ('Nagpur Junction','Nasik Road','1st Ac',2415)

  insert into Cost values('Nagpur Junction','Jalgaon','General',135),
  ('Nagpur Junction','Jalgaon','Sleeper',285),
  ('Nagpur Junction','Jalgaon','Ac 3rd Tier',740),
  ('Nagpur Junction','Jalgaon','Ac 2nd Tier',1030),
  ('Nagpur Junction','Jalgaon','1st Ac',1725)

  insert into Cost values('Nagpur Junction','Madgaon','General',550),
  ('Nagpur Junction','Madgaon','Sleeper',800),
  ('Nagpur Junction','Madgaon','Ac 3rd Tier',2035),
  ('Nagpur Junction','Madgaon','Ac 2nd Tier',2835),
  ('Nagpur Junction','Madgaon','1st Ac',3485)

  insert into Cost values('Nagpur Junction','Vasco da Gama','General',520),
  ('Nagpur Junction','Vasco da Gama','Sleeper',760),
  ('Nagpur Junction','Vasco da Gama','Ac 3rd Tier',1975),
  ('Nagpur Junction','Vasco da Gama','Ac 2nd Tier',2575),
  ('Nagpur Junction','Vasco da Gama','1st Ac',3245)

  ________________________________________________________________________________

  insert into Cost values('Wardha Junction','Nagpur Junction','General',70),
  ('Wardha Junction','Nagpur Junction','Sleeper',145),
  ('Wardha Junction','Nagpur Junction','Ac 3rd Tier',400),
  ('Wardha Junction','Nagpur Junction','Ac 2nd Tier',650),
  ('Wardha Junction','Nagpur Junction','1st Ac',1000)

  
insert into cost values('Wardha Junction','Badnera Junction','General',120),
('Wardha Junction','Badnera Junction','Sleeper',175),
('Wardha Junction','Badnera Junction','Ac 3rd Tier',555),
('Wardha Junction','Badnera Junction','Ac 2nd Tier',760),
('Wardha Junction','Badnera Junction','1st AC',1255)


insert into cost values('Wardha Junction','Akola Junction','General',155),
('Wardha Junction','Akola Junction','Sleeper',215),
('Wardha Junction','Akola Junction','Ac 3rd Tier',555),
('Wardha Junction','Akola Junction','Ac 2nd Tier',760),
('Wardha Junction','Akola Junction','1st AC',1255)


insert into cost values('Wardha Junction','Malkapur','General',175),
('Wardha Junction','Malkapur','Sleeper',220),
('Wardha Junction','Malkapur','Ac 3rd Tier',555),
('Wardha Junction','Malkapur','Ac 2nd Tier',760),
('Wardha Junction','Malkapur','1st AC',1255)


insert into cost values('Wardha Junction','Busaval Junction','General',175),
('Wardha Junction','Busaval Junction','Sleeper',275),
('Wardha Junction','Busaval Junction','Ac 3rd Tier',720),
('Wardha Junction','Busaval Junction','Ac 2nd Tier',995),
('Wardha Junction','Busaval Junction','1st AC',1665)


insert into cost values('Wardha Junction','Manmad Junction','General',255),
('Wardha Junction','Manmad Junction','Sleeper',365),
('Wardha Junction','Manmad Junction','Ac 3rd Tier',955),
('Wardha Junction','Manmad Junction','Ac 2nd Tier',1340),
('Wardha Junction','Manmad Junction','1st AC',2230)


insert into cost values('Wardha Junction','Ahmednagar Junction','General',335),
('Wardha Junction','Ahmednagar Junction','Sleeper',475),
('Wardha Junction','Ahmednagar Junction','Ac 3rd Tier',1245),
('Wardha Junction','Ahmednagar Junction','Ac 2nd Tier',1760),
('Wardha Junction','Ahmednagar Junction','1st AC',2960)

insert into cost values('Wardha Junction','Daund Junction','General',325),
('Wardha Junction','Daund Junction','Sleeper',425),
('Wardha Junction','Daund Junction','Ac 3rd Tier',1120),
('Wardha Junction','Daund Junction','Ac 2nd Tier',1580),
('Wardha Junction','Daund Junction','1st AC',2960)

insert into cost values('Wardha Junction','Pune Junction','General',325),
('Wardha Junction','Pune Junction','Sleeper',425),
('Wardha Junction','Pune Junction','Ac 3rd Tier',1145),
('Wardha Junction','Pune Junction','Ac 2nd Tier',1635),
('Wardha Junction','Pune Junction','1st AC',2960)

insert into cost values('Wardha Junction','Kolhapur Junction','General',325),
('Wardha Junction','Kolhapur Junction','Sleeper',455),
('Wardha Junction','Kolhapur Junction','Ac 3rd Tier',1145),
('Wardha Junction','Kolhapur Junction','Ac 2nd Tier',1655),
('Wardha Junction','Kolhapur Junction','1st AC',2975)

insert into cost values('Wardha Junction','CSMT','General',430),
('Wardha Junction','CSMT','Sleeper',455),
('Wardha Junction','CSMT','Ac 3rd Tier',1200),
('Wardha Junction','CSMT','Ac 2nd Tier',1695),
('Wardha Junction','CSMT','1st AC',2850)

insert into cost values('Wardha Junction','Thane','General',375),
('Wardha Junction','Thane','Sleeper',450),
('Wardha Junction','Thane','Ac 3rd Tier',1050),
('Wardha Junction','Thane','Ac 2nd Tier',1670),
('Wardha Junction','Thane','1st AC',2850)

insert into cost values('Wardha Junction','Dadar','General',375),
('Wardha Junction','Dadar','Sleeper',430),
('Wardha Junction','Dadar','Ac 3rd Tier',1045),
('Wardha Junction','Dadar','Ac 2nd Tier',1130),
('Wardha Junction','Dadar','1st AC',1595)

insert into cost values('Wardha Junction','Nasik Road','General',375),
('Wardha Junction','Nasik Road','Sleeper',365),
('Wardha Junction','Nasik Road','Ac 3rd Tier',1025),
('Wardha Junction','Nasik Road','Ac 2nd Tier',1445),
('Wardha Junction','Nasik Road','1st AC',1340)

insert into cost values('Wardha Junction','Jalgaon','General',215),
('Wardha Junction','Jalgaon','Sleeper',255),
('Wardha Junction','Jalgaon','Ac 3rd Tier',600),
('Wardha Junction','Jalgaon','Ac 2nd Tier',845),
('Wardha Junction','Jalgaon','1st AC',1120)

insert into cost values('Wardha Junction','Jalgaon','General',215),
('Wardha Junction','Jalgaon','Sleeper',255),
('Wardha Junction','Jalgaon','Ac 3rd Tier',600),
('Wardha Junction','Jalgaon','Ac 2nd Tier',845),	
('Wardha Junction','Jalgaon','1st AC',1120)

insert into cost values('Wardha Junction','Madgaon','General',215),
('Wardha Junction','Madgaon','Sleeper',780),
('Wardha Junction','Madgaon','Ac 3rd Tier',1985),
('Wardha Junction','Madgaon','Ac 2nd Tier',2760),
('Wardha Junction','Madgaon','1st AC',3110)

insert into cost values('Wardha Junction','Vasco da Gama','General',215),
('Wardha Junction','Vasco da Gama','Sleeper',780),
('Wardha Junction','Vasco da Gama','Ac 3rd Tier',1920),
('Wardha Junction','Vasco da Gama','Ac 2nd Tier',2760),
('Wardha Junction','Vasco da Gama','1st AC',3110)
_________________________________________________________________________________________________

create table Registration(Name varchar(500), Email varchar(500), PhoneNo bigint,
Password varchar(500), ConfirmPassword  varchar(500))

insert into cost values('Badnera Junction','Nagpur Junction','General',85),
('Badnera Junction','Nagpur Junction','Sleeper',175),
('Badnera Junction','Nagpur Junction','Ac 3rd Tier',555),
('Badnera Junction','Nagpur Junction','Ac 2nd Tier',760),
('Badnera Junction','Nagpur Junction','1st AC',1255)

insert into cost values('Badnera Junction','Wardha Junction','General',85),
('Badnera Junction','Wardha Junction','Sleeper',175),
('Badnera Junction','Wardha Junction','Ac 3rd Tier',555),
('Badnera Junction','Wardha Junction','Ac 2nd Tier',760),
('Badnera Junction','Wardha Junction','1st AC',1255)

insert into cost values('Badnera Junction','Akola Junction','General',85),
('Badnera Junction','Akola Junction','Sleeper',175),
('Badnera Junction','Akola Junction','Ac 3rd Tier',555),
('Badnera Junction','Akola Junction','Ac 2nd Tier',760),
('Badnera Junction','Akola Junction','1st AC',1255)

insert into cost values('Badnera Junction','Malkapur','General',85),
('Badnera Junction','Malkapur','Sleeper',175),
('Badnera Junction','Malkapur','Ac 3rd Tier',555),
('Badnera Junction','Malkapur','Ac 2nd Tier',760),
('Badnera Junction','Malkapur','1st AC',1255)

insert into cost values('Badnera Junction','Busaval Junction','General',105),
('Badnera Junction','Busaval Junction','Sleeper',200),
('Badnera Junction','Busaval Junction','Ac 3rd Tier',555),
('Badnera Junction','Busaval Junction','Ac 2nd Tier',760),
('Badnera Junction','Busaval Junction','1st AC',1255)


select * from Cost
