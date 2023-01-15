using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace example.Models
{
    public class fotodata
    {
        public static List<foto> Items { get; set; }

        static fotodata()
        {
            Items = new List<foto>
            {
                new foto
                {
                    id=1,
                    imageurl="/Content/img/img2.jpg",
                },
                new foto
                {
                    id=2,
                    imageurl="/Content/img/img1.jpg",
                },
                new foto
                {
                    id=3,
                    imageurl="/Content/img/img3.jpg",
                },
                new foto
                {
                    id=4,
                    imageurl="/Content/img/saat-kulesi-tokat.jpg",
                },

                new foto
                {
                    id=5,
                    imageurl="/Content/img/b20 _800 x 600_ Kale Boğazı.jpg",
                },


                new foto
                {
                    id=6,
                    imageurl="/Content/img/Kaz-Golu.jpg",
                },

                new foto
                {
                    id=7,
                    imageurl="/Content/img/Kaz-Golu-2.jpg",
                },
                new foto
                {
                    id=8,
                    imageurl="/Content/img/pazar-ballıca.jpg",
                },
                new foto
                {
                    id=9,
                    imageurl="/Content/img/pazar-ballıca2.jpg",
                },
                new foto
                {
                    id=10,
                    imageurl="/Content/img/PazarKazGolu_1200x801.jpg",
                },

                new foto
                {
                    id=11,
                    imageurl="/Content/img/kayak1_1200x801.jpg",
                },


                new foto
                {
                    id=12,
                    imageurl="/Content/img/kayak4_1200x801.jpg",
                },
            };
        }



        public static foto GetById(int id)
        {
            return Items.FirstOrDefault(x => x.id == id);
        }

        public static int Insert(foto item)
        {
            item.id = (Items.Count == 0) ? 1 : Items.Max(x => x.id) + 1;
            Items.Add(item);
            return item.id;
        }

        public static void Update(foto item)
        {
            var foto = Items.FirstOrDefault(x => x.id == item.id);
            if (foto != null)
            {
                foto.id = item.id;
                foto.imageurl = item.imageurl;
            }
        }

        public static void Remove(int id)
        {
            foto item = Items.FirstOrDefault(x => x.id == id);
            if (item != null)
                Items.Remove(item);
        }
    }
}