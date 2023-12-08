namespace DAL.DAL.Entities;

public class Waterwell
{
    public int WaterWellId { get; set; }
    public EnumWaterwellStatus WaterWellStatus { get; set; }
    public string Location { get; set; }
    public float Depth { get; set; }
    public List<Sensor> Sensors { get; set; }
    
}

public enum EnumWaterwellStatus
{
    Active,
    InUse,
    Inactive
}