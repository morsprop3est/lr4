using System;
using Xunit;
using lr4.Repositories.Impl;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using DAL.Repositories.Interfaces;
using System.Linq;
using DAL.EF;
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
        public void Create_InputStreetInstance_CalledAddMethodOfDBSetWithStreetInstance()
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

            Operator expectedOperator = new Operator(1, "Test") { operator_id = 1};
            mockDbSet.Setup(mock => mock.Find(expectedOperator.operator_id)).Returns(expectedOperator);

            //Act
            repository.Delete(expectedOperator.operator_id);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedOperator.operator_id
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

            Operator expectedOperator = new Operator(1, "Test") { operator_id = 1 };
            mockDbSet.Setup(mock => mock.Find(expectedOperator.operator_id))
                    .Returns(expectedOperator);
            var repository = new TestOperatorRepository(mockContext.Object);

            //Act
            var actualOperator = repository.Get(expectedOperator.operator_id);

            // Assert
            mockDbSet.Verify(
                dbSet => dbSet.Find(
                    expectedOperator.operator_id
                    ), Times.Once());
            Assert.Equal(expectedOperator, actualOperator);
        }
    }
}