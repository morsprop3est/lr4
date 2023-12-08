using DAL.DAL.Repositories.Impl;
using DAL.DAL.Repositories.Interfaces;
using DAL.DAL.UnitOfWork;
using DAL.Repositories.Interfaces;
using lr4.Repositories.Impl;

namespace DAL.DAL.EF;

public class EFUnitOfWork : IUnitOfWork
{
    private SamplingContext db;
    private DataRepository dataRepository;
    private OperatorRepository operatorRepository;
    private ReportRepository reportRepository;
    private SamplingPlanRepository samplingPlanRepository;
    private SensorRepository sensorRepository;
    private StatisticsRepository statisticsRepository;
    private UnplannedSamplingRepository unplannedSamplingRepository;
    private WaterQualityStandartRepository waterQualityStandartRepository;
    private WaterwellRepository waterwellRepository;

    public EFUnitOfWork(SamplingContext context)
    {
        db = context;
    }

    

    public IDataRepository Datas
    {
        get
        {
            if (dataRepository == null)
                dataRepository = new DataRepository(db);
            return dataRepository;
        }
    }
    
    public IOperatorRepository Operators
    {
        get
        {
            if (operatorRepository == null)
                operatorRepository = new OperatorRepository(db);
            return operatorRepository;
        }
    }

    public IReportRepository Repositories { get; }

    public IReportRepository Reports
    {
        get
        {
            if (reportRepository == null)
                reportRepository = new ReportRepository(db);
            return reportRepository;
        }
    }

    public ISamplingPlanRepository SamplingPlans
    {
        get
        {
            if (samplingPlanRepository == null)
                samplingPlanRepository = new SamplingPlanRepository(db);
            return samplingPlanRepository;
        }
    }

    public IStatisticsRepository Statisticss
    {
        get
        {
            if (statisticsRepository == null)
                statisticsRepository = new StatisticsRepository(db);
            return statisticsRepository;
        }
    }

    public ISensorRepository Sensors
    {
        get
        {
            if (sensorRepository == null)
                sensorRepository = new SensorRepository(db);
            return sensorRepository;
        }
    }

    public IUnplannedSamplingRepository UnplannedSamplings
    {
        get
        {
            if (unplannedSamplingRepository == null)
                unplannedSamplingRepository = new UnplannedSamplingRepository(db);
            return unplannedSamplingRepository;
        }
    }

    public IWaterQualityStandartRepository WaterQualityStandarts
    {
        get
        {
            if (waterQualityStandartRepository == null)
                waterQualityStandartRepository = new WaterQualityStandartRepository(db);
            return waterQualityStandartRepository;
        }
    }

    public IWaterwellRepository Waterwells
    {
        get
        {
            if (waterwellRepository == null)
                waterwellRepository = new WaterwellRepository(db);
            return waterwellRepository;
        }
    }


    public IDataRepository Data { get; }
    public IOperatorRepository Operator { get; }
    public IReportRepository Repository { get; }
    public ISamplingPlanRepository SamplingPlan { get; }
    public ISensorRepository Sensor { get; }
    public IStatisticsRepository Statistics { get; }
    public IUnplannedSamplingRepository UnplannedSampling { get; }
    public IWaterwellRepository Waterwell { get; }
    public IWaterQualityStandartRepository WaterQualityStandart { get; }

    public void Save()
    {
        db.SaveChanges();
    }
    private bool disposed = false;

    public virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                db.Dispose();
            }
            this.disposed = true;
        }
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
}
