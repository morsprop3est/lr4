
using System;
using System.Collections.Generic;
using DAL.DAL.Entities;
using DAL.BLL.DTO;
using DAL.DAL.Repositories.Interfaces;
using AutoMapper;
using DAL.BLL.Services.Interfaces;
using DAL.CCL.Security;
using DAL.DAL.UnitOfWork;

namespace DAL.BLL.Services.Impl
{
    public class OperatorService : IOperatorService
    {
        private readonly IUnitOfWork _database;
        private int pageSize = 10;

        public OperatorService(IUnitOfWork unitOfWork)
        {
            if (unitOfWork == null)
            {
                throw new ArgumentNullException(nameof(unitOfWork));
            }
            _database = unitOfWork;
        }

        public IEnumerable<OperatorDTO> GetOperators(int pageNumber)
        {
            // Тут ми отримуємо користувача і перевіряємо його тип
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            
            if (userType != typeof(Operator))
            {
                throw new MethodAccessException();
            }

            // Отримуємо ID ОСББ користувача
            var userId = user.UserId;

            // Отримуємо операторів для відповідного ОСББ
            var operators = _database.Operators.Find(z => z.UserId == userId, pageNumber, pageSize);

            // Мапимо операторів в DTO
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Operator, OperatorDTO>()).CreateMapper();
            var operatorsDto = mapper.Map<IEnumerable<Operator>, List<OperatorDTO>>(operators);

            return operatorsDto;
        }

        public void AddOperator(OperatorDTO newOperator)
        {
            // Аналогічно перевіряємо користувача на директора або бухгалтера
            var user = SecurityContext.GetUser();
            var userType = user.GetType();
            if (userType != typeof(Operator))
            {
                throw new MethodAccessException();
            }

            // Перевіряємо вхідні дані на валідність
            Validate(newOperator);

            // Мапимо DTO в сутність оператора та додаємо його
            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<OperatorDTO, Operator>()).CreateMapper();
            var operatorEntity = mapper.Map<OperatorDTO, Operator>(newOperator);
            _database.Operators.Create(operatorEntity);
        }

        private void Validate(OperatorDTO newOperator)
        {
            if (string.IsNullOrEmpty(newOperator.Name))
            {
                throw new ArgumentException("Name повинне містити значення!");
            }
        }
    }
}
