# C-sharp-fundamentals
This repo is created to track and record learning C# 

## HelloWorldApplication
- Learn how to create a C# (.Net Framework) console app
- Learn about Console.Write, Console.WriteLine(), Console.ReadLine() methods
- Learn how to build and run C# app

## Module02Lesson02Variables
- Learn about different types of variables (string, int, double, decimal, boolean)
- Learn to declare a variable
- Learn to use a variable
- Strings (Learn about escaping characters, string literal, string interpolation)
- Difference between double and decimal 
- Identify when to use int and string

## Module02Lesson02VariablesExcercise
This app was created to implement learning from Module02Lesson02Variables and uses following C# features
- Use Console.Write to output message
- Use Console.ReadLine() to collect data from user and assign it to variable
- Use bool and while loop to collect age data from user 
- Use int.TryParse() method to convert string into integer age
- Use Console.Clear() to clear console screen

## Module02Lesson03Conditionals
- Learn about if / else if / else conditonal statements
- Learn about &&, ||, == operators
- Learn about switch statements
- Learn about .ToLower() method

## Module02Lesson03ConditionalsExcercise
- Practise if else conditional statements
- Console app to welcome Tim Corey as professor and others as students

## Module02Lesson04Conversion
- Convert string to int
- Learn how to use int.TryParse and int.Parse methods
- Combining int.TryParse methods with if/else conditions

## Module02Lesson04ConversionExcercise
- Console app asks for user age and calculates how old user was in the year 2000
- While loop is used to ensure correct age is entered by user
- if / else statement is used to display results

## HomeWorkConditionalsConversion
- Mini project to practise if/else conditon
- Convert string to int
- Perform subtraction operation on string interpolation
- Practise writing pseudocode

## Module02Lesson06Loops
- While Loop (runs 0 or more times)
- Do while loop (runs 1 or more times)
- Looping is important to ensure user enters correct data or to perform any kind of validation

## Module02Lesson06LoopsExcercise
- Ask for the users name. If users name is Tim, say "Hello Professor" otherwise, say hi username until they type exit
- Do while loop is chosen as the code needs to run at least once
- If / else statemennt is used inside loop for conditional check

## Module02Lesson07Arrays
- Create Array
- Different ways of creating arrays
- Accessing array element 
- Array length and indexing

## Module02Lesson07ArraysExcercise
- Console app to create an array with three names
- User selects number 1 to 3 and respective name is displayed based on first, second and third name in an array
- Learn how to use and access array

## Module02Lesson08Lists
- how to create lists
- advantages of lists
- how to add data to lists
- how to remove elements from lists
- how to replace elements from lists

## Module02Lesson08ListsExcercise
- Console app to add students until there are no more students to add
- uses while loop to check if user wants to add students or not
- uses while loop to collect correct data format
- adds student names to the list if the user wants to add student to list

## Module02Lesson09Dictionary
- How to create key value pairs
- How to check if key is present
- How to access value of key
- Keys must be unique, if same then it will overwrite previous values

## Module02Lesson09DictionaryExcercise
- Console app: Create a dictionary with id and name
- ask user for id and display the name
- check the id is correct, a number and is within range
- re-prompt user for id if id is incorrect

## Module02Lesson10ForLoop
- How to use for loop 
- How to increase and decrease for loop 
- How to use for loops with arrays and lists

## Module02Lesson10ForLoopExcercise
- Console App that asks username seperated by commas
- Regex set up to remove all whitespaces, tabs
- Split user input and assign it to an array
- Print the contents of array using for loop

## Module02Lesson11ForEach
- How to use forEach
- When to use forEach
- Use forEach as much as possible with lists, arrays

## Module02Lesson11ForEachExcercise
- Console App that asks firstname
- adds user input into list
- then displays the user input using foreach loop

## Module02Lesson12Methods
- Learn how to use methods
- why methods are important
- Concept of DRY Do not repeat yourself
- Global variables
- How to create and call methods

## Module02Lesson12MethodsExcercise
- Console app to create two methods
- One method asks user for username
- Another method welcomes user by printing "Hello username"

## UsingBreakPointsDemo
- Create breakpoint by clicking the grey area
- Use locals to watch the existing variables
- Create breakpoints at different points
- Remove breakpoints by clicking on the breakpoint or Debug > Toggle Breakpoint

## ExceptionHandlingDemo
- How to handle exception using try and catch
- Try tries to execute a code
- catch catches and error and throws exception

## AdvancedExceptionDemo
- Different types of exception
- Use try catch 

## AdvancedBreakpointsDemo
- Deal with advanced breakpoints
- Add conditions to breakpoints
- Add action and log to breakpoints
- import and export exceptions

## Module04StaticClassesDemo
- how to create static classes
- importance of public classes
- why static classes are important
- use class files to seperate code 

## Module04StaticClassesDemoExcercise
- Create a console app with static class that handles calculations
- Create different classes

## Module04InstantiatedClassDemo
- Instantiate class
- Purpose of instantiating data

## Module04InstantiatedClassDemoExcercise
- Console app that has a person class and an address class
- Instantiate class
- Create class
- Use class in method

## Module04PropertyTypesDemo
- Difference between auto prop and full prop
- Use full prop when data needs to be masked or filtered/checked
- As a default always use auto props

## Module04PropertyTypesDemoExcercise
- Console app that has properties for street address, city, state and zip code
- Then add a FullAddress property that is read-only

## Module04ClassLibraryDemo
- Importance of class library
- how to reference class library to user interface
- put as much code as possible into class library
- do not put user interface code to class library (for e.g. console.writeline and readline etc)

## Module04ClassLibraryDemoExcercise
- Try to make a console app without looking at the tutorial

## Battleship app
- Create a battleship console app
- Use all the concepts up to module04
- Follow tutorial and complete challenges
- Complete methods challenges

## Module06InheritanceDemo
- Define inheritance (special class which can be passed down to other class)
- When to use inheritance (whenever property is a relationship inheritance should be used)
- When not to use inheritance (if a property does not apply we should not inherit it)
- Cannot inherit directly from more than one class

## Module06Lesson04InheritanceMiniProject
- Miniproject that uses inheritance and interface 
- Interface can be used to connect non related items together

## Module06Lesson05AccessModifiersDemoApp
- Different types of modifiers and its usage

## Module06Lesson06AbstractClassDemoApp
-  How to create Abstract class

## Module06Lesson07MethodOverRidingDemoApp
- How to create method overiding

## Module06Lesson07MethodOverRidingDemoAppExcercise
- Excercise to practise overiding

## Module06Lesson08CardGameUIApp
- Mini project to implement abstract, access modifier, enums

## Module06Lesson09MethodOverloadApp
- Method overload means having multiple methods with same name but different parameters
- Can have two methods with same name as long as their signatures are different
- Method overload allows us to have different configuration set up for a method 
- method overload is ideal when
	- performing same operation with different data types
	- providing flexibility in input
	- improving code readability and input

## Module06Lesson10ExtensionMethodDemo
- What is a extension method ?
	- Way to add additional functionality to an existing class without modifying its source code or creating a new derived class.
	- Simple analogy: Shoes which is functional but you want it to be waterproof. Instead of creating shoes from scratch you can just add a waterproof spray. Waterproof spray is like an extension method.
- How to create an extension method ?
	- step 1: Create a static class (helper container)
	- step 2: Inside that static class create a static method. First parameter of method starts with "this" keyword
	- step 3: Populate the method as required. Once complete method becomes and use it using dot notation (e.g. variable.ExtensionMethod())
- Why and When to use extension class ?
	- When you don't have access to source code or you don't own class but you want to add functionality, e.g. extension method to add data to database
	- To keep your code clean as you don't need to create subclasses or modify source code
	- Make code more readable by calling methods directly on the objects they relate to

## Module06Lesson10ExtensionMethodDemoExcercise
- Create the following chain using extension methods person.SetDefaultAge().PrintInfo() 
	- In this example default age has been set as 18 and provided as an optional parameter

## Module06Lesson11ExtensionMethodsMiniProject
- MiniProject to practise extension method and method overloading

## Module06Lesson11ExtensionMethodsMiniProject2
- Practice extension method and method overloading without looking at solution

## Module06Lesson12GenericsDemo
- What is a generic item ?
	- Generic item allows us to define classes, methods, and data structures that can operate with any data type while maintaining type safety. So this works with any datatype we provide.
- Why do we need Generics ?
	- We need generics to ensure type safetey i.e. ensure compile time type checking and prevent runtime errors
	- It also allows us to write one method or class that works with any data type
	- It also increases the performance as it avoids boxing/ unboxing for value types 
 
- How do we create Generics ?
	- We create generics by adding <T> to class and methods
	- class example:
    	`public class GenericHelper<T>
    	{  
        	private T item;
        
        	public T GetItem()  //No need to declare <T> as it has already been declared in the class
        	{ 
            	return item
        	}
    	}`
	- method example: 
    	`public static void Print<T, U>(T input1, U input2)  //we can also have more than 1 generic type
    	{
        	Console.WriteLine(input1)
        	Console.WriteLine(input2)
    	}`

	- interface example:
    	`public interface IImportance<T>
    	{
        	T MostImportant(T a, T b);
    	}

    	public class EvaluateImportance :  IImportance<int>, IImportance<string>    //implement in a class
    	{
        	public int MostImportant(int a, int b)
        	{
            		if (a > b)
            		{
                		return a;
            		}
            		else return b;
        	}

        	public string MostImportant(string a, string b)
        	{
            		if (a.Length > b.Length)
            		{
                		return a;
            		}
            		else return b;
    		}
	}`
 
	- constrains example:
	`public class SampleClass<T> whereT : class, new()   //this must have a class and an empty constructor
    	{
        
    	}`
 




