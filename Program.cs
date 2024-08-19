using System;
namespace DisplayHello
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 2;
            numbers[1] = 5;
            numbers[2] = 9;
            numbers[3] = 6;
            numbers[4] = 7;
            int sum = 0;
            for(int i=0; i<numbers.Length; i++){
                sum = sum + numbers[i];
            }
            Console.Write("Sum = "+ sum);
        }
    }
}

