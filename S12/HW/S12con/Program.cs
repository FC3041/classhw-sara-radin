Ivehicle[] Vehicles = new Ivehicle[]
{
            new Motorcycle("ural_motorcycle"),
            new Airplane("Boeing 737"),
            new Ship("Naval Aircraft Carriers"),
            new Train("High-Speed Trains"),
};

int _Capacity = 0;
int _wheel = 0;
string _Transport_domain;

for (int i = 0; i < Vehicles.Length; i++)
{
    _Capacity = Vehicles[i].Capacity();
    _wheel = Vehicles[i].wheel();
    _Transport_domain = Vehicles[i].Transport_domain();
    System.Console.WriteLine($"{Vehicles[i]} \t people capacity : {_Capacity} \t transport domain : {_Transport_domain} \t wheel : {_wheel} \n");
}
