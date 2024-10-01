using System.Collections;

namespace D2P1
{
    public class CustomArrayList : ArrayList
    {
        public string RandomElement()
        {
            Random random = new Random();

            int index = random.Next(Count);

            Object element = this[index];

            RemoveAt(index);

            return element.ToString();
        }
    }
}
