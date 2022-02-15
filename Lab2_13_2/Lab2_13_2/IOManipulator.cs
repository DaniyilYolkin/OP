using System;
using System.IO;

namespace Lab2_13_2
{
    public class PhoneCallIOManipulator
    {

        public static void WriteDataFromConsoleInFile(string filePath)
        {
            using (BinaryWriter fileWriter = new BinaryWriter(new FileStream(filePath, FileMode.Create)))
            {
                Console.WriteLine("Write your data: ");
                string stream = Console.ReadLine();
                while (IsEscapeSequence(stream))
                {
                    fileWriter.Write(stream);
                    stream = Console.ReadLine();
                }
            }
        }

        private static bool IsEscapeSequence(string data)
        {
            foreach (char letter in data)
            {
                if (letter >= 0 && letter != 10 && letter <= 31)
                {
                    return false;
                }
            }
            return true;

        }

        public static void WritePhoneCallDataInOutputByCertainCriteria(string inputPath, string outputPath)
        {
            using (BinaryReader inputReader = new BinaryReader(File.Open(inputPath, FileMode.Open)))
            {
                using (BinaryWriter outputWriter = new BinaryWriter(new FileStream(outputPath, FileMode.Create)))
                {
                    while (inputReader.BaseStream.Length != (int)inputReader.BaseStream.Position)
                    {
                        string data = inputReader.ReadString();
                        if (data != "")
                        {
                            string[] phoneCallData = data.Split(' ');
                            PhoneCall phoneCall = new PhoneCall(phoneCallData[0], phoneCallData[1], phoneCallData[2]);
                            if (IsFullfillingCriteria(phoneCall))
                            {
                                outputWriter.Write(phoneCall.ToString());
                            }
                        }
                    }
                }
            }
        }

        private static bool IsFullfillingCriteria(PhoneCall phoneCall)
        {
            return phoneCall.PhoneCallLength >= 3;
        }

        public static void PrintDataFromFile(string filePath)
        {
            using (BinaryReader fileReader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                while (fileReader.BaseStream.Length != (int)fileReader.BaseStream.Position)
                {
                    Console.WriteLine("\n" + fileReader.ReadString());
                }
            }
        }

        public static void PrintDataFromFileWithMessage(string header, string filePath)
        {
            Console.WriteLine("--------------" + header + "--------------");
            PrintDataFromFile(filePath);
            Console.WriteLine("------------------------------------");
        }
    }
}
