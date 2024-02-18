using ClientAquariumApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
    public partial class EditJournalForm : Form
    {
        private const string urlGetAllShort = "http://localhost:5238/api/Aquarium/GetAllShort";

        private const string urlMtGetAllShort = "http://localhost:5238/api/MaintenanceType/GetAllShort";

        private const string urlEditJournal = "http://localhost:5238/api/Journal/Edit";

        private const string urlGetJournal = "http://localhost:5238/api/Journal/Getbyid";


        private List<IdNameModel> _availableMaintenanceTypes;

        private JournalPostModel _model;

        private int _journalId;

        public EditJournalForm(int journalId)
        {
            InitializeComponent();

            _journalId = journalId;

            LoadAvailableMaintenanceTypesAsync();
        }

        public EditJournalForm(JournalPostModel model)
        {
            InitializeComponent();
            _model = model;

            FillControlsByModel();

            _availableMaintenanceTypes = new List<IdNameModel>();
            LoadAvailableMaintenanceTypesAsync();
        }

        public EditJournalForm()
        {
        }

        private async void EditJournalForm_Load(object sender, EventArgs e)
        {
            _model = await GetJournalPostModelAsync(urlGetJournal, _journalId);

            FillControlsByModel();
            await FillComboBoxWithFishTanks();
        }

        private void FillControlsByModel()
        {
            if (_model != null)
            {
                txtName.Text = _model.Name;
                txtDescription.Text = _model.Description;
                dateTimePicker1.Text = _model.DateTime?.ToString() ?? "";
                listBoxSelected.Items.Clear();

                if (_model.MaintenanceTypeIntIDs != null && _model.MaintenanceTypeIntIDs.Any())
                {
                    var maintenanceTypeInts = _model.MaintenanceTypeIntIDs.Split(',');

                    var selectedMaintenanceTypes = new List<IdNameModel>();

                    foreach (var maintenanceTypeInt in maintenanceTypeInts)
                    {
                        var selectedMaintenanceType = _availableMaintenanceTypes.SingleOrDefault(t => t.ID == int.Parse(maintenanceTypeInt));
                        if (selectedMaintenanceType != null)
                        {
                            selectedMaintenanceTypes.Add(selectedMaintenanceType);
                        }
                    }

                    UpdateListBoxDataSource(listBoxSelected, selectedMaintenanceTypes);
                }
            }
        }

        private void UpdateListBoxDataSource(ListBox listBox, List<IdNameModel> list)
        {
            listBox.DataSource = null;
            listBox.DataSource = new BindingList<IdNameModel>(list);
            listBox.DisplayMember = "Name";
            listBox.ValueMember = "ID";
        }

        private async Task LoadAvailableMaintenanceTypesAsync()
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    var response = await httpClient.GetAsync(urlMtGetAllShort);
                    if (response.IsSuccessStatusCode)
                    {
                        var jsonString = await response.Content.ReadAsStringAsync();
                        if (!string.IsNullOrEmpty(jsonString))
                        {
                            _availableMaintenanceTypes = JsonConvert.DeserializeObject<List<IdNameModel>>(jsonString);
                        }

                        listBoxAvailable.Items.Clear();
                        foreach (var maintenanceType in _availableMaintenanceTypes)
                        {
                            listBoxAvailable.Items.Add(maintenanceType.Name);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при загрузке данных о доступных типах обслуживания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task FillComboBoxWithFishTanks()
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(urlGetAllShort);

                    if (response.IsSuccessStatusCode)
                    {
                        var fishTanks = await response.Content.ReadFromJsonAsync<List<FishTankBaseModel>>();
                        comboBoxSelectAquarium.DataSource = fishTanks;
                        comboBoxSelectAquarium.DisplayMember = "Name";
                        comboBoxSelectAquarium.ValueMember = "ID";
                    }
                    else
                    {
                        MessageBox.Show($"Ошибка получения данных: {response.ReasonPhrase}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Исключение при запросе: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task<JournalPostModel?> GetJournalPostModelAsync(string apiBaseUrl, int id)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync($"{apiBaseUrl}?id={id}");
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<JournalPostModel>(json);

                        return data;
                    }
                    else
                    {
                        MessageBox.Show("Ошибка при выполнении запроса.");

                        return null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);

                    return null;
                }
            }
        }

    }


}
