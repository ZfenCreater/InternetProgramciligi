using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace example.Models
{
    public class yemekcesitdata
    {
        public static List<yemekcesit> Items { get; set; }

        static yemekcesitdata()
        {
            Items = new List<yemekcesit>()
            {
                new yemekcesit { id = 1, Ad = "Yemek"},
                new yemekcesit { id = 2, Ad = "Tatlı"},
                new yemekcesit { id = 3, Ad = "İçecek"},
            };
        }

        public static yemekcesit GetById(int id)
        {
            return Items.FirstOrDefault(x => x.id == id);
        }
    }
}