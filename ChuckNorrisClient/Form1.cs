using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuckNorrisClient
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();

            //Initialize client settings
            //MAKE SURE, YOUR URL ENDS WITH A FORWARD SLASH
            client.BaseAddress =
                new Uri("https://api.icndb.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            //Tell service we want JSON data
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            //Tell service which browser (user-agent) we are using
            //SOME WEB SERVICES REQUIRE USER-AGENT TO BE SET
            client.DefaultRequestHeaders
                .Add("User-Agent", "Joe's App");

        }

        private async void btnGetRandJoke_Click(object sender, EventArgs e)
        {
            HttpResponseMessage response =
                await client.GetAsync("jokes/random");
            //Check if web service returns HTTP 200 - OK
            if (response.IsSuccessStatusCode)
            {
                RandJokeResponse data = 
                    await response.Content.ReadAsAsync<RandJokeResponse>();

                Value jokeData = data.value;

                //Decode any special HTML Entities
                //ex. &quot; should be "
                string decodedJoke = WebUtility.HtmlDecode(jokeData.joke);

                MessageBox.Show(decodedJoke);

                if(jokeData.categories.Count > 0)
                {
                    MessageBox.Show(string.Join("\n", jokeData.categories));
                }
                
            }
            else
            {
                MessageBox.Show("There was an error. Try again.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
