using System;
using Xunit;
using lr4.Repositories.Impl;
using Microsoft.EntityFrameworkCore;
using DAL.Repositories.Interfaces;
using System.Linq;
using DAL.DAL.EF;
using DAL.DAL.Entities;
using DAL.DAL.Repositories.Impl;
using lr4;
using lr4.Repositories.Impl;
using Moq;

namespace DAL.Tests
{
    class TestOperatorRepository
        : BaseRepository<Operator>
    {
        public TestOperatorRepository(DbContext context) 
            : base(context)
        {
        }
    }

    public class BaseRepositoryUnitTests
    {
        [Fact]
        public void Create_InputOperatorInstance_CalledAddMethodOfDBSetWithStreetInstance()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SamplingContext>()
                .Options;
            var mockContext = new Mock<SamplingContext>(opt);
            var mockDbSet = new Mock<DbSet<Operator>>();
            mockContext
                .Setup(context => 
                    context.Set<Operator>(  
                        ))
                .Returns(mockDbSet.Object);
            var repository = new TestOperatorRepository(mockContext.Object);

            Operator expectedOperator = new Mock<Operator>().Object;

            //Act
            repository.Create(expectedOperator);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Add(
                    expectedOperator
                    ), Times.Once());
        }

        [Fact]
        public void Delete_InputId_CalledFindAndRemoveMethodsOfDBSetWithCorrectArg()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SamplingContext>()
                .Options;
            var mockContext = new Mock<SamplingContext>(opt);
            var mockDbSet = new Mock<DbSet<Operator>>();
            mockContext
                .Setup(context =>
                    context.Set<Operator>(
                        ))
                .Returns(mockDbSet.Object);
            var repository = new TestOperatorRepository(mockContext.Object);

            Operator expectedOperator = new Operator() { operatorID = 1};
            mockDbSet.Setup(mock => mock.Find(expectedOperator.operatorID)).Returns(expectedOperator);

            //Act
            repository.Delete(expectedOperator.operatorID);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedOperator.operatorID
                    ), Times.Once());
            mockDbSet.Verify(
                dbSet => dbSet.Remove(
                    expectedOperator
                    ), Times.Once());
        }

        [Fact]
        public void Get_InputId_CalledFindMethodOfDBSetWithCorrectId()
        {
            // Arrange
            DbContextOptions opt = new DbContextOptionsBuilder<SamplingContext>()
                .Options;
            var mockContext = new Mock<SamplingContext>(opt);
            var mockDbSet = new Mock<DbSet<Operator>>();
            mockContext
                .Setup(context =>
                    context.Set<Operator>(
                        ))
                .Returns(mockDbSet.Object);

            Operator expectedOperator = new Operator() { operatorID = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedOperator.operatorID))
                    .Returns(expectedOperator);
            var repository = new TestOperatorRepository(mockContext.Object);

            //Act
            var actualOperator = repository.Get(expectedOperator.operatorID);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedOperator.operatorID
                    ), Times.Once());
            Assert.Equal(expectedOperator, actualOperator);
        }
    }
}