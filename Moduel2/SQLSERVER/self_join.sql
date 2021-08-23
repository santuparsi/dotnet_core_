use Training
sp_tables
select * from Staff_Master
--Self Join
--Display stafff_Name who are working as Managers
Select Distinct S1.Staff_Name,S1.Staff_Code as 'Managers' from Staff_Master S1 join
Staff_Master S2 on S1.Staff_Code=S2.Mgr_code
Select Distinct S1.Staff_code as 'Managers' from Staff_Master S1 join
Staff_Master S2 on S1.Staff_Code=S2.Mgr_code