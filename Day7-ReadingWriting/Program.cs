using System;
using System.IO;

namespace ReadingWriting
{
    class Program
    {
        // public static void Main(string[] args)
        // {
        //     File.WriteAllText("test.txt", "Hello World !");

        //     using (StreamWriter writer = new StreamWriter("test.txt", append: true)){
        //         writer.WriteLine(" Hello from Stream Writer");
        //     }
        //     using (StreamReader reader = new StreamReader("test.txt")){
        //         string line;
        //         while ((line = reader.ReadLine()) != null){
        //         Console.WriteLine(line);
        //         }
        //     }
        // }

        public static void Main(string[] args){
             
            string filepath = "test.txt";
            string content = ReadFile(filepath);
            CountWords(content);            
        }

        public static string ReadFile(string filePath){
                string content;
                using (StreamReader reader = new StreamReader(filePath)){
                    content = reader.ReadToEnd();
                }
                return content;
            }

             public static void CountWords(string content){
                string[] words = content.Split(new[] {' ', '\t', '\n', '\r', '.', ',', ';', '!', '?'},StringSplitOptions.RemoveEmptyEntries);
                int wordCount = words.Length;
                Console.WriteLine("Word Count: "+ wordCount);
            }
    }
}