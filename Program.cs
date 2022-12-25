using System;
using System.ComponentModel.Design;
using System.IO;
using System.Text;
namespace Textvalidation
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Menu:
            Console.WriteLine("Check your langugage:");
            Console.WriteLine("------------------------------");
            Console.WriteLine("|  1 Poland  |  2 English  |");
            string language = Console.ReadLine();
            int checktype = 0;
            try
            {
                 checktype = int.Parse(language);
            }
          catch(Exception)
            {
                Console.WriteLine("Error Parse.Exception");
            }
            if (checktype == 1)
            {
                ValidationTools validationtext = new ValidationTools();
                Console.WriteLine("Type your text to validation:");
                string text = Console.ReadLine();

                    text = validationtext.Validation(text);
                    Console.WriteLine("Next stage of validation:");
                    Console.WriteLine("We use comma after some polish words:");
                    text = validationtext.Comma(text);
                    Console.WriteLine(text);
                Console.WriteLine("Do you want get this text to document txt?");
                Console.WriteLine("|  Send Yes - y  |  Send No - n  |");
                string check = Console.ReadLine();
                if(check == "y" || check == "yes" || check == "Yes" || check == "yEs" || check == "yeS" || check == "YES" || check == "yES" || check == "YeS")
                {
                    Console.WriteLine("Please, take name for your document:");
                    string documentname = Console.ReadLine();
                    StreamWriter document = new StreamWriter($"../../../{documentname}.txt");
                    document.Write(text);
                    document.Close();
                    Console.WriteLine("Your file is ready");
                    Console.WriteLine("Click something to exit");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Click something to exit");
                 
                }
            }
            else if (checktype == 2)
            {
                Console.WriteLine($"We dont have this language now");
                goto Menu;
            }
            else
            {
                Console.WriteLine($"Error {language}, please write correct number");
                goto Menu;
            }

            Console.ReadLine();
        }
    }
}