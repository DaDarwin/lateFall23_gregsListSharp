namespace gregsListSharp.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HouseController : ControllerBase
{
    private readonly HouseService houseService;

    public HouseController(HouseService houseService)
    {
        this.houseService = houseService;
    }

    [HttpGet]
    public ActionResult<List<House>> GetHouses()
    {
        try
        {
            List<House> houses = houseService.GetHouses();
            return Ok(houses);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }

    [HttpPost]
    public ActionResult<House> CreateHouse([FromBody] House houseData)
    {
        try
        {
            House house = houseService.CreateHouse(houseData);
            return Ok(house);
        }
        catch (Exception error)
        {
            return BadRequest(error.Message);
        }
    }
}