namespace lab4;

public class WaterQualityStandard
{
    public string WQSName { get; set; }
    public float Limit { get; set; }
    public EnumDataUnit WQSType { get; set; }

    public WaterQualityStandard(string wqsName, float limit, EnumDataUnit wqsType)
    {
        WQSName = wqsName;
        Limit = limit;
        WQSType = wqsType;
    }
}