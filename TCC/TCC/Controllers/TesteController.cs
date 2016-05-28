using System;
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
            SocialCareEntities db = new SocialCareEntities();

            var result = db.TAB_CID.Where(model => model.des_cid.Contains(termo) || model.cod_cid10.Contains(termo)).ToList();

            var colCID10 = from c in result select new CID10Dto(c).descricao;

            return Request.CreateResponse(HttpStatusCode.OK, colCID10);
        }

        [HttpGet]
        [Route("api/cid10")]
        public HttpResponseMessage ObterCID10()
        {
            SocialCareEntities db = new SocialCareEntities();

            var result = db.TAB_CID.ToList();

            var colCID10 = from c in result select new CID10Dto(c).descricao;

            return Request.CreateResponse(HttpStatusCode.OK, colCID10.ToArray());
        }
    }
}
