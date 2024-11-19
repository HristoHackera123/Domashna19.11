namespace CheckNames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "Martin", "Obu", "Peter", "John", "Ivan", "Lubo" };
            LinkedList<string> list = new LinkedList<string>(input);
            CheckName(list);
        }
        static void CheckName(LinkedList<string> list)
        {
            Console.Write("The name you're looking for: ");
            string name = Console.ReadLine();
            foreach(string element in list)
            {
                if(string.Compare(element, name, true) == 0)
                {
                    Console.WriteLine("The name is on the list");
                    return;
                }
            }
            Console.WriteLine("The name is not on the list");
        }
    }
}
