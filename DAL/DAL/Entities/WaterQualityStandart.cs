using System.ComponentModel.DataAnnotations;

namespace DAL.DAL.Entities;

public class WaterQualityStandard
{
    [Key]
    public string WQSName { get; set; }
    public float Limit { get; set; }
    public EnumDataUnit WQSType { get; set; }


}