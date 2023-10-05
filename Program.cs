using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        //Question 1 
        /*static void Main(string[] args)
        {
            int i = 0;
            int alphabate = 0;
            int digit = 0;
            int specialChar = 0;
            Console.Write("Input the string: ");
            String x = Console.ReadLine();

            int lengthOfInput = x.Length;
            while(i < lengthOfInput)
            {
                if((x[i] >= 'a' && x[i] <= 'z') || (x[i] >= 'A' && x[i] <= 'Z')){
                    alphabate++;
                }
                else if((x[i] >= '0' && x[i] <= '9'))
                {
                    digit++;
                }
                else
                {
                    specialChar++;  
                }
                i++;            
            }
            Console.WriteLine($"Number of Alphabate in the string: {alphabate} ");
            Console.WriteLine($"Number of Digit in the string: {digit} ");
            Console.WriteLine($"Number of Special character in the string: {specialChar} ");
            Console.ReadLine();
        }*/


        //Question 2
        /*static void Main(String[] args)
        {
            char temp;
            Console.Write("input the string: ");
            String x = Console.ReadLine();
            char[] chars = x.ToCharArray();
            
            for (int i = 1; i < chars.Length; i++) 
            {
                for(int j = 0; j < chars.Length-1; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        temp = chars[j];
                        chars[j] = chars[j+1];
                        chars[j + 1] = temp;
                    }
                    
                }
            }
            Console.Write("After shorting: ");
            Console.Write(chars);
            Console.ReadLine();
        }*/


        //Question 3
        /* static void Main(String[] args) 
         {
             Console.Write("Please enter your word : ");
             string word = Console.ReadLine();

             Console.Write("Starting position : ");
             int start = Convert.ToInt32(Console.ReadLine());

             Console.Write("Number of letters : ");
             int numberOfLetters = Convert.ToInt32(Console.ReadLine());


             for (int counter = start; counter <= numberOfLetters; counter++)
             {
                 Console.Write(word[counter]);
             }

             Console.ReadLine();
         }*/


        //Question 4
        /*static void Main(String[] args)
        {
            Console.Write("Please enter your char : ");
            string input = Console.ReadLine();
            int i=0;

            if ((input[i] >= 'a' && input[i] <= 'z') || (input[i] >= 'A' && input[i] <= 'Z'))
            {
                if (input[i] >= 'A' && input[i] <= 'Z')
                {
                    Console.WriteLine($"input is {input} is upper");
                }
                else
                {
                    Console.WriteLine("try again");
                }
            }
            else
            {
                Console.WriteLine("not a char");    
            }
            Console.ReadLine();
        }*/


        //Question 5
        /*static void Main(String[] args)
        {
            int i = 0;
            char c;
            Console.Write("Please enter your char : ");
            string input = Console.ReadLine();

            int lengthOfInput = input.Length;
            char[] input1 = input.ToCharArray();

            while(i < lengthOfInput)
            {
                c= input1[i];
                if (char.IsLower(c))
                {
                    Console.Write(char.ToUpper(c));
                }
                else
                {
                    Console.Write(char.ToLower(c));
                }
                i++;
            }
            Console.ReadLine();
        }*/


    }
}
