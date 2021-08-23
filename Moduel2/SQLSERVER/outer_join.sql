select * from Employees
select * from Projects
insert into Employees(employee_code,employee_name,join_date,designation,Salary)
values(5678,'Ram',getdate(),'programmer',13000)
insert into Projects values('P0003','ECommerce','09.01.2021',null,5)
--Left	outer Join
Select E.employee_code,E.employee_name,P.Project_Name from Employees E
left outer join Projects P on E.project_code=P.project_code
--Right outer Join
Select E.employee_code,E.employee_name,P.Project_Name from Employees E
right outer join Projects P on E.project_code=P.project_code
--Full Outer Join
Select E.employee_code,E.employee_name,P.Project_Name from Employees E
Full outer join Projects P on E.project_code=P.project_code

