using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface IJogoRepository


    {
        IEnumerable<Jogo> ObterTodos();
        Task<Jogo> ObterPorId(Guid id);
        Task<IEnumerable<Jogo>> ObterPorCategoria(int proximoCodigojogo);

        void Adicionar(Jogo jogo);
        void Atualizar(Jogo jogo);



    }
}
