using AutoMapper;
using Corporate.Havan.Schedule.Application.Contracts.Applications;
using Corporate.Havan.Schedule.Domain.Contracts.Repositories.Base;
using Corporate.Havan.Schedule.Domain.Entities.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Application.Contracts.Implements
{
    public class ProdutoFamiliaApplication : IProdutoFamiliaApplication
    {
        private readonly IUnitOfWork _unitOfWork;      

        public ProdutoFamiliaApplication(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;        
        }

        public async Task<List<FamiliaProduto>> GetAllFamiliaProd()
        {
            try
            {
               return await _unitOfWork.ProdutoFamilias.GetAllFalimiaProd();              
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
