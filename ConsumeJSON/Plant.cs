﻿namespace ConsumeJSON
{
    public class Plant
    {
        int id;
        string genus;
        string species;
        string cultivar;
        string common;

        public int Id { get => id; set => id = value; }
        public string Genus { get => genus; set => genus = value; }
        public string Species { get => species; set => species = value; }
        public string Cultivar { get => cultivar; set => cultivar = value; }
        public string Common { get => common; set => common = value; }
    }
}
