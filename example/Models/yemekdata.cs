using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace example.Models
{
    public class yemekdata
    {
        public static List<yemekler> Items { get; set; }

        static yemekdata()
        {
            Items = new List<yemekler>
            {
                new yemekler
                {
                    id = 1,
                    adi = "Tokat Kebabı",
                    imageurl="/Content/img/tokatkebabi.jpeg",
                    yemekcesitid=1,                },

                new yemekler
                {
                    id = 2,
                    adi = "Yaprak sarması",
                    imageurl="/Content/img/dolma.jpeg",
                    yemekcesitid=1,
                },

                new yemekler
                {
                    id = 3,
                    adi = "Cevizli Bat",
                    imageurl="/Content/img/cevizlibat.jpeg",
                    yemekcesitid=1,
                },

                new yemekler
                {
                    id = 4,
                    adi = "Bakla Dolması",
                    imageurl="/Content/img/bakladolması.jpeg",
                    yemekcesitid=1,
                },

                new yemekler
                {
                    id = 5,
                    adi = "Patlıcan Pehlisi",
                    imageurl="/Content/img/patlicanp.jpeg",
                    yemekcesitid=1,
                },

                new yemekler
                {
                    id = 6,
                    adi = "Erikli Dolma",
                    imageurl="/Content/img/ErikliDolma.jpeg",
                    yemekcesitid=1,
                },

                new yemekler
                {
                    id = 7,
                    adi = "Kabak Kabuğu Kavurması",
                    imageurl="/Content/img/kkk.jpeg",
                    yemekcesitid=1,
                },

                new yemekler
                {
                    id = 8,
                    adi = "Et Dolması",
                    imageurl="/Content/img/etdolmas.jpeg",
                    yemekcesitid=1,
                },

                new yemekler
                {
                    id = 9,
                    adi = "Kurutulmuş biber dolması",
                    imageurl="/Content/img/kbd.jpeg",
                    yemekcesitid=1,
                },

                 new yemekler
                {
                    id = 10,
                    adi = "Zile Pekmezi",
                    imageurl="/Content/img/ZilePekmezi.jpeg",
                    yemekcesitid=2,
                },

                new yemekler
                {
                    id = 11,
                    adi = "Köme",
                    imageurl="/Content/img/Köme.jpeg",
                    yemekcesitid=2,
                },

                new yemekler
                {
                    id = 12,
                    adi = "Tırtıl Baklavası",
                    imageurl="/Content/img/TirtiBak.jpeg",
                    yemekcesitid=2,
                },

                new yemekler
                {
                    id = 13,
                    adi = "Yufka Tatlısı",
                    imageurl="/Content/img/yufkatat.jpeg",
                    yemekcesitid=2,
                },

                new yemekler
                {
                    id = 14,
                    adi = "Zambak Reçelidir",
                    imageurl="/Content/img/zambakre.jpeg",
                    yemekcesitid=2,
                },

                new yemekler
                {
                    id = 15,
                    adi = "Mahlep şarabı",
                    imageurl="/Content/img/mahleps.jpeg",
                    yemekcesitid=3,
                },
            };
        }

        public static yemekler GetById(int id)
        {
            return Items.FirstOrDefault(x => x.id == id);
        }

        public static int Insert(yemekler item)
        {
            item.id = (Items.Count == 0) ? 1 : Items.Max(x => x.id) + 1;
            Items.Add(item);
            return item.id;
        }

        public static void Update(yemekler item)
        {
            var yemek = Items.FirstOrDefault(x => x.id == item.id);
            if (yemek != null)
            {
                yemek.id=item.id;
                yemek.adi = item.adi;
                yemek.imageurl= item.imageurl;
            }
        }

        public static void Remove(int id)
        {
            yemekler item = Items.FirstOrDefault(x => x.id == id);
            if (item != null)
                Items.Remove(item);
        }




    }
}




