using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Revisao.Domain.Entities
{
    public class Jogo
    {
        #region 1 - Contrutores
        [JsonConstructor]
        public Jogo(int proximoCodigojogo, string nome, string cpf,int primeiroNumero, int segundoNumero, int terceiroNumero, int quartoNumero, int quintoNumero, int sextoNumero, DateTime dataJogo)
        {
            Codigo = proximoCodigojogo;
            Nome = nome;
            CPF = cpf;
            PrimeiroNumero = primeiroNumero;
            SegundoNumero = segundoNumero;
            TerceiroNumero = terceiroNumero;
            QuartoNumero = quartoNumero;
            QuintoNumero = quintoNumero;
            SextoNumero = sextoNumero;
            DataJogo = dataJogo;
         


        }
       






        #endregion

        #region 2 - Propriedades


        public int Codigo { get; private set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public int PrimeiroNumero { get; private set; }
        public int SegundoNumero { get; private set; }
        public int TerceiroNumero { get; private set; }
        public int QuartoNumero { get; private set; }
        public int QuintoNumero { get; private set; }
        public int SextoNumero { get; private set; }
        public DateTime DataJogo { get; private set; }





        #endregion

        #region 3 - Comportamentos



        public void AlterarNome(string nome) => Nome = Nome;



        public void AlterarCPF(string cpf) => CPF = CPF;

        public void SetaCodigoJogo(int novocodigo) => Codigo = novocodigo;

        public void AlterarPrimeiroNumero(int primeiroNumero) => PrimeiroNumero = PrimeiroNumero;

        public void AlterarSegundoNumero(int segundoNumero) => SegundoNumero = SegundoNumero;


        public void AlterarTerceiroNumero(int terceiroNumero) => TerceiroNumero = TerceiroNumero;


        public void AlterarQuartoNumero(int quartoNumero) => QuartoNumero = QuartoNumero;


        public void AlterarQuintoNumero(int quintoNumero) => QuintoNumero = QuintoNumero;



        public void AlterarSextoNumero(int sextoNumero) => SextoNumero = SextoNumero;

        #endregion


    }
}
