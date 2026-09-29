using System.Security.Cryptography.X509Certificates;

namespace Api_Lab
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            fall_list.Items.AddRange(new object[]
            {
                "fullName", "inn", "snils", "email"
            });
            fall_list.SelectedIndex = 0;
        }




        private async void name_znachenia_Click(object sender, EventArgs e)
        {
            // 1. Проверка выбора и ввода
            if (fall_list.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип данных");
                return;
            }
            if (string.IsNullOrWhiteSpace(search_znachenia.Text))
            {
                MessageBox.Show("Введите значение");
                return;
            }

            string field = fall_list.SelectedItem.ToString();
            string value = search_znachenia.Text.Trim();
            string baseUrl = "http://prb.sylas.ru/TransferSimulator/";

            try
            {
                search1.Enabled = false;
                var client = new ApiClient(baseUrl);
                var results = await client.FinddAsync(field, value);

                rezults.DataSource = null;
                rezults.DataSource = results;

                if (results.Count == 0)
                {
                    rezults.DataSource = null;
                    rezults.DataSource = new[] { new { Сообщение = "Ничего не найдено" } }.ToList();
                    rezults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                search1.Enabled = true;
            }
        }


    }
}
