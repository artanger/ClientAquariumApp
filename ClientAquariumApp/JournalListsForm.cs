using ClientAquariumApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ClientAquariumApp
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Windows.Forms;
    using Newtonsoft.Json;

    public partial class JournalListsForm : Form
    {
        private const string urlGetAllShort = "http://localhost:5238/api/Aquarium/GetAllShort";
        private const string urlGetJournalsByFishTankId = "http://localhost:5238/api/Journal/GetJournalsByFishTankId";
        private const string urlSearchJournals = "http://localhost:5238/api/Journal/SearchJournals";
        private const string urlGetbyid = "http://localhost:5238/api/Journal/Getbyid";

        public JournalListsForm()
        {
            InitializeComponent();
        }

        private async void JournalListsForm_Load(object sender, EventArgs e)
        {
            await FillComboBoxWithFishTanks();
        }

        private async void ComboBoxFishTank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxFishTank.Visible || comboBoxFishTank.DataSource == null)
            {
                return;
            }

            var theCombobox = sender as ComboBox;
            if (theCombobox != null)
            {
                int selectedFishTankId = ((FishTankBaseModel)theCombobox.SelectedItem)?.ID ?? 0;
                if (selectedFishTankId != 0)
                {
                    await LoadJournalsByFishTankId(selectedFishTankId);
                }
            }
        }

        private async Task FillComboBoxWithFishTanks()
        {
            try
            {
                comboBoxFishTank.Visible = false;
                comboBoxFishTank.DisplayMember = "Name";
                comboBoxFishTank.ValueMember = "ID";
                comboBoxFishTank.Text = "~Select Aquarium~";
                comboBoxFishTank.DataSource = await GetFishTanks();
                comboBoxFishTank.Visible = true;
            }
            catch (Exception ex)
            {
                ShowError("Error loading fish tanks: " + ex.Message);
            }
        }

        private async Task<List<FishTankBaseModel>> GetFishTanks()
        {
            var fishTanks = new List<FishTankBaseModel>();

            try
            {
                using (var client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync(urlGetAllShort);

                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        fishTanks = JsonConvert.DeserializeObject<List<FishTankBaseModel>>(json);
                    }
                    else
                    {
                        ShowError("Error loading fish tanks");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Error loading fish tanks: " + ex.Message);
            }

            return fishTanks;
        }

        private async Task<List<JournalPostModel>> GetJournalsByFishTankId(int fishTankId)
        {
            List<JournalPostModel> journals = new List<JournalPostModel>();
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{urlGetJournalsByFishTankId}/{fishTankId}");
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    journals = JsonConvert.DeserializeObject<List<JournalPostModel>>(responseBody);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting journals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return journals;
        }

        private async Task LoadJournalsByFishTankId(int fishTankId)
        {
            try
            {
                List<JournalPostModel> journals = await GetJournalsByFishTankId(fishTankId);
                if (journals != null)
                {
                    DisplayJournals(journals);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading journals: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeDataGridViewColumns()
        {
            if (dataGridViewJournals.Columns.Count == 0)
            {
                dataGridViewJournals.Columns.Add("ID", "ID");
                dataGridViewJournals.Columns["ID"].Visible = false;
                dataGridViewJournals.Columns.Add("Name", "Name");
                dataGridViewJournals.Columns.Add("DateTime", "DateTime");
                dataGridViewJournals.Columns.Add("Description", "Description");
                dataGridViewJournals.Columns["Description"].Visible = false;
            }
        }

        private void DisplayJournals(List<JournalPostModel> journals)
        {
            InitializeDataGridViewColumns();
            dataGridViewJournals.Rows.Clear();
            foreach (JournalPostModel journal in journals)
            {
                int rowIndex = dataGridViewJournals.Rows.Add();
                dataGridViewJournals.Rows[rowIndex].Cells["ID"].Value = journal.ID;
                dataGridViewJournals.Rows[rowIndex].Cells["Name"].Value = journal.Name;
                dataGridViewJournals.Rows[rowIndex].Cells["DateTime"].Value = journal.DateTime;
                dataGridViewJournals.Rows[rowIndex].Cells["Description"].Value = journal.Description;
            }
        }

        private async void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime? fromDate = fromDateTimePicker.Value;
                DateTime? toDate = toDateTimePicker.Value;
                string name = textBoxSearchByName.Text;

                using (var httpClient = new HttpClient())
                {
                    string apiUrl = urlSearchJournals + "?";
                    if (fromDate.HasValue)
                        apiUrl += "DateFrom=" + fromDate.Value.ToString("yyyy-MM-dd") + "&";
                    if (toDate.HasValue)
                        apiUrl += "DateTo=" + toDate.Value.ToString("yyyy-MM-dd") + "&";
                    if (!string.IsNullOrEmpty(name))
                        apiUrl += "name=" + name;

                    List<JournalPostModel> journals = await GetJournalsFromApi(httpClient, apiUrl);

                    InitializeDataGridViewColumns();

                    DisplayJournals(journals);
                }
            }
            catch (Exception ex)
            {
                ShowError("Error performing search: " + ex.Message);
            }
        }

        private async Task<List<JournalPostModel>> GetJournalsFromApi(HttpClient httpClient, string apiUrl)
        {
            using (var response = await httpClient.GetAsync(apiUrl))
            {
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<JournalPostModel>>(jsonResponse);
            }
        }

        private async void dataGridViewJournals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var journalId = -1;
                var journalIdValue = dataGridViewJournals.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                if (int.TryParse(journalIdValue, out journalId))
                {
                    try
                    {
                        using (var httpClient = new HttpClient())
                        {
                            var selectedJournal = await GetJournalById(httpClient, journalId);
                            if (selectedJournal != null)
                            {
                                var editForm = new EditJournalForm(journalId);
                                editForm.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("Selected row does not contain journal data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error getting journal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Unable to determine journal ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async Task<JournalPostModel> GetJournalById(HttpClient httpClient, int journalId)
        {
            try
            {
                string apiUrl = $"{urlGetbyid}?id={journalId}";

                var response = await httpClient.GetAsync(apiUrl);
                response.EnsureSuccessStatusCode();

                string jsonResponse = await response.Content.ReadAsStringAsync();
                var journal = JsonConvert.DeserializeObject<JournalPostModel>(jsonResponse);

                return journal;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error getting journal: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

}
