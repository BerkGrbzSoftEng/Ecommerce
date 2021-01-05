using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Entities.Models;

namespace Business.Abstract
{
    public interface IUnitService
    {
        Task<List<Unit>> GetAll();
        Task<bool> Add(Unit unit);
        Task<bool> Update(Unit unit);
        Task<bool> Delete(Unit unit);
        Task<bool> Delete(int unitId);
    }
}
