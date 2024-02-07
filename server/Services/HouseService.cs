namespace gregsListSharp.Services;


public class HouseService(HouseRepository repo)
{
    private readonly HouseRepository repo = repo;

    internal List<House> GetHouses()
    {
        List<House> houses = repo.GetHouses();
        return houses;
    }

    internal House CreateHouse(House houseData)
    {
        House house = repo.CreateHouse(houseData);
        return house;
    }
};