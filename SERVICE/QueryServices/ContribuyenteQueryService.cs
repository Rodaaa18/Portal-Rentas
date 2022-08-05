using DATA.Models;
using DATA_ACCESS.Generic;
using DTOs;
using ENTITIES;
using MAPPING.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SERVICE.QueryServices
{
    public interface IContribuyenteQueryService
    {
        Task<IEnumerable<ContribuyentesDTO>> GetAllAsync(int page, int take);
    }
    public class ContribuyenteQueryService : IContribuyenteQueryService
    {
        private readonly IGenericRepository<Contribuyentes> _repository;

        public ContribuyenteQueryService(IGenericRepository<Contribuyentes> genericRepository)
        {
            _repository = genericRepository;
        }

        public async Task<IEnumerable<ContribuyentesDTO>> GetAllAsync(int page, int take)
        {
            try
            {
                var contribuyentes = await _repository.GetAsync(page, take);

                return contribuyentes.MapTo<IEnumerable<ContribuyentesDTO>>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los Contribuyentes");
            }
            
        }
    }
}
