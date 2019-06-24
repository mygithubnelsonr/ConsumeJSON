using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingObjectForListboxDatasource
{
    public class ZeigePflanzen
    {
        public List<Plant2> GetPflanzen()
        {
            List<Plant2> pflanzen = new List<Plant2>();

            //foreach (Plant p in AllPlants)
            //{
            //    Plant2 plant2 = new Plant2 { Id = p.Id, Common = p.Common };
            //    pflanzen.Add(plant2);
            //}

            return pflanzen;
        }
    }
}
