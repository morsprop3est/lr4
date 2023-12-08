using DAL.DAL.Repositories.Interfaces;
using DAL.Repositories.Interfaces;

namespace DAL.DAL.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IDataRepository Datas { get; }
    IOperatorRepository Operators { get; }
    IReportRepository Repositories { get; }
    ISamplingPlanRepository SamplingPlans { get; }
    ISensorRepository Sensors { get; }
    IStatisticsRepository Statisticss { get; }
    IReportRepository Reports { get; }
    IUnplannedSamplingRepository UnplannedSamplings { get; }
    IWaterwellRepository Waterwells { get; }
    IWaterQualityStandartRepository WaterQualityStandarts { get; }
        
    void Save();
}