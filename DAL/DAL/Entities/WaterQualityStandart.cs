namespace lr4;
using System.ComponentModel.DataAnnotations;
public class WaterQualityStandard
{
    [Key]
    public string WQSName { get; set; }
    public float Limit { get; set; }
    public EnumDataUnit WQSType { get; set; }


}