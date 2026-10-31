namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1(string role)
        {
            InitializeComponent();
            userRole = role;
            lblUserRole.Text = $"Роль: {role}";
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
