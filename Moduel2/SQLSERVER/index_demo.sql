select * from product
sp_helpIndex product
sp_helpIndex Employees
sp_help Employees
--create non-clustred index
create nonclustered index project_code_nci on Employees(project_code)
create table Users(user_id int not null,user_name varchar(20) not null)
--clustered index
create unique clustered index user_id_ci on Users(user_id)
create nonclustered index user_name_nci on Users(user_name)
sp_helpindex Users
--Drop Index
drop index Users.user_name_nci