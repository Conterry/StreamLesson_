using System;
using System.IO;

namespace StreamLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string FileWay = "Input.txt";
            string OutputFileWay = "Output.txt";

            string InputText = ReadFile(FileWay);
            WriteFile(OutputFileWay, InputText);
            if(ReadFile(OutputFileWay) == null)
            {
                Console.WriteLine("I think everything is much worse");
            }
        }

        public static string ReadFile(string Way)
        {
            StreamReader sr = new StreamReader(Way);
            string InputText = sr.ReadLine();
            return InputText;
        }

        public static void WriteFile(string Way, string Text)
        {
            StreamWriter sw = new StreamWriter(Way);
            sw.WriteLine(Text);
            sw.Close();
        }
    }
}
