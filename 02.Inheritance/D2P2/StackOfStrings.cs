namespace D2P2
{
    public class StackOfStrings
    {
        private List<string> data;

        public StackOfStrings()
        {
            data = new List<string>();
        }

        // 1
        // 2 1
        // 3 2 1

        public void Push(string value)
        {
            this.data.Add(value);
        }

        public string Pop()
        {
            string element = Peek();

            if (element != null)
            {
                data.RemoveAt(data.Count - 1);
            }

            return element;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                return null;
            }

            string element = data[data.Count - 1];

            return element;
        }

        public bool IsEmpty()
        {
            return data.Count == 0;
        }
    }
}
