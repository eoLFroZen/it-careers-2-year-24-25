using Easter_Races;

DriverRepository driverRepository = new DriverRepository();
CarRepository carRepository = new CarRepository();
RaceRepository raceRepository = new RaceRepository();

ChampionshipController championshipController = new ChampionshipController(driverRepository, carRepository, raceRepository);

Engine engine = new Engine(championshipController);

engine.Run();