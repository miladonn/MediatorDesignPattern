namespace MediatorDesignPattern.StateMachine;

public sealed class PauseState : IPlayerState
{
    public void Enter(GameManager gameManager)
    {
        Console.WriteLine("Game is paused.");
    }
}