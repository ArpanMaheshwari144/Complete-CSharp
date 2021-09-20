using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            // Console.WriteLine("Arpan");
            // Console.WriteLine("Hello Arpan");

            // this is a single line comment
            /* this is a multi line comment */

            // Console.Write("Hello World ");
            // Console.Write("Arpan ");
            // Console.Write("Hello Arpan ");

            // int arpan = 34; // Integer Varaible
            // Console.WriteLine("This is a integer variable " + arpan);

            /*
            Data Types in C#
            int - 4 bytes, float - 4 bytes, char - 2 bytes, boolean - 1 bit, string - 2 bytes per character, long - 8 bytes, double - 8 bytes
            */

            // string input = Console.ReadLine(); // Console.ReadLine() returns a string and stores it to input name varaible
            // Console.WriteLine("The string is " + input);

            // Data Types Example in C#
            // int a = 34;
            // float b = 34.3F;
            // double c = 34.76;
            // bool d = true;
            // char e = 'A';
            // string f = "arpan"; 
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(d);
            // Console.WriteLine(e);
            // Console.WriteLine(f);

            // Typecasting in C#
            // There are two types of TypeCasting-
            // 1 Implicit TypeCasting - (ye complier automatically kar deta hai) char to int to long to float to double
            // int x = 3;
            // double y = x;
            // Console.WriteLine(y);

            // char a = 'A';
            // double b = a;
            // Console.WriteLine(b);

            // char a = 'a';
            // float b = a;
            // Console.WriteLine(b);

            // 2 Explicit TypeCasting - ye hum karte hai
            // int x = (int) 3.5;
            // double y = (int) 3.44;
            // Console.WriteLine(x);
            // Console.WriteLine(y);

            // TypeCasting using methods
            // float varr = Convert.ToInt32(3.55);
            // float varr1 = Convert.ToInt64(3.55);
            // int varr2 = Convert.ToChar('a');
            // Console.WriteLine(varr);
            // Console.WriteLine(varr1);
            // Console.WriteLine(varr2);


            // Taking User Inputs
            // Console.WriteLine("Enter Your Name");
            // string name = Console.ReadLine();
            // Console.WriteLine("The name is " + name);

            // Console.Write("Enter Your Name: ");
            // string name1 = Console.ReadLine();
            // Console.WriteLine("The name is " + name1);

            // Console.Write("How many candies do you want: ");
            // string candies = Console.ReadLine();
            // Console.WriteLine("The candies are " + candies);

            // Console.Write("How many candies do you want: ");
            // string candies1 = Console.ReadLine();
            // Console.WriteLine("The candies are " + (Convert.ToInt32(candies1) + 4));

            // Operators in C#
            // 1. Arithmetic Operators
            // 2. Assignment Operators
            // 3. Logical Operators
            // 4. Comparison Operators

            // Arithmetic Operators
            // int a = 7;
            // int b = 3;
            // Console.WriteLine("The value of a + b is: " + (a+b));
            // Console.WriteLine("The value of a - b is: " + (a-b));
            // Console.WriteLine("The value of a * b is: " + (a*b));
            // Console.WriteLine("The value of a / b is: " + (a/b));

            // Assignment Operators
            // int a = 4;
            // int b = a;
            // Console.WriteLine(b);

            // int a = 4;
            // int b = a;
            // b += 4;
            // Console.WriteLine(b);

            // int a = 4;
            // int b = a;
            // b -= 2;
            // Console.WriteLine(b);

            // int a = 4;
            // int b = a;
            // b *= 2;
            // Console.WriteLine(b);

            // int a = 4;
            // int b = a;
            // b /= 2;
            // Console.WriteLine(b);

            // Logical Operators

            // Logical OR Operators
            // Console.WriteLine(true && true);
            // Console.WriteLine(true && false);
            // Console.WriteLine(false && true);
            // Console.WriteLine(false && false);

            // Bitwise OR Operators
            // Console.WriteLine(true & true);
            // Console.WriteLine(true & false);
            // Console.WriteLine(false & true);
            // Console.WriteLine(false & false);

            // Bitwise AND Operators
            // Console.WriteLine(true | true);
            // Console.WriteLine(true | false);
            // Console.WriteLine(false | true);
            // Console.WriteLine(false | false);

            // Bitwise AND Operators
            // Console.WriteLine(true || true);
            // Console.WriteLine(true || false);
            // Console.WriteLine(false || true);
            // Console.WriteLine(false || false);

            // Logical NOT Operators
            // Console.WriteLine(!true);
            // Console.WriteLine(!false);

            // Comparison Operators
            // Console.WriteLine(2 > 1);
            // Console.WriteLine(2 < 1);
            // Console.WriteLine(2 >= 1);
            // Console.WriteLine(2 <= 1);
            // Console.WriteLine(2 == 1);
            // Console.WriteLine(2 != 1);

            // Math class in C#
            // int a = Math.Max(34, 33);
            // int b = Math.Min(34, 33);
            // double c = Math.Sqrt(64); // Sqrt returns a double
            // double d = Math.Sqrt(64.44);
            // int e = Math.Abs(-233);
            // Console.WriteLine(a);
            // Console.WriteLine(b);
            // Console.WriteLine(c);
            // Console.WriteLine(d);
            // Console.WriteLine(e);

            // String Class In C#
            // string hello = "This is it";
            // Console.WriteLine(hello.Length);
            // Console.WriteLine(hello.ToUpper());
            // Console.WriteLine(hello.ToLower());
            // Console.WriteLine(hello + " " + "Arpan");
            // Console.WriteLine(string.Concat(hello + " " + "Arpan"));
            // Console.WriteLine(string.Concat(hello, " Arpan"));

            // String Interpolation
            // string name = Console.ReadLine();
            // string candies = Console.ReadLine();
            // Console.WriteLine($"Your name is {name}. You won {candies} candies");

            // string name = "Arpan Maheshwari";
            // Console.WriteLine(name[0]);
            // Console.WriteLine(name.IndexOf('e'));
            // Console.WriteLine(name.IndexOf('a'));
            // Console.WriteLine(name.LastIndexOf('a'));
            //Console.WriteLine(name.Substring(1)); //start's index from 1

            // Escape Sequence Characters
            // string x = "arpan \"maheshwari\"";
            // string y = "arpan \n maheshwari";
            // string z = "arpan \nmaheshwari";
            // string x1 = "arpan \t maheshwari";
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // Console.WriteLine(z);
            // Console.WriteLine(x1);

            // if-else statements
            // int age = 16;
            // if (age > 18)
            // {
            //    Console.WriteLine("you can drive");
            // }
            // else
            // {
            //    Console.WriteLine("you cannot drive");
            // }

            // if else-if statements
            // int age = 18;
            // if (age > 18)
            // {
            //    Console.WriteLine("You can drive");
            // }
            // else if (age == 18)
            // {
            //    Console.WriteLine("You can learn driving");
            // }
            // else
            // {
            //    Console.WriteLine("You cannot drive");
            // }

            // if else-if ladder
            // int age = 16;
            // if (age < 2)
            // {
            //    Console.WriteLine("You are just born");
            // }
            // else if (age < 10)
            // {
            //    Console.WriteLine("Please finish your high school");
            // }
            // else if (age < 18)
            // {
            //    Console.WriteLine("You are below 18");
            // }
            // else if (age < 75)
            // {
            //    Console.WriteLine("You can drive");
            // }
            // else
            // {
            //    Console.WriteLine("You cannot drive");
            // }

            // Console.Write("Enter your age: ");
            // string ageStr = Console.ReadLine();
            // int age = Convert.ToInt32(ageStr);
            // if (age < 2)
            // {
            //    Console.WriteLine("You are just born");
            // }
            // else if (age < 10)
            // {
            //    Console.WriteLine("Please finish your high school");
            // }
            // else if (age < 18)
            // {
            //    Console.WriteLine("You are below 18");
            // }
            // else if (age < 75)
            // {
            //    Console.WriteLine("You can drive");
            // }
            // else
            // {
            //    Console.WriteLine("You cannot drive");
            // }

            // Console.Write("Enter your age: ");
            // string ageStr = Console.ReadLine();
            // int age = Convert.ToInt32(ageStr);
            // bool isBanned = true;
            // if (age < 2 || isBanned)
            // {
            //    Console.WriteLine("You are just born or banned");
            // }
            // else if (age < 10)
            // {
            //    Console.WriteLine("Please finish your high school");
            // }
            // else if (age < 18)
            // {
            //    Console.WriteLine("You are below 18");
            // }
            // else if (age < 75)
            // {
            //    Console.WriteLine("You can drive");
            // }
            // else
            // {
            //    Console.WriteLine("You cannot drive");
            // }

            // Switch Statements
            // int age = 18;
            // switch (age)
            // {
            //    case 18:
            //        Console.WriteLine("You are 18");
            //        break;

            //    case 19:
            //        Console.WriteLine("You are 19");
            //        break;

            //    case 20:
            //        Console.WriteLine("Yor are 20");
            //        break;

            //    default:
            //        Console.WriteLine("Enjoy!");
            //        break;
            // }

            // while loop
            // int i = 0;
            // while (i < 5)
            // {
            //    Console.WriteLine(i);
            //    i++;
            // }

            // do-while loop
            // int i = 0;
            // do
            // {
            //    Console.WriteLine(i);
            //    i++;
            // }
            // while (i < 4);

            // for loop
            // for(int i = 0; i < 5; i++)
            // {
            //    Console.WriteLine(i);
            // }

            // Break - leave this loop forever and Continue - leave this particular iteration of the loop
            // for(int i = 0; i < 5; i++)
            // {
            //    if (i == 3)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            // }

            // for (int i = 0; i < 5; i++)
            // {
            //    if (i == 3)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            // }

            // Methods
            // Greet();
            // Greet1("Arpan");
            // Greet1("Adarsh");
            // Console.WriteLine(Average(3, 6, 8));
            // int temp = Average(2, 3, 2);
            // Console.WriteLine(temp);
            // Console.WriteLine(Average(3, 4));
            // Console.WriteLine(Average1(3, 6, 8));
            // float temp1 = Average1(2, 3, 2);
            // Console.WriteLine(temp1);

            // OOPs - Classes and Objects
            Player tommy = new Player();
            Console.WriteLine(tommy.name);
            Console.WriteLine(tommy.health);
            tommy.setAge(50);
            Console.WriteLine(tommy.getGoals());
        }
        // static void Greet()
        // {
        //    Console.WriteLine("Good Morning");
        // }

        // static void Greet1(string name)
        // {
        //    Console.WriteLine("Good Morning" + " " + name);
        // }

        // static int Average(int a, int b, int c)
        // {
        //    int sum = a + b + c;
        //    return sum / 3;

        // }

        // static float Average(int a, int b)
        // {
        //    return (a + b) / 2;

        // }

        // static float Average1(int a, int b, int c)
        // {
        //    float sum = a + b + c;
        //    return sum / 3;
        // }
    }
    class Player
    {
        public string name = "arpan";
        public int health = 100;
        public int age = 23;
        private int goals = 10;

        public void setAge(int a)
        {
            age = a;
            Console.WriteLine(age);
        }

        public int getGoals()
        {
            return goals;
        }
    }
}
