namespace MediatorDesignPattern.StateMachine;

public sealed class WinState : IPlayerState
{
    public void Enter(GameManager gameManager)
    {
        Console.WriteLine("Level completed! Player wins!");
    }
}