using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCOREMVC.Models
{
    public class HomeModel
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public List<HomeModel> GetAll()
        {
            HomeModel item;
            List<HomeModel> list = new List<HomeModel>();

            item = new HomeModel();
            item.Id = 1;
            item.Name = "Luis";
            list.Add(item);

            item = new HomeModel();
            item.Id = 2;
            item.Name = "Ferreira";
            list.Add(item);

            return list;

        }
    }
}
