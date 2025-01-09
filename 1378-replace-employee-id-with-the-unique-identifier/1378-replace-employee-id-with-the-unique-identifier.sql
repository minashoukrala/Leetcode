/* Write your T-SQL query statement below */
SELECT unique_id, Employees.name
FROM Employees
left join EmployeeUNI eu
ON Employees.id = eu.id
