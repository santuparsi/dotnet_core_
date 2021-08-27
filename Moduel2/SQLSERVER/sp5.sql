create procedure GetNameById(@Pid int,@Pname varchar(20) out)
as
begin
select @Pname=Pname from Product where Pid=@Pid
end
declare @P varchar(20)
exec GetNameById  3457,@P out
print @P
select * from Product