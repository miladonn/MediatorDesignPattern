namespace MediatorDesignPattern.StateMachine;

public sealed class GameManager
{
    private IPlayerState currentState;
    private IPlayerState previousState;

    private readonly int startTime;
    private int remainingTime;

    public GameManager(int startTime)
    {
        this.startTime = startTime;
        remainingTime = startTime;

        SetState(new PlayingState());
    }

    public void SetState(IPlayerState newState)
    {
        currentState = newState;
        currentState.Enter(this);
    }

    public void PauseGame()
    {
        if (currentState is PauseState)
        {
            Console.WriteLine("Game is already paused.");
            return;
        }

        previousState = currentState;
        SetState(new PauseState());
    }

    public void ResumeGame()
    {
        if (currentState is not PauseState)
        {
            Console.WriteLine("Game is not paused.");
            return;
        }

        SetState(previousState);
    }

    public void FinishLevel()
    {
        if (currentState is not PlayingState)
        {
            Console.WriteLine("Cannot win right now.");
            return;
        }

        SetState(new WinState());
    }

    public void HitEnemy()
    {
        if (currentState is not PlayingState)
        {
            Console.WriteLine("Cannot die right now.");
            return;
        }

        SetState(new DeadState());
    }

    public void TickTime()
    {
        if (currentState is not PlayingState)
        {
            Console.WriteLine("Time does not move while not playing.");
            return;
        }

        remainingTime--;

        Console.WriteLine($"Time Remaining: {remainingTime}");

        if (remainingTime <= 0)
        {
            Console.WriteLine("Time ran out!");
            SetState(new DeadState());
        }
    }

    public void RestartGame()
    {
        remainingTime = startTime;

        Console.WriteLine("Restarting level...");
        SetState(new PlayingState());
    }
}
