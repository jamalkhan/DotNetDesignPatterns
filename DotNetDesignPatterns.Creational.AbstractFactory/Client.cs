class Client
{
    private AbstractSideScrollerGame _sideScrollerGame;
    private AbstractShooterGame _shooterGame;

    public Client(AbstractVideoGameFactory factory)
    {
        _sideScrollerGame = factory.CreateSideScrollerGame();
        _shooterGame = factory.CreateShooterGame();
    }

    public void Run()
    {
        Console.WriteLine($"If you love side scrollers, you need to try {_sideScrollerGame.Name} for the {_sideScrollerGame.GameConsole}");
        Console.WriteLine($"If you love shooters, you need to try {_shooterGame.Name} where you pilot the {_shooterGame.Plane}!");
    }
}