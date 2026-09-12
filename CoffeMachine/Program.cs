using System.Runtime.ConstrainedExecution;

namespace CoffeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ni kommer att skriva ett program för en kaffemaskin där användare kan beställa tre olika storlekar -small, medium och large. 
            //Priset kommer att variera för varje storlek! Dessutom kommer programmet att skicka ett meddelande till användaren för att ta emot beställningen och fråga om användaren vill beställa mer inom samma beställning!
            //programmet kommer också att skriva ut det totala beloppet som användaren måste betala!

            bool no = false;
            int total = 0;
            do 
             {
                Console.WriteLine("Please select you Coffey size : 1 - Small 2 - Medium 3 - Large");
                string userInput = Console.ReadLine(); //här ska valet läggas som en summa som vidare läggs i en summering nånstans

                switch (userInput)
                {
                    case "1":
                        int small = 10;
                        total += small;
                        Console.WriteLine("Do You Want to buy more Coffee? Yes or No");
                        string answerSmall = Console.ReadLine();
                        if (answerSmall == "no")
                        {
                            no = true;
                            break;
                        }
                        else
                        {
                            break;
                        }                                               
                    case "2":
                        int medium = 15;
                        total += medium;
                        Console.WriteLine("Do You Want to buy more Coffee? Yes or No");
                        string answerMedium = Console.ReadLine();
                        if (answerMedium == "no")
                        {
                            no = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case "3":
                        int large = 20;
                        total += large;
                        Console.WriteLine("Do You Want to buy more Coffee? Yes or No");
                        string answerLarge = Console.ReadLine();
                        if (answerLarge == "no")
                        {
                            no = true;
                            break;
                        }
                        else
                        {
                            break;
                        }
                        
                }

            }
            while (!no); Console.WriteLine("Thank you for your order!" + "\nTotal to pay: " + total + " SEK");
                     
            
            


            



        }
    


    
    
    }

}
