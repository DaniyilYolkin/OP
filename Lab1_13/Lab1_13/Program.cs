using System;
using System.IO;

namespace Lab1_13
{
    class Program
    {
        static void Main(string[] args)
        {

            FileInfo input = new FileInfo("input.txt");
            FileInfo output = new FileInfo("output.txt");

            const string pathInput = @"input.txt";
            const string pathOutput = @"output.txt";

            // Function is used to clear input file on each modification of output file to avoid repetition
            ClearFile(pathInput);

            WriteTextInInput(input);

            string[] lines = ReadFile(pathInput);
  
            foreach(string line in lines)
            {
                string shortestWord = FindShortestWordInLine(line);
                string modifiedLine = ComposeModifiedString(line, shortestWord);
                WriteLineInOutput(modifiedLine, output);
            }

            Console.WriteLine("\nLines was succesfully grouped in output.txt and file was added to the ./bin/Debug/net5.0/output.txt");

            DisplayMessageAsHeader("Input.txt");
            DisplayDataOfFile(pathInput);
            DisplayMessageAsHeader("Output.txt");
            DisplayDataOfFile(pathOutput);

        }

        static void ClearFile(string path) {
            File.WriteAllText(path, string.Empty);
        }

        static void DisplayDataOfFile(string path)
        {
            string[] lines = ReadFile(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        static void DisplayMessageAsHeader(string message)
        {
            Console.WriteLine("\n-------------------------" + message + "----------------------------------\n");
        }

        static void DisplayMessage()
        {
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine("Write your input text in the console: ");
            Console.WriteLine("Leave console line blank and press \"Enter\" when you finish");
            Console.WriteLine("----------------------------------------------------------------");
            Console.WriteLine();
        }

        static void WriteTextInInput(FileInfo input)
        {
            StreamWriter sr = input.AppendText();
            displayMessage();
            string text = Console.ReadLine();
            while (text != "")
            {
                sr.WriteLine(text);
                sr.Flush();
                text = Console.ReadLine();
            }
            Console.WriteLine("\nInput file was succesfully created and added to the ./bin/Debug/net5.0");
        }

        static string[] ReadFile(string path)
        {
            return File.ReadAllLines(path);
        }

        static string FindShortestWordInLine(string line)
        {
            char[] separators = new char[] { ' ', ',', ';', '.' };
            string shortestWord = "";
            int shortestWordLength = int.MaxValue;
            string[] arrayOfWords = line.Split(separators);
            foreach (string word in arrayOfWords)
            {
                if (word.Length < shortestWordLength && word != "")
                {
                    shortestWordLength = word.Length;
                    shortestWord = word;
                }
            }
            return shortestWord;
        }

        static string ComposeModifiedString(string line, string shortestWord)
        {
            return line + " - " + shortestWord.Length + " - " + shortestWord;
        }

        static void WriteLineInOutput(string line, FileInfo output)
        {
            StreamWriter sr = output.AppendText();
            sr.WriteLine(line);
            sr.Flush();
        }

    }
}
