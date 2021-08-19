--Primary key-allow only unique values to the column and table can have only 1 pk
--Unique key	- allow only unique values and one null values and table can have multiple uniqe keys
--Not null	 -column value is required must
--Check- to allow values to a column in a given range or in bewtween range.
--Default		 - to set the default value.
--Foreignkey   -ensure child table column value should be exist in the paranet column
use PracticeDB
create table Projects(project_code char(5) primary key,
project_name varchar(30) unique not null,start_date date default getdate(),
end_date date,team_size int)
create table Employees(
employee_code int primary key,
employee_name varchar(20) not null,
join_date date,
designation varchar(20) check(designation in('Programmer','Sr Programmer','TeamLeader')),
salary money,
project_code char(5) foreign key references Projects(project_code))
drop table Employees

insert into Projects(project_code,project_name) values('P0001','HealthCare')
insert into Projects values('P0002','Boing','12.2.2020','12.1.2021',10)
select * from Projects
