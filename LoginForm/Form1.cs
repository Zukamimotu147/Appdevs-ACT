namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Label1_Click(object sender, EventArgs e)
        {
            //AYAW NI I DELETE 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "demo" && txtPassword.Text == "123")
            {
                new Form2().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The Username or Password is incorrect. Try again.");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
