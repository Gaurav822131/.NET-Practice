create table User1 (Id int,email varchar(100));

Insert into User1 values(1,'gaura822131@gmail.com'),
						(2,'gaurav83401@gmail.com'),
						(3,'gaurav822131@gmail.com'),
						(4,'gaurav822131@gmail.com'),
						(5,'manvi317@gmail.com');

select * from User1;
select email,count(*) as DuplicateEmail from User1 GROUP BY email having count(*)>1;