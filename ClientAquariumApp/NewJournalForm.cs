using ClientAquariumApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAquariumApp
{
    public partial class NewJournalForm : Form
    {
        const string urlGetAllShort = "http://localhost:5238/api/Aquarium/GetAllShort";

        const string urlMtGetAllShort = "http://localhost:5238/api/MaintenanceType/GetAllShort";

        const string urlAddJournal = "http://localhost:5238/api/Journal/AddJounal";

        List<IdNameModel> availableMaintenanceTypes = new List<IdNameModel>();
        List<IdNameModel> selectedMaintenanceTypes = new List<IdNameModel>();

        public NewJournalForm()
        {
            InitializeComponent();

        }

        private void NewJournalForm_Load(object sender, EventArgs e)
        {
            FillComboBoxWithFishTanks();
            LoadMaintenanceTypesAsync();

        }

        private async void NewJournalForm_Activated(object sender, EventArgs e)
        {

        }

        private async Task FillComboBoxWithFishTanks()
        {
            var fishTanks = await GetFishTanks();
            comboBoxFishTanks.DataSource = fishTanks;
            comboBoxFishTanks.DisplayMember = "Name";
            comboBoxFishTanks.ValueMember = "ID";
        }

        private async Task<List<FishTankBaseModel>> GetFishTanks()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(urlGetAllShort);

                    if (response.IsSuccessStatusCode)
                    {
                        // Десериализация JSON ответа в список объектов FishTankBaseModel
                        var fishTanks = await response.Content.ReadFromJsonAsync<List<FishTankBaseModel>>();
                        return fishTanks ?? new List<FishTankBaseModel>();
                    }
                    else
                    {
                        // Обработка ошибок при запросе
                        Console.WriteLine($"Ошибка получения данных: {response.ReasonPhrase}");
                        return new List<FishTankBaseModel>();
                    }
                }
                catch (Exception ex)
                {
                    // Обработка исключений, связанных с запросом
                    Console.WriteLine($"Исключение при запросе: {ex.Message}");
                    return new List<FishTankBaseModel>();
                }
            }
        }

        private async Task LoadMaintenanceTypesAsync()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(urlMtGetAllShort);
                if (response.IsSuccessStatusCode)
                {
                    availableMaintenanceTypes = await response.Content.ReadFromJsonAsync<List<IdNameModel>>();
                    listBoxAvailable.DataSource = new BindingList<IdNameModel>(availableMaintenanceTypes);
                    listBoxAvailable.DisplayMember = "Name";
                    listBoxAvailable.ValueMember = "ID";
                }
                else
                {
                    Console.WriteLine($"Ошибка получения данных: {response.ReasonPhrase}");
                }
            }
        }

        private async void btnSaveJournal_Click(object sender, EventArgs e)
        {
            var selectedIds = selectedMaintenanceTypes.Select(m => m.ID).ToList();

            var journalModel = new JournalPostModel
            {
                FishTankID = (int?)comboBoxFishTanks.SelectedValue,
                Name = txtName.Text,
                Description = txtDescription.Text,
                DateTime = dateTimePicker.Value,
                MaintenanceTypes = selectedIds
            };

            await SaveJournal(journalModel);
        }
        private async Task SaveJournal(JournalPostModel journalModel)
        {
            using (var client = new HttpClient())
            {
                var response = await client.PostAsJsonAsync(urlAddJournal, journalModel);
                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Журнал успешно сохранен.");
                }
                else
                {
                    MessageBox.Show("Ошибка при сохранении журнала." + response.ReasonPhrase);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MoveItem(listBoxAvailable, availableMaintenanceTypes, selectedMaintenanceTypes);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MoveItem(listBoxSelected, selectedMaintenanceTypes, availableMaintenanceTypes);
        }

        private void MoveItem(ListBox listBoxFrom, List<IdNameModel> listFrom, List<IdNameModel> listTo)
        {
            var selectedItem = listBoxFrom.SelectedItem as IdNameModel;
            if (selectedItem != null)
            {
                listFrom.Remove(selectedItem);
                listTo.Add(selectedItem);

                UpdateListBoxDataSource(listBoxFrom, listFrom);
                UpdateListBoxDataSource(listBoxFrom == listBoxAvailable ? listBoxSelected : listBoxAvailable, listTo);
            }
        }

        private void UpdateListBoxDataSource(ListBox listBox, List<IdNameModel> list)
        {

            listBox.DataSource = null;
            listBox.DataSource = new BindingList<IdNameModel>(list);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "ID";
        }


    }
}
