namespace MediatorDesignPattern.StateMachine;

public sealed class PlayingState : IPlayerState
{
    public void Enter(GameManager gameManager)
    {
        Console.WriteLine("Player is currently playing the level.");
    }
}