using System;
using System.IO;

namespace Lab2_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            const string INPUT_PATH = @"input.bin";
            const string OUTPUT_PATH = @"output.bin";

            PhoneCallIOManipulator.WriteDataFromConsoleInFile(INPUT_PATH);
            PhoneCallIOManipulator.WritePhoneCallDataInOutputByCertainCriteria(INPUT_PATH, OUTPUT_PATH);
            PhoneCallIOManipulator.PrintDataFromFileWithMessage("Input.bin", INPUT_PATH);
            PhoneCallIOManipulator.PrintDataFromFileWithMessage("Output.bin", OUTPUT_PATH);

            Console.ReadKey();
        }
    }
}
