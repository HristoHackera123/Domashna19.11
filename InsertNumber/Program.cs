namespace InsertNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>(new int[] {1, 2, 4, 5});
            Console.WriteLine($"Original list: {string.Join(" ", list)}");
            InsertAfter(list, 2, 3); // po uslovie vkarva 3 sled 2
            CheckSorted(list);
        }
        static void InsertAfter(LinkedList<int> list, int search, int insert)
        {
            LinkedListNode<int> node = list.First;
            while (node.Value != search)
            {
                node = node.Next;
            }

            if (node != null)
            {
                list.AddAfter(node, insert);
            }
            else
            {
                Console.WriteLine("Element not found");
            }
            Console.WriteLine($"New list after adding {insert} after {search}: {string.Join(" ", list)}");
        }
        static void CheckSorted (LinkedList<int> list)
        {
            LinkedListNode<int> node = list.First.Next;
            while (node != null)
            {
                if (node.Previous.Value > node.Value)
                {
                    Console.WriteLine("List is unsorted");
                    return;
                }
                node = node.Next;
            }
            Console.WriteLine("List is sorted");
        }
    }
}
