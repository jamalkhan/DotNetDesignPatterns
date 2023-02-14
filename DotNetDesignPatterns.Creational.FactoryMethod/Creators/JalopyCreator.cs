public class JalopyCreator : CarCreator
{
    public override Car FactoryMethod()
    {
        // Can Jalopies be new???
        return new GeoMetro();
    }
}