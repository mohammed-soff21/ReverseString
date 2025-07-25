using System.Text;

namespace ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Declaring variables
            char cUserChoice = ' ';
            string sPhrase = string.Empty;
            while (true)
            {
                // Welcome message
                WelcomeApp("reverse the string");
                // ask user to enter the string
                ReadString("any statement you want to reverse", out sPhrase);
                // print the reversed string
                Print($"The reversed statement is {ReverseString(sPhrase)}");
                




                // To read user choice to continue in the app again and validate the user input
                if (!IsChar(" y to check another number else enter n", out cUserChoice))
                    return;
                // Convert the character to lower 
                cUserChoice = Char.ToLower(cUserChoice);
                // To check the user input in the right format (y,n)
                if (!IsInRightFormat(cUserChoice))
                    return;
                // To check if the user want to continue or not
                if (!WantToContinue(cUserChoice))
                    return;
            }

        }


        #region Methods 

        // This region contains the main methods used in the application
        #region main-methods

        // 1) this method to welcome user in the beginning of the application
        static void WelcomeApp(String welcomeMessage)
        {
            Console.Clear();
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine($"  Welcome to {welcomeMessage} Application!");
            Console.WriteLine("  This app is designed to make your life easier.");
            Console.WriteLine("  Let's get started!");
            Console.WriteLine("  Developed by: Mohammed Salem");
            Console.WriteLine("*********************************************************************************");
        }

        // 2) this method to print message in a beatiful form
        static void Print(String message)
        {
            Console.WriteLine("---------------------------------------------------------------------------------");
            Console.WriteLine(message);
            Console.WriteLine("---------------------------------------------------------------------------------");
        }

        // 3) this method to read and validate character from the user
        static bool IsChar(string field, out char cInput)
        {
            Console.Write($"Please, enter {field}: ");
            if (!char.TryParse(Console.ReadLine(), out cInput))
            {
                Print("Please, enter a valid character");
                return false;
            }
            return true;
        }

        // 4) this method to check that the user entered (y,n) only
        static bool IsInRightFormat(char input)
        {
            if (input == 'y' || input == 'n')
                return true;
            Print("Please, enter (y) to check another number else enter (n) only");
            return false;
        }

        // 5) this method to check the user choice if he wants to continue in the app or not
        static bool WantToContinue(char input)
        {
            if (input == 'y')
                return true;
            Print("The program ended : see you soon again");
            return false;
        }

        // 6) This method to reverse the string
        static string ReverseString(string input)
        {
            StringBuilder sbReversed = new StringBuilder();
            for (int nCounter = input.Length - 1; nCounter >= 0; nCounter--)
                sbReversed.Append(input[nCounter]);
            return sbReversed.ToString();
        }

        // 7) this method to read a string from user
        static void ReadString(string field, out string value)
        {
            Console.Write($"Please enter {field}: ");
            value = Console.ReadLine();
        }
        #endregion


        #endregion

    }
}