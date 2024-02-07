using ClientAquariumApp.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientAquariumApp
{
    public partial class AddMaintenanceTypeForm : Form
    {
        private const string urlMaintenanceType = "http://localhost:5238/api/MaintenanceType/AddNewType";

        public AddMaintenanceTypeForm()
        {
            InitializeComponent();
        }

        private async void addTypeButton_Click(object sender, EventArgs e)
        {
            string name = textBoxNameType.Text;
            string description = richTextBoxDescription.Text;

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(description))
            {
                MessageBox.Show("Введите название типа обслуживания");
                return;
            }
            var newType = new IdNameModel
            {
                Name = name,
                Description = description
            };

            try
            {
                bool succes = await AddMeintenanceType(newType);
                if (succes)
                {
                    MessageBox.Show("Новый тип обслуживания успешно добавлен!");
                    ClearForm();
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении нового типа обслуживания.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");

            }
        }

        private void ClearForm()
        {
            textBoxNameType.Text = "";
            richTextBoxDescription.Text = "";
        }

        private async Task<bool> AddMeintenanceType(IdNameModel newType)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlMaintenanceType);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                string json = JsonConvert.SerializeObject(newType);
                var content = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync(urlMaintenanceType, content);
                return response.IsSuccessStatusCode;
            }
        }
    }
}
