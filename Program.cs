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
            int x = 5; int y = 6;
            Console.WriteLine($"before : X = {x} , X = {y}");
            increaseby1(ref x, ref y);
            Console.WriteLine($"after : X = {x} , X = {y}");
            #endregion
        }
        public static void increaseby1(ref int a, ref int b)
        {
            a += 1; b += 1;
        }

    }
}
