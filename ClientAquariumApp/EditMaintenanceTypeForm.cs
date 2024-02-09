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
    public partial class EditMaintenanceTypeForm : Form
    {
        private const string urlEditMaintenance = "http://localhost:5238/api/MaintenanceType/EditType";
        private IdNameModel maintenanceType;
        public EditMaintenanceTypeForm(IdNameModel maintenanceType)
        {
            InitializeComponent();
            this.maintenanceType = maintenanceType;

            FillFormFields();
        }

        private async void FillFormFields()
        {
            txtBoxEditName.Text = maintenanceType.Name;
            editrichTextBoxDescription.Text = maintenanceType.Description;
        }

        private async void btnEditForm_Click(object sender, EventArgs e)
        {
            await UpdateMeintenanceType();
        }

        private async Task UpdateMeintenanceType()
        {
            string name = txtBoxEditName.Text;
            string description = editrichTextBoxDescription.Text;

            maintenanceType.Name = name;
            maintenanceType.Description = description;
            try
            {
                bool success = await EditMaintenanceType(maintenanceType);
                if (success)
                {
                    MessageBox.Show("Тип обслуживания успешно обновлен!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при обновлении типа обслуживания.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private async Task<bool> EditMaintenanceType(IdNameModel maintenanceType)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlEditMaintenance);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                string json = JsonConvert.SerializeObject(maintenanceType);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PutAsync(urlEditMaintenance, content);

                return response.IsSuccessStatusCode;
            }
        }
    }
}
