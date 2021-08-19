select * from Projects
select * from Employees
--insert record
insert into Employees values(4324,'Rohan',	'12.2.2021','Programmer',12000,'P0001')	  --insert all columns
insert into Employees(employee_code,employee_name) values(3454,'Karan')			--insert specific columns
--update records
update Projects set end_date='12.2.2021',team_size=10  where  project_code='P0001'
update Employees set join_date='10.2.2020',salary=15000,project_code='P0002' where employee_code=3454

--delete records
delete from Employees where employee_code=3454
