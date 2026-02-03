Create database TopBrains;
create table employee1(Id int,name varchar(50),Dept varchar(50),salary int);
insert into employee1 values(101,'Gaurav','CSE',100000);
insert into employee1 values(102,'Mandabi','CSE',150000),(103,'Ayush','ECE',200000),
								(104,'Manvi','Backend',300000),(105,'Palak','IT',110000);

select * from employee1;

SELECT Dept,name, salary
FROM employee1 e
WHERE salary = (
    SELECT MAX(salary)
    FROM employee1
    WHERE Dept = e.Dept
)order by  salary desc;
