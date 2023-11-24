namespace lab4;

public class Statistics
{
    public int StatisticsId { get; set; }
    public List<Data> StatisticsData { get; set; }

    public Statistics(int statisticsId, List<Data> statisticsData)
    {
        StatisticsId = statisticsId;
        StatisticsData = statisticsData;
    }

    public void SaveStatistics()
    {
        // Логіка для збереження статистики
    }

    public void ExportStatistics()
    {
        // Логіка для експорту статистики
    }
}