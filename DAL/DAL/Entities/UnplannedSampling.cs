namespace DAL.DAL.Entities;

public class UnplannedSampling : SamplingPlan
{
    public UnplannedSampling(int planId, int waterWellId, DateTime startTime, TimeSpan duration, int numberOfSamples, float waterAmount, EnumPlanStatus planStatus)
        : base()
    {
    }
}