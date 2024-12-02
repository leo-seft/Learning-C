1. Getting Started with C#
   This section covers the following topics:

- Introduction to C# and .NET Framework
- Writing Your First C# Program
- Basic Syntax and Data Types
- Variables, Constants, and Data Types in C#

By completing these tasks, you should have a good understanding of the basics of C# programming, including its syntax and data types, how to write a simple C# program, and how to use variables and constants in your code.

Tasks:
Introduction to C# and .NET Framework

- Research what C# is and its history.
  History:
  C# is a modern, object-oriented programming language developed by Microsoft. It was designed in 1999/2000 and it became part of the .NET framework in 2000.
  It was introduced as part of the .NET initiative and is widely used for building a variety of applications, including web, desktop, and cloud-based applications.

- Understand the .NET framework and how it relates to C#.
  .NET:
  The .NET Framework is a platform for developing Windows-based applications, and it was introduced in 2002. It also allows cross-language interoperability which means code can be written in different .NET languages and work with no issues. C# was built to be one of the primary languages of the .NET framework.

- Learn about the advantages of using C# and the .NET framework for programming.
  Advantages of C# and .NET:
  C# is a fully object-oriented language which supports encapsulation, inheritance, and polymorphism, this makes it easier to write reusable and maintainable code.
  C# is very versitile as it can be used for: Web, Desktopm, Mobile, Game development and Cloud-based applications
  .NET has tools and frameworks for most application types.
  Applications made on .NET are both scalable and reliable, which makes it very future proof.

Writing Your First C# Program

- Set up your development environment (Visual Studio, VS Code, or other).
  When trying to run my code in Ubuntu I had numerous issues so I switched over to my local computer where I had issues regarding permissions so I had to create files by entering 'dotnet new console -n application name' which then allowed me to run my code. I found that this is because c# is a more secure language than javascript

- Create a new C# project with a .cs file extension.
  please See Day1-MyFirstProgram

- Write a simple "Hello, world!" program in C#.
  please See Day1-MyFirstProgram

- Build and run your program to verify that it works correctly.
  please See Day1-MyFirstProgram
  For it to run I had to use 'dotnet run' in the terminal

Basic Syntax and Data Types

- Print "Hello World" to the console using C#.
  To do this you use 'Console.WriteLine("Hello World!")'
- Learn the basic syntax of the C# programming language.
- Understand C# data types, including integers, floating-point numbers, characters, booleans, and strings.
- Practice creating and using arithmetic operators and expressions.

Variables, Constants, and Data Types in C#

- Explore how to declare and initialize variables in C#.
  to declare a variable we do it like this:
  'variable-type variable-name = data'
- Learn the difference between variables and constants in C#.
  The value of a constant can not change but a variable can
- Understand how to declare and initialize variables and constants.
  to declare a constant we do it like this:
  'const variable-type variable-name = data'
  an 'enum' is a group of constants
- Explore the different C# data types in variable declarations and their uses.
- Research C# single and multidimensional array data structures, including useful methods.
- Practice using variables and constants to create variables of different data types in your C# programs.

Build Something 🔨

- Name Badge Generator: Create a name prompt program that asks users for their name, job, and contact information. Once the program has this information, output a name badge with this information.
  Please see Day3-smallprojects

---

2. Control Structures and Functions in C#
   This section covers the following topics:

- Conditional Statements (if-else, switch)
- Loops (for, while, do-while)
- Functions in C# (creating and calling)
- Passing Arguments to Functions
- Returning Values from Functions

By completing these tasks, you should have a good understanding of how to use conditional statements and loops to control program flow, how to define and call functions in C#, and how to pass arguments and return values from functions.

Tasks:
Conditional Statements (if-else, switch)

- Learn about the different types of conditional statements in C# (if-else, switch).
  If-else statements work the same as JavaScript
  Switch statements work using Case as the if and default as else for example
  'switch(year){
  case 1 :{
  Text
  break
  }
  default:{
  Text
  break
  }
  }'
- Understand how to use logical operators (AND, OR, NOT) in C# conditional statements.
- Practice writing conditional statements to control program flow based on conditions. For example, create a simple program that outputs different responses based on the user input.
  please see Day3-ConditionalsAndLoops

Loops (for, while, do-while)

- Learn about the different types of loops in C# (for, while, do-while).
  for and while loops work the same as in JavaScript
- Understand how to use break and continue statements in loops.
- Practice writing loops to repeat code based on certain conditions. For example, create a program that prints out all even numbers between 0 and a value specified by a user.
  please see Day3-ConditionalsAndLoops

Functions in C# (creating and calling)

- Learn how to define and call functions in C#.
  'modifiers return-type method-name parameter-list'
  when a method has no return type, it is set to void

- Understand the difference between methods and functions in C#.
  A function is independent and can be called without an object

- Practice writing functions that perform simple tasks like a function that prints out a message when called.

Please see Day5-functions

Passing Arguments to Functions

- Understand how to pass arguments to functions in C#.
- Learn about the different types of parameters in C# functions.
- Practice passing arguments to functions to perform complex tasks like a function that returns a letter grade when a score is provided.

Returning Values from Functions

- Learn how to return values from functions in C#.
- Understand the difference between void and non-void functions in C#.
  void is when you dont expect a new value to return ie just hello but non-void is for when a new value is returned such as 1+1=2

- Practice using functions to perform complex tasks and return values to the main program.

Please see Day5-functions

Build Something 🔨
Rock, Paper, Scissors:

- Create a program that:

  - Asks the user for an input of rock, paper, or scissors. - Done
  - Randomly selects rock, paper, or scissors for the computer. - Done
  - Determines the winner of the game based on the random values that were selected. - Done
  - Tracks the player and computer scores.
  - Allows the player to play until they opt to end the game.

  Please see Rock, Paper, Scissors

---

3. Object-Oriented Programming in C#
   This section covers the following topics:

- Introduction to Object-Oriented Programming (OOP) Concepts
- Creating Classes and Objects in C#
- Defining and Accessing Class Members (fields, properties, methods)
- Inheritance and Polymorphism in C#
- Interfaces and Abstract Classes in C#

By completing these tasks, you should have a good understanding of OOP concepts, how to create classes and objects in C#, how to define and access class members, and how to use inheritance, polymorphism, interfaces, and abstract classes in C#.

Tasks:
Introduction to Object-Oriented Programming (OOP) Concepts

- Learn about the key concepts of OOP, including encapsulation, inheritance, and polymorphism.
- Understand the benefits of using OOP in software development.
- Practice identifying objects, classes, and properties in real-world scenarios.

Creating Classes and Objects in C#

- Learn how to create classes in C#.
  'Class class-name{
  }
- Understand how to instantiate objects from classes.
- Practice creating and using objects to perform simple tasks.

Defining and Accessing Class Members (fields, properties, methods)

- Learn how to define fields, properties, and methods in C# classes.
- Understand the differences between fields and properties in C#.
- Practice accessing class members from objects to perform complex tasks.
- Example: Create a Person class with name, age, and hometown fields. The class should also have a bio method that prints the person's information.
  please see Day6-OOP

Inheritance and Polymorphism in C#

- Learn about inheritance and polymorphism in C# programming.
- Understand how to create derived classes that inherit from base classes.
  class DerivedClass : BaseClass{}
- Example: Create a Shape calculator with a parent Shape class and subclasses like Circle, Triangle, Square. Implement an `Area()` method in each class to calculate respective areas.

please see Day6-OOP

Interfaces and Abstract Classes in C#

- Learn about interfaces and abstract classes in C# programming.
- Understand the differences between interfaces and abstract classes.
  Interface is something classes must follow, abstract is a partial implementation that can be inherited
- Practice creating interfaces and abstract classes to define common behavior for classes.
  Please see Day6-OOP

Build Something 🔨
Option #1 - Scooter Application:

- Recreate a scooter tracking application using C#.

Option #2 - Inventory Management System:

- Create a store inventory manager allowing users to add, update, and view products. Include stock availability checks, total inventory value calculations, and report generation.

4. TDD, Exception Handling, and File I/O in C#
   This section covers the following topics:

- Test Driven Development in C#
- Exception Handling in C#
- Handling Exceptions with try-catch Blocks
- Reading and Writing Files in C#
- Streams and Byte Arrays in C#

By completing these tasks, you should have a good understanding of how to create unit tests in C#, handle exceptions in your programs, read and write files, and work with streams and byte arrays.

Tasks

Test Driven Development in C#

- Research the NUnit, MSTest, and xUnit.net unit testing frameworks. Determine which is best for your project.
- Return to the mini-project from the previous section and create tests for the functions you wrote.
- Use a TDD approach to create new functions by writing tests first.  
  Example: Write tests for a function that returns the largest element of an array before writing the function.

Exception Handling in C#

- Learn about exceptions and their role in managing errors in C# programs.
- Understand the importance of exception handling for robust programs.
- Identify potential exceptions in previous projects and define exception types.

Handling Exceptions with try-catch Blocks

- Learn how to use `try-catch` blocks for exception handling in C#.
- Understand the differences between checked and unchecked exceptions.
- Practice applying exception handling to existing code by wrapping sections in `try-catch` blocks.

Reading and Writing Files in C#

- Learn how to read and write files using the `File` and `StreamReader`/`StreamWriter` classes.
- Understand how to handle exceptions when working with files.
- Create a program that reads a text file and counts the number of words in it. Use exception handling to ensure the file is accessible.

Streams and Byte Arrays in C#

- Learn about streams and byte arrays in C#.
- Practice using streams to read and write data efficiently.
- Create a program that demonstrates reading and writing data using byte arrays.

Build Something 🔨
**Option #1 - Word Frequency Analyzer:**

- Create a program that reads a text file, processes its contents, and generates a report of word frequencies.
- Include exception handling and write unit tests.

**Option #2 - Movie Recommendation System:**

- Build a program that suggests movies based on user preferences and previously watched movies.
- Use file input to read the list of watched movies and genres, and implement exception handling.

---

5. Advanced Topics in C#
   This section covers the following topics:

- Delegates and Events in C#
- Generics in C#
- LINQ (Language Integrated Query) in C#
- Asynchronous Programming in C#

By completing these tasks, you’ll gain a deeper understanding of advanced C# programming techniques and concepts.

Tasks

Delegates and Events in C#

- Learn about delegates and events in C# programming.
- Understand how delegates are used to reference methods.
- Practice creating events to handle program input or user actions.

Generics in C#

- Learn about generic types and methods.
- Understand how generics enable flexible and reusable code.
- Practice implementing generic types and methods in your programs.

LINQ (Language Integrated Query) in C#

- Learn the fundamentals of LINQ and its use for querying data.
- Practice using LINQ to filter and manipulate data.
- Create a program that uses LINQ to query collections or databases.

Asynchronous Programming in C#

- Learn how to write asynchronous code using `async` and `await`.
- Understand how asynchronous programming improves program performance.
- Practice writing asynchronous methods to handle tasks such as API calls or file processing.

Build Something 🔨
**Option #1 - Task Management Application:**

- Build an app to create, update, and track tasks using LINQ, async programming, and exception handling.

**Option #2 - Movie Recommendation System:**

- Extend the system from Section 4. Add LINQ to filter movies based on genre, rating, or release year.
- Incorporate asynchronous programming for file or database interactions.

**Option #3 - Event Management System:**

- Create an event manager where users can register for events and receive notifications.
- Use delegates and events for event handling.

---

Final Project Ideas
After completing Sections 4 and 5, choose a larger project to apply your skills:

1. **Address Book:**

   - Build a program to manage contacts (add, edit, delete).
   - Use file I/O for data storage and exception handling.

2. **File Organizer:**

   - Create an app to organize files based on user-defined rules.
   - Use streams and exception handling for file operations.

3. **Hangman Game:**
   - Develop a console-based Hangman game.
   - Use file I/O to load words and apply exception handling for missing files.
