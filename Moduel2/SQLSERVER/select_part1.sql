sp_tables
select * from Book_Master
select Book_name,Author from Book_Master
select * from Book_Master where Author='Microsoft'
select * from Book_Master where book_category='Comp Sc'
select * from Book_Master where Author='Millan'
Select * from Book_Master where Author='Millan' and pub_year=2000
Select * from Book_Master where Author='Millan' or pub_year=2000
select * from Book_Master where Book_Code=10000008
select Author from Book_Master
select distinct Author from Book_Master
select distinct book_category from Book_Master
--OrderBy(to display records in ascending or descending order)
Select * from Book_Master order by pub_year
Select * from Book_Master order by pub_year desc
Select * from Book_Master order by Author
Select * from Book_Master where Author='Millan' order by pub_year
