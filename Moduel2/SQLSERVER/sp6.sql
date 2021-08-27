create procedure AddNumbers(@a int,@b int=4)
as
begin
declare @c int
set @c=@a+@b
return @c
end	
declare @result int
exec @result=AddNumbers 12,12
print @result