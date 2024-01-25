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
    public partial class DashboardAquariums : Form
    {
        const string apiGetAllAquariumsUrl = "http://localhost:5238/api/Aquarium/GetAllAquariums";        

        bool isFirstLoaded = false;

        public DashboardAquariums()
        {
            InitializeComponent();
        }

        #region Events

        private void DashboardAquariums_Load(object sender, EventArgs e)
        {
            UpdateAquariumsGrid();
            isFirstLoaded = true;
        }

        private void DashboardAquariums_Activated(object sender, EventArgs e)
        {
            if (isFirstLoaded)
            {
                isFirstLoaded = false;
            }
            else
            {
                UpdateAquariumsGrid();
            }
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                if (selectedRow.DataBoundItem is FishTankGridModel selectedFishTank)
                {
                    var aquariumId = selectedFishTank.ID.HasValue
                        ? selectedFishTank.ID.Value.ToString()
                        : "0";

                    string apiUrl = $"http://localhost:5238/api/Aquarium/Getbyid?id={aquariumId}";

                    var fishTankModel = await FetchFishTankModelAsync(apiUrl);
                    if (fishTankModel != null)
                    {
                        using (EditAquariumForm modalForm = new EditAquariumForm(fishTankModel))
                        {
                            if (modalForm.ShowDialog() == DialogResult.OK)
                            {
                                await RefreshDataGridViewData();
                            }

                        }
                    }
                }
            }
        }

        #endregion Events

        #region Privates

        //private void SetFocusOnRow(int rowIndex, Color color)
        //{
        //    if (dataGridView1.Rows.Count > rowIndex)
        //    {
        //        dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[0];
        //        dataGridView1.Rows[rowIndex].Selected = true;

        //        foreach (DataGridViewCell cell in dataGridView1.Rows[rowIndex].Cells)
        //        {
        //            cell.Style.BackColor = color;
        //        }
        //    }
        //}

        private void SetFocusOnRow(int rowIndex, Color color)
        {
            //// Сохранение индексов выделенных строк
            //var selectedRowIndices = dataGridView1.SelectedRows
            //                           .Cast<DataGridViewRow>()
            //                           .Select(row => row.Index)
            //                           .ToList();

            //// Проверка и установка фокуса на строку
            //if (dataGridView1.Rows.Count > rowIndex)
            //{
            //    dataGridView1.CurrentCell = dataGridView1.Rows[rowIndex].Cells[0];
            //    dataGridView1.Rows[rowIndex].Selected = true;

            //    // Изменение цвета фона выбранной строки
            //    foreach (DataGridViewCell cell in dataGridView1.Rows[rowIndex].Cells)
            //    {
            //        cell.Style.BackColor = color;
            //    }
            //}

            //// Восстановление выделения строк
            //foreach (int index in selectedRowIndices)
            //{
            //    if (index >= 0 && index < dataGridView1.Rows.Count)
            //    {
            //        dataGridView1.Rows[index].Selected = true;
            //    }
            //}
            if (dataGridView1.Rows.Count > rowIndex)
            {
                dataGridView1.Rows[rowIndex].Selected = true;
            }
        }

        private void SetDataForAquariumsGridView(FishTankGridModel[] data)
        {
            dataGridView1.DataSource = data;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.Columns["Name"].DisplayIndex = 0;
        }

        private async Task RefreshDataGridViewData()
        {
            int selectedRowIndex = -1;

            if (dataGridView1.CurrentCell != null)
            {
                selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
            }

            UpdateAquariumsGrid();

            SetFocusOnRow(selectedRowIndex, Color.BlueViolet);
        }

        private async Task<FishTankModel?> FetchFishTankModelAsync(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<FishTankModel>(json);

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

        private async void UpdateAquariumsGrid()
        {
            var data = await GetFishTankGridModel(apiGetAllAquariumsUrl);
            if (data != null)
            {
                SetDataForAquariumsGridView(data);
            }
        }

        private async Task<FishTankGridModel[]?> GetFishTankGridModel(string apiUrl)
        {
            using (var client = new HttpClient())
            {
                try
                {
                    var response = await client.GetAsync(apiUrl);
                    if (response.IsSuccessStatusCode)
                    {
                        string json = await response.Content.ReadAsStringAsync();
                        var data = JsonConvert.DeserializeObject<FishTankGridModel[]>(json);

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

        #endregion Privates
    }
}