namespace DotNetDesignPatterns.BuilderPattern
{
    public class TruckBuilder : AutomobileBuilder
    {
        private Automobile _product = new Automobile();
        public override void AddChassis()
        {
            _product.Add("Big Lift Kit");
        }

        public override void AddEngine()
        {
            _product.Add("Big Loud Engine");
        }

        public override Automobile GetResult()
        {
            return _product;
        }
    }
}