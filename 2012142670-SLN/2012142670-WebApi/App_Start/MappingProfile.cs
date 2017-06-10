using AutoMapper;
using _2012142670_ENT.Entities;
using _2012142670_ENT.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _2012142670_WebApi.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Cliente, ClienteDTO>();
            CreateMap<ClienteDTO, Cliente>();


        }
    }
}