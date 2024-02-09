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
    public partial class MaintenanceListForm : Form
    {
        private const string getMaintenanceType = "http://localhost:5238/api/MaintenanceType/GetAll";
        public MaintenanceListForm()
        {
            InitializeComponent();            
        }

        private async void MaintenanceListForm_Load(object sender, EventArgs e)
        {            
            await LoadMaintenanceTypes();
            dataGridViewMaintenanceTypes.Columns[0].Visible = false;
        }

        private async Task LoadMaintenanceTypes()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(getMaintenanceType);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(getMaintenanceType);

                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    var maintenanceTypes = JsonConvert.DeserializeObject<List<IdNameModel>>(json);

                    dataGridViewMaintenanceTypes.DataSource = maintenanceTypes;
                }
                else
                {
                    MessageBox.Show("Ошибка при загрузке данных");
                }
            }
        }

        private void dataGridViewMaintenanceTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {          
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {                
                IdNameModel selectedMaintenanceType = (IdNameModel)dataGridViewMaintenanceTypes.Rows[e.RowIndex].DataBoundItem;                
                EditMaintenanceTypeForm editForm = new EditMaintenanceTypeForm(selectedMaintenanceType);               
                editForm.ShowDialog();
            }
        }
    }
}
