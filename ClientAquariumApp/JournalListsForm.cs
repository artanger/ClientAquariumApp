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
    public partial class JournalListsForm : Form
    {
        private const string urlGetAllShort = "http://localhost:5238/api/Aquarium/GetAllShort";
        private const string urlGetJournalsByFishTankId = "http://localhost:5238/api/Journal/GetJournalsByFishTankId";
        private const string urlSearchJournals = "http://localhost:5238/api/Journal/SearchJournals";

        private bool isFirstLoaded = false;

        public JournalListsForm()
        {
            InitializeComponent();

        }

        private async void JournalListsForm_Load(object sender, EventArgs e)
        {
            //isFirstLoaded = true;

            FillComboBoxWithFishTanks();

            //isFirstLoaded = false;
        }

        private void ComboBoxFishTank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!comboBoxFishTank.Visible || comboBoxFishTank.DataSource == null)
            {
                return;
            }

            var theCombobox = sender as System.Windows.Forms.ComboBox;
            if (theCombobox != null)
            {
                int selectedFishTankId = ((FishTankBaseModel)theCombobox.SelectedItem)?.ID ?? 0;
                if (selectedFishTankId != 0)
                {
                    LoadJournalsByFishTankId(selectedFishTankId);
                }
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
                ShowError("Произошла ошибка при выполнении поиска: " + ex.Message);
            }
        }

        private async Task FillComboBoxWithFishTanks()
        {
            comboBoxFishTank.Visible = false;
            comboBoxFishTank.DisplayMember = "Name";
            comboBoxFishTank.ValueMember = "ID";
            comboBoxFishTank.Text = "~Select Aquarium~";
            comboBoxFishTank.DataSource = await GetFishTanks();
            comboBoxFishTank.Visible = true;
        }

        //private async Task LoadFishTanks()
        //{
        //    //comboBoxFishTank.Enabled = false;
        //    comboBoxFishTank.Text = "~Select Aquarium~";
        //    // var ttt = GetFiskTanks();
        //    comboBoxFishTank.DataSource = GetFishTanks();
        //    comboBoxFishTank.DisplayMember = "Name";

        //    //comboBoxFishTank.Refresh();
        //    //comboBoxFishTank.Enabled = true;
        //}

        private async Task<List<FishTankBaseModel>> GetFishTanks()
        {
            var fishTanks = new List<FishTankBaseModel>();

            try
            {
                using (var client = new HttpClient())
                {
                    //client.BaseAddress = new Uri(urlGetAllShort);
                    //HttpResponseMessage response = await client.GetAsync("GetAllShort");
                    HttpResponseMessage response = await client.GetAsync(urlGetAllShort);
                    //HttpResponseMessage response = client.GetAsync(urlGetAllShort).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var json = await response.Content.ReadAsStringAsync();
                        //var json = /*await*/ response.Content.ReadAsStringAsync().Result;
                        fishTanks = JsonConvert.DeserializeObject<List<FishTankBaseModel>>(json);
                    }
                    else
                    {
                        ShowError("Ошибка при загрузке аквариумов");
                    }
                }
            }
            catch (Exception ex)
            {
                ShowError("Произошла ошибка при загрузке аквариумов: " + ex.Message);
            }

            return fishTanks;
        }

        private async Task<List<JournalPostModel>> GetJournalsByFishTankId(int fishTankId)
        {
            List<JournalPostModel> journals = null;
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync($"{urlGetJournalsByFishTankId}/{fishTankId}");
                    response.EnsureSuccessStatusCode(); // Убедитесь, что ответ успешен
                    string responseBody = await response.Content.ReadAsStringAsync();
                    journals = JsonConvert.DeserializeObject<List<JournalPostModel>>(responseBody);
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок при выполнении HTTP-запроса или разборе ответа
                MessageBox.Show($"Ошибка при получении журналов: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return journals;
        }

        private async void LoadJournalsByFishTankId(int fishTankId)
        {
            List<JournalPostModel> journals = await GetJournalsByFishTankId(fishTankId);
            if (journals != null)
            {
                DisplayJournals(journals);
            }
        }

        private async Task<List<JournalPostModel>> GetJournalsFromApi(HttpClient httpClient, string apiUrl)
        {
            using (HttpResponseMessage response = await httpClient.GetAsync(apiUrl))
            {
                response.EnsureSuccessStatusCode();
                string jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<JournalPostModel>>(jsonResponse);
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

        private void dataGridViewJournals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var journalId = -1;
                var journalIdValue = dataGridViewJournals.Rows[e.RowIndex].Cells[0].Value.ToString();
                if (int.TryParse(journalIdValue, out journalId))
                {
                    var editForm = new EditJournalForm(journalId);
                    editForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Выбранная строка не содержит данных о журнале.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        //private void dataGridViewJournals_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0 && e.RowIndex < dataGridViewJournals.Rows.Count)
        //    {
        //        try
        //        {
        //            DataGridViewRow selectedRow = dataGridViewJournals.Rows[e.RowIndex];
        //            // Получаем значения ячеек выбранной строки
        //            string? name = selectedRow.Cells["Name"].Value.ToString();
        //            DateTime? dateTime = selectedRow.Cells["DateTime"].Value as DateTime?;
        //            string? description = selectedRow.Cells["Description"].Value.ToString();

        //            // Получаем объект JournalPostModel из DataBoundItem выбранной строки
        //            var selectedJournal = selectedRow?.DataBoundItem as JournalPostModel;

        //            // Проверяем, что объект JournalPostModel не равен null
        //            if (selectedJournal != null)
        //            {
        //                // Создаем новую форму редактирования и передаем выбранный объект JournalPostModel в конструктор
        //                var editJournalForm = new EditJournalForm(selectedJournal, name, dateTime, description);
        //                editJournalForm.Show();
        //            }
        //            else
        //            {
        //                MessageBox.Show("Выбранная строка не содержит данных о журнале.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        catch (Exception ex)
        //        {
        //            ShowError("Произошла ошибка при открытии формы редактирования журнала: " + ex.Message);
        //        }
        //    }
        //}

        private void ShowError(string message)
        {
            MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}