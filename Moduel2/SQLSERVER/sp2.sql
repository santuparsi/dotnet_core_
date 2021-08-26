CREATE PROCEDURE GetProductById(@Pid int)
as
begin
Select * from Product where Pid=@Pid
end
exec GetProductById 3457
exec GetProductById @Pid=3458