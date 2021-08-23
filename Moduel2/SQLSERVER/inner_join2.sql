select * from	[dbo].[Book_Master]
select * from 	  [dbo].[Book_Transaction]
select * from 		 [dbo].[Student_Master]
select T1.Stud_Code,T1.Stud_Name,T3.Book_Name,T2.Issue_date from 
 [dbo].[Student_master] T1	 join
 [dbo].[Book_Transaction] T2 on T1.Stud_Code=T2.Stud_Code
 join 	[dbo].[Book_Master]	T3 on T2.Book_code=T3.Book_code
 select T1.Stud_Code,T1.Stud_Name,T3.Book_Name,T2.Issue_date from 
 [dbo].[Student_master] T1	 join
 [dbo].[Book_Transaction] T2 on T1.Stud_Code=T2.Stud_Code
 join 	[dbo].[Book_Master]	T3 on T2.Book_code=T3.Book_code where T1.Dept_Code in(10,30)
 order by T2.Issue_date