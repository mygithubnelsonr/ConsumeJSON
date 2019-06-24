using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ConsumeJSON
{
    public partial class Form1 : Form
    {
        BindingList<Pflanze> _listOfPflanzen;

        string _rawJSON;
        string _fill;
        PlantCollection _plantCollection;
        MovieCollection _movieCollection;

        public string RawJSON { get => _rawJSON; set => _rawJSON = value; }
        public PlantCollection PlantCollection { get => _plantCollection; set => _plantCollection = value; }
        public MovieCollection MovieCollection { get => _movieCollection; set => _movieCollection = value; }
        public BindingList<Pflanze> ListOfPflanzen { get => _listOfPflanzen; set => _listOfPflanzen = value; }
        public string Fill { get => _fill; set => _fill = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //buttonReadJSON.PerformClick();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Debug.Print($"{listBox1.SelectedValue},{listBox1.Text}");
        }

        private void buttonFillList_Click(object sender, EventArgs e)
        {
            if (Fill == "plants")
                FillPlants();
            
            if (Fill == "movies")
                FillMovies();
        }

        private void buttonReadMovies_Click(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                // get a string representation of our JSON.
                string RawJSON = webClient.DownloadString(
                    "http://sys-service.de/customer/movies.json"
                    );

                // convert the JSON string to a serias of objects.
                MovieCollection = JsonConvert.DeserializeObject<MovieCollection>(RawJSON);
                Console.WriteLine(MovieCollection.Movies.Count);

                var movies = MovieCollection.Movies.Select(m => m);
                Console.WriteLine(movies.Count<Movie>());

                int n = 0;
                foreach (var movie in movies)
                {
                    Console.WriteLine($"{++n},{movie.Title},{movie.Year}");
                }

                Fill = "movies";
            }
        }

        private void buttonReadPlants_Click(object sender, EventArgs e)
        {
            using (var webClient = new WebClient())
            {
                // get a string representation of our JSON.
                string RawJSON = webClient.DownloadString(
                    "http://sys-service.de/customer/plants.json"
                    );

                // convert the JSON string to a serias of objects.
                PlantCollection = JsonConvert.DeserializeObject<PlantCollection>(RawJSON);
                //Console.WriteLine(PlantCollection.Plants.Count);

                var plants = PlantCollection.Plants.Select(p => new { p.Id, p.Common });
                //Console.WriteLine(plants.Count());

                int n = 0;
                foreach (var plant in plants)
                {
                    Console.WriteLine($"{++n},{plant.Id},{plant.Common}");
                }

                Fill = "plants";
            }
        }

        private void FillPlants()
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            var plants = PlantCollection.Plants.Select(p => new { p.Id, p.Common });
            Console.WriteLine(plants.Count());

            foreach (var plant in plants)
            {
                dic.Add(plant.Id, plant.Common);
            }

            listBox1.DataSource = new BindingSource(dic.ToList(), null);
            listBox1.DisplayMember = "Value";
            listBox1.ValueMember = "Key";
        }

        private void FillMovies()
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            var movies = MovieCollection.Movies.Select(m => new { m.Year, m.Title });
            Console.WriteLine(movies.Count());

            foreach (var movie in movies)
            {
                string year = movie.Year.Substring(0, 4);
                char rs = (char)30;
                
                string titel = movie.Title.Substring(0, movie.Title.IndexOf(rs,0));
                dic.Add( year , titel);
            }

            listBox1.DataSource = new BindingSource(dic.ToList(), null);
            listBox1.DisplayMember = "Value";
            listBox1.ValueMember = "Key";
        }
    }
}
