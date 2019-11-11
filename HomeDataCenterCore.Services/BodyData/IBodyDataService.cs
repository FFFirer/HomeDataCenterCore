using System;
using System.Collections.Generic;
using System.Text;
using HomeDataCenterCore.Domain;
using HomeDataCenterCore.Domain.ViewModels;
using System.Threading;
using System.Threading.Tasks;

namespace HomeDataCenterCore.Services
{
    public interface IBodyDataService
    {
        Task<Tuple<IEnumerable<BodyDataViewModel>, int>> GetAllBodyData();
        Task<IEnumerable<BodyDataViewModel>> GetAllBodyDataByPage(int page, int count);
        Task<int> GetBodyDataCount();
        Task<bool> AddBodyData(BodyDataViewModel model);
    }
}
