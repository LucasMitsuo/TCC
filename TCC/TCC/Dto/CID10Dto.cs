using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TCC.Models;

namespace TCC.Dto
{
    public class CID10Dto
    {
        public int id { get; set; }
        public string descricao { get; set; }


        public CID10Dto(CID10 cid10)
        {
            this.id = cid10.id;
            this.descricao = cid10.codcid + " - " + cid10.descricao;
        }
    }
}