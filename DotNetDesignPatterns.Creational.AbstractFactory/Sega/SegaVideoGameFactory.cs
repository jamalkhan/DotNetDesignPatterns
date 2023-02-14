public class SegaVideoGameFactory : AbstractVideoGameFactory
{
    public override AbstractSideScrollerGame CreateSideScrollerGame()
    {
        return new SonicAndKnucklesGame();
    }

    public override AbstractShooterGame CreateShooterGame()
    {
        return new AfterBurnerGame();
    }
}
