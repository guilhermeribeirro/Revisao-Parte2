using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface IJogoService
    {

        
        IEnumerable<JogoViewModel> ObterTodos();
        Task<JogoViewModel> ObterPorId(Guid id);
        Task<IEnumerable<JogoViewModel>> ObterPorCategoria(int proximoCodigojogo);

        void Adicionar(NovoJogoViewModel jogo);
        void Atualizar(JogoViewModel jogo);




    }



}

