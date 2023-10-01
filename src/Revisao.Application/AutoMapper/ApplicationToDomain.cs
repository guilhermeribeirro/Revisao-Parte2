
using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{

    public class ApplicationToDomain : Profile
    {
        public ApplicationToDomain()
        {


            CreateMap<NovoJogoViewModel, Jogo>()
               .ConstructUsing(q => new Jogo(q.Codigo, q.Nome, q.CPF, q.PrimeiroNumero, q.SegundoNumero, q.TerceiroNumero, q.QuartoNumero, q.QuintoNumero, q.SextoNumero, q.DataJogo));

            CreateMap<JogoViewModel, Jogo>()
               .ConstructUsing(q => new Jogo(q.Codigo, q.Nome, q.CPF, q.PrimeiroNumero, q.SegundoNumero, q.TerceiroNumero, q.QuartoNumero, q.QuintoNumero, q.SextoNumero, q.DataJogo));

        }



    }
}
