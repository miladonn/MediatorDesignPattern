using MediatorDesignPattern.StateMachine;

namespace MediatorDesignPattern;

class Program
{
    static void Main(string[] args)
    {
        var gameManager = new GameManager(10);

        while (true)
        {
            Console.WriteLine();
            Console.WriteLine("===== Mario Game =====");
            Console.WriteLine("1 - Pass Time");
            Console.WriteLine("2 - Hit Enemy");
            Console.WriteLine("3 - Finish Level");
            Console.WriteLine("4 - Pause Game");
            Console.WriteLine("5 - Resume Game");
            Console.WriteLine("6 - Restart Game");
            Console.WriteLine("7 - Exit");

            Console.Write("Choose option: ");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    gameManager.TickTime();
                    break;

                case "2":
                    gameManager.HitEnemy();
                    break;

                case "3":
                    gameManager.FinishLevel();
                    break;

                case "4":
                    gameManager.PauseGame();
                    break;

                case "5":
                    gameManager.ResumeGame();
                    break;

                case "6":
                    gameManager.RestartGame();
                    break;

                case "7":
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}








// Mediator Main
/* AirportControlTower tower = new AirportControlTower();

Plane plane1 = new Plane("Plane A", tower);
Helicopter heli1 = new Helicopter("Helicopter H1", tower);
Plane plane2 = new Plane("Plane B", tower);
Helicopter heli2 = new Helicopter("Helicopter H2", tower);

plane1.Send("Requesting landing");
heli1.Send("Requesting takeoff");
plane2.Send("Requesting takeoff");
heli1.Send("Requesting landing");
heli2.Send("Requesting takeoff");

Console.ReadLine(); */
