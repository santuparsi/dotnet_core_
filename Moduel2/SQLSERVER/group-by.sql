select * from student_Master
--Group by
select pub_year,count(Book_name) as 'no of books published' from Book_Master group by pub_year	 order by 'no of books published'
select Dept_Code,count(Stud_Code) as 'Count' from Student_master group by dept_Code
select Address,count(Stud_Code) as 'Count' from Student_master where [Address] is not null group by [Address]
select Address,count(Stud_Code) as 'Count' from Student_master where [Address] is not null 
group by [Address] having count(Stud_Code)>1
select Address,count(Stud_Code) as 'Count' from Student_master where [Address] is not null 
group by [Address] having count(Stud_Code)>1 order by 'Count'