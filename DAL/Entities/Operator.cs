namespace lr4;

public class Operator
{
    public int Number { get; set; }
    public string Name { get; set; }
    
    public Operator(int number, string name)
    {
        Number = number;
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
