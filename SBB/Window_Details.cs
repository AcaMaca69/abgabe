using System;
using System.Windows.Forms;
using SwissTransport;
using SwissTransport.Models;
using SwissTransport.Core;

namespace SBB
{
    public partial class Detail : Form
    {
        private Connection connection;

        public Detail()
        {
            // init comopnent
            InitializeComponent();
        }
        
        private void SetProperties()
        {
            // set properties for detail view
            connection = Tag as Connection;
            // destination
            destination_time_placerholder.Text = DateTime.Parse(connection.From.Departure.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            // arival time
            arival_time_placerholder.Text = DateTime.Parse(connection.To.Arrival.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            // dpearure prop
            deprautre_placerholder.Text = connection.From.Station.Name;
            // station name
            deprautre_time_placerholder.Text = connection.To.Station.Name;
           
        }

        private void setDataView()
        {
            // add connection to table
            void add_connection_to_table(Pass staion)
            {
                // add each row
                string[] row = new string[]
                {
                staion.Arrival,
                staion.Station.Name,
                staion.Departure
                };

                // add the values into the listview and set the connection as the tag of the row
                ltvConnections.Items.Add(new ListViewItem(row)
                {
                    Tag = staion
                });
            }

            connection = Tag as Connection;

            // if error just add email reference
  
            Console.WriteLine(connection.Sections.Count);

            foreach (Section section in connection.Sections)
            {
                Console.WriteLine(section.Journey.Passes);
                foreach (Pass pass in section.Journey.Passes)
                {
                    add_connection_to_table(pass);
                }

            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            // setup email 
            connection = Tag as Connection;

            string departureTime = DateTime.Parse(connection.From.Departure.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            string deparutreLocation = connection.From.Station.Name;
            string arrivalTime = DateTime.Parse(connection.To.Arrival.ToString()).ToString("yyyy-MM-dd HH:mm:ss");
            string arrivatLocation = connection.To.Station.Name;

            string mailText = $"The Train will depart at {departureTime} in {deparutreLocation} and will arive at {arrivalTime} in {arrivatLocation}";

            System.Diagnostics.Process.Start($"mailto:test@mail.com?subject=SBB Fahrplan&body={mailText}");
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            ltvConnections.Items.Clear();
            Console.WriteLine("runningload");
            SetProperties();
            setDataView();
        }
    }
}

