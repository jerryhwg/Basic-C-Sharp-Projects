# Basic-C-Sharp-Projects

#### AbstractClassBasic1

* abstract class
    ```C#
    public abstract class Person
    ```
* inheritance
    ```C#
    public class Employee : Person
    ```

#### anonyIncomeComp

* data type: string, integer
* boolean logic

#### arrayBasic1

* array
    ```C#
    int[] numArray1 = new int[] { 5, 2, 10, 200, 500 };
    int[] numArray2 = { 5, 2, 10, 200, 5000 };
    ```

#### assignmentBasic1

* multiple scenarios
* for loop for array
* do while loop with switch
* for loop with if
* while loop
* foreach with if
* fruits.Contains(choice)
* multiple matching & indexes

#### booleanBasic

* boolean logic (==, !=, >=, <=, &&, ||)

#### branchBasic

* if, else if, else, nested if/else
* double (data type)

#### classObjectMethodBasic1

* class
* method
    ```C#
    Math.Addition(number)
    public static double Addition(double number)
    ```

#### classObjectMethodBasic2

* method
    ```C#
    Math.math(firstNumber: 3, secondNumber: 5);
    public static void math(int firstNumber, int secondNumber)
    ```

#### classObjectMethodBasic3

* method overload (math)
* datatype (int, decimal, string)
* instantiate
    ```C#
    int result1 = new int();
    ```

#### classObjectMethodBasic4

* method
* instantiate / initialize / assignment
* output parameter
    ```C#
    public static int math(int number1, int number2 = 3)
    if (!Int32.TryParse(input2, out number2))
    ```

#### classObjectMethodBasic5

* method overload
* output parameter
    ```C#
    public static void Div(int number)
    public static void Div(int number, out int output)

    Math.Div(number, out output);
    ```

#### ConsoleApp1

* Basic C# console program example

#### ConstructionChainConstBasic1

* constructor call chain
    ```C#
    public Racer(string name) : this (name, 100)
    public Racer(string name, int racerLevel)
    ```
* property type
* var
* const

#### DateTimeBasic1

* DateTime
* DateTime.Now
* dt.AddHours(+t)

#### enumBasic1

* enums
    ```C#
    public enum DaysOfWeek
    DaysOfWeek day = DaysOfWeek.Monday;
    ```
* try catch

#### exceptionHandlingBasic1

* try
* catch (FormatException msg)
* catch (DivideByZeroException msg)
* catch (Exception msg)
* finally

#### exceptionHandlingBasic2

* try
* catch

#### ExceptionHandlingMoreBasic1

* try catch (ArgumentException)
* age (DateTime)

### FileIOBasic1

* File I/O
    ```C#
    File.WriteAllText(@"C:\Users\jerry\Logs\number.txt", number);
    File.ReadAllText(@"C:\Users\jerry\Logs\number.txt");
    ```
* @ " "

#### GenericBasic1

* generics
    ```C#
    public class Employee<T>

    Employee<string> employee = new Employee<string>();
    Employee<int> employeeID = new Employee<int>();
    ```

#### InheritanceBasic1

* inheritance
    ```C#
    class Employee : Person
    ```
* call super class method (Person)
    ```C#
    employee.SayName();
    ```

#### InterfaceBasic1

* interface
    ```C#
    interface IQuittable
    public class YQuit : IQuittable
    ```
* inheritance
* polymorphism

#### iterationBasic1

* foreach
    ```C#
    foreach (int score in testScores)
    ```
* passingScores.Count

#### iterationBasic2

* for loop
    ```C#
    for (int i = 0; i < names.Length; i++)
    ```
* for loop / if / do while switch
* array
* \ for "

#### LambdaBasic1

* list with multi members & properties
* foreach and show a matching
* property type

#### LambdaBasic2

* lambda expression
    ```C#
    List<Employee> empListJoe = empList.Where(x => x.FName == "Joe").ToList();
    ```

#### LambdaBasic3

* lambda expression
    ```C#
    List<Employee> empListJoe = empList.Where(x => x.Id > 5).ToList();
    ```

#### listBasic1

* List  
    ```C#
    List<int> intList1 = new List<int>();
    List<int> intList2 = new List<int>() { 1, 2, 3, 4, 5 };
    List<string> intList2 = new List<string>();
    ```

#### listsAndArraysBasic

* list
* array

#### listsAndArraysBasic2

* list
* array
* another version of listsAndArraysBasic

#### loopBasic1

* do while loop
* switch / case / default
* break

#### loopBasic2

* while loop
* switch / case / default

#### loopBasic3

* do while loop of loopBasic2

#### loopBasic4

* do while loop
* list any matching array member using while loop
* Array.IndexOf
* index -1
* \n for new line

#### mathBasic

* math operation (+, -, *, /, %)
* casting: string conversion to integer for math operation
* string + variable

#### MyApp1  

* Basic C# console program structure
  
#### MyApp2  

* basic C# console program example
* write, read, data type conversion (casting), string + variable

#### OperatorOverload

* operator overloading
    ```C#
    public static bool operator ==(Employee x, Employee y)

    public static Game operator+ (Game game, Player player)
    game = game + player;
    ```

#### stringBasic

* string
* ToUpper
* StringBuilder

#### StructBasic1

* structs
    ```C#
    public struct Number
    ```
* value type (struct)
* reference type (class)

#### TwentyOne - Before_Put_All_Together

#### TwentyOne - Put_All_Together

#### TwentyOne - ADO

* ADO.NET
    ```C#
    private static void UpdateDbWithException()
    
    string connectionString
    using (SqlConnection connection = new SqlConnection(connectionString))
    string queryString
    
    SqlCommand command = new SqlCommand(queryString, connection);
    command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);
    command.Parameters["@TimeStamp"].Value = DateTime.Now;
    ```