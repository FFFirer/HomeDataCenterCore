using System;
using System.Collections.Generic;
using System.Text;
using HomeDataCenterCore.Domain;
using System.Threading;
using System.Threading.Tasks;

namespace HomeDataCenterCore.Services
{
    interface IBodyDataService
    {
        Task<Tuple<IEnumerable<BodyDataViewModel>, int>> GetAllBodyData();
        Task<Tuple<IEnumerable<BodyDataViewModel>, int>> GetAllBodyDataByPage(int page, int count);
        Task<bool> AddBodyData(BodyDataViewModel model);
    }
}
