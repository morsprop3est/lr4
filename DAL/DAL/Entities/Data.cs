using lr4;

namespace DAL.DAL.Entities;

public class Data
{
    public int DataId { get; set; }
    public DateTime DataTime { get; set; }
    public float Value { get; set; }
    public EnumDataUnit DataUnit { get; set; }
}