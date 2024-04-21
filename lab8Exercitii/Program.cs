using lab8Exercitii;


Train train = new Train("Locomotive Express");
Console.WriteLine($"A new train named '{train.Name}' has been created.");

train.DepartFromStation();
train.AddWagon(new FreightWagon(10000, 2018, "Coal", 50), 10000, 2018); 
train.AddWagon(new FreightWagon(12000, 2019, "Grain", 60), 12000, 2019); 
train.AddWagon(new FreightWagon(12000, 2019, "Steel", 800), 12000, 2019);

train.AddWagon(new PassengerWagon(5000, 2010, 50), 5000, 2010); 
train.AddWagon(new PassengerWagon(6000, 2012, 40), 6000, 2012); 

FirstClassPassengerWagon wagon = new FirstClassPassengerWagon(7000, 2015, 20);
wagon.StartAirConditioning(); 

int totalSeats = train.NumberofSeats();

Console.WriteLine($"Total seats in passenger wagons: {totalSeats}");

Dictionary<string, (int, int, int)> cargoSummary = train.SummarizeCargo();
Console.WriteLine("Cargo summary:");
foreach (var cargoType in cargoSummary)
{
    Console.WriteLine($"- {cargoType.Key}: {cargoType.Value.Item1} tons, Weight: {cargoType.Value.Item2}, Year: {cargoType.Value.Item3}");
}
wagon.StopAirConditioning();
train.StopAtStation();
