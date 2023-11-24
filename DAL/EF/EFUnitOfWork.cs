using DAL.Repositories.Interfaces;
using lr4.Repositories.Impl;
using lr4.UnitOfWork;
using Microsoft.EntityFrameworkCore;

namespace DAL.EF;

public class EFUnitOfWork : IUnitOfWork
{
    private SamplingContext db;
    private DataRepository DataRepository;
    private OperatorRepository OperatorRepository;
    private ReportRepository ReportRepository;
    private SamplingPlanRepository SamplingPlanRepository;
    private SensorRepository SensorRepository;
    private StatisticsRepository StatisticsRepository;
    private UnplannedSamplingRepository UnplannedSamplingRepository;
    private WaterQualityStandartRepository WaterQualityStandartRepository;
    private WaterwellRepository WaterwellRepository;

    public EFUnitOfWork(DbContextOptions options)
    {
        db = new SamplingContext(options);
    }

    

    public IDataRepository Datas
    {
        get
        {
            if (DataRepository == null)
                DataRepository = new DataRepository(db);
            return DataRepository;
        }
    }
    
    public IOperatorRepository Operators
    {
        get
        {
            if (OperatorRepository == null)
                OperatorRepository = new OperatorRepository(db);
            return OperatorRepository;
        }
    }

    public IReportRepository Reports
    {
        get
        {
            if (ReportRepository == null)
                ReportRepository = new ReportRepository(db);
            return ReportRepository;
        }
    }

    public ISamplingPlanRepository SamplingPlans
    {
        get
        {
            if (SamplingPlanRepository == null)
                SamplingPlanRepository = new SamplingPlanRepository(db);
            return SamplingPlanRepository;
        }
    }

    public IStatisticsRepository Statisticss
    {
        get
        {
            if (StatisticsRepository == null)
                StatisticsRepository = new StatisticsRepository(db);
            return StatisticsRepository;
        }
    }

    public ISensorRepository Sensors
    {
        get
        {
            if (SensorRepository == null)
                SensorRepository = new SensorRepository(db);
            return SensorRepository;
        }
    }

    public IUnplannedSamplingRepository UnplannedSamplings
    {
        get
        {
            if (UnplannedSamplingRepository == null)
                UnplannedSamplingRepository = new UnplannedSamplingRepository(db);
            return UnplannedSamplingRepository;
        }
    }

    public IWaterQualityStandartRepository WaterQualityStandarts
    {
        get
        {
            if (WaterQualityStandartRepository == null)
                WaterQualityStandartRepository = new WaterQualityStandartRepository(db);
            return WaterQualityStandartRepository;
        }
    }

    public WaterwellRepository Waterwells
    {
        get
        {
            if (WaterwellRepository == null)
                WaterwellRepository = new WaterwellRepository(db);
            return WaterwellRepository;
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
    private IUnitOfWork _unitOfWorkImplementation;

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
