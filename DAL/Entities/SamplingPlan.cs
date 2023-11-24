namespace lab4;

public class SamplingPlan
{
    public int PlanId { get; set; }
    public int WaterWellId { get; set; }
    public DateTime StartTime { get; set; }
    public TimeSpan Duration { get; set; }
    public int NumberOfSamples { get; set; }
    public float WaterAmount { get; set; }
    public EnumPlanStatus PlanStatus { get; set; }

    public SamplingPlan(int planId, int waterWellId, DateTime startTime, TimeSpan duration, int numberOfSamples, float waterAmount, EnumPlanStatus planStatus)
    {
        PlanId = planId;
        WaterWellId = waterWellId;
        StartTime = startTime;
        Duration = duration;
        NumberOfSamples = numberOfSamples;
        WaterAmount = waterAmount;
        PlanStatus = planStatus;
    }
}


public enum EnumPlanStatus
{
    Active,
    InProgress,
    Done,
    NotDone
}