using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apidotnet.entity;
using apidotnet.model;
using AutoMapper;

  

namespace apidotnet.map
{
    public class Automapperprofiles :Profile
    {

      public Automapperprofiles(){
        CreateMap<livro, livroModel>().ReverseMap();
      }

    }
}