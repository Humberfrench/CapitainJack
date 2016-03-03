﻿using Jack.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Jack.Presentation.Web.Controllers.API
{
    public class AnosController : ApiController
    {
        public List<DTOAnos> GetValues()
        {
            List<DTOAnos> listaRetorno = new List<DTOAnos>();
            for (int ano = 2014; ano <= 2020; ano++)
            {
                listaRetorno.Add(new DTOAnos(ano.ToString(), ano.ToString()));
            }
            return listaRetorno;
        }
    }
}