# C# Mastery Notes

These are my personal way of studying C#, by writing clean codes and detailed notes as comments. If you think this is also an effective way for you to learn C# and .NET fundamentals, feel free to clone and learn!

## Overview
This repository contains a comprehensive, step-by-step guide to mastering C# from beginner to intermediate levels. Every topic is implemented as a standalone, runnable console project with code and explanatory comments inside `Program.cs`.

Whether you are starting from zero or refreshing your understanding of C# syntax, data structures, algorithms, and Object-Oriented Programming (OOP), you can follow along with the syllabus sequence below.

---

## 🚀 Getting Started

### Prerequisites
- [.NET SDK](https://dotnet.microsoft.com/download) installed, or [Visual Studio](https://visualstudio.microsoft.com/) / [VS Code](https://code.visualstudio.com/) with C# Dev Kit.

### Clone & Run
1. Clone the repository:
   ```bash
   git clone https://github.com/your-username/csharp-mastery-notes.git
   ```
2. Navigate into any topic folder and run:
   ```bash
   cd DataTypes
   dotnet run
   ```
   Or open `C#Mastery.slnx` directly in Visual Studio.

---

## 📚 Syllabus & Learned Topics

### 1. Fundamentals & Console I/O
- **Data Types**: Understanding value types, integers, floating-point numbers, characters, and booleans ([`DataTypes/Program.cs`](DataTypes/Program.cs)).
- **Console Input & Output**: Reading user inputs with `Console.ReadLine()` and displaying output with `Console.WriteLine()` ([`consoleInputOutput/Program.cs`](consoleInputOutput/Program.cs)).
- **Operators & Variables**: Arithmetic operators, remainder (`%`), compound assignments, and type inference with `var` ([`Operator,remainder, var and co/Program.cs`](Operator%2Cremainder%2C%20var%20and%20co/Program.cs)).

### 2. Control Flow & Conditionals
- **If / Else Statements**: Decision-making and branching execution paths ([`IfElse and switch/Program.cs`](IfElse%20and%20switch/Program.cs)).
- **Switch Statements**: Multi-way branch selection and switch cases ([`Switch/Program.cs`](Switch/Program.cs)).
- **Loops**: Iteration using `for`, `while`, and `do-while` loops ([`loop/Program.cs`](loop/Program.cs)).
- **Loop Exercise**: Practical challenge combining loops and conditional statements ([`loop&if else mini exercise/Program.cs`](loop%26if%20else%20mini%20exercise/Program.cs)).

### 3. Parsing, Formatting & Number Operations
- **TryParse**: Safe string-to-number parsing avoiding runtime exceptions ([`TryParse Function/Program.cs`](TryParse%20Function/Program.cs)).
- **Numeric Formatting**: Formatting currency, percentages, decimals, and custom number layouts ([`numeric formatting/Program.cs`](numeric%20formatting/Program.cs)).
- **Exercise - Timetable**: Building an interactive multiplication timetable ([`exercise-TimeTable/Program.cs`](exercise-TimeTable/Program.cs)).
- **Exercise - FizzBuzz**: Implementing the classic FizzBuzz interview challenge ([`exercise-fizzbuzz-game/Program.cs`](exercise-fizzbuzz-game/Program.cs)).

### 4. Strings & Text Processing
- **Verbatim String Literal**: Multiline strings, file paths, and escaping characters with `@` ([`VerbatingStringLiteral/Program.cs`](VerbatingStringLiteral/Program.cs)).
- **String Formatting**: String interpolation (`$""`) and composite formatting ([`stringFormattin/Program.cs`](stringFormattin/Program.cs)).
- **Empty Strings**: Understanding `string.Empty` vs `""` ([`empty/Program.cs`](empty/Program.cs)).
- **String Equals Function**: Comparing strings, case sensitivity, and ordinal comparisons ([`stringEqualsFunction/Program.cs`](stringEqualsFunction/Program.cs)).
- **String Iteration**: Looping through characters in a string with indexers and `foreach` ([`StringIteration(looping)/Program.cs`](StringIteration(looping)/Program.cs)).
- **String IsNullOrEmpty**: Validating strings using `string.IsNullOrEmpty` and `IsNullOrWhiteSpace` ([`StringisNullorEmptyFunc/Program.cs`](StringisNullorEmptyFunc/Program.cs)).
- **Exercise - Print String Reverse**: Reversing strings through loop iteration ([`exercise-printStringReverse/Program.cs`](exercise-printStringReverse/Program.cs)).
- **Exercise - Password Checker**: Password validation rule checker ([`exercise-passwordChecker/Program.cs`](exercise-passwordChecker/Program.cs)).
- **Conditional Operator**: Ternary operator (`?:`) shorthand for compact conditional logic ([`conditional operator/Program.cs`](conditional%20operator/Program.cs)).

### 5. Arrays & Collections
- **Arrays**: Initializing fixed-size arrays and accessing elements by index ([`arrays/Program.cs`](arrays/Program.cs)).
- **Array Sorting**: Ordering elements with `Array.Sort()` ([`arraysorting/Program.cs`](arraysorting/Program.cs)).
- **Array Reverse**: Inverting array element order with `Array.Reverse()` ([`reversearray/Program.cs`](reversearray/Program.cs)).
- **Array Clearing**: Resetting array elements with `Array.Clear()` ([`arrayclearing/Program.cs`](arrayclearing/Program.cs)).
- **Array IndexOf**: Searching for element positions with `Array.IndexOf()` ([`arrayindexOf/Program.cs`](arrayindexOf/Program.cs)).
- **Lists**: Dynamic collections using `List<T>`, adding, removing, and iterating items ([`list/Program.cs`](list/Program.cs)).
- **Dictionaries**: Key-value pair data structures with `Dictionary<TKey, TValue>` ([`Dictionary/Program.cs`](Dictionary/Program.cs)).
- **Exercise - Odd & Even Split**: Separating numbers into odd and even collections ([`exercises-odd&evenNumberSplit/Program.cs`](exercises-odd%26evenNumberSplit/Program.cs)).
- **Exercise - Array of Multiples**: Generating an array of multiples for a given number ([`arrayOfMultiples/Program.cs`](arrayOfMultiples/Program.cs)).

### 6. Functions & Methods
- **Functions Introduction**: Modularizing reusable logic into methods ([`Function/Program.cs`](Function/Program.cs)).
- **Void Functions**: Writing methods that perform actions without returning values ([`voidFunctions/Program.cs`](voidFunctions/Program.cs)).
- **Return Type Functions**: Creating methods that compute and return values ([`returnTypeFunctions/Program.cs`](returnTypeFunctions/Program.cs)).
- **Function Parameters**: Passing data and arguments into methods ([`FunctionsParameters/Program.cs`](FunctionsParameters/Program.cs)).
- **Optional Parameters**: Defining default argument values in method signatures ([`OptionalParameters/Program.cs`](OptionalParameters/Program.cs)).
- **Named Parameters**: Calling methods using explicit parameter names ([`namedParameters/Program.cs`](namedParameters/Program.cs)).
- **Out Parameters**: Returning multiple values from a method via `out` ([`outParameters/Program.cs`](outParameters/Program.cs)).
- **Out Parameter (Simpler)**: Modern simplified `out` variable declaration syntax ([`outParameter(SIMPLER)/Program.cs`](outParameter(SIMPLER)/Program.cs)).
- **Reference Parameters**: Passing variables by reference using `ref` ([`referenceParameter/Program.cs`](referenceParameter/Program.cs)).
- **Exercise - Area of Triangle**: Method calculation exercise ([`exercise-areaOftriangle/Program.cs`](exercise-areaOftriangle/Program.cs)).
- **Exercise - Sum of Int Array**: Computing totals from integer arrays using methods ([`exercise-sumOfIntArray/Program.cs`](exercise-sumOfIntArray/Program.cs)).

### 7. Exception Handling & Debugging
- **Exception Handling**: Understanding runtime errors and graceful failure handling ([`exceptionHandling/Program.cs`](exceptionHandling/Program.cs)).
- **Try & Catch**: Catching and managing exceptions safely ([`tryNcatch/Program.cs`](tryNcatch/Program.cs)).
- **Print Error Messages**: Inspecting `Exception.Message` and error details ([`PrintErrorMessages/Program.cs`](PrintErrorMessages/Program.cs)).
- **Exercise - Custom TryParse**: Building your own robust TryParse method from scratch ([`customTryParse/Program.cs`](customTryParse/Program.cs)).
- **Debugging**: Breakpoints, call stacks, and inspecting local variables ([`Debugging/Program.cs`](Debugging/Program.cs)).
- **Debugging 2**: Advanced step-through debugging and watches ([`debugging2/Program.cs`](debugging2/Program.cs)).

### 8. Structures & Object-Oriented Programming (OOP)
- **Structures**: Value-type data containers with `struct` ([`structures/Program.cs`](structures/Program.cs)).
- **Classes**: Blueprint fundamentals, reference types, and object instantiation ([`classes/Program.cs`](classes/Program.cs)).
- **Class Functions (Methods)**: Encapsulating behavior inside classes ([`ClassFunctions/Program.cs`](ClassFunctions/Program.cs)).
- **Class Functions 2**: Method parameters and object interactions ([`ClassFunctions2/Program.cs`](ClassFunctions2/Program.cs)).
- **Class Fields**: Member variables, access modifiers, and encapsulation ([`ClassFields/Program.cs`](ClassFields/Program.cs)).
- **Class Properties & Scope**: Getters, setters, auto-implemented properties, backing fields, and variable scope ([`classVariable&Function'sScope/Program.cs`](classVariable%26Function'sScope/Program.cs)).
- **ToString() Override**: Overriding `object.ToString()` for custom object representations ([`ClassToStringFuncOverride/Program.cs`](ClassToStringFuncOverride/Program.cs)).
