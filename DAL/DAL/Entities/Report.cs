using lr4;

namespace DAL.DAL.Entities;

public class Report : Statistics
{
    public int ReportId { get; set; }
    public List<Data> ReportData { get; set; }
}