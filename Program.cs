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
        public static void Menu()
        {
            Console.WriteLine("Which calculator would you like to use?");
            Console.WriteLine("1 - Personal Calculator");
            Console.WriteLine("2 - Finance Calculator");
            Console.WriteLine("3 - Geometry Calculator");
            Console.WriteLine("4 - Cartesian Plane");
            Console.WriteLine("5 - Exit");
            Console.WriteLine("Enter your choice (1 - 5): ");
            string userInput = Console.ReadLine();
            if (userInput == "1")
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
                Console.WriteLine("Have a great day");
                Console.ReadKey();
            }
        }// Menu
        public static void PersonalCalculator()
        {
            try
            {
                string value;
                do
                {
                    Console.Write("Enter number 1: ");
                    string userResponse1 = Console.ReadLine();
                    double num1 = double.Parse(userResponse1);
                    Console.WriteLine("+ - Add");
                    Console.WriteLine("- - Subtract");
                    Console.WriteLine("* - Multiply");
                    Console.WriteLine("/ - Divide");
                    Console.WriteLine("e - Exit Personal Calculator");
                    Console.WriteLine("Which math operation would you like(+,-, *, /,e): ");
                    string operatorType = Console.ReadLine();
                    Console.Write("Enter number 2: ");
                    string userResponse2 = Console.ReadLine();
                    int num2 = int.Parse(userResponse2);



                    if (operatorType == "+")
                    {
                        Console.WriteLine("Result: ");
                        Console.WriteLine(num1 + num2);
                    }
                    else if (operatorType == "-")
                    {
                        Console.WriteLine(num1 - num2);
                    }
                    else if (operatorType == "*")
                    {
                        Console.WriteLine(num1 * num2);
                    }
                    else if (operatorType == "/")
                    {
                        Console.WriteLine(num1 / num2);
                    }
                    else
                    {
                        Console.WriteLine("Please enter the correct operator");
                    }

                    Console.ReadLine();
                    Console.Write("Do you want to continue(y/n):");
                    value = Console.ReadLine();
                } while (value == "y" || value == "Y");

             


            }

            catch (System.Exception ex)
            {
                Console.WriteLine("A problem has occurred and the application will now exit. Details: {0}", ex.Message);
            }
            

        }//personal calculator

        public static void FinanceCalculator()
        {

        }
        public static void GeometryCalculator()
        {

        }
        public static void CartesianPlane()
        {

        }

    }//class
}//namespace
