using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeJSON
{
    public class Pflanze
    {
        //public List<Plant2> GetPflanzen()
        //{
        //    List<Plant2> pflanzen = new List<Plant2>();

        //    //foreach (Plant p in AllPlants)
        //    //{
        //    //    Plant2 plant2 = new Plant2 { Id = p.Id, Common = p.Common };
        //    //    pflanzen.Add(plant2);
        //    //}

        //    return pflanzen;
        //}

        int _id;
        string _name;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
    }
}
