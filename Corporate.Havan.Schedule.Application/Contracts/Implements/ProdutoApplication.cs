using AutoMapper;
using Corporate.Havan.Schedule.Application.Contracts.Applications;
using Corporate.Havan.Schedule.Application.Mapping.Dto;
using Corporate.Havan.Schedule.Domain.Contracts.Repositories.Base;
using Corporate.Havan.Schedule.Domain.Entities.Produtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Corporate.Havan.Schedule.Application.Contracts.Implements
{
    public class ProdutoApplication : IProdutoApplication
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProdutoApplication(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }     

        public ProdutoDto GetById(int idFamilia)
        {
            try
            {
                var produto =  _unitOfWork.Produtos.GetBayId(idFamilia);
                return _mapper.Map<ProdutoDto>(produto);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
