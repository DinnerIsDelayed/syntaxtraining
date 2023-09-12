using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Practice.Categories
{
    internal class CSharp
    {
        public string type = "CSharp";
        public List<Problem> problems = new List<Problem>();
        public List<Problem> savedProblems = new List<Problem>();

        public CSharp()
        {
            problems = new List<Problem>()
            {
                // 1. How to define a class
                new Problem("How do you define a class in C#?", "class MyClass { }", "Defining a class in C# uses the 'class' keyword followed by the class name and its body enclosed in curly braces.\nExample: class MyClass { public int MyProperty { get; set; } }\nBest Use Case: When you want to create a new type that contains data and behavior."),

                // 2. How to instantiate a class
                new Problem("How do you instantiate a class?", "new MyClass()", "Instantiating a class involves the 'new' keyword followed by the class constructor.\nExample: MyClass myObject = new MyClass();\nBest Use Case: When you need to create a new object of a given class."),

                // 3. How to define a constructor
                new Problem("How do you define a constructor?", "public MyClass() { }", "A constructor is defined using the class name and empty parentheses, and can be parameterized.\nExample: public MyClass(int x) { this.x = x; }\nBest Use Case: When you need to initialize new instances of a class."),

                // 4. How to define a property
                new Problem("How do you define a property?", "public int MyProperty { get; set; }", "Properties in C# use the 'get' and 'set' accessors within curly braces.\nExample: public int MyProperty { get; set; }\nBest Use Case: When you want to encapsulate the fields of a class."),

                // 5. How to define a method
                new Problem("How do you define a method?", "public void MyMethod() { }", "A method definition includes an access modifier, a return type, and the method name.\nExample: public void MyMethod() { Console.WriteLine(\"Hello\"); }\nBest Use Case: When you need to define behavior for a class."),

                // 6. How to define a static method
                new Problem("How do you define a static method?", "public static void MyStaticMethod() { }", "A static method is defined with the 'static' keyword, and belongs to the class rather than any particular object instance.\nExample: public static void MyStaticMethod() { }\nBest Use Case: When a method doesn't depend on object state."),

                // 7. How to define an Interface
                new Problem("How do you define an interface?", "public interface IMyInterface { }", "An interface is defined with the 'interface' keyword and can contain method and property signatures.\nExample: public interface IMyInterface { void MyMethod(); }\nBest Use Case: When you want to define a contract for classes to implement."),

                // 8. How to implement an Interface
                new Problem("How do you implement an interface?", "class MyClass : IMyInterface", "Implementing an interface involves inheriting from it and implementing all its methods and properties.\nExample: class MyClass : IMyInterface { public void MyMethod() { } }\nBest Use Case: When you want to ensure a class adheres to a particular contract."),

                // 9. How to define an abstract class
                new Problem("How do you define an abstract class?", "public abstract class MyAbstractClass { }", "An abstract class is defined using the 'abstract' keyword, and cannot be instantiated.\nExample: public abstract class MyAbstractClass { public abstract void MyMethod(); }\nBest Use Case: When you want to define a base class with some methods left for derived classes to implement."),

                // 10. How to implement an abstract class
                new Problem("How do you implement an abstract class?", "class MyClass : MyAbstractClass", "Implementing an abstract class involves inheriting from it and implementing all its abstract methods.\nExample: class MyClass : MyAbstractClass { public override void MyMethod() { } }\nBest Use Case: When you want to build on a base class but ensure certain methods are overridden."),

                // 11. How to define a sealed class
                new Problem("How do you define a sealed class?", "public sealed class MySealedClass { }", "A sealed class is defined using the 'sealed' keyword, and cannot be inherited from.\nExample: public sealed class MySealedClass { }\nBest Use Case: When you want to prevent a class from being extended."),

                // 12. How to define a generic class
                new Problem("How do you define a generic class?", "public class MyGenericClass<T> { }", "A generic class is defined with the type parameter enclosed in angle brackets.\nExample: public class MyGenericClass<T> { public T MyProperty { get; set; } }\nBest Use Case: When you want to write reusable and type-safe code."),

                // 13. How to instantiate a generic class
                new Problem("How do you instantiate a generic class?", "new MyGenericClass<int>()", "Instantiating a generic class involves specifying the type argument during instantiation.\nExample: MyGenericClass<int> myObject = new MyGenericClass<int>();\nBest Use Case: When you need to create a type-specific instance of a generic class."),

                // 14. How to define a struct
                new Problem("How do you define a struct?", "struct MyStruct { }", "A struct is defined using the 'struct' keyword and is a value type.\nExample: struct MyStruct { public int MyField; }\nBest Use Case: When you want a lightweight, immutable object."),

                // 15. How to instantiate a struct
                new Problem("How do you instantiate a struct?", "new MyStruct()", "Instantiating a struct involves using the 'new' keyword followed by the struct constructor.\nExample: MyStruct myStruct = new MyStruct();\nBest Use Case: When you need a simple, efficient data container."),

                // 16. How to use 'try-catch'
                new Problem("How do you use 'try-catch'?", "try { } catch(Exception e) { }", "'try-catch' blocks are used for exception handling.\nExample: try { DoSomething(); } catch(Exception e) { Console.WriteLine(e.Message); }\nBest Use Case: When you want to handle exceptions gracefully."),

                // 17. How to throw an exception
                new Problem("How do you throw an exception?", "throw new Exception(\"Message\");", "An exception is thrown using the 'throw' keyword followed by a new exception object.\nExample: throw new ArgumentException(\"Invalid argument\");\nBest Use Case: When you want to signal an error condition that needs to be handled upstream."),

                // 18. How to define a lambda expression
                new Problem("How do you define a lambda expression?", "(x) => x * x", "A lambda expression is an anonymous function defined using the '=>' operator.\nExample: Func<int, int> square = (x) => x * x;\nBest Use Case: When you need a quick and concise function for LINQ queries or event handlers."),

                // 19. How to use LINQ 'Where' clause
                new Problem("How do you use LINQ 'Where' clause?", "collection.Where(x => x > 5)", "The LINQ 'Where' clause filters collections based on a predicate.\nExample: var result = myList.Where(x => x > 5);\nBest Use Case: When you need to filter elements in a collection based on a condition."),

                // 20. How to use LINQ 'Select' clause
                new Problem("How do you use LINQ 'Select' clause?", "collection.Select(x => x.Property)", "The LINQ 'Select' clause projects elements from a collection into a new form.\nExample: var result = myList.Select(x => x.Name);\nBest Use Case: When you need to transform elements in a collection."),
            
                // 21. Difference between dynamic and object types
                new Problem("What is the difference between dynamic and object types?", "dynamic: type determined at runtime, object: type determined at compile-time", "The 'dynamic' type bypasses compile-time checking, while the 'object' type is the base class for all types in C#. With 'dynamic', type determination is deferred until runtime.\nExample: dynamic x = 10; // type is determined at runtime\nobject y = 10;  // type is object at compile-time\nBest Use Case: Use 'dynamic' when you want more flexibility but less type safety, and 'object' when you want type safety enforced at compile-time."),

                // 22. How to create an XmlDocument
                new Problem("How do you create an XmlDocument?", "new XmlDocument()", "XmlDocument is a class used for XML document manipulation. It can be instantiated using the 'new' keyword.\nExample: XmlDocument xmlDoc = new XmlDocument();\nBest Use Case: When you need to parse, create, or manipulate XML documents."),

                // 23. How to use StreamWriter
                new Problem("How do you use StreamWriter?", "new StreamWriter(\"path\")", "StreamWriter is used for writing characters to a stream. It's part of System.IO.\nExample: using (StreamWriter writer = new StreamWriter(\"file.txt\")) { writer.WriteLine(\"Hello\"); }\nBest Use Case: When you need to write text to files."),

                // 24. How to use target-typed new
                new Problem("How do you use target-typed new?", "Point p = new(3, 5);", "Target-typed 'new' expressions allow omitting the type when it can be inferred from the context.\nExample: Point p = new(3, 5); // type Point is inferred\nBest Use Case: When you want to reduce code verbosity while maintaining readability."),

                // 25. How to format using numbered positional arguments
                new Problem("How to format using numbered positional arguments?", "string.Format(\"{0} {1}\", arg1, arg2)", "You can format strings using numbered positional arguments that map to the parameters in 'string.Format'.\nExample: string.Format(\"Hello {0} {1}\", \"John\", \"Doe\");\nBest Use Case: When you need to insert variables into a string in specific positions."),

                // 26. How to format using interpolated strings
                new Problem("How do you format using interpolated strings?", "$\"Hello {name}\"", "Interpolated strings in C# allow embedding expressions inside a string.\nExample: string greeting = $\"Hello {name}\";\nBest Use Case: When you want a cleaner and more readable way to format strings."),

                // 27. How to get key input from user
                new Problem("How do you get key input from user?", "Console.ReadKey()", "You can use 'Console.ReadKey()' to capture a single key press from the user.\nExample: var key = Console.ReadKey();\nBest Use Case: When you need to capture individual keypresses for console-based interaction."),

                // 28. How to use Async and Await
                new Problem("How do you use Async and Await?", "async Task MyMethod() { await SomeAsyncMethod(); }", "Async and Await are used for asynchronous programming in C#. 'async' marks a method as asynchronous and 'await' waits for the method to complete.\nExample: async Task MyMethod() { await SomeAsyncMethod(); }\nBest Use Case: When you want to perform time-consuming operations without freezing the UI."),

                // 29. How to use LINQ 'OrderBy'
                new Problem("How do you use LINQ 'OrderBy'?", "collection.OrderBy(x => x.Property)", "The LINQ 'OrderBy' method sorts a collection based on a property.\nExample: var result = myList.OrderBy(x => x.Age);\nBest Use Case: When you need to sort elements in a collection based on a specific property."),

                // 30. How to use LINQ 'GroupBy'
                new Problem("How do you use LINQ 'GroupBy'?", "collection.GroupBy(x => x.Property)", "The LINQ 'GroupBy' method groups a collection based on a property.\nExample: var result = myList.GroupBy(x => x.Department);\nBest Use Case: When you need to categorize elements in a collection based on a specific property."),

                // 31. How to define an extension method
                new Problem("How do you define an extension method?", "static class Extensions { public static void MyMethod(this MyClass obj) { } }", "Extension methods allow adding new methods to existing types without modifying them. They are defined as static methods in a static class.\nExample: public static void Print(this string str) { Console.WriteLine(str); }\nBest Use Case: When you want to add functionality to a type you don't own or can't modify."),

                // 32. How to use LINQ 'First'
                new Problem("How do you use LINQ 'First'?", "collection.First()", "The LINQ 'First' method returns the first element of a collection.\nExample: var firstItem = myList.First();\nBest Use Case: When you need the first element in a collection and are certain at least one element exists."),

                // 33. How to use LINQ 'FirstOrDefault'
                new Problem("How do you use LINQ 'FirstOrDefault'?", "collection.FirstOrDefault()", "The LINQ 'FirstOrDefault' method returns the first element of a collection or a default value if the collection is empty.\nExample: var firstItem = myList.FirstOrDefault();\nBest Use Case: When you need the first element in a collection but it might be empty."),

                // 34. How to define a nullable type
                new Problem("How do you define a nullable type?", "int? x = null;", "Nullable types can represent a normal value or null. They are defined using a '?' symbol after the type.\nExample: int? x = null;\nBest Use Case: When you need to represent missing or undefined data."),

                // 35. How to use string.IsNullOrEmpty
                new Problem("How do you use string.IsNullOrEmpty?", "string.IsNullOrEmpty(str)", "The 'string.IsNullOrEmpty' method checks if a string is null or empty.\nExample: if (string.IsNullOrEmpty(name)) { /*...*/ }\nBest Use Case: When you need to validate that a string has content."),

                // 36. How to use 'ref' keyword
                new Problem("How do you use the 'ref' keyword?", "void MyMethod(ref int x)", "'ref' is used to pass an argument by reference, allowing changes to the argument to affect the original variable.\nExample: void Increment(ref int x) { x++; }\nBest Use Case: When you need to modify an argument and have the changes reflected outside the method."),

                // 37. How to use 'out' keyword
                new Problem("How do you use the 'out' keyword?", "void MyMethod(out int x)", "'out' is used to pass an argument whose value will be set inside the method.\nExample: void GetLength(out int len) { len = 10; }\nBest Use Case: When you need to return more than one value from a method."),

                // 38. How to use LINQ 'Count'
                new Problem("How do you use LINQ 'Count'?", "collection.Count()", "The LINQ 'Count' method returns the number of elements in a collection.\nExample: var itemCount = myList.Count();\nBest Use Case: When you need to know the number of elements in a collection."),

                // 39. How to use 'yield return'
                new Problem("How do you use 'yield return'?", "yield return item;", "'yield return' is used within an iterator block to provide a value to the enumerator object.\nExample: public IEnumerable<int> GetNumbers() { yield return 1; yield return 2; }\nBest Use Case: When you need to create custom iterators."),

                // 40. How to use LINQ 'Any'
                new Problem("How do you use LINQ 'Any'?", "collection.Any()", "The LINQ 'Any' method checks if any elements exist in a collection.\nExample: var hasElements = myList.Any();\nBest Use Case: When you need to quickly check if a collection has any elements.")

            };

            for (int i = 0; i < problems.Count; i++)
            {
                problems[i].problemNumber = i + 1;
            }
        }
    }
}
