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
    public partial class EditJournalForm : Form
    {
        const string urlGetAllShort = "http://localhost:5238/api/Aquarium/GetAllShort";
        public EditJournalForm()
        {
            InitializeComponent();
        }
        private void EditJournalForm_Load(object sender, EventArgs e)
        {
            FillComboBoxWithFishTanks();
        }

        private async Task FillComboBoxWithFishTanks()
        {
            var fishTanks = await GetFishTanks();
            comboBoxSelectAquarium.DataSource = fishTanks;
            comboBoxSelectAquarium.DisplayMember = "Name";
            comboBoxSelectAquarium.ValueMember = "ID";
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




    }
}
