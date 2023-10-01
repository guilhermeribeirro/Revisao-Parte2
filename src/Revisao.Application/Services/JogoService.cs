using AutoMapper;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class JogoService : IJogoService
    {


        #region - Construtores
        private readonly IJogoRepository _jogoRepository;
        private IMapper _mapper;

        public JogoService(IJogoRepository jogoRepository, IMapper mapper)
        {
            _jogoRepository = jogoRepository;
            _mapper = mapper;
        }
        #endregion

        #region - Funções
        public void Adicionar(NovoJogoViewModel novojogoViewModel)
        {
            var novojogo = _mapper.Map<Jogo>(novojogoViewModel);
            _jogoRepository.Adicionar(novojogo);

        }

        public void Atualizar(JogoViewModel jogo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<JogoViewModel>> ObterPorCategoria(int proximoCodigojogo)
        {
            throw new NotImplementedException();
        }

        public Task<JogoViewModel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<JogoViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<JogoViewModel>>(_jogoRepository.ObterTodos());
        }
        #endregion



    }
}
