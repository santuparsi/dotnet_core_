declare @a int
declare @b int
select @a=20,@b=21
if @a>@b
begin
print cast(@a as varchar(20))+ 'Is bigger'
print cast(@b as varchar(20))+ 'Is smaller'
end
else
begin
print cast(@b as varchar(20))+ 'Is bigger'
print cast(@a as varchar(20))+ 'Is smaller'
end
GO