using Microsoft.Data.SqlClient;
using WinFormsApp1.DataAccess;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            
            InitializeComponent();
            

            DatabaseConnection db = new DatabaseConnection();
            using (SqlConnection connection = db.GetSqlConnection())
            {
                connection.Open();
                MessageBox.Show("Подключеие успешно");

            }
        }

        private string userRole;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            decimal price = decimal.Parse(txtPrice.Text);
            decimal quantity = int.Parse(txtQuantity.Text);

            decimal total = price * quantity;

            lblResult.Text = $"{name}: {total} руб.";

        }
    }
}
