﻿using System;
using static keywords.DELEGATE;

namespace keywords
{

    // Abstract class
    abstract class Abstract
    {
        // Abstract method (does not have a body)
        public abstract void animalSound();
        // Regular method
        public void sleep()
        {
            Console.WriteLine("1.1) sleeping sound :" + "Zzz" + "\n");
        }
    }

    // Derived class (inherit from Animal)
    class Pig : Abstract
    {

        public override void animalSound()
        {
            Console.WriteLine("1)  Abstract");
            // The body of animalSound() is defined and provided this derived class
            Console.WriteLine("The pig says: wee wee");
        }
    }


    public static class AS
    {
        public static void ASExplain()
        {
            Console.WriteLine("2)  AS");
            object obj = "seran";
            string str = obj as string;
            if (str != null)
            {
                Console.WriteLine(str + "\n");
            }
        }

    }


    class Base
    {
        //base class method
        public void Eat()
        {
            Console.WriteLine("3.1) Animal is eating." + "\n");
        }
    }

    class Dog : Base

    {
        public void Bark()
        {
            Console.WriteLine("3)  Base");
            Console.WriteLine(" Dog is barking.");
            base.Eat(); // Calling base class method
        }
    }
    static class BOOL
    {
        public static void BOOLExplain()
        {
            Console.WriteLine("4)  BOOL ");
            //it returns only the value of true or false
            int x = 10;
            int y = 9;
            Console.WriteLine(x > y);
            Console.WriteLine();
        }
    }
    static class BREAK
    {
        public static void BREAKExplain()
        {
            Console.WriteLine("5)  BREAK");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    break;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
    static class CONTINUE
    {
        public static void CONTINUExplain()
        {
            Console.WriteLine("6)  Continue");
            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
    static class BYTE
    {
        public static void BYTEExplain()
        {
            Console.WriteLine("7)  BYTE");
            byte num = 255;

            // to print value
            Console.WriteLine("num: " + num);

            // to print size of a byte
            Console.WriteLine("Size of a byte variable: " + sizeof(byte) + "\n");

        }

    }
    static class CASEDEFAULT
    {
        public static void CASEDEFAULTExplain()
        {
            Console.WriteLine("8)  CASEDEFAULT");
            int day = 1;

            switch (day)
            {
                case 1:
                    Console.WriteLine("Morning");
                    break;
                case 2:
                    Console.WriteLine("Afternoon");
                    break;
                case 3:
                    Console.WriteLine("Evening");
                    break;
                default:
                    Console.WriteLine("Unknown day");
                    break;
            }
            Console.WriteLine();
        }
    }
    static class TRYCATCH
    {
        public static void TRYCATCHExplain()
        {
            Console.WriteLine("9)  TRYCATCH");
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine();
        }
    }
    static class CHAR
    {
        public static void CHARExplain()
        {
            Console.WriteLine("10)  CHAR");
            char Char = 's';
            Console.WriteLine("Represents only single character :" + Char + "\n");
        }
    }
    /*static class CHECKED
    {
        public static void CHECKEDExplain()
        {
            Console.WriteLine("11)  CHECKED");
            //Handling arthimatic exception
            int a = 2147483647;
            int b = 2147483647;
            int c = checked(a + b);
            Console.WriteLine(c);
            Console.WriteLine();
        }
    }*/
    static class CLASS
    {

        public static void CLASSExplain()
        {
            Console.WriteLine("12)  CLASS");
            string color = "red";
            Console.WriteLine(color);
            Console.WriteLine();
        }
    }
    /* static class CONST
     {
    Console.WriteLine("13)  CONST");
         public static void CONSTExplain()
         {
             const int myNum = 15;
             myNum = 20;
             Console.WriteLine();
         }
     }*/
    static class DECIMAL
    {

        public static void DECIMALExplain()
        {
            Console.WriteLine("14)  DECIMAL");
            decimal Decimal = 20.21M;
            Console.WriteLine(Decimal);
            Console.WriteLine();
        }
    }

    class DELEGATE
    {

        public delegate void MyDelegate(string msg);
        public static void DELEGATEExplain(string msg)
        {
            Console.WriteLine("15)  DELEGATE");
            Console.WriteLine("Called DELEGATE.DELEGATEExplain() with parameter: " + msg);
            Console.WriteLine();
        }
    }
    static class DOWHILE
    {
        public static void DOWHILEExplain()
        {
            Console.WriteLine("16)  DOWHILE");
            int i = 0;

            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
            Console.WriteLine();
        }

    }
    static class DOUBLE
    {
        public static void DOUBLEExplain()
        {
            Console.WriteLine("17  DOUBLE");
            double myNum = 19.99D;
            Console.WriteLine(myNum + "\n");
        }
    }
    static class CONDITIONAL
    {
        public static void CONDITIONALExplain()
        {
            Console.WriteLine("18  CONDITIONAL");
            int x = 10;

            if (x > 5)
            {
                Console.WriteLine("x is greater than 5");
            }
            else if (x == 11)
            {
                Console.WriteLine("x is equal  to 11");
            }
            else
            {
                Console.WriteLine("x is less than  5");
            }
            Console.WriteLine();

        }
    }
    enum DaysOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    class main
    {
        public static void Main(string[] args)
        {
            Pig myPig = new Pig();
            myPig.animalSound();
            myPig.sleep();

            AS.ASExplain();

            Dog dog = new Dog();
            dog.Bark();

            BOOL.BOOLExplain();
            BREAK.BREAKExplain();
            CONTINUE.CONTINUExplain();
            BYTE.BYTEExplain();
            CASEDEFAULT.CASEDEFAULTExplain();
            TRYCATCH.TRYCATCHExplain();
            CHAR.CHARExplain();
            //CHECKED.CHECKEDxplain();
            CLASS.CLASSExplain();
            //CONST.CONSTExplain();

            MyDelegate del = DELEGATE.DELEGATEExplain;
            del("Hello World");

            DOWHILE.DOWHILEExplain();
            DOUBLE.DOUBLEExplain();
            CONDITIONAL.CONDITIONALExplain();
            DaysOfWeek today = DaysOfWeek.Monday;

                
        }
    }
}