//--------------- *** Mahmoud Najuib AbdEltwab *** C43-G02-C#02 *** ---------------//
//---------------------------------------------------------------------------------//
//
namespace Assigment01
{
    internal class Program
    {
        class User
        {
            public string Name { get; set; }
        }

        static void Main(string[] args)
        {

            #region 1. Write a program that allows the user to enter a number then print it.

            //Console.Write("Write a Number: ");
            //int X = int.Parse(Console.ReadLine());
            //Console.WriteLine(X);


            ////// OR:

            //Console.Write("Write a Number: ");
            //String Input = Console.ReadLine();
            //Console.WriteLine(Input);

            #endregion

            #region 2. Write C# program that converts a string to an integer, but the string contains non-numeric characters. And mention what will happen:

            //int Input = int.Parse(Console.ReadLine());        //Ex: "Juba123"
            //Console.WriteLine(Input);

            ////What will happen: FormatException had been Occured => Can't Convert Integer Entries to String Datatype.

            #endregion

            #region 3. Write C# program that Perform a simple arithmetic operation with floating-point numbers. And mention what will happen:

            //Decimal X = Decimal.Parse("5.5") + Decimal.Parse("4.4");
            //Console.WriteLine(X);

            //////OR:

            //Console.Write("Enter 1st Num: ");
            //String X1 = Console.ReadLine();        //Ex: "5.5"

            //Console.Write("Enter 2nd Num: ");
            //String X2 = Console.ReadLine();        //Ex: "4.4"

            //Double Y1 = Double.Parse(X1);
            //Double Y2 = Double.Parse(X2);

            //Console.WriteLine(Y1 + Y2);

            //////OR:

            //Console.Write("Enter 1st Num: ");
            //Double Y1 = Double.Parse(Console.ReadLine());
            //Console.Write("Enter 2nd Num: ");
            //Double Y2 = Double.Parse(Console.ReadLine());
            //Console.WriteLine($"Sum of 2 Entires {Y1} + {Y2} = {Y1 + Y2}");

            ////What will happen: The Resault Occured Successfully Without Any Problems.

            #endregion

            #region 4. Write C# program that Extract a substring from a given string:

            //Console.Write("Enter a String: ");                                  //Ex: "Mahmoud Najuib"
            //string inputString = Console.ReadLine();

            //Console.Write("Enter the starting position: ");                     //Ex: "8"; The First of "Najuib".
            //int startPosition = int.Parse(Console.ReadLine());

            //Console.Write("Enter the length of the Substring: ");               //Ex: "6"; The length what I Need
            //int length = int.Parse(Console.ReadLine());

            //string substring = inputString.Substring(startPosition, length);
            //Console.WriteLine($"Extracted SubString is: {substring}");           //Resault: "Extracted SubString is: Najuib"

            #endregion

            #region 5. Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen:

            //int Num_1 = 2;

            ////To Assign Num_1 Value to The Other Value type variable:
            //int Num_2 = Num_1;

            ////To Modify the value of Num_2:
            //Num_2 = 5;

            ////To Show Resaults"
            //Console.WriteLine($"Num 1 = {Num_1}");                  //Resault: "2"
            //Console.WriteLine($"Num 2 = {Num_2}");                  //Resault: "5"

            ////What will happen: The Resault Occured Successfully Without Any Problems.

            #endregion

            #region 6. Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen:

            //User user_01 = new User { Name = "Mahmoud" };
            //User user_02 = user_01;                                     // When Modifiyng the "Name" property using user_02, the same shared object is modified for All.

            //    user_02.Name = "Juba";

            //Console.WriteLine($"user 1: {user_01.Name}");               // Resault: Juba
            //Console.WriteLine($"user 2: {user_02.Name}");               // Resault: Juba

            //// What Will Happen: "Juba" will be Showen in The 2 Resaults, Because The 2 Variables Refer to The Same Object.

            #endregion

            #region 7. Write C# program that take two string variables and print them as one variable:

            //// Input: 1st variable:
            //Console.Write("Enter The 1st String: ");
            //string FirstString = Console.ReadLine();                                // Ex: Mahmoud

            //// Input: 2nd variable:
            //Console.Write("Enter The 2nd String: ");
            //string SecondString = Console.ReadLine();                               // Ex: Najuib

            //// Output: Display the Total String:
            //Console.WriteLine(" ");
            //Console.WriteLine($"The Total String: {FirstString} {SecondString}");   // The Total String: Mahmoud Najuib

            #endregion

            #region 8. Which of the following statements is correct about the C#.NET code snippet given below?

            //int d;
            //d = Convert.ToInt32( !(30 < 20) );      // If Not = True Operator.

            //Console.WriteLine(d);                   // == "1".

            //// The Resault: B) A value 1 will be assigned to d.

            #endregion

            #region 9. Which of the following is the correct output for the C# code given below?

            //Console.WriteLine(13 / 2 + " " + 13 % 2); 

            //// The Resault: D) 6 1

            #endregion

            #region 10. What will be the output of the C# code given below?

            //int num = 1, z = 5;

            //if (!(num <= 0))                                            // == If Not.
            //    Console.WriteLine( ++num + z++ + " " + ++z );           // ==> This Condition Will be implement.
            //else
            //    Console.WriteLine( --num + z-- + " " + --z ); 

            //// The Resault: D) 7 7

            #endregion

        }
    }
}