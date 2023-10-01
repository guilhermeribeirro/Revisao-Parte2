using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Revisao.Application.ViewModels;
using Revisao.Domain.Entities;

namespace Revisao.Application.AutoMapper
{
    public class DomainToApplication : Profile
    {
        public DomainToApplication()
        {
            CreateMap<Jogo, JogoViewModel>();
        }
    }
}
