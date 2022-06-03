namespace ChainResponsibility
{
    internal class InfoLogger : Logger
    {
        public InfoLogger(int level)
        {
            _level = level;
        }
        public override void Write(string message)
        {
            Console.WriteLine("INFO:: "+message);
        }
    }
}
