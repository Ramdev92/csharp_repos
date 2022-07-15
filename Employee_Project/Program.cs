using System; // the using keyword is used to include the System namespace in the program

namespace AllApps  // A namespace is a collection of classes
{
    class WelcomeEmployee
    {
        static void Main(string[] args)
        {
            // single line comment - Welcoming new employee //

            Console.WriteLine("Hello & Welcome to Cred Vision");

            /* 
             Console.ReadKey() --> 
             
             * This makes the program wait for a key press and it prevents the screen from running & closing quickly
             * The pressed key is optionally displayed in the console window. It is STRUCT Data type which is ConsoleKeyInfo. 
            
             */



            /*
             
             Key Points:

             * C# is case sensitive & It is an object-oriented programming language.
             * All statements and expression must end with a semicolon (;).
             * The program execution starts at the Main method.
             * Unlike Java, program file name could be different from the class name.
             * The extension of c# files is .cs.
             
             
            */

            /* DATA TYPES:
               ----------
            
            The variables in C#, are categorized into the following types −

               * Value types  -->  Value type variables can be assigned a value directly. They are derived from the class System.ValueType
               * Reference types  -->
               * Pointer types -->

            Value Types:
            ------------

            bool --> True/False
            char --> holds character
            decimal --> decimal value
            float --> 32-bit single-precision floating point type
            double  --> 64-bit double-precision floating point type
            sbyte -> 8-bit --> -128 to 128
            short -> 16-bit --> -32768 to 32768
            int -> 32-bit --> -2,147,483,648 to 2,147,483,647
            long -> 64 bit --> -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            byte -> 0 to 255
            ushort ->  0 to 65,535
            uint ->  0 to 4,294,967,295
            ulong -> 0 to 18,446,744,073,709,551,615

            <data_type> <variable_name> = value;

           // int d = 3, f = 5;    initializing d and f.
           // byte z = 22;          initializes z
           // double pi = 3.14159;  declares an approximation of pi.
           // char x = 'x';        the variable x has the value 'x'

            Reference Type:
            --------------

            The reference types do not contain the actual data stored in a variable, but they contain a reference to the variables.
            Example of built-in reference types are: object, dynamic, and string.

            Object Type:
            -----------
            The Object Type is the ultimate base class for all data types in C# Common Type System (CTS). Object is an alias for System.Object class. 
            The object types can be assigned values of any other types, value types, reference types, predefined or user-defined types.

            Dynamic Type:
            ------------
            
            You can store any type of value in the dynamic data type variable.
            Type checking for these types of variables takes place at run - time. 
            
            * dynamic <variable_name> = value;

            */

            //Execute Rectangle App from data of Rectangle class

            Rectangle r = new Rectangle(); //An object with reference variable "r" of class Rectangle is created

            Console.WriteLine("The Output of Rectangle App is:");

            r.Acceptdetails(); // calling Acceptdetails() method of Rectangle class through "r" reference variable

            r.Display(); // calling Display() method of Rectangle class through "r" reference variable

            /*
             
            Type conversion is converting one type of data to another type. It is also known as Type Casting. 
            In C#, type casting has two forms −

            Implicit type conversion − These conversions are performed by C# in a type-safe manner. 
                                       For example, are conversions from smaller to larger integral types and conversions from derived classes to base classes.

            Explicit type conversion − These conversions are done explicitly by users using the pre-defined functions. 
                                       Explicit conversions require a cast operator.
            
            */

            short a;
            int m;
            double c;

            /* actual initialization */
            a = 10;
            m = 20;
            c = a + m;
            Console.WriteLine("a = {0}, m = {1}, c = {2}", a, m, c);
            Console.WriteLine("a = " + a + "," + " m = " + m + ","  + " c = " + c);
            //Explicit Code:

            double d = 5673.74;
            int i;
            // cast double to int.
            i = (int)d;
            Console.WriteLine("Explicit Conversion of 5673.74 to int is: {0}", i);
            Console.WriteLine("Explicit Conversion of 5673.74 to int is: "+ i); // both lines are same

            int j = 75;
            float f = 53.005f;
            double e = 2345.7652;
            bool b = true;

            Console.WriteLine(j.ToString());
            Console.WriteLine(f.ToString());
            Console.WriteLine((int)e);
            Console.WriteLine(b.ToString());

            /*

            Accepting Values from User:
            --------------------------

            The Console class in the System namespace provides a function ReadLine() for accepting input from the user and store it into a variable.

            */

            // For example,

            int num;
            Console.WriteLine("Enter an input of number to convert to int");
            num = Convert.ToInt32(Console.ReadLine());

            //The function Convert.ToInt32() converts the data entered by the user to int data type, because Console.ReadLine() accepts the data in string format.

            Console.WriteLine("The entered number is: {0}", num);

            /*

            Constants:
            ----------

            * The constants refer to fixed values that the program may not alter during its execution.
            * These fixed values are also called literals. 
            * Constants are defined using the const keyword. Syntax for defining a constant is −

                const <data_type> <constant_name> = value;

            */

            //Example of Constants:

            const double pi = 3.14159;
            // constant declaration 
            double rad;
            Console.WriteLine("Enter Radius: ");
            rad = Convert.ToDouble(Console.ReadLine());

            double area_of_Circle = pi * rad * rad;
            Console.WriteLine("Radius: {0}, Area of Circle: {1}", rad, area_of_Circle);
            Console.ReadLine();

            /*
             
            Decision Making:
            ---------------

            Decision making structures requires the programmer to specify one or more conditions to be evaluated or tested by the program, 
            along with a statement or statements to be executed if the condition is determined to be true, and optionally, 
            other statements to be executed if the condition is determined to be false.
             
             
            The ? : Operator:
            -----------------

            Exp1 ? Exp2 : Exp3; --> 
            The value of a ? expression is determined as follows: Exp1 is evaluated. 
            If it is true, then Exp2 is evaluated and becomes the value of the entire ? expression. 
            If Exp1 is false, then Exp3 is evaluated and its value becomes the value of the expression.

            C# - Loops:
            ----------

            There may be a situation, when you need to execute a block of code several number of times. 
            In general, the statements are executed sequentially: 

            The first statement in a function is executed first, followed by the second, and so on.

            * while loop:

                It repeats a statement or a group of statements while a given condition is true. 
                It tests the condition before executing the loop body.

            * for loop
            
                It executes a sequence of statements multiple times and abbreviates the code that manages the loop variable.

            * do...while loop
            
                It is similar to a while statement, except that it tests the condition at the end of the loop body.

            * nested loops
            
                You can use one or more loop inside any another while, for or do..while loop.

            * Loop Control Statements
                
                Loop control statements change execution from its normal sequence.
                
                break statement:
                Terminates the loop or switch statement and transfers execution to the statement immediately following the loop or switch.

                continue statement:
                Causes the loop to skip the remainder of its body and immediately retest its condition prior to reiterating.

            */




        }
    }

class Rectangle // A class to initiate all values & executed in "ExecuteRectangle" class
{

// member variables of type double
double length;
double width;

public void Acceptdetails() // It doesn't return any value, as the method type is "void"
{
length = 4.5; // variable defined above with double data type
width = 3.5;  // variable defined above with double data type
}
public double GetArea() // A function that returns value with double data type
{
return length * width;
}
public void Display()
{
Console.WriteLine("Length: " + length);
Console.WriteLine("Width: " + width);
Console.WriteLine("Area of Rectangle is: " + GetArea());
}
}


}
