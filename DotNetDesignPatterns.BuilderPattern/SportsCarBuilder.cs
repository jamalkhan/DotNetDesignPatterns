namespace DotNetDesignPatterns.BuilderPattern
{
    public class SportsCarBuilder : AutomobileBuilder
    {
        private Automobile _automobile = new Automobile();
        public override void AddChassis()
        {
            _automobile.Add("Cool Curves");
        }

        public override void AddEngine()
        {
            _automobile.Add("Fast Engine");
        }

        public override Automobile GetResult()
        {
            return _automobile;
        }
    }
}