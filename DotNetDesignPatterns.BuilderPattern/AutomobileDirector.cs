namespace DotNetDesignPatterns.BuilderPattern
{
    public class AutomobileDirector
    {
        AutomobileBuilder _builder;
        public AutomobileDirector(AutomobileBuilder builder)
        {
            _builder = builder;
        }

        // Builder uses a complex series of steps
        public void Construct()
        {
            _builder.AddChassis();
            _builder.AddEngine();
        }
    }
}