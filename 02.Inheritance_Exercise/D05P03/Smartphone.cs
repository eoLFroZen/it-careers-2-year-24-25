namespace D05P03
{
    public class Smartphone : ICallable, IBrowsable
    {
        private List<string> phoneNumbers;
        private List<string> webSites;

        public Smartphone(List<string> phoneNumbers, List<string> webSites)
        {
            this.phoneNumbers = phoneNumbers;
            this.webSites = webSites;
        }

        public void Browse()
        {
            webSites
                .ForEach(webSite => Console.WriteLine(hasDigit(webSite) ? "Invalid URL!" : $"Browsing: {webSite}"));
        }

        public void CallNumbers()
        {
            phoneNumbers
                .ForEach(phoneNumber => Console.WriteLine(hasOnlyDigits(phoneNumber) ? $"Calling... {phoneNumber}" : "Invalid number!"));
        }

        // http://www.g00gle.com
        private bool hasDigit(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int charAsciCode = data[i];

                if (charAsciCode >= 48 && charAsciCode <= 57)
                {
                    return true;
                }
            }

            return false;
        }

        private bool hasOnlyDigits(string data)
        {
            for (int i = 0; i < data.Length; i++)
            {
                int charAsciCode = data[i];

                if (charAsciCode < 48 || charAsciCode > 57)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
