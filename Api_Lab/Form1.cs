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
                "fullName",
                "inn", 
                "snils", 
                "email",
                "identityCard"  
            });
            fall_list.SelectedIndex = 0;
        }
        private async void name_znachenia_Click(object sender, EventArgs e)
        {
            if (fall_list.SelectedItem == null)
            {
                MessageBox.Show("Выберите тип данных");
                return;
            }

            string methodName = fall_list.SelectedItem.ToString();
            string baseUrl = "http://192.168.1.200:4444/TransferSimulator/";

            try
            {
                search1.Enabled = false;
                var client = new ApiClient(baseUrl);
                var result = await client.FinddAsync(methodName);

                if (result == null || string.IsNullOrWhiteSpace(result.Value))
                    lblResult.Text = "Ничего не найдено";
                else
                    lblResult.Text = result.Value;
            }
            catch (Exception ex)
            {
                lblResult.Text = "Ошибка: " + ex.Message;
            }
            finally
            {
                search1.Enabled = true;
            }
        }




    }
}
