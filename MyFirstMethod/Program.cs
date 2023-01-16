using System;

namespace MyFirstMethod
{
    public class MyFirstMethod
    {
        public static string Something()
        {
            return "Algo";
        }
        public int IntegerMultiplication(int a, int b)
        {
            int multiplication = a * b;
            return multiplication;
        }
        public void IntegerAddition(int a, int b)
        {
            int addition = a + b;
            Console.WriteLine("El resultado es " + addition);
        }
        static void Main(string[] args)
        {
            MyFirstMethod MyProgram = new MyFirstMethod();
            MyProgram.IntegerAddition(1, 2);
            int result = MyProgram.IntegerMultiplication(1, 2);
            Console.WriteLine("La multiplicación es " + result);
        }
    }

}