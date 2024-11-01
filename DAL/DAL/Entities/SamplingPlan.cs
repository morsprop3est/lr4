﻿namespace DAL.DAL.Entities;

public class SamplingPlan
{
    public int PlanId { get; set; }
    public int WaterWellId { get; set; }
    public DateTime StartTime { get; set; }
    public TimeSpan Duration { get; set; }
    public int NumberOfSamples { get; set; }
    public float WaterAmount { get; set; }
    public EnumPlanStatus PlanStatus { get; set; }
}


public enum EnumPlanStatus
{
    Active,
    InProgress,
    Done,
    NotDone
} 