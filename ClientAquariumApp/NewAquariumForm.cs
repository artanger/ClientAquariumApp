using ClientAquariumApp.ViewModels;
using System.Text;
using Newtonsoft.Json;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView.Extensions;

namespace ClientAquariumApp
{
    public partial class NewAquariumForm : Form
    {
        private FishTankModel _fishTankModel;

        public NewAquariumForm()
        {
            InitializeComponent();
            _fishTankModel = new FishTankModel();

            txtBoxAquaName.TextChanged += CheckFieldsFilled;
            richtxtAquaDescription.TextChanged += CheckFieldsFilled;
            numericVolumeOfWater.TextChanged += CheckFieldsFilled;
            numericFishCount.ValueChanged += CheckFieldsFilled;
            button1.Enabled = false;


        }

        private void CheckFieldsFilled(object sender, EventArgs e)
        {
            if (int.TryParse(numericVolumeOfWater.Text, out var volume) && numericFishCount.Value > 0)
            {
                button1.Enabled = !string.IsNullOrEmpty(txtBoxAquaName.Text) && !string.IsNullOrEmpty(richtxtAquaDescription.Text);
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string name = txtBoxAquaName.Text;
            string description = richtxtAquaDescription.Text;

            _fishTankModel.Name = name;
            _fishTankModel.Description = description;
            _fishTankModel.VolumeOfWater = int.Parse(numericVolumeOfWater.Text);
            _fishTankModel.FishCount = int.Parse(numericFishCount.Text);
            _fishTankModel.Width = int.Parse(textBoxWidth.Text);
            _fishTankModel.Height = int.Parse(textBoxHeight.Text);
            _fishTankModel.Depth = int.Parse(textBoxDepth.Text);
            _fishTankModel.IsLightning = checkBox1.Checked;
            _fishTankModel.IsPump = checkBox2.Checked;
            _fishTankModel.IsHeater = checkBox3.Checked;
            _fishTankModel.IsFilters = checkBox4.Checked;

            bool saveSuccess = await SaveDataToServer(_fishTankModel);

            if (saveSuccess)
            {
                MessageBox.Show("Данные успешно сохранены на сервере.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Не удалось сохранить данные на сервере.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private async Task<bool> SaveDataToServer(FishTankModel fishTankModel)
        {
            try
            {
                using (var httpClient = new HttpClient())
                {
                    // Замените "YourApiEndpoint" на реальный URL вашего API
                    string apiUrl = "http://localhost:5238/api/Aquarium/AddAquarium";

                    // Преобразование объекта в JSON
                    string jsonData = JsonConvert.SerializeObject(fishTankModel);

                    // Отправка POST-запроса на сервер
                    var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
                    var response = await httpClient.PostAsync(apiUrl, content);

                    // Обработка ответа сервера
                    if (response.IsSuccessStatusCode)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок при отправке запроса
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


    }
}

