using System.Text;
using ClientAquariumApp.ViewModels;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.WinForms;
using Newtonsoft.Json;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.VisualElements;

namespace ClientAquariumApp
{
    public partial class EditAquariumForm : Form
    {
        private FishTankModel _editedFishTank;
        private PieChart pieChart1;
        public EditAquariumForm(FishTankModel fishTank)
        {
            InitializeComponent();
            _editedFishTank = fishTank;

            textBoxName.KeyPress += TextBoxText_KeyPress;
            descriptionTextBox.KeyPress += TextBoxText_KeyPress;


            pieChart1 = new PieChart()
            {
                Size = new System.Drawing.Size(300, 250),
                Title = new LabelVisual
                {
                    Text = "Fish Quantity & Water Level", // Текст заголовка
                    TextSize = 20, // Размер текста
                    Padding = new LiveChartsCore.Drawing.Padding(5), // Отступы
                    Paint = new SolidColorPaint(SKColors.DarkBlue)
                },

            };
            Controls.Add(pieChart1);
            tableLayoutPanel1.Controls.Add(pieChart1, 1, 3);
            DisplayFishTankData();
            DisplayDataInPieChart();
        }

        private void DisplayDataInPieChart()
        {
            if (_editedFishTank != null)
            {
                var series = new ISeries[]
                 {
                    new PieSeries<int>
                    {
                        Values = new [] { _editedFishTank.VolumeOfWater },
                        Name = "VolumeOfWater",
                        Fill = new SolidColorPaint(SKColors.Blue)
                    },
                    new PieSeries<int>
                    {
                        Values = new [] { _editedFishTank.FishCount },
                        Name = "FishCount",
                        Fill = new SolidColorPaint(SKColors.Green)
                    }

                 };
                pieChart1.Series = series;

            }
            else
            {
                var defaultSeries = new ISeries[]
                 {
                    new PieSeries<int>
                    {
                        Values = new [] { 0 },
                        Name = "Нет данных",
                        Fill = new SolidColorPaint(SKColors.Gray)
                    }
                 };

                pieChart1.Series = defaultSeries;
            }
        }

        private void TextBoxText_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;
            }
        }

        private void DisplayFishTankData()
        {
            textBoxName.Text = _editedFishTank.Name;
            descriptionTextBox.Text = _editedFishTank.Description;
            textBoxWidth.Text = _editedFishTank.Width.ToString();
            textBoxHeight.Text = _editedFishTank.Height.ToString();
            textBoxDepth.Text = _editedFishTank.Depth.ToString();
            numericVolumeOfWater.Text = _editedFishTank.VolumeOfWater.ToString();
            numericFishCount.Text = _editedFishTank.FishCount.ToString();
            checkBoxFilters.Checked = _editedFishTank.IsFilters;
            checkBoxHeater.Checked = _editedFishTank.IsHeater;
            checkBoxLightning.Checked = _editedFishTank.IsLightning;
            checkBoxPump.Checked = _editedFishTank.IsPump;

            DisplayDataInPieChart();
        }

        private void UpdateFishTankData()
        {
            _editedFishTank.Name = textBoxName.Text;
            _editedFishTank.Description = descriptionTextBox.Text;

            _editedFishTank.Width = (int)textBoxWidth.Value;
            _editedFishTank.Height = (int)textBoxHeight.Value;
            _editedFishTank.Depth = (int)textBoxDepth.Value;
            _editedFishTank.VolumeOfWater = (int)numericVolumeOfWater.Value;
            _editedFishTank.FishCount = (int)numericFishCount.Value;

            _editedFishTank.IsFilters = checkBoxFilters.Checked;
            _editedFishTank.IsHeater = checkBoxHeater.Checked;
            _editedFishTank.IsLightning = checkBoxLightning.Checked;
            _editedFishTank.IsPump = checkBoxPump.Checked;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            UpdateFishTankData();

            try
            {
                using (var httpClient = new HttpClient())
                {
                    string jsonBody = JsonConvert.SerializeObject(_editedFishTank);
                    var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                    var response = await httpClient.PutAsync("http://localhost:5238/api/Aquarium/EditAquarium", content);

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Аквариум успешно обновлен.", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show($"Не удалось обновить аквариум. Код состояния: {response.StatusCode}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
