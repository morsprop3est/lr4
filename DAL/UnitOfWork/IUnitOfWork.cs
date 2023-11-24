using DAL.Repositories.Interfaces;

namespace lr4.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IDataRepository Data { get; }
    IOperatorRepository Operator { get; }
    IReportRepository Repository { get; }
    ISamplingPlanRepository SamplingPlan { get; }
    ISensorRepository Sensor { get; }
    IStatisticsRepository Statistics { get; }
    IUnplannedSamplingRepository UnplannedSampling { get; }
    IWaterwellRepository Waterwell { get; }
    IWaterQualityStandartRepository WaterQualityStandart { get; }
        
    void Save();
}