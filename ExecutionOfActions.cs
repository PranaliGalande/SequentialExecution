//Rextester.Program.Main is the entry point for your code. Don't change it.
//Microsoft (R) Visual C# Compiler version 2.9.0.63208 (958f2354)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;

namespace Rextester
{
    public class Execution
    {
        Action[] work;
        public Execution()
        {
            work=new Action[]{new Action(AddNumbers),   new Action(SubstractNumbers),    
                          new Action(MultiplyNumbers), new Action(DisplayNumberOfActions)};
        }
        int current =0;
        int number1 = 20,number2=10;
        public void ExecutionOfActions()
        {
            while(current!=work.Length)
            {
                try
                {
                    work[current]();
                    current++;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        public void AddNumbers()
        {
            Console.WriteLine("Addition of two numbers is {0}", number1+number2);
        }
        
         public void SubstractNumbers()
        {
            Console.WriteLine("Substraction of two numbers is {0}", number1-number2);
        }
        
         public void MultiplyNumbers()
        {
            Console.WriteLine("Multiplication of two numbers is {0}", number1*number2);
        }
        
        public void DisplayNumberOfActions()
        {
             Console.WriteLine("Number of Actions are {0}", current);
        }
        
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Execution execObj = new Execution();
            execObj.ExecutionOfActions();
        }
    }
}