1. Write a SQL query to find all information about all departments (use "TelerikAcademy" database).
2. Write a SQL query to find all department names.
3. Write a SQL query to find the salary of each employee.
4. Write a SQL to find the full name of each employee.
5. Write a SQL query to find the email addresses of each employee (by his first and last name). Consider that the mail domain is telerik.com. Emails should look like “John.Doe@telerik.com". The produced column should be named "Full Email Addresses".
6. Write a SQL query to find all different employee salaries.
7. Write a SQL query to find all information about the employees whose job title is “Sales Representative“.
8. Write a SQL query to find the names of all employees whose first name starts with "SA".
9. Write a SQL query to find the names of all employees whose last name contains "ei".
10. Write a SQL query to find the salary of all employees whose salary is in the range [20000…30000].
11. Write a SQL query to find the names of all employees whose salary is 25000, 14000, 12500 or 23600.
12. Write a SQL query to find all employees that do not have manager.
13. Write a SQL query to find all employees that have salary more than 50000. Order them in decreasing order by salary.
14. Write a SQL query to find the top 5 best paid employees.
15. Write a SQL query to find all employees along with their address. Use inner join with ON clause.
16. Write a SQL query to find all employees and their address. Use equijoins (conditions in the WHERE clause).
17. Write a SQL query to find all employees along with their manager.
18. Write a SQL query to find all employees, along with their manager and their address. Join the 3 tables: Employees e, Employees m and Addresses a.
19. Write a SQL query to find all departments and all town names as a single list. Use UNION.
20. Write a SQL query to find all the employees and the manager for each of them along with the employees that do not have manager. Use right outer join. Rewrite the query to use left outer join.
21. Write a SQL query to find the names of all employees from the departments "Sales" and "Finance" whose hire year is between 1995 and 2005.
22. Write a SQL query to find the names and salaries of the employees that take the minimal salary in the company.
    - Use a nested SELECT statement.
23. Write a SQL query to find the names and salaries of the employees that have a salary that is up to 10% higher than the minimal salary for the company.
24. Write a SQL query to find the full name, salary and department of the employees that take the minimal salary in their department.
    - Use a nested SELECT statement.
25. Write a SQL query to find the average salary in the department #1.
26. Write a SQL query to find the average salary  in the "Sales" department.
27. Write a SQL query to find the number of employees in the "Sales" department.
28. Write a SQL query to find the number of all employees that have manager.
29. Write a SQL query to find the number of all employees that have no manager.
30. Write a SQL query to find all departments and the average salary for each of them.
31. Write a SQL query to find the count of all employees in each department and for each town.
32. Write a SQL query to find all managers that have exactly 5 employees. Display their first name and last name.
33. Write a SQL query to find all employees along with their managers. For employees that do not have manager display the value "(no manager)".
34. Write a SQL query to find the names of all employees whose last name is exactly 5 characters long. Use the built-in LEN(str) function.
35. Write a SQL query to display the current date and time in the following format "day.month.year hour:minutes:seconds:milliseconds".
    - Search in Google to find how to format dates in SQL Server.
36. Write a SQL statement to create a table Users. Users should have username, password, full name and last login time.
    - Choose appropriate data types for the table fields. Define a primary key column with a primary key constraint.
    - Define the primary key column as identity to facilitate inserting records.
    - Define unique constraint to avoid repeating usernames.
    - Define a check constraint to ensure the password is at least 5 characters long.
37. Write SQL statements to insert in the Users table the names of all employees from the Employees table.
    - Combine the first and last names as a full name.
    - For username use the first letter of the first name + the last name (in lowercase).
    - Use the same for the password, and NULL for last login time.
38. Write a SQL statement that changes the password to NULL for all users that have not been in the system since 10.03.2010.
39. Write a SQL statement that deletes all users without passwords (NULL password).
40. Write a SQL query to display the average employee salary by department and job title.
41. Write a SQL query to display the minimal employee salary by department and job title along with the name of some of the employees that take it.
42. Write a SQL query to display the town where maximal number of employees work.
43. Write a SQL query to display the number of managers from each town.