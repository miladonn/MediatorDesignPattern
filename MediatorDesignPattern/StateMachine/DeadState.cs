namespace MediatorDesignPattern.StateMachine;

public sealed class DeadState : IPlayerState
{
    public void Enter(GameManager gameManager)
    {
        Console.WriteLine("Player died! Game over.");
    }
}