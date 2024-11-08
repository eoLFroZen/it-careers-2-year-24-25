using System.Text;

public class Engine
{
    private bool isRunning;
    private Controller controller;

    public Engine(Controller controller)
    {
        this.controller = controller;
        isRunning = true;
    }

    public void Run()
    {
        StringBuilder stringBuilder = new StringBuilder();

        while (isRunning)
        {
            List<string> arguments = Console.ReadLine()
                .Split()
                .ToList();

            string command = arguments[0];

            List<string> commandArgs = arguments
                .Skip(1)
                .ToList();

            string msg = "";
            try
            {
                switch (command)
                {
                    case "AddCareItem":
                        msg = controller.AddCareItem(commandArgs);
                        break;
                    case "AddPlant":
                        msg = controller.AddPlant(commandArgs);
                        break;
                    case "GetTotalCaresByPlantId":
                        msg = controller.GetTotalCaresByPlantId(commandArgs);
                        break;
                    case "WaterPlantById":
                        msg = controller.WaterPlantById(commandArgs);
                        break;
                    case "FertilizePlantById":
                        msg = controller.FertilizePlantById(commandArgs);
                        break;
                    case "GetTallestTree":
                        msg = controller.GetTallestTree(commandArgs);
                        break;
                    case "End":
                        isRunning = false;
                        break;
                }
            }
            catch (SystemException ex)
            {
                msg = ex.Message;
            }

            stringBuilder.AppendLine(msg);
        }

        Console.WriteLine(stringBuilder.ToString());
    }
}
