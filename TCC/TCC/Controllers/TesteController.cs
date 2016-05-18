﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TCC.Dto;
using TCC.Models;

namespace TCC.Controllers
{
    public class TesteController : ApiController
    {
        [HttpGet]
        [Route("api/cid10/{termo}")]
        public HttpResponseMessage ObterCID10(string termo)
        {
            TccModelEntities db = new TccModelEntities();

            var result = db.CID10.Where(model => model.descricao.Contains(termo) || model.codcid.Contains(termo)).ToList();

            var colCID10 = from c in result select new CID10Dto(c).descricao;

            return Request.CreateResponse(HttpStatusCode.OK, colCID10);
        }
    }
}