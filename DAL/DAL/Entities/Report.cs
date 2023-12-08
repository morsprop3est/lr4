namespace lr4;

public class Report : Statistics
{
    public int ReportId { get; set; }

    public Report(int reportId, int statisticsId, List<Data> statisticsData)
        : base(statisticsId, statisticsData)
    {
        ReportId = reportId;
    }

    public void SaveReport()
    {
        // Логіка для збереження звіту
    }

    public void ExportReport()
    {
        // Логіка для експорту звіту
    }

    public void GetDeviation()
    {
        // Логіка для отримання відхилень
    }
}