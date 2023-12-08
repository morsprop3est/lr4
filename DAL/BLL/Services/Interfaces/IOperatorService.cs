using DAL.BLL.DTO;
using DAL.DAL.Entities;

namespace DAL.BLL.Services.Interfaces
{
    public interface IOperatorService
    {
        IEnumerable<OperatorDTO> GetOperators(int page);
    }
}