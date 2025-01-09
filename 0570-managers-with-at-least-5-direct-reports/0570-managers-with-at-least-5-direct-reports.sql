# Write your MySQL query statement below

#find names that has 5 or more employees with the same manager

SELECT name
from Employee
where id = (SELECT managerId 
            From Employee 
            group by managerId
            Having count(managerId) >= 5);


