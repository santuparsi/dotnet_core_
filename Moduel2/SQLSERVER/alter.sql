Create table Person(Pid int not null,Pname varchar(10),Address varchar(20))
--Alter statements
--Add column
alter table Person Add city varchar(20) null
select * from Person
--Remove column
alter table Person drop column Address
--change datatype
alter table Person alter column Pname varchar(30)
--apply constraint
alter table person add constraint Pid_PK primary key(Pid)