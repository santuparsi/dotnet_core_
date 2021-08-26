--Create variable
declare @a int
declare @b int
declare @n varchar(20)
--assign values
set @a=10;
set @b=24;
set @n='Ram'
--set multiple values
select @a=20,@b=30,@n='Raghu'
--Global variables
select @@version