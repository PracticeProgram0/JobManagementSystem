Create Database JobPotel;

create table Jobs(
		JobId int primary key Identity(1,1),
		JobTitle varchar(50),
		CompanyName varchar(50)
      ,Location varchar(50)
      ,JobType varchar(50)
	  ,jobCategory varchar(50)
	  ,Experience varchar(50)
      ,Education varchar(100)
      ,Skills varchar(100)
      ,SalaryRange varchar(50)
      ,JobDescription varchar(100)
      ,PostDate varchar(50)
      ,FinalDate varchar(50)	  
)
drop table jobs;

select * from jobs;
