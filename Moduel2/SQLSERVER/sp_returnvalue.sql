Create procedure GetPrice(@Pname varchar(20))
as
begin
declare @price int
Select @price=Price from Product where Pname=@Pname
return @price
end

declare @p int
exec @p=GetPrice 'Mouse'
print @p