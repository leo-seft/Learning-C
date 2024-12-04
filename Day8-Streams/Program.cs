using System;
using System.IO;

namespace StreamReadingWriting
{
    class Program
    {
        //  static void Main(){
        //     string inputFilePath = "input.txt";
        //     string outputFilePath = "output.txt";
            
        //     using (FileStream fsInput = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
        //     using (FileStream fsOutput = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
        //     {
        //         byte[] buffer = new byte[4096];
        //         int bytesRead;
                
        //         while ((bytesRead = fsInput.Read(buffer, 0, buffer.Length)) > 0)
        //     {
        //         for (int i = 0; i < bytesRead; i++)
        //         {
        //             if (buffer[i] >= 'a' && buffer[i] <= 'z')
        //             {
        //                 buffer[i] = (byte)(buffer[i] - 32); // ascii code 32 difference between upper and lower case
        //             }
        //         }

        //         fsOutput.Write(buffer, 0, bytesRead);
        //     }
        //     }
        //     Console.WriteLine("Processing complete.");
        // }
        public static void Swap<T>(ref T a, ref T b){
            T temp = a;
            a = b;
            b = temp;
        }
        public class Person{
            public string Name{get; set;}
            public int Age{get; set;}
        }
        public static void Main(){
            int a = 15, b = 7;
            Console.WriteLine($"Before: {a}, {b}");
            Swap(ref a, ref b);
            Console.WriteLine($"After: {a}, {b}");

        }
    }
}