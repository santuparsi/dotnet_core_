alter view EmployeeView
with encryption
as
Select 	 employee_code,employee_name from Employees
GO
Select * from EmployeeView
Select employee_code from EmployeeView
Delete from Employees where employee_code=3454
sp_helptext EmployeeView
sp_depends Employeeview