using System;
using System.Collections.Generic;
using System.Linq;

namespace E_mail_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string mail = Console.ReadLine().Trim();

                string firstWord = "";
                string secondWord = "";
                
                bool isValid = true;

                List<string> listSplit = mail.Split('@')
                                .ToList();

                if (listSplit.Count == 2)
                {
                    firstWord = listSplit[0];
                    secondWord = listSplit[1];
                }
                else
                {
                    isValid = false;
                    
                }

                if (firstWord.Length >= 3)
                {
                    for (int b = 0; b < firstWord.Length; b++)
                    {

                        if (!char.IsDigit(firstWord[b]) && !char.IsLetter(firstWord[b]) && firstWord[b] != '_' && firstWord[b] != '.')
                        {
                            isValid = false;
                            
                        }
                    }
                }
                else
                {
                    isValid = false;
                    
                }

                List<string> secondList = secondWord.Split('.')
                                            .ToList();

                string firstSecondWord = "";
                string secondSecondWord = "";

                if (secondList.Count == 2)
                {
                    firstSecondWord = secondList[0];
                    secondSecondWord = secondList[1];
                }
                else
                {
                    isValid = false;
                    
                }
                if (!secondSecondWord.EndsWith("bg",StringComparison.OrdinalIgnoreCase) 
                    && !secondSecondWord.EndsWith("com", StringComparison.OrdinalIgnoreCase)
                    && !secondSecondWord.EndsWith("net", StringComparison.OrdinalIgnoreCase))
                {
                    isValid = false;
                    
                }
                if (firstSecondWord.Length < 3)
                {
                    isValid = false;
                    
                }
                for (int g = 0; g < firstSecondWord.Length; g++)
                {
                    if (!char.IsLetter(firstSecondWord[g]))
                    {
                        isValid = false;
                        
                    }
                }

                Console.WriteLine(isValid);

            }
        }
    }
}
