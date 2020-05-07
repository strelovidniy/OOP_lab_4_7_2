using System;

namespace OOP_lab_4_7_2
{
    class Program
    {
        private static int n = int.Parse(Console.ReadLine());

        public static Student[] group = new Student[n];

        private static void Main(string[] args)
        {
            Input.Read();
            Output.Write();
        }
    }
}
