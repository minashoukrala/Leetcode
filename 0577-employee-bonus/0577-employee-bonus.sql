# Write your MySQL query statement below
select e.name, Bonus.bonus
from Employee e
left outer join Bonus
on e.empId = Bonus.empId
where Bonus.bonus <= 1000 or Bonus.bonus is null