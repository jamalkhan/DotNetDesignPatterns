


public class SportsCarCreator:CarCreator
{
    public override Car FactoryMethod()
    {
        return new Tesla();
    }
}
