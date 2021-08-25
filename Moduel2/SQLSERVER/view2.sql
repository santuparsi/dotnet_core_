alter view EmployeeProject
as
select e.employee_code,e.employee_name,p.project_code,
p.project_name
from Employees e join Projects p
on e.project_code=p.project_code
GO
select * from EmployeeProject
select * from EmployeeProject where 
project_name='Boing'