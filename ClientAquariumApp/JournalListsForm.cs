using ClientAquariumApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAquariumApp
{
    public partial class JournalListsForm : Form
    {
        const string urlGetAllShort = "http://localhost:5238/api/Aquarium/GetAllShort";

        const string urlGetJournalsByFishTankId = "http://localhost:5238/api/Journal/GetJournalsByFishTankId";

        public JournalListsForm()
        {
            InitializeComponent();
        }

        private async void JournalListsForm_Load(object sender, EventArgs e)
        {
            await LoadFishTanks();
            comboBoxFishTank.SelectedIndexChanged += ComboBoxFishTank_SelectedIndexChanged;
        }
        private async void ComboBoxFishTank_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedFishTankId = ((FishTankBaseModel)comboBoxFishTank.SelectedItem)?.ID ?? 0;
            var task = LoadJournalsByFishTankId(selectedFishTankId);

        }

        private async Task LoadFishTanks()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlGetAllShort);
                HttpResponseMessage response = await client.GetAsync("GetAllShort");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var fishTanks = JsonConvert.DeserializeObject<List<FishTankBaseModel>>(json);

                    comboBoxFishTank.DataSource = fishTanks;
                    comboBoxFishTank.DisplayMember = "Name";
                    comboBoxFishTank.Text = "~Select Aquarium~";

                }
                else
                {
                    MessageBox.Show("Ошибка при загрузке аквариумов");
                }
            }
        }

        private async Task LoadJournalsByFishTankId(int fishTankId)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlGetJournalsByFishTankId);
                HttpResponseMessage response = await client.GetAsync($"GetJournalsByFishTankId/{fishTankId}");
                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadAsStringAsync();
                    var journals = JsonConvert.DeserializeObject<List<GetJournalModel>>(json);

                    dataGridViewJournals.DataSource = journals;

                }
                else
                {
                    MessageBox.Show("Ошибка при загрузке журналов");
                }
            }
        }



    }
}
