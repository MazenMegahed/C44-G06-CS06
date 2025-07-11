using System.ComponentModel;

namespace Session6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.
            //passing by value : any change happens in the function doesn't reflect on the original variable in main code 
            // passing by reference : any change happens in the function reflects on the original variable in main code 
            //int x = 5; int y = 6;
            //Console.WriteLine($"before : X = {x} , X = {y}");
            //increaseby1(ref x, ref y);
            //Console.WriteLine($"after : X = {x} , X = {y}");
            #endregion

            #region Q2
            // Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c example.
            //passing by value : change the object's content but don't affect the reference in heap
            // passing by reference : change the object's content and create new reference in heap
            //int[] Array = { 1, 2, 3, 4, 5 };
            //Console.WriteLine("Main hashcode : "+Array.GetHashCode());
            //changelastelementbyvalue(Array);
            //Console.WriteLine("Hashcode after change last by value : " + Array.GetHashCode());
            //changelastelementbyreference(ref Array);
            //Console.WriteLine("Hashcode after change last by reference : " + Array.GetHashCode());

            #endregion

            #region Q3
            //Write a c# Function that accept 4 parameters from user and
            //return result of summation and subtracting of two numbers
            Console.WriteLine("Enter a num 1");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter a num 2");
            int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Enter a num 3");
            int.TryParse(Console.ReadLine(), out int num3);
            Console.WriteLine("Enter a num 4");
            int.TryParse(Console.ReadLine(), out int num4);

            int sum =0, substraction=0;
            if (num1 != null && num2!= null) (sum,substraction)=SummationandSubstractionFirst2(num1, num2, num3, num4); 
         
            Console.WriteLine($"Summation = {sum} , Substraction = {substraction}");
            #endregion
        }
        public static void increaseby1(ref int a, ref int b)
        {
            a += 1; b += 1;
        }

        public static void changelastelementbyvalue(int[]objects)
        {
            objects[objects.Length-1] += 5; 
        }
        static void changelastelementbyreference(ref int[] objects)
        {
            // This actually replaces the array with a new one
            objects = new int[] { 9, 9, 9, 9, 9 };
        }

        static(int x, int y) SummationandSubstractionFirst2(int a,int b,int c ,int d)
        {
            int summation = a + b;

            int substraction =a>b ?a-b :b-a;
          return (summation, substraction);
        }

    }
}
