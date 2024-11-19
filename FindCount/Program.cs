namespace FindCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 1, 5, 12, 3, 6, 0, 55, 32, 4 };
            LinkedList<int> list = new LinkedList<int>(input);
            Console.WriteLine(string.Join(" ", list));
            int count = FindCount(list);
            Console.WriteLine($"The list above has {count} elements");
        }
        static int FindCount(LinkedList<int> list)
        {
            int counter = 0;
            foreach (int i in list)
            {
                counter++;
            }
            return counter;
        }
    }
}
