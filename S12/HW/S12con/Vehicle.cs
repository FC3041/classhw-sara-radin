
public interface Ivehicle
{
    public int Capacity();
    public int  wheel();
    public string Transport_domain();

}

class Motorcycle:Ivehicle
{
    public string Type ;

    public Motorcycle(string type)
    {
        this.Type = type;
    }
    
    public int Capacity()
    {
        if (Type == "ural_motorcycle")
            return 3;
        return 2;
    }

    public int  wheel()
    {
        if (Type == "ural_motorcycle")
            return 3;
        return 2;
    }

    public string Transport_domain()
    {
        return "Land";
    }
}



class Train:Ivehicle
{

    public string Type ;

    public Train(string type)
    {
        this.Type = type;
    }
    public int Capacity()
    {
        if (Type == "Metro")
            return 1200;
        if (Type == "High-Speed Trains")
            return 800;
        if (Type == "Freight Trains")
            return 3;
        return 800;
            
        
    }

    public int  wheel()
    {
        if (Type == "Metro")
            return 48;
        if (Type == "High-Speed Trains")
            return 150;
        if (Type == "Freight Trains")
            return 400;
        return 800;
    }

    public string Transport_domain()
    {
        return "rail";
    }
}


class Airplane:Ivehicle
{
    public string Type ;

    public Airplane(string type)
    {
        this.Type = type;
    }
    public int Capacity()
    {
        if (Type == "Boeing 737")
            return 180;
        if (Type == "Airbus A320")
            return 160;
        if (Type == "Boeing 747")
            return 350;
        return 200;
    }

    public int  wheel()
    {
        if (Type == "Boeing 737")
            return 6;
        if (Type == "Airbus A320")
            return 6;
        if (Type == "Boeing 747")
            return 18;
        return 6;
    }

    public string Transport_domain()
    {
        return "Air";
    }
}


class Ship:Ivehicle
{
    public string Type ;

    public Ship(string type)
    {
        this.Type = type;
    }
    public int Capacity()
    {
        if (Type == "Cruise Ship")
            return 4500;
        if (Type == "Cargo Ship")
            return 24000;
        if (Type == "Naval Aircraft Carriers")
            return 5000;
        return 5000;
    }

    public int  wheel()
    {
        return 0;
    }

    public string Transport_domain()
    {
        return "Water";
    }
}