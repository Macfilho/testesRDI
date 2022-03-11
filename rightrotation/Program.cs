using System;

namespace rightrotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] oneDimensionalArray = new int[3];
            Console.WriteLine("Enter the one Digit Array Elements : ");
            for (int i = 0; i < oneDimensionalArray.Length; i++)
            {
                oneDimensionalArray[i] = int.Parse(Console.ReadLine());
            }


            int k;
            for (int j = 0; j < oneDimensionalArray.Length - 1; j++)
            {
                k = oneDimensionalArray[0];
                oneDimensionalArray[0] = oneDimensionalArray[j + 1];
                oneDimensionalArray[j + 1] = k;

            }
            Console.WriteLine("Array Elements After Right Circular First Rotation:");
            foreach (int num in oneDimensionalArray)
            {
                // Console.Write( num + " ");
                Console.WriteLine(num + " ");


            }

            k = oneDimensionalArray[2];
            for (int j = 0; j < oneDimensionalArray.Length - 1; j++)
            {
                k = oneDimensionalArray[0];
                oneDimensionalArray[0] = oneDimensionalArray[j + 1];
                oneDimensionalArray[j + 1] = k;

            }

            Console.WriteLine("Array Elements After Right Circular Seccond Rotation:");
            foreach (int num in oneDimensionalArray)
            {
                Console.Write(num + " ");
                //Console.WriteLine(num + " ");

            }


            Console.ReadKey();


        }
    }
}
