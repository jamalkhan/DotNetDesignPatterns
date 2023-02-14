public class NintendoVideoGameFactory : AbstractVideoGameFactory
{
    public override AbstractSideScrollerGame CreateSideScrollerGame()
    {
        return new SuperMarioWorldGame();
    }

    public override AbstractShooterGame CreateShooterGame()
    {
        return new StarFoxGame();
    }
}
