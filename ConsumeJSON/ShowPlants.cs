using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;

namespace ConsumeJSON
{
    public class ShowPlants
    {
        static ShowPlants()
        {
            using (var webClient = new WebClient())
            {
                // get a string representation of our JSON.
                string rawJSON = webClient.DownloadString(
                    "http://sys-service.de/customer/plants.json"
                    );

                // convert the JSON string to a serias of objects.
                PlantCollection plantCollection = JsonConvert.DeserializeObject<PlantCollection>(rawJSON);

                // take the objects parsed from Json and give them 
                // to my static collection
                AllPlants = plantCollection.Plants;
            }
        }

        private static List<Plant> allPlants;

        public static List<Plant> AllPlants { get => allPlants; set => allPlants = value; }

        public static List<Plant> GetPlants()
        {
            return AllPlants;
        }

    }

    public class Plant2
    {
        //public override string ToString()
        //{
        //    return $"{id},{common}";
        //}

        int id;
        string common;

        public int Id { get => id; set => id = value; }
        public string Common { get => common; set => common = value; }
    }
}
