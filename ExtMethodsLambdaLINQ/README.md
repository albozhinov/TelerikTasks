ExtensionMethods-Lambda-LINQ
=================================================

### Problem 1. StringBuilder.Substring
*	Implement an extension method `Substring(int index, int length)` for the class `StringBuilder` that returns new `StringBuilder` and has the same functionality as `Substring` in the class `String`.

### Problem 2. IEnumerable extensions
*	Implement a set of extension methods for `IEnumerable<T>` that implement the following group functions: sum, product, min, max, average.

### Problem 3. First before last
*	Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
*	Use LINQ query operators.

### Problem 4. Age range
*	Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

### Problem 5. Order students
*	Using the extension methods `OrderBy()` and `ThenBy()` with lambda expressions sort the students by first name and last name in descending order.
*	Rewrite the same with LINQ.

### Problem 6. Divisible by 7 and 3
*	Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. 
*	Use the built-in extension methods and lambda expressions. 
*	Rewrite the same with LINQ.

### Problem 7. Student groups
*	Create a class `Student` with properties `FirstName`, `LastName`, `FN`, `Tel`, `Email`, `Marks` (a List<int>), `GroupNumber`.
*	Create a `List<Student>` with sample students. Select only the students that are from group number 2.
*	Use LINQ query. Order the students by FirstName.

### Problem 8. Student groups extensions
*	Implement the previous using the same query expressed with extension methods.

### Problem 9. Extract students by email
*	Extract all students that have email in `abv.bg`.
*	Use `string` methods and `IEnumerable<T>` extension methods.

### Problem 10. Extract students by phone
*	Extract all students that have phone number starting with `02`.
*	Use `IEnumerable<T>` extension methods.

### Problem 11. Extract students by marks
*	Select all students that have at least one mark `Excellent` (`6`) into a new anonymous class that has properties – `FullName` and `Marks`.
*	Use `IEnumerable<T>` extension methods.

### Problem 12. Extract students with two marks
*	Write down a similar program that extracts the students with exactly two marks "`2`".
*	Use `IEnumerable<T>` extension methods.

### Problem 13. Extract marks 
*	Extract all `Marks` of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

### Problem 14. Longest string
*	Write a program to return the string with maximum length from an array of strings.
*	Use IEnumerable<T> extension methods.
