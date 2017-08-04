using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateMenu();

            Run:
            ConsoleKey key = ReadMenu();
            RunAssignment(key);
            if (key != ConsoleKey.Z)
            {
                goto Run;
            }
        }


        private static void CreateMenu()
        {
            Console.WriteLine("01 - Press 1 to run write hello and name in new line.");
            Console.WriteLine("02 - Press 2 to run  Check Two Integers Are Equal Or Not");
            Console.WriteLine("03 - Press 3 to run  Check Positive And Negtive");

            Console.WriteLine("04 - Press 4 to run Check Even And Odd Number");
            Console.WriteLine("05 - Press 5 to run  Find Leap Year");
            Console.WriteLine("06 - Press 6 to runAge of candidate.");
            Console.WriteLine("07 - press 7 to run  Swap The Valu Of M and N");

            Console.WriteLine("08 - Press 8 to run Height Of A aPerson In Centimeter ");
            Console.WriteLine("09 - press 9 to run Coordinate Point In An XY");
            Console.WriteLine("A - Press Ato run  Find Greatest Number");
            Console.WriteLine("B - press B to run  Find Eligibilty For Admission ");
            Console.WriteLine("C - press C to run Information of student's subject ");
            Console.WriteLine("D - press D to run Read Temperature In Centigrade ");
            Console.WriteLine("E - press E to run  Check Triangle Is Equilateral ");
            Console.WriteLine("F - press F to run  Check Whether Triangle Valid ");
            Console.WriteLine("G - press G to run  Check Alphabet Is Vowel");
            Console.WriteLine("H - press H to run  Find Loss And Profit  ");
            Console.WriteLine("I - press I to run  Print The Electricity Bill");
            Console.WriteLine("J - press J to run   Disply Grade");
            Console.WriteLine("K - press K to run  Display Day Name ");
            Console.WriteLine("L - press L to run   Display In The Word");

            Console.WriteLine("M - press M to run  Display Month Name");
            Console.WriteLine("N - press N to run  Display Number Of Month ");
            Console.WriteLine("O - press O to run  ");
            Console.WriteLine("P - press P to run  ");
            Console.WriteLine("Q - press Q to run   ");

            Console.WriteLine("R - press R to run  ");
            Console.WriteLine("S - press S to run  ");
            Console.WriteLine("T - press T to run   ");
            Console.WriteLine("U - press U to run  ");

            Console.WriteLine("V - press V to run  ");
            Console.WriteLine("W - press W to run  ");
            Console.WriteLine("X - press X to run   ");
            Console.WriteLine("Y - press Y to run  ");
            Console.WriteLine("Z - press U to run  ");
        }

        private static ConsoleKey ReadMenu()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("------------");
            return key.Key;
        }

        private static void RunAssignment(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    WriteHelloAndNameInNewLine();
                    break;
                case ConsoleKey.D2:
                    CheckTwoIntegersAreEqualOrNot();
                    break;
                case ConsoleKey.D3:
                    CheckPositiveAndNegtive();
                    break;
                case ConsoleKey.D4:
                    CheckEvenAndOddNumber();
                    break;
                case ConsoleKey.D5:
                    FindLeapYear();
                    break;
                case ConsoleKey.D6:
                    ReadTheAgeOfACandidate();
                    break;
                case ConsoleKey.D7:
                    TheValueOfMandN();
                    break;
                case ConsoleKey.D8:
                    HeightOfAaPersonInCentimeter();
                    break;
                case ConsoleKey.D9:
                    CoordinatePointInAnXY();
                    break;
                case ConsoleKey.A:
                    FindGreatestNumber();
                    break;
                case ConsoleKey.B:
                    FindEligibiltyForAdmission();
                    break;
                case ConsoleKey.C:
                    StudentInformationn();
                    break;
                case ConsoleKey.D:
                    ReadTemperatureInCentigrade();
                    break;
                case ConsoleKey.E:
                    CheckTriangleIsEquilateral();
                    break;
                case ConsoleKey.F:
                    CheckWhetherTriangleValid();
                    break;
                case ConsoleKey.G:
                    CheckAlphabetIsVowel();
                    break;
                case ConsoleKey.H:
                    FindLossAndProfit();
                    break;
                case ConsoleKey.I:
                    PrinTheElectricityBill();
                    break;
                case ConsoleKey.J:
                    DisplyGrade();
                    break;
                case ConsoleKey.K:
                    DisplayDayName();
                    break;
                case ConsoleKey.L:
                    DisplayInTheWord();
                    break;
                case ConsoleKey.M:
                    DisplayMonthName();
                    break;
                case ConsoleKey.N:
                    DisplayNumberOfMonth();
                    break;
                case ConsoleKey.O:

                    break;
                case ConsoleKey.P:

                    break;
                case ConsoleKey.Q:

                    break;
                case ConsoleKey.R:

                    break;
                case ConsoleKey.S:

                    break;
                case ConsoleKey.T:

                    break;
                case ConsoleKey.U:

                    break;
                case ConsoleKey.V:

                    break;
                case ConsoleKey.W:

                    break;
                case ConsoleKey.X:

                    break;
                case ConsoleKey.Y:

                    break;


                case ConsoleKey.Z:
                    Console.WriteLine("Bye bye");
                    break;
                default:
                    break;


            }

        }

        private static void WriteHelloAndNameInNewLine()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("Maryam Kalsoom");
        }

        /// program to accept two integers and check whether they are equal or not.


        private static void CheckTwoIntegersAreEqualOrNot()
        {
            int num1, num2;
            Console.WriteLine("Check Two Integers Are Equal Or Not");

            Console.WriteLine("ener first number");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(num1.Equals(num2));


        }

        private static void CheckPositiveAndNegtive()
        {
            int num;
            Console.WriteLine("chesk positive and negtive umber");
            Console.WriteLine("enter number");
            num = Int32.Parse(Console.ReadLine());
            if (num >= 0)
            {
                Console.WriteLine("number is positive {0}", num);
            }
            else
            {
                Console.WriteLine("number is negtive {0}", num);
            }

        }


        /// program to check whether a given number is even or odd.


        private static void CheckEvenAndOddNumber()
        {
            int num1;
            Console.WriteLine("check even and odd number");
            Console.WriteLine("enter number");
            num1 = Int32.Parse(Console.ReadLine());
            if (num1 % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else if (num1 % 2 != 0)
            {
                Console.WriteLine("number is odd");
            }

        }

        ///  program to find whether a given year is a leap year or not.


        private static void FindLeapYear()
        {
            int chek_year;
            Console.WriteLine(" given year is a leap year or not");
            Console.WriteLine("enter year");
            chek_year = Int32.Parse(Console.ReadLine());

            if ((chek_year % 400 == 0) && (chek_year % 100 != 0) || (chek_year % 4 == 0))
            {
                Console.WriteLine("year is leap  year {0}", chek_year);

            }
            else
            {
                Console.WriteLine("year is not leap year {0}", chek_year);
            }
        }

        ///read the age of a candidate and determine whether it is eligible for casting his/her own vote.


        private static void ReadTheAgeOfACandidate()
        {
            int age;
            Console.WriteLine("Enter age of a candidate is: 21");
            age = Int32.Parse(Console.ReadLine());
            if (age == 21)
            {
                Console.WriteLine("Congratulation! You are eligible for casting your vote.");
            }
            else
            {
                Console.WriteLine("sorry!  You are not eligible for casting your vote");
            }
        }


        /// program to read the value of an integer m and display the value of n is 1
        ///when m is larger than 0, 0 when m is 0 and -1 when m is less than 0

        private static void TheValueOfMandN()
        {
            int m, n;

            Console.WriteLine("Display the value of n is 1,0 and -1 for the value of er m:");
            m = Int32.Parse(Console.ReadLine());
            if (m != 0)
                if (m > 0)
                    n = 1;
                else
                    n = -1;
            else n = 0;
            Console.WriteLine("the value of m is:  {0}", m);
            Console.WriteLine("the value of n is:  {0}", n);


        }

        ///  program to accept the height of a person in centimeter and categorize the person according to their heigh.


        private static void HeightOfAaPersonInCentimeter()
        {
            float per_height;
            Console.WriteLine(" height of a person in centimeter");
            Console.WriteLine("Accept the height of a person in centimeter and categorize them:");
            per_height = Convert.ToInt64(Console.ReadLine());

            if (per_height < 150.0)
                Console.Write("The person is Dwarf. \n\n");

            else if ((per_height >= 150.0) && (per_height <= 165.0))
                Console.Write("The person is  average heighted. \n\n");

            else if ((per_height >= 165.0) && (per_height <= 195.0))
                Console.Write("The person is taller. \n\n");

            else
                Console.Write("Abnormal height.\n\n");
        }
        /// program to accept a coordinate point in an XY coordinate system and
        /// determine in which quadrant the coordinate point lies

        private static void CoordinatePointInAnXY()
        {
            int x, y;
            Console.WriteLine("Find the quadrant in which the coordinate point lies");
            Console.WriteLine("enter the value of x");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter the value of x");
            y = Convert.ToInt32(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("The coordinate point ({0} {1}) lies in the First quandrant", x, y);

            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The coordinate point ({0} {1}) lies in the second quandrant", x, y);
            }
            else if (x < 0 && x < 0)
            {
                Console.WriteLine("The coordinate point ({0} {1}) lies in the Third quandrant", x, y);
            }
            else if (x > 0 && y < 0)
                Console.Write("The coordinate point ({0} {1}) lies in the Fourth quandrant.", x, y);

            else if (x == 0 && y == 0)
                Console.Write("The coordinate point ({0} {1}) lies at the origin.\n\n", x, y);
        }

        ///find the largest of three numbers.

        private static void FindGreatestNumber()
        {
            int num1, num2, num3;
            Console.WriteLine("enter first number");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter second number");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter third number");
            num3 = Int32.Parse(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }

        ///find the eligibility of admission for a professional course based on the following criteria

        private static void FindEligibiltyForAdmission()
        {
            int m, p, c;
            Console.WriteLine("Find the eligibilty?");
            Console.WriteLine("enter marks of math");
            m = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter marks of math");
            p = Int32.Parse(Console.ReadLine());

            Console.WriteLine("enter marks of math");
            c = Int32.Parse(Console.ReadLine());

            Console.WriteLine("total marks of all books {0}", m + p + c);
            Console.WriteLine("marks of math and physics : {0}", p + m);
            if (m >= 65)
                if (p >= 55)
                    if (c >= 50)
                        if ((m + p + c) >= 180 || (m + p) >= 140)
                            Console.WriteLine("the candidate is elligible for admission");
                        else
                            Console.WriteLine("the candidate is not elligible");
                    else
                        Console.WriteLine("The candidate is not elliginle");
                else
                    Console.WriteLine("The candidate is not elliginle");
            else
                Console.WriteLine("The candidate is not elliginle");

        }


        /// program to read roll no, name and marks of three subjects and
        /// calculate the total, percentage and division

        private static void StudentInformationn()
        {
            double rolno, che, phy, com, total;
            double per;
            string name, div;

            Console.Write("Calculate the total, percentage and division to take marks of three subjects:\n");

            Console.WriteLine("enter roll number");
            rolno = Int32.Parse(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();

            Console.WriteLine("input the marks of physics");
            phy = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input the marks of chemestry");
            che = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input the marks of computer");
            com = Int32.Parse(Console.ReadLine());

            total = phy + che + com;
            per = total / 3.0;
            if (per >= 60)
                div = "first";
            else
            if (per >= 60 && per >= 48)
                div = "second";
            else
            if (per >= 48 && per >= 36)
                div = "pass";
            else
                div = "fail";
            Console.WriteLine("Roll no and name of student {0} {1}", rolno, name);
            Console.WriteLine("marks of phy : marks of computer : marks of chemestry {0} {1} {2} ", phy, com, che);
            Console.WriteLine("totla marks  = {0}\npercentagae = {1}\n division = {2}", total, per, div);

        }


        /// </summaryprogram to read temperature in centigrade and 
        /// display a suitable message according to temperature state below

        private static void ReadTemperatureInCentigrade()
        {
            int temp;
            Console.WriteLine("Accept a temperature in centigrade and display a suitable message:");
            Console.WriteLine("Input days temprature");
            temp = Int32.Parse(Console.ReadLine());

            if (temp < 0)
                Console.WriteLine("Freezing weather ");
            else
                if (temp < 10)
                Console.WriteLine("Very Cold weather");
            else
                if (temp < 20)
                Console.WriteLine("Cold weather");
            else
                if (temp < 30)
                Console.WriteLine("Normal in Temp");
            else
                if (temp < 40)
                Console.WriteLine("Its Hot ");
            else
                Console.WriteLine(" Its Very Hot ");



        }

        /// <summary>
        ///  program to check whether a triangle is Equilateral, Isosceles or Scalene
        /// </summary>

        private static void CheckTriangleIsEquilateral()
        {
            int side1, side2, side3;
            Console.WriteLine("Check whether a triangle is Equilateral, Isosceles or Scalene: ");
            Console.WriteLine("Input first side");
            side1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input first side");
            side2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input first side");
            side3 = Int32.Parse(Console.ReadLine());

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("This is an equilateral triangle");

            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                Console.WriteLine("This is an isosceles triangle");

            }
            else
            {
                Console.Write("This is a scalene triangle.");
            }

        }

        ///program to check whether a triangle can be formed by the given value for the angles

        private static void CheckWhetherTriangleValid()
        {
            int num1, num2, num3;
            int sum = 0;

            Console.WriteLine("Input angle 1 of triangle");
            num1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input angle 2 of triangle");
            num2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Input angle 3 of triangle");
            num3 = Int32.Parse(Console.ReadLine());

            sum = num1 + num2 + num3;
            if (sum == 180)
            {
                Console
                    .WriteLine("The triangle is valid ");
            }
            else
            {
                Console.WriteLine("The triangle is not valid");
            }

        }

        /// <summary>
        ///  program to check whether an alphabet is a vowel or consonant
        /// </summary>

        private static void CheckAlphabetIsVowel()
        {
            char ch;
            Console.WriteLine("Check alphabet is wovel or constant");
            Console.WriteLine("input character");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("It is vowel");
                    break;
                case 'e':
                    Console.WriteLine("It is vowel");
                    break;
                case 'i':
                    Console.WriteLine("It is vowel");
                    break;
                case 'o':
                    Console.WriteLine("It is vowel");
                    break;
                case 'u':
                    Console.WriteLine("It is vowel");
                    break;
                default:
                    Console.WriteLine("It Is Not Vowel");
                    break;

            }
        }
        /// <summary>
        ///  program to calculate profit and loss on a transaction
        /// </summary>

        private static void FindLossAndProfit()
        {
            int cprice, sprice, p;
            Console.WriteLine("Calculate loss and profit");

            Console.WriteLine("input cost price");
            cprice = Int32.Parse(Console.ReadLine());

            Console.WriteLine("input sale price");
            sprice = Int32.Parse(Console.ReadLine());

            if (cprice > sprice)
            {
                p = cprice - sprice;
                Console.WriteLine("you can booked your profitt :{0}", p);
            }

            else
                if (sprice > cprice)
            {
                p = sprice - cprice;
                Console.WriteLine("you got loss");
            }
            else
            {
                Console.WriteLine("no loss no profit");
            }

        }

        /// <summary>
        ///  calculate and print the Electricity bil
        /// </summary>

        private static void PrinTheElectricityBill()
        {

            int userid, conunit;
            double chg, surchg = 0, gramt, netamt;
            string connme;

            Console.WriteLine("calculate the electricity bill");
            Console.WriteLine("input customer id:");
            userid = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter user name");
            connme = Console.ReadLine();

            Console.WriteLine("input unit");
            conunit = Convert.ToInt32(Console.ReadLine());
            if (conunit > 200)
                chg = 1.20;
            else if (conunit >= 200 && conunit <= 400)
                chg = 1.50;
            else if (conunit >= 400 && conunit <= 600)
                chg = 1.80;
            else
                chg = 2.00;
            gramt = conunit * chg;
            if (gramt > 300)
                surchg = gramt * 15 / 100.0;
            netamt = gramt + surchg;
            if (netamt < 100)
                netamt = 100;
            Console.WriteLine("Electricity bill");
            Console.WriteLine("cutomer id:       {0}", userid);
            Console.WriteLine("cutomer namr:    {0}", connme);
            Console.WriteLine("consumer unit    {0}", conunit);
            Console.Write("Amount Charges @Rs. {0}  per unit :{1}", chg, gramt);
            Console.Write("Surchage Amount                     :{0}", surchg);
            Console.Write("Net Amount Paid By the Customer     :{0}", netamt);

        }
        /// <summary>
        /// program in C# Sharp to accept a grade and declare the equivalent description 
        /// </summary>

        private static void DisplyGrade()
        {
            string notes;
            char grd;
            Console.WriteLine("Display grade");
            Console.WriteLine("input grade");
            grd = Convert.ToChar(Console.ReadLine().ToUpper());

            switch (grd)
            {
                case 'E':
                    notes = "Excelent";
                    break;

                case 'V':
                    notes = "very good";
                    break;
                case 'G':
                    notes = "good";
                    break;
                case 'A':
                    notes = "Average";
                    break;
                case 'F':
                    notes = "Fail";
                    break;
                default:
                    notes = "invalid grade";
                    break;

            }
            Console.WriteLine("You have chosen  : {0}", notes);
        }

        /// <summary>
        /// program in C# Sharp to read any day number in integer and display day name in the word.
        /// </summary>

        private static void DisplayDayName()
        {
            int dayno;
            Console.WriteLine("Accept day number and display its equivalent day name in word:");
            Console.WriteLine("input number of day:");
            dayno = Convert.ToInt32(Console.Read());

            switch (dayno)
            {
                case '1':
                    Console.WriteLine("monday");
                    break;
                case '2':
                    Console.WriteLine("tuesday");
                    break;
                case '3':
                    Console.WriteLine("wednesday");
                    break;
                case '4':
                    Console.WriteLine("thursday");
                    break;
                case '5':
                    Console.WriteLine("friday");
                    break;
                case '6':
                    Console.WriteLine("saturday");
                    break;
                case '7':
                    Console.WriteLine("sunday");
                    break;
                default:
                    Console.WriteLine("invalid day number");
                    break;

            }

        }

        /// <summary>
        /// program in C# Sharp to read any digit, display in the word.
        /// </summary>
        private static void DisplayInTheWord()
        {
            int digit;
            Console.WriteLine("Accept digit and display in word");
            Console.WriteLine("iput any digit");
            digit = Convert.ToInt32(Console.ReadLine());

            switch (digit)
            {
                case 0:
                    Console.Write("Zero\n");
                    break;

                case 1:
                    Console.Write("one\n");
                    break;
                case 2:
                    Console.Write("Two\n");
                    break;
                case 3:
                    Console.Write("Three\n");
                    break;
                case 4:
                    Console.Write("Four\n");
                    break;
                case 5:
                    Console.Write("Five\n");
                    break;
                case 6:
                    Console.Write("Six\n");
                    break;
                case 7:
                    Console.Write("Seven\n");
                    break;
                case 8:
                    Console.Write("Eight\n");
                    break;
                case 9:
                    Console.Write("Nine\n");
                    break;
                default:
                    Console.Write("invalid digit. \nPlease try again ....\n");
                    break;

            }
        }

        /// <summary>
        /// program in C# Sharp to read any Month Number in integer and display Month name in the word.
        /// </summary>

        private static void DisplayMonthName()
        {
            int digit;
            Console.WriteLine("Read month number and display month name:");
            Console.WriteLine("input digit");
            digit = Convert.ToInt32(Console.ReadLine());

            switch (digit)
            {
                case 1:
                    Console.Write("jan\n");
                    break;
                case 2:
                    Console.Write("feb\n");
                    break;
                case 3:
                    Console.Write("march\n");
                    break;
                case 4:
                    Console.Write("April\n");
                    break;
                case 5:
                    Console.Write("May\n");
                    break;
                case 6:
                    Console.Write("June\n");
                    break;
                case 7:
                    Console.Write("July\n");
                    break;
                case 8:
                    Console.Write("Agust\n");
                    break;
                case 9:
                    Console.Write("Sep\n");
                    break;
                case 10:
                    Console.Write("oct\n");
                    break;
                case 11:
                    Console.Write("nov\n");
                    break;
                case 12:
                    Console.Write("dec\n");
                    break;
                default:
                    Console.Write("invalid digit. \nPlease try again ....\n");
                    break;
            }
        }
        /// <summary>
        ///  program in C# Sharp to read any Month Number in integer and display the number of days for this month.
        /// </summary>
        private static void DisplayNumberOfMonth()
        {
            int monthno;

            Console.WriteLine("Read month number and display number of days for that month:");
            Console.Write("Input Month No : ");
            monthno = Convert.ToInt32(Console.ReadLine());//
            switch (monthno)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.Write("Month  have 31 days. \n");
                    break;
                case 2:
                    Console.Write("The 2nd month is a February and have 28 days. \n");
                    Console.Write("in leap year The February month  Have 29 days.\n");
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.Write("Month have 30 days. \n");
                    break;
                default:
                    Console.Write("invalid Month number.\nPlease try again ....\n");
                    break;
            }
        }

    }
}
