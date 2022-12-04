--Part 1
select column_name, data_type from Information_schema.columns
where table_name = "jobs";
--Part 2
select employers.Name as Employer, Location from employers
where Location = "St. Louis";
--Part 3
