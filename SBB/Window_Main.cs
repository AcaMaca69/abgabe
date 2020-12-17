using System;
using System.Linq;
using System.Windows.Forms;
using SwissTransport.Models;
using SwissTransport.Core;
using System;

namespace SBB
{
    public partial class MainView : Form
    {
        private readonly Transport _transportHanlder;
        private Detail _DetailView;

        public MainView()
        {
            _transportHanlder = new Transport();
            _DetailView = new Detail();

            InitializeComponent();
            ButtonsCheckEnbled();
        }

        private void GetStationRecomendations(ComboBox ComboBoxElement)
        {
            // add a try catch block to enhace user experience
            try
            {
                // request stations from the API from given input
                Stations _stations = _transportHanlder.GetStations(ComboBoxElement.Text);

                // clear input so there are no false values
                ComboBoxElement.Items.Clear();

                // on condition that count would be break function
                if (_stations.StationList.Count == 0)
                {
                    // Console Wirteline for Debbuggin
                    Console.WriteLine("Station count is 0");
                    return;
                }

                // loop over all the sttions in Stationlist
                foreach (Station station in _stations.StationList)
                {
                    // if the station is none hide
                    if (string.IsNullOrEmpty(station.Name))
                    {
                        continue;
                    }

                    // add sation to comonboboxelemen
                    ComboBoxElement.Items.Add(station.Name);
                }

                // adter updating the Items the index needs to be set to the last char
                ComboBoxElement.SelectionStart = ComboBoxElement.Text.Length;
            }
            catch
            {
                return;
            }
        }

        private void AddConnectionToList(Connection connection)
        {
            // create string row with fitting values for row
            string[] row = new string[]
            {
                connection.From.Station.Name,
                connection.From.Departure.ToString(),
                connection.To.Station.Name,
                connection.To.Arrival.ToString(),
                (DateTime.Parse(connection.To.Arrival.ToString()) - DateTime.Parse(connection.From.Departure.ToString())).ToString(),
                "-"
            };

            // add the values into the listview and set the connection as the tag of the row
            ltvConnections.Items.Add(new ListViewItem(row)
            {
                // add connection as Tag for later data usaage
                Tag = connection
            });
        }

        private void ButtonsCheckEnbled()
        {
            // if button is checked enable elements for Dateime selection
            if (chbSpecifyTime.Checked)
            {
                dtpTime.Enabled = true;
                rdbArrival.Enabled = true;
                rdbDeparture.Enabled = true;
            }
            // if not enabled disable all the buttons
            else
            {
                dtpTime.Enabled = false;
                rdbArrival.Enabled = false;
                rdbDeparture.Enabled = false;
            }
        }

        private void GetStations()
        {
            // check if datetime picker is active
            int ariOrDep;
            DateTime trainTime;

            // if user wants to give specific time input
            if (chbSpecifyTime.Checked)
            {
                // if button is cehcked set value to 0 (departure)
                if (rdbDeparture.Checked)
                { 
                    ariOrDep = 0;
                }
                // if not set value to one (arrival time)
                else
                {
                    ariOrDep = 1;
                }

                // asing value from picker.
                trainTime = dtpTime.Value;
            }
            
            // otherwise set default value (now)
            else
            {
                ariOrDep = 0;
                trainTime = DateTime.Now;
            }

            // make API call
            Connections _connections = _transportHanlder.GetConnections(cmbStartLocation.Text, cmbDestinationLocation.Text, ariOrDep, trainTime, trainTime, 10);

            // clear all items from collection
            ltvConnections.Items.Clear();

            // add all connections to Main View
            foreach (Connection connection in _connections.ConnectionList)
            {

                // Add to view.
                AddConnectionToList(connection);
            }
        }

        private void cmbStartLocation_TextUpdate(object sender, EventArgs e)
        {
            // get Station recomenations on Textupdate (future improving -> only start rec after 3 ore more letters)
            GetStationRecomendations(cmbStartLocation);
        }

        private void cmbDestinationLocation_TextUpdate(object sender, EventArgs e)
        {
            // get Station recomenations on Textupdate (future improving -> only start rec after 3 ore more letters)
            GetStationRecomendations(cmbDestinationLocation);
        }

        private void getPossibleestinations()
        {
            // try catch block for user exprience
            try
            {
                // make API call
                Station station = _transportHanlder.GetStations(cmbStartLocation.Text).StationList.ElementAt(0);

                // get Board from station name and Id
                StationBoardRoot Board = _transportHanlder.GetStationBoard(station.Name, station.Id);

                // -> cursor to waitingcursor
                Cursor.Current = Cursors.WaitCursor;

                // clear view
                //ltvConnections.Items.Clear();


                // for each board entry in stationBoard
                foreach (StationBoard bord in Board.Entries)
                {
                    // another catch for debugging
                    try
                    {
                        // get destionation station from Stationlist
                        Station to_statoin = _transportHanlder.GetStations(bord.To).StationList.ElementAt(0);
                        
                        // get connection from board and destination statiaon
                        Connection connection = _transportHanlder.GetConnections(bord.Stop.Station.Name, to_statoin.Name, 1, DateTime.Now, DateTime.Now, 10).ConnectionList[0];

                        // add connection 
                        AddConnectionToList(connection);
                    }
                    catch
                    {
                        return;
                    }

                }
                // reset cursor 
                Cursor.Current = Cursors.Default;
            }
            catch
            {
                return;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // if destionion is emty get possible journey
            if (cmbDestinationLocation.Text == "")
            {
                getPossibleestinations();
            }
            // else get connecitons and display then in view
            else
            {
                GetStations();
            }

        }

        private void chbSpecifyTime_CheckedChanged(object sender, EventArgs e)
        {
            // check if buttons should be enabled
            ButtonsCheckEnbled();
        }

        private void ltvConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            // if no items in View then break the fucntion 
            if (ltvConnections.SelectedItems.Count <= 0 || ltvConnections.SelectedIndices[0] < 0)
            {
                return;
            }

            // set list view item to item from selection ite
            ListViewItem item = ltvConnections.SelectedItems[0];
            Console.WriteLine(item.Tag);

            // init new form in dialogMode
            _DetailView.Tag = item.Tag;
            _DetailView.ShowDialog(this);
        }
    }
}
