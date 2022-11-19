using System;

namespace DataStructureAndAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select Programs\n 1.Binary search");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        BinarySearch binarysearch = new BinarySearch();
                        binarysearch.Search(@"C:\Users\Lenovo\Desktop\Git\DataStructureAndAlgorithm\DataStructureAndAlgorithm\Word.txt");
                        break;
                
    public class BinarySearch
    {
        public void Search(string filepath)
        {
            string data = File.ReadAllText(filepath);
            string[] words = data.Split(",");
            Console.WriteLine("Enter words to search");
            string search = Console.ReadLine();
            foreach (var item in words)
            {
                if (search.ToLower().Equals(item.ToLower()))
                {
                    Console.WriteLine("words found");
                    return;
                }
            }
            Console.WriteLine("words not found");
        }
    }
}