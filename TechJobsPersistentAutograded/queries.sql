--Part 1
select column_name, data_type from Information_schema.columns
where table_name = "jobs";
--Part 2
select employers.Name as Employer, Location from employers
where Location = "St. Louis";
--Part 3
select skills.Name, skills.Description from skills
inner join jobskills on skills.ID = jobskills.SkillId
group by skills.name
order by skills.name asc;