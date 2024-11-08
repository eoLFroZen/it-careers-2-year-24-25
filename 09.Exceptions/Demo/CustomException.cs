namespace Demo;

public class CustomException : Exception
{
    public CustomException(string message): base(message)
    {

    }

        public CustomException(string message, Exception exception): base(message, exception)
    {

    }
}
