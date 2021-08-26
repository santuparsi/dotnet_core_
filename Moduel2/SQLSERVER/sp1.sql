CREATE PROCEDURE GetProducts
as
begin
select * from Product
end
--execute procedure
exec GetProducts