use TelerikAcademy
 --1
--Select * From Departments;

 --2
--Select [Name] FROM Departments;

 --3
--Select SUM(Salary) FROM Employees;

 --4
 --Select FirstName, LastName FROM Employees;

 --5
--Select FirstName + '.' +  LastName + '@telerik.com' AS [Full Email Adress] FROM Employees;

 --6
 --SELECT DISTINCT[Salary] FROM Employees;

 --7
 --Select * FROM Employees WHERE JobTitle = 'Sales Representative';

 --8 
 --Select * FROM Employees WHERE FirstName LIKE 'SA%';

 --9
 --Select * FROM Employees WHERE LastName LIKE '%ei%';

 --10
 --Select * FROM Employees WHERE Salary BETWEEN 20000 AND 30000 ORDER BY Salary desc;

 --11
 --SELECT Salary, FirstName + LastName AS 'full name' FROM Employees 
 --WHERE Salary = 25000 OR Salary = 14000 OR Salary = 12500 OR Salary = 23600 
 --ORDER BY Salary asc;
 --12
 --SELECT * FROM Employees WHERE ManagerID is NULL;

 --13
 --SELECT * FROM Employees WHERE Salary > 50000 ORDER BY Salary desc;

 --14
 --SELECT TOP 5 * FROM Employees ORDER BY Salary desc;

 --15
 --Select Employees.FirstName, Addresses.AddressText
 --FROM Employees
 --INNER JOIN Addresses
 --ON Employees.AddressID = Addresses.AddressID;

 --16
 --SELECT Employees.FirstName, Addresses.AddressText 
 --FROM Employees, Addresses
 --WHERE Employees.AddressID = Addresses.AddressID;

 --17
 --SELECT e.firstName AS [Employees], m.FirstName AS [Manager]
 --FROM Employees e
 --INNER JOIN Employees m
 --ON e.ManagerID = m.EmployeeID;

 --18
 --SELECT e.FirstName AS [FirstName], m.FirstName AS [Manager], a.AddressText as [Address]
 --FROM Employees e
 --INNER JOIN Employees m
 --ON e.ManagerID = m.EmployeeID
 --INNER JOIN Addresses a
 --ON e.AddressID = a.AddressID;
 --SELECT * FROM Employees; Използвах ги за да видя таблиците, които трябва да събера.
 --SELECT * FROM Addresses;

 --19
 --SELECT [Name] FROM Departments
 --UNION
 --SELECT [Name] FROM Towns;
 --SELECT * FROM Departments;
 --Select * FROM Towns;

 --20
 --SELECT e.FirstName AS [Employee], m.FirstName AS [Manager]
 --FROM Employees e 
 --LEFT OUTER JOIN Employees m
 --ON e.ManagerID = m.EmployeeID;
 --------------------------------
 --SELECT e.FirstName AS [Employee], m.FirstName AS [Manager]
 --FROM Employees m 
 --RIGHT OUTER JOIN Employees e
 --ON e.ManagerID = m.EmployeeID;

 --21
 --SELECT e.FirstName AS [Employee], m.Name AS [Department], e.HireDate
 --FROM Employees e
 --INNER JOIN Departments m
 --ON e.DepartmentID = m.DepartmentID
 --WHERE (m.Name = 'Sales' OR m.Name = 'Finance') AND (DATEPART (YEAR,e.HireDate) BETWEEN 1995 AND 2005); 
 --SELECT * FROM Departments;
 --Select * FROM Employees;

 --22
 --SELECT FirstName + ' ' + LastName AS [Full name], Salary
 --FROM Employees
 --WHERE 
 --Salary = 
	--	(SELECT MIN(Salary) FROM Employees)
 --Order By FirstName asc;

 --23
 --SELECT FirstName + ' ' + LastName AS [Full name], Salary
 --FROM Employees
 --WHERE Salary BETWEEN 
 --(SELECT MIN(Salary) FROM Employees)
 --AND (SELECT MIN(Salary) + MIN(Salary) * 0.1 FROM Employees);

 --24
-- SELECT e.FirstName + ' ' + e.LastName AS [Full name],
-- d.Name AS [Department],
-- e.Salary AS [Min Salary]
-- FROM Employees e
-- JOIN Departments d
-- ON e.DepartmentID = d.DepartmentID
-- WHERE e.Salary = 
--			(SELECT MIN(Salary) FROM Employees	
--			 WHERE d.DepartmentID = DepartmentID)
--ORDER BY Salary desc;

 --25 
 --SELECT AVG(Salary) AS [Average salary]
 --FROM Employees
 --WHERE DepartmentID = 1;

 --26
 --SELECT AVG(e.Salary) AS [Average salary] 
 --FROM Employees e
 --JOIN Departments d
 --ON e.DepartmentID = d.DepartmentID
 --WHERE d.Name = 'Sales';

 --27
 --SELECT COUNT(*) AS [All employees from the Sales department]
 --FROM Employees e
 --JOIN Departments d
 --ON e.DepartmentID = d.DepartmentID
 --WHERE d.Name = 'Sales';

 --28
 --SELECT COUNT(*) AS [Number of employees that have manager]
 --FROM Employees
 --WHERE ManagerID IS NOT NULL;

 --29
 --SELECT COUNT(*) AS [Employees without manager] FROM Employees
 --WHERE ManagerID IS NULL;

 --30
 --SELECT d.Name AS [Department], AVG(e.Salary) AS [Average salary]
 --FROM Departments d
 --JOIN Employees e
 --ON d.DepartmentID = e.DepartmentID
 --GROUP BY d.Name
 --ORDER BY AVG(e.Salary) desc;

 --31
 --SELECT d.Name AS [Department], t.Name AS [Town], COUNT(*) AS [Number of employees]
 --FROM Employees e
 --JOIN Departments d
 --ON e.DepartmentID = d.DepartmentID
 --JOIN Addresses a
 --ON a.AddressID = e.AddressID
 --JOIN Towns t
 --ON t.TownID = a.TownID
 --GROUP BY t.Name, d.Name
 --ORDER BY COUNT(*) DESC;

 --32
 --SELECT m.FirstName + ' ' + m.LastName AS [Name], COUNT(*) AS [Number of employees]
 --FROM Employees m
 --JOIN Employees e
 --ON e.ManagerID = m.EmployeeID
 --GROUP BY m.FirstName + ' ' + m.LastName
 --HAVING COUNT(*) = 5
 --ORDER BY m.FirstName + ' ' + m.LastName asc;

 --33
 SELECT e.FirstName + ' ' + e.LastName AS [Full name], m.FirstName + ' ' + m.LastName AS [Manager]
 FROM Employees m 
 JOIN Employees e
 ON e.ManagerID = m.EmployeeID;

 SELECT * FROM Employees;






