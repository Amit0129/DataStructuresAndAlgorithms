namespace DataStructuresAndAlgorithms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Insertion Sort");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    int[] arr = { 1, 65, 65, 4, 54, 88, 54 };
                    Insertion_Sort insertion_Sort = new Insertion_Sort();
                    insertion_Sort.Insertion(arr);
                    insertion_Sort.Display(arr);
                    break;
                default:
                    Console.WriteLine("Enter avslid choice");
                    break;
            }
        }
    }
}