declare @a varchar(10)
set @a='Sachin'
declare @n int
set @n=1
while @n<=10
begin
print 'Hello '+@a
set @n=@n+1
end