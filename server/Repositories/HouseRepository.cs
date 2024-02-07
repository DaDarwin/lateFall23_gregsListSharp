namespace gregsListSharp.Repositories;


public class HouseRepository(IDbConnection db)
{
    private readonly IDbConnection db = db;

    internal List<House> GetHouses()
    {
        string sql = @"
        SELECT
        *
        FROM houses";
        List<House> houses = db.Query<House>(sql).ToList();
        return houses;
    }

    internal House CreateHouse(House houseData)
    {
        string sql = @"
        INSERT INTO houses
        (address, bedrooms, bathrooms, description, year, price)
        VALUES
        (@address, @bedrooms, @bathrooms, @description, @year, @price);
        
        SELECT
        *
        FROM houses
        where id = LAST_INSERT_ID();
        ";
        House house = db.Query<House>(sql, houseData).FirstOrDefault();
        return house;
    }

}