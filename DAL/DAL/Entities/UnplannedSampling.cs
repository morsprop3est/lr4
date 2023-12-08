namespace lr4;

public class UnplannedSampling : SamplingPlan
{
    public UnplannedSampling(int planId, int waterWellId, DateTime startTime, TimeSpan duration, int numberOfSamples, float waterAmount, EnumPlanStatus planStatus)
        : base(planId, waterWellId, startTime, duration, numberOfSamples, waterAmount, planStatus)
    {
    }

    public void DoUnplannedSampling()
    {
        // Логіка для неспланованих вибірок
    }
}