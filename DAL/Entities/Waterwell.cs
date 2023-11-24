namespace lab4;

public class WaterWell
{
    public int WaterWellId { get; set; }
    public EnumWaterwellStatus WaterWellStatus { get; set; }
    public string Location { get; set; }
    public float Depth { get; set; }
    public List<Sensor> Sensors { get; set; }

    public WaterWell(int waterWellId, EnumWaterwellStatus waterWellStatus, string location, float depth, List<Sensor> sensors)
    {
        WaterWellId = waterWellId;
        WaterWellStatus = waterWellStatus;
        Location = location;
        Depth = depth;
        Sensors = sensors;
    }
}

public enum EnumWaterwellStatus
{
    Active,
    InUse,
    Inactive
}