using Newtonsoft.Json;
using Revisao.Domain.Entities;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Revisao.Data.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        private readonly string _jogoCaminhoArquivo;

        #region - Construtores
        public JogoRepository()
        {
            _jogoCaminhoArquivo = Path.Combine(Directory.GetCurrentDirectory(), "FileJsonData", "Jogo.json");
        }

        #endregion

        #region - Funções
        public void Adicionar(Jogo jogo)
        {
            var jogos = LerJogosDoArquivo();
            int proximoCodigo = ObterProximoCodigoDisponivel();
            jogo.SetaCodigoJogo(proximoCodigo);
           jogos.Add(jogo);
            EscreverJogosNoArquivo(jogos);
        }

        public void Atualizar(Jogo jogo)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Jogo>> ObterPorCategoria(int proximoCodigojogo)
        {
            throw new NotImplementedException();
        }

        public Task<Jogo> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Jogo> ObterTodos()
        {
            return LerJogosDoArquivo();
        }
        #endregion

        #region - Métodos arquivo
        private List<Jogo> LerJogosDoArquivo()
        {
            if (!System.IO.File.Exists(_jogoCaminhoArquivo))
                return new List<Jogo>();
            string json = System.IO.File.ReadAllText(_jogoCaminhoArquivo);
            return JsonConvert.DeserializeObject<List<Jogo>>(json);
        }

        private int ObterProximoCodigoDisponivel()
        {
            List<Jogo> jogos = LerJogosDoArquivo();
            if (jogos.Any())
                return jogos.Max(p => p.Codigo) + 1;
            else
                return 1;
        }

        private void EscreverJogosNoArquivo(List<Jogo> jogos)
        {
            string json = JsonConvert.SerializeObject(jogos);
            System.IO.File.WriteAllText(_jogoCaminhoArquivo, json);
        }
        #endregion


    }
}