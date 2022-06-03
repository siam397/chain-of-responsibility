namespace ChainResponsibility
{
    public class ErrorLogger : Logger
    {
        public ErrorLogger(int level)
        {
            _level = level;
        }
        public override void Write(string message)
        {
            Console.WriteLine("ERROR:: "+message);
        }
    }
}
