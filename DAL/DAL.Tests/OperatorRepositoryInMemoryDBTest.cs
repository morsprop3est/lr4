﻿using System;
using Xunit;
using lr4.Repositories.Impl;
using DAL.EF;
using Microsoft.EntityFrameworkCore;
using DAL.Repositories.Interfaces;
using System.Linq;
using lr4;


namespace DAL.Tests
{
    public class OperatorRepositoryInMemoryDBTests
    {

        public SamplingContext Context => MySqlInMemoryContext();

        private SamplingContext MySqlInMemoryContext()
        {
            // Параметри підключення до тестової бази MySQL
            var optionsBuilder = new DbContextOptionsBuilder<SamplingContext>();
            optionsBuilder.UseMySQL("Server=localhost;Database=trpz;Uid=root;Pwd=2004;");

            var context = new SamplingContext(optionsBuilder.Options);
            context.Database.EnsureCreated();
            return context;
        }

        [Fact]
        public void Create_InputOperatorWithId0_SetOperatorId1()
        {
            // Arrange
            int expectedListCount = 1;
            var context = MySqlInMemoryContext();
            EFUnitOfWork uow = new EFUnitOfWork(context);
            IOperatorRepository repository = uow.Operator;

            Operator Operator1 = new Operator()
            {
                operatorID = 1,
                Name = "test"
            };

            //Act
            repository.Create(Operator1);
            uow.Save();
            var factListCount = context.Operators.Count();

            // Assert
            Assert.Equal(expectedListCount, factListCount);
        }

        [Fact]
        public void Delete_InputExistOperatorId_Removed()
        {
            // Arrange
            int expectedListCount = 0;
            var context = MySqlInMemoryContext();
            EFUnitOfWork uow = new EFUnitOfWork(context);
            IOperatorRepository repository = uow.Operators;
            Operator Operator1 = new Operator()
            {
                operatorID = 1,
                Name = "test"
            };
            context.Operators.Add(Operator1);
            context.SaveChanges();

            //Act
            repository.Delete(Operator1.operatorID);
            uow.Save();
            var factOperatorCount = context.Operators.Count();

            // Assert
            Assert.Equal(expectedListCount, factOperatorCount);
        }

        [Fact]
        public void Get_InputExistOperatorId_ReturnOperator()
        {
            // Arrange
            var context = MySqlInMemoryContext();
            EFUnitOfWork uow = new EFUnitOfWork(context);
            IOperatorRepository repository = uow.Operators;
            Operator expectedOperator = new Operator()
            {
                operatorID = 1,
                Name = "test"
            };
            context.Operators.Add(expectedOperator);
            context.SaveChanges();

            //Act
            var factOperator = repository.Get(expectedOperator.operatorID);

            // Assert
            Assert.Equal(expectedOperator, factOperator);
        }
    }
}