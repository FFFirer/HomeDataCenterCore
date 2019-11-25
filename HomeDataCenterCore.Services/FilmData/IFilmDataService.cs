using System;
using System.Collections.Generic;
using System.Text;
using HomeDataCenterCore.Domain.ViewModels;
using HomeDataCenterCore.Domain.DomainModels;
using System.Threading.Tasks;


namespace HomeDataCenterCore.Services
{
    public interface IFilmDataService
    {
        Task<IEnumerable<FilmDataViewModel>> GetFilmDataByPage(int page, int count);
        Task<FilmData> GetFilmDetailById(int Id);
        Task<int> GetFilmDataCount();
    }
}
