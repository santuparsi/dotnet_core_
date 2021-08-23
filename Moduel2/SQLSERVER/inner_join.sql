select * from Student_master
select * from Student_Marks
select S1.Stud_code,S1.Stud_Name,S2.Stud_Year,
s2.Subject1,s2.Subject2,s2.Subject3   from Student_master S1 join Student_Marks S2
on S1.Stud_Code=S2.Stud_Code
select S1.Stud_code,S1.Stud_Name,S1.Dept_Code,S2.Stud_Year,
s2.Subject1,s2.Subject2,s2.Subject3   from Student_master S1 join Student_Marks S2
on S1.Stud_Code=S2.Stud_Code where S1.Dept_Code=20

