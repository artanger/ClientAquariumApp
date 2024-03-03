using ClientAquariumApp.ViewModels;
using Newtonsoft.Json;
using System.Net.Http;
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
        private const string urlGetJournal = "http://localhost:5238/api/Journal/Getbyid";
        private const string urlEditJournal = "http://localhost:5238/api/Journal/Edit";

        private List<IdNameModel> _availableMaintenanceTypes = new List<IdNameModel>();
        private List<IdNameModel> _selectedMaintenanceTypes = new List<IdNameModel>();

        private JournalPostModel _model;
        private int _journalId;

        public EditJournalForm(JournalPostModel model)
        {
            InitializeComponent();
            _model = model;
            FillControlsByModel();
            LoadAvailableMaintenanceTypesAsync();
        }

        public EditJournalForm(int journalId)
        {
            InitializeComponent();

            _journalId = journalId;
            LoadAvailableMaintenanceTypesAsync();
        }


        private async void EditJournalForm_Load(object sender, EventArgs e)
        {
            if (_journalId != 0)
            {
                _model = await GetJournalPostModelAsync(urlGetJournal, _journalId);
                FillControlsByModel();
            }
            await FillComboBoxWithFishTanks();
            await LoadSelectedMaintenanceTypesAsync();
        }

        private void FillControlsByModel()
        {
            if (_model != null)
            {
                var selectedFishTank = comboBoxSelectAquarium.Items.Cast<FishTankBaseModel>().FirstOrDefault(f => f.ID == _model.FishTankID);
                if (selectedFishTank != null)
                {
                    comboBoxSelectAquarium.SelectedItem = selectedFishTank;
                }
                txtName.Text = _model.Name;
                txtDescription.Text = _model.Description;
                dateTimePicker1.Value = _model.DateTime ?? DateTime.Now;


                if (!string.IsNullOrEmpty(_model.MaintenanceTypeIntIDs))
                {
                    var maintenanceTypeInts = _model.MaintenanceTypeIntIDs.Split(',');
                    foreach (var maintenanceTypeInt in maintenanceTypeInts)
                    {
                        var selectedMaintenanceType = _availableMaintenanceTypes.SingleOrDefault(t => t.ID == int.Parse(maintenanceTypeInt));
                        if (selectedMaintenanceType != null)
                        {
                            _selectedMaintenanceTypes.Add(selectedMaintenanceType);
                        }
                    }

                    UpdateListBoxDataSource(listBoxSelected, _selectedMaintenanceTypes);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MoveItem(listBoxAvailable, _availableMaintenanceTypes, _selectedMaintenanceTypes);
            UpdateListBoxDataSource(listBoxSelected, _selectedMaintenanceTypes);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MoveItem(listBoxSelected, _selectedMaintenanceTypes, _availableMaintenanceTypes);
            UpdateListBoxDataSource(listBoxSelected, _selectedMaintenanceTypes);
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

        private async Task LoadSelectedMaintenanceTypesAsync()
        {
            try
            {
                if (_model != null && !string.IsNullOrEmpty(_model.MaintenanceTypeIntIDs))
                {
                    var maintenanceTypeInts = _model.MaintenanceTypeIntIDs.Split(',');
                    foreach (var maintenanceTypeInt in maintenanceTypeInts)
                    {
                        var selectedMaintenanceType = _availableMaintenanceTypes.SingleOrDefault(t => t.ID == int.Parse(maintenanceTypeInt));
                        if (selectedMaintenanceType != null)
                        {
                            _selectedMaintenanceTypes.Add(selectedMaintenanceType);
                        }
                    }

                    UpdateListBoxDataSource(listBoxSelected, _selectedMaintenanceTypes);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке данных о выбранных типах обслуживания: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task FillComboBoxWithFishTanks()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(urlGetAllShort);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var fishTanks = JsonConvert.DeserializeObject<List<FishTankBaseModel>>(jsonString);
                    comboBoxSelectAquarium.DataSource = fishTanks;
                    comboBoxSelectAquarium.DisplayMember = "Name";
                    comboBoxSelectAquarium.ValueMember = "ID";
                }
                else
                {
                    MessageBox.Show($"Ошибка получения данных: {response.ReasonPhrase}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task<JournalPostModel?> GetJournalPostModelAsync(string urlGetJournal, int id)
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"{urlGetJournal}?id={id}");
                response.EnsureSuccessStatusCode();

                string json = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<JournalPostModel>(json);
                return data;
            }
        }

        private async Task SaveJournalAsync(int journalId)
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var selectedFishTank = comboBoxSelectAquarium.SelectedItem as FishTankBaseModel;
                    int selectedFishTankId = selectedFishTank?.ID ?? 0;

                    var selectedMaintenanceTypeIds = listBoxSelected.Items.Cast<IdNameModel>().Select(mt => mt.ID).ToList();

                    var editedJournal = new JournalPostModel
                    {
                        ID = journalId,
                        FishTankID = selectedFishTankId,
                        Name = txtName.Text,
                        Description = txtDescription.Text,
                        DateTime = dateTimePicker1.Value,
                        MaintenanceTypeIntIDs = string.Join(",", selectedMaintenanceTypeIds)
                    };

                    var response = await client.PutAsJsonAsync(urlEditJournal, editedJournal);
                    response.EnsureSuccessStatusCode();

                    MessageBox.Show("Данные журнала успешно сохранены.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Ошибка HTTP при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при сохранении данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSaveJournal_Click(object sender, EventArgs e)
        {
            await SaveJournalAsync(_journalId);

        }
    }
}
