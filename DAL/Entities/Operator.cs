namespace lr4;

public class Operator
{
    public int operator_id { get; set; }
    public string Name { get; set; }
    
    public Operator(int number, string name)
    {
        operator_id = number;
        Name = name;
    }

    public void ViewStatistics()
    {
        // Логіка для перегляду статистики
    }

    public void PlanSampling()
    {
        // Логіка планування вибірок
    }

    public void UnplannedSampling()
    {
        // Логіка неспланованих вибірок
    }
}   
