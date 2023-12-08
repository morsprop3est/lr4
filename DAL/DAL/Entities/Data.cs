namespace lr4;

public class Data
{
    public int DataId { get; set; }
    public DateTime DataTime { get; set; }
    public float Value { get; set; }
    public EnumDataUnit DataUnit { get; set; }

    public Data(int dataId, DateTime dataTime, float value, EnumDataUnit dataUnit)
    {
        DataId = dataId;
        DataTime = dataTime;
        Value = value;
        DataUnit = dataUnit;
    }
}