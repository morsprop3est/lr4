namespace lr4;

public class Sensor
{
    public int SensorId { get; set; }
    public EnumDataUnit DataUnit { get; set; }

    public Sensor(int sensorId, EnumDataUnit dataUnit)
    {
        SensorId = sensorId;
        DataUnit = dataUnit;
    }
}