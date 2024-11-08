using System.Collections.Generic;
using System.Linq;
public class Controller
{
    private List<Plant> plants;

    public Controller()
    {
        plants = new List<Plant>();
    }

    public string AddCareItem(List<string> args)
    {
        int plantId = int.Parse(args[0]);

        Plant plant = GetPlantById(plantId);

        if (plant == null)
        {
            return "Plant not found!";
        }

        string name = args[1];
        bool status = bool.Parse(args[2]);

        CareItem careItem = new CareItem(name, status);

        plant.AddCareItem(careItem);

        return $"Created Care {name} for {plantId}!";
    }

    public string AddPlant(List<string> args)
    {
        int id = int.Parse(args[0]);
        string name = args[1];
        double humidityLevel = double.Parse(args[2]);
        double fertilityLevel = double.Parse(args[3]);
        string type = args[4];

        Plant plant = plants.FirstOrDefault(p => p.Id == id);

        if (plant != null)
        {
            return $"Plant with ID {id} already exists!";
        }

        if (type == "tree")
        {
            int height = int.Parse(args[5]);
            plant = new TreePlant(id, name, humidityLevel, fertilityLevel, height);
        }
        else if (type == "flower")
        {
            string color = args[5];
            plant = new FloweringPlant(id, name, humidityLevel, fertilityLevel, color);
        }

        plants.Add(plant);

        return $"Created Plant {name} with ID {id}!";
    }

    public string GetTotalCaresByPlantId(List<string> args)
    {
        int plantId = int.Parse(args[0]);

        Plant plant = GetPlantById(plantId);

        if (plant == null)
        {
            return "Plant not found!";
        }

        int doneCareItems = plant.CareItems.Where(ci => ci.Status).Count();

        return $"Total cares for plant {plantId}: {doneCareItems}";
    }

    public string WaterPlantById(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        Plant plant = GetPlantById(plantId);

        if (plant == null)
        {
            return "Plant not found!";
        }


        bool result = plant.Water(percent);

        return result
            ? $"Plant {plantId} was watered successfully!"
            : $"Plant {plantId} could not be watered!";
    }

    public string FertilizePlantById(List<string> args)
    {
        int plantId = int.Parse(args[0]);
        double percent = double.Parse(args[1]);

        Plant plant = GetPlantById(plantId);

        if (plant == null)
        {
            return "Plant not found!";
        }

        bool isFertilized = plant.Fertilize(percent);

        return isFertilized
            ? $"Plant {plantId} was fertilized successfully!"
            : $"Plant {plantId} could not be fertilized!";
    }

    public string GetTallestTree(List<string> args)
    {
        Plant plant = plants.Where(p => p.Type == "tree")
            .OrderByDescending(tp => ((TreePlant)tp).Height)
            .FirstOrDefault();

        return plant != null
            ? plant.ToString()
            : "No trees found!";
    }

    private Plant GetPlantById(int id)
    {
        return plants.FirstOrDefault(p => p.Id == id);
    }
}
