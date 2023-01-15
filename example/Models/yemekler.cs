using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace example.Models
{
    public class yemekler
    {
        public int id { get; set; }
        public String adi { get; set; }
        public String imageurl { get; set; }

        public int yemekcesitid { get; set; }
        public yemekcesit yemekcesit
        {
            get { return yemekcesitdata.GetById(this.yemekcesitid); }
        }
    }
}