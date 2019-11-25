using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HomeDataCenterCore.Domain;

namespace HomeDataCenterCore
{
    public interface IBodyDataDAL
    {
        Task<Tuple<IEnumerable<BodyDataViewModel>, int>> GetAllBodyData();
        Task<Tuple<IEnumerable<BodyDataViewModel>, int>> GetAllBodyDataByPage(int page, int count);
        Task<bool> AddBodyData(BodyDataViewModel model);
    }
}
