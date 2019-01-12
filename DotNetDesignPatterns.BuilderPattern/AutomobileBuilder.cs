namespace DotNetDesignPatterns.BuilderPattern
{
    public abstract class AutomobileBuilder
    {
        public abstract void AddChassis();
        public abstract void AddEngine();
        public abstract Automobile GetResult();
    }
}