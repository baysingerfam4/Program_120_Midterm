using System.Reflection.Metadata;

namespace Program_120_Midterm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Carla Baysinger
            // Programming 120
            // Midterm
            // May 10th 2024

            Menu();
            PersonalCalculator();
            FinanceCalculator();
            GeometryCalculator();
            CartesianPlane();
        }// Main
        public static void Menu() // this is the main menu that happens when application first opens. Ask user which one you would like.
        {
            Console.WriteLine("Which calculator would you like to use?");
            Console.WriteLine("1 - Personal Calculator");
            Console.WriteLine("2 - Finance Calculator");
            Console.WriteLine("3 - Geometry Calculator");
            Console.WriteLine("4 - Cartesian Plane");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("Enter your choice (1 - 5): "); // here you enter choice
            string userInput = Console.ReadLine(); // computer reads input
            if (userInput == "1") // This one and below are options of the menu to enter into
            {
                PersonalCalculator();
            }
            else if(userInput == "2")
            {
                FinanceCalculator();
            }
            else if(userInput == "3")
            {
                GeometryCalculator();
            }
            else if(userInput == "4")
            {
                CartesianPlane();
            }
            else
            {
                Console.WriteLine("Have a great day"); // pops up if any other number, leter, or character is entered or exit is chosen.
                
                Environment.Exit(0);// following this exit code click any key to exit application

            }
        }// Menu
        public static void PersonalCalculator()
        {
            try
            {
                string value; // a string used in the while loop
                do
                {
                    Console.Write("Enter number 1: "); // user input
                    string userResponse1 = Console.ReadLine(); // computer reads string
                    double num1 = double.Parse(userResponse1); // convert string to double
                    Console.WriteLine("+ - Add");   // menu user chooses operation to use
                    Console.WriteLine("- - Subtract");
                    Console.WriteLine("* - Multiply");
                    Console.WriteLine("/ - Divide");
                    Console.WriteLine("e - Exit Personal Calculator"); // choose to exit
                    Console.WriteLine("Which math operation would you like(+,-, *, /,e): "); // ask user
                    string operatorType = Console.ReadLine(); // computer reads
                    Console.Write("Enter number 2: "); // ask user for second number
                    string userResponse2 = Console.ReadLine(); // computer reads
                    double num2 = double.Parse(userResponse2); // convert string to double



                    if (operatorType == "+") // adding option
                    {
                        Console.WriteLine("Result: ");
                        Console.WriteLine(num1 + num2); // display answer
                    }
                    else if (operatorType == "-") // minus option
                    {
                        Console.WriteLine(num1 - num2); // display answer
                    }
                    else if (operatorType == "*") // multiplication option
                    {
                        Console.WriteLine(num1 * num2); // display answer
                    }
                    else if (operatorType == "/") // division option
                    {
                        Console.WriteLine(num1 / num2); // display answer
                    }
                    else if (operatorType == "e") // exit option
                    {
                        Menu(); // exit to main menu
                    }
                    else // any other option entered goes to this
                    {
                        Console.WriteLine("Please enter the correct operator");// display
                    }
                    
                    Console.Write("Do you want to continue(y/n):"); // asks user if they want to continue
                    value = Console.ReadLine(); // computer reads
                } while (value == "y" || value == "Y"); // continues loop to personal calculator

                Console.WriteLine("Thank you for using my program, click any key to go to the Menu"); // displays when n is chosen
                Console.ReadKey();
                Menu();
            }

            catch (System.Exception ex) // if error happens
            {
                Console.WriteLine("A problem has occurred and the application will now exit. Details: {0}", ex.Message); // will exit application
            }

        }//personal calculator

        public static void FinanceCalculator()
        {
            try                                // put try/catch around code for errors
            {
                Console.WriteLine("1 - Net Income");
                Console.WriteLine("2 - Rule of 72");   // finance calculator menu user chooses
                Console.WriteLine("3 - Net Worth");
                Console.WriteLine("e - Exit Finance Calculator");
                Console.WriteLine("Choose your Selection (1,2,3,e): ");
                string userInput = Console.ReadLine(); //computer reads input of user
               
                if (userInput == "1") // if user chooses 1 for net income
                {
                    
                    Console.WriteLine("Total Revenue: "); // ask user for revenue
                    userInput = Console.ReadLine(); //computer reads input
                    decimal usernumber1 = decimal.Parse(userInput); //convert to decimal
                    Console.WriteLine("Total Cost: "); // ask user for expenses amount
                    userInput = Console.ReadLine(); // computer reads
                    decimal usernumber2 = decimal.Parse(userInput);// convert to decimal
                    decimal Result = usernumber1 - usernumber2; // net income equation
                    Console.WriteLine($"Your net income is: {Result.ToString("C")} "); //convert to currency
                    FinanceCalculator(); // back to submenu
                }
                else if (userInput == "2") //if user chooses 2 rule of 72
                {
                    Console.WriteLine("Interest Rate: "); // ask user for interest rate
                    userInput = Console.ReadLine(); // computer reads input
                    decimal usernumber1 = decimal.Parse(userInput);//convert to decimal
                    decimal ruleof72 = 72; // put in the decimal amount of 72
                    decimal result = ruleof72 / usernumber1; //equation rule of 72
                    decimal result1 = Math.Round(result,2); //round answer to 2 digits after decimal
                    Console.WriteLine($"With an interest rate of {usernumber1}% your money will double in {result1} years"); //display result
                    FinanceCalculator(); // back to submenu
                }
                else if (userInput == "3") // if user chooses number 3 net worth
                {
                    Console.WriteLine("Total assets: "); // ask user for total assets
                    userInput = Console.ReadLine(); // computer reads input
                    decimal usernumber1 = decimal.Parse(userInput); // convert string to decimal
                    Console.WriteLine("Total Liablities: "); // ask user for liablilities
                    userInput = Console.ReadLine(); // computer reads
                    decimal usernumber2 = decimal.Parse(userInput); // convert to decimal
                    decimal result = usernumber1 - usernumber2; // net worth equation
                    Console.WriteLine($"Your net worth is: {result.ToString("C")} ");// display result as currency
                    FinanceCalculator(); //back to sub menu
                }
                else if (userInput == "e") // if user chooses e
                {
                    Menu(); // exit to main menu
                }
            }
            catch (System.Exception ex) // if error happens
            {
                Console.WriteLine("A problem has occurred and the application will now exit. Details: {0}", ex.Message); // exit finance calculator
                Menu(); // go to main menu
            }

        }// Finance Calculator
        public static void GeometryCalculator()
        {   // below are the menu options for the geometry calculations
           try {
                string value;
                do { 
                 Console.WriteLine("1 - Square");
                 Console.WriteLine("2 - Rectangle");
                 Console.WriteLine("3 - Circle");
                 Console.WriteLine("4 - Right");
                 Console.WriteLine("e - Exit");
                 Console.WriteLine("Choose your selection (1,2,3,4,e):");
                    string userInput = Console.ReadLine();

                    if (userInput == "1") // square option
                    {
                        Console.WriteLine("What is the size of each Side: "); // ask user for size of square
                        userInput = Console.ReadLine(); //computer reads input
                        decimal usernumber1 = decimal.Parse(userInput); //convert to decimal
                        decimal Perimeter = 4 * usernumber1; // perimeter equation
                        decimal Area = usernumber1 * usernumber1;// Area Equation
                        decimal Perimeter1 = Math.Round(Perimeter, 2); // round perimeter to 2 digits after decimal
                        decimal Area1 = Math.Round(Area, 2); // round area to 2 digits after decimal
                        Console.WriteLine($"Perimeter is: {Perimeter1} "); //Display perimeter
                    }
                    else if (userInput == "2")
                    {
                        Console.WriteLine("What is the Length: "); // ask user for length of rectangle
                        userInput = Console.ReadLine(); //computer reads input
                        decimal Length = decimal.Parse(userInput); //convert to decimal
                        Console.WriteLine("What is the width: ");
                        userInput = Console.ReadLine();
                        decimal width = decimal.Parse(userInput);
                        decimal Perimeter = width + width + Length + Length; // perimeter equation
                        decimal Area = width * Length;// Area Equation
                        decimal Perimeter1 = Math.Round(Perimeter, 2); // round perimeter to 2 digits after decimal
                        decimal Area1 = Math.Round(Area, 2); // round area to 2 digits after decimal
                        Console.WriteLine($"Perimeter is: {Perimeter1} "); //Display perimeter
                        Console.WriteLine($"Area is: {Area1}"); // Display Area
                    }
                    else if (userInput == "3")
                    {
                        Console.WriteLine("What is the radius: "); // ask user for radius
                        userInput = Console.ReadLine(); //computer reads input
                        double radius = double.Parse(userInput); //convert to double
                        double area = Math.PI * radius * radius; // area equation
                        double Circumference = Math.PI * 2 * radius; // circumference equation
                        double area1 = Math.Round(area, 2); // round
                        double Circumference1 = Math.Round(Circumference, 2);
                        Console.WriteLine($"Area is: {area1} "); //Display Area
                        Console.WriteLine($"Circumference is: {Circumference1}"); // Display Circumference
                    }
                    else if (userInput == "4")
                    {
                        Console.WriteLine("Enter the radius of the cone: "); // ask user for radius of cone
                        userInput = Console.ReadLine(); //computer reads input
                        double radius = double.Parse(userInput); //convert to decimal
                        Console.WriteLine("What is the height of the cone: "); // ask user for height of the cone
                        userInput = Console.ReadLine();  // computer reads input
                        double height = double.Parse(userInput); //convert to double
                        double volume = Math.PI * radius * radius * height/3; // cone equation
                        double volume1 = Math.Round(volume, 2); // round volume to 2 digits after decimal
      
                        Console.WriteLine($"The volume is: {volume1} "); //Display perimeter
                    }
                    else if (userInput == "e")
                    {
                        Menu();
                    }

                    Console.Write("Do you want to continue(y/n):"); // asks user if they want to continue
                    value = Console.ReadLine(); // computer reads
                } while (value == "y" || value == "Y"); // continues loop to geometry calculator

                Console.WriteLine("Thank you for using my program, click any key to go to the Menu"); // displays when n is chosen
                Console.ReadKey();
                Menu();
           }
            catch (System.Exception ex) // if error happens
            {
                Console.WriteLine("A problem has occurred and the application will now exit. Details: {0}", ex.Message); // exit geometry calculator
                Menu(); // go to main menu
            }
        }
        public static void CartesianPlane()
        {
            try
            {
                string value;
                do { 
                string userInput;
            Console.WriteLine("Enter your x coordinate (as a whole number): "); // ask user for x coordinate
            userInput = Console.ReadLine(); //computer reads input
            double xCoor = double.Parse(userInput); // converts to double
            double xCoor1 = Math.Round(xCoor, 2); // rounds the x coordinate
            Console.WriteLine("Enter your y coordinate (as a whole number): "); // ask user for x coordinate
            userInput = Console.ReadLine(); //computer reads input
            double yCoor = double.Parse(userInput); // convert to double
            double yCoor1 = Math.Round(yCoor, 2); // rounds the y coordinate

            if (xCoor1 > 0 && yCoor1 < 0) // if x is more than 0 and y is less than 0
            {
                Console.WriteLine($"Your coordinates ({xCoor1}, {yCoor1}) are in Quadrant IV");
            }
            else if(xCoor1 < 0 && yCoor1 > 0) // if x is less than 0 and y is more than 0
                    {
                Console.WriteLine($"Your coordinates ({xCoor1}, {yCoor1}) are in Quadrant II");
            }
            else if (xCoor1 > 0 && yCoor1 > 0) // if x is more than 0 and y is more than 0
                    {
                Console.WriteLine($"Your coordinates ({xCoor1}, {yCoor1}) are in Quadrant I");
            }
            else if (xCoor1 < 0 && yCoor1 < 0) // if x is less than 0 and y is less than 0
                    {
                Console.WriteLine($"Your coordinates ({xCoor1}, {yCoor1}) are in Quadrant III");
            }
            else if (xCoor1 == 0 && yCoor1 > 0 || yCoor1 < 0) // if x = 0 and y is more than or less than 0
                    {
                Console.WriteLine($"Your coordinates ({xCoor1}, {yCoor1}) are at the y axis");
            }
            else if (yCoor1 == 0 && xCoor1 > 0 || xCoor1 < 0) // if y  = 0 and x is  more than or less than 0
                    {
                Console.WriteLine($"Your coordinates ({xCoor1}, {yCoor1}) are at the x axis");
            }
            else if (xCoor1 == 0 && yCoor1 == 0) // if x = 0 and y = 0
            {
                Console.WriteLine($"Your coordinates ({xCoor1}, {yCoor1}) are at the origin");
            }
                    Console.Write("Do you want to continue(y/n):"); // asks user if they want to continue
                    value = Console.ReadLine(); // computer reads
                } while (value == "y" || value == "Y"); // continues loop to cartesian plane

                Console.WriteLine("Thank you for using my program, click any key to go to the Menu"); // displays when n is chosen
                Console.ReadKey();
                Menu();
            }
            catch (System.Exception ex) // if error happens
            {
                Console.WriteLine("A problem has occurred and the application will now exit. Details: {0}", ex.Message); // exit cartesian plane
                Menu(); // go to main menu
            }

        }// cartesian plane


    }//class
}//namespace
