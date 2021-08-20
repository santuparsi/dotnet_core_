select * from Book_Master
select * from Student_master
select * from Student_master where Dept_Code in(10,30,50)
select * from Student_master where Address in('Mumbai','New Delhi')
select * from Student_master where Address not in('Mumbai','New Delhi')
select * from Student_master where Address is null
select * from Student_master where Stud_Dob between '01.01.1981' and '12.31.1982'
select * from Student_master where Stud_Dob between '01.01.1981' and '12.31.1982' and Address is not null
select * from Student_master where Stud_Dob not between '01.01.1981' and '12.31.1982'
select * from Student_master where Stud_Name='Raj'
select * from Student_master where Stud_Name like 'R%'
select * from Student_master where Stud_Name like '%j'
select * from Student_master where Stud_Name like 'r%j'
select * from Student_master where Stud_Name like '[AR]%'
select * from Student_master where Stud_Name like '%n%'	 --n in any position
select * from Student_master where Stud_Name like '_a%'		--returns names with 2nd char is a
