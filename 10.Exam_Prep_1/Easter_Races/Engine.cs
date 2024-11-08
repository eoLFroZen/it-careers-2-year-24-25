using System.Text;
using System.Threading.Channels;

namespace Easter_Races;

public class Engine
{
    private bool isRunning;
    private StringBuilder stringBuilder;
    private ChampionshipController championshipController;

    public Engine(ChampionshipController championshipController)
    {
        isRunning = true;
        stringBuilder = new StringBuilder();
        this.championshipController = championshipController;
    }

    public void Run()
    {
        while(isRunning)
        {
            List<string> arguments = Console.ReadLine()
                .Split()
                .ToList();

            string command = arguments[0];
            string commandMessage = "";

            try
            {
                if(command == "CreateDriver")
                {
                    string name = arguments[1];
                    
                    commandMessage = championshipController.AddDriver(name);
                }
                else if(command == "CreateCar")
                {
                    string type = arguments[1];
                    string model = arguments[2];
                    int hp = int.Parse(arguments[3]);

                    commandMessage = championshipController.CreateCar(type, model, hp);
                }
                else if(command == "AddCarToDriver")
                {
                    string driverName = arguments[1];
                    string carName = arguments[2];

                    commandMessage = championshipController.AddCarToDriver(driverName, carName);
                }
                else if(command == "AddDriverToRace")
                {
                    string raceName = arguments[1];
                    string driverName = arguments[2];

                    commandMessage = championshipController.AddDriverToRace(raceName, driverName);
                }
                else if(command == "CreateRace")
                {
                    string raceName = arguments[1];
                    int laps = int.Parse(arguments[2]);

                    commandMessage = championshipController.CreateRace(raceName, laps);
                }
                else if(command == "StartRace")
                {
                    string raceName = arguments[1];

                    commandMessage = championshipController.StartRace(raceName);
                }
                else 
                {
                    isRunning = false;
                }

            } 
            catch(SystemException ex)
            {
                commandMessage = ex.Message;
            }

            stringBuilder.AppendLine(commandMessage);
        }

        System.Console.WriteLine(stringBuilder.ToString().TrimEnd());
    }
}
