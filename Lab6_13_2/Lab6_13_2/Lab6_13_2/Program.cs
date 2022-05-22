using System;

namespace Lab6_13_2
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryHeapTree bht = new BinaryHeapTree();
            Console.WriteLine("Do you want to add a node to the Tree? Y/N: ");
            string answer = Console.ReadLine();
            while (answer == "Y" || answer == "y")
            {
                try
                {
                    Console.WriteLine("Enter the data for a node (detail_name quantity distributor): ");
                    string[] data = Console.ReadLine().Split();
                    bht.Insert(new Data(data[0], Convert.ToInt32(data[1]), data[2]));
                    Console.WriteLine("Data was succesfully added!");
                }
                catch
                {
                    Console.WriteLine("Error occured: Data weren't added");
                }
                finally
                {
                    Console.WriteLine("Do you want to add node to the Tree? Y to continue: ");
                    answer = Console.ReadLine();
                }
            }
            Data max_quantity_distributor = bht.FindMaxDistributorByQuantity();
            Console.ReadLine();
        }
    }
}
