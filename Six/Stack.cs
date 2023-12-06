namespace Six
{
    internal class Stack<T>
    {
        private List<T> list = new List<T>();

        internal void Push(T item) 
        {
            list.Add(item);
        }

        internal T? Pop() 
        {
            int index = list.Count - 1;
            T item = list[index];
            list.RemoveAt(index);
            return item;
        }

        internal T Peek() 
        {
            T lastItem = list[list.Count - 1];
            return lastItem;
        }

        internal Boolean isEmplty() 
        {
            if (list.Count == 0) 
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        internal void PrintStack() 
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.PrintStack();
            stack.Push(2);
            stack.Push(3);

            stack.Pop();
        }
    }
}
