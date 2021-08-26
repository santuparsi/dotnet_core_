Create procedure AddProduct(@Pname varchar(20),@Price int,@Stock int)
as
begin
declare @Pid int
Select 	@Pid=Max(Pid) from Product
set @Pid=@Pid+1
insert into Product values(@Pid,@Pname,@Price,@Stock)
End
exec AddProduct 'CCCC',200,10
exec GetProducts