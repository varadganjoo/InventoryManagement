namespace InventoryManagement
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        sqlFunctions sqlFunctions = new sqlFunctions();

        private void clear_Click(object sender, EventArgs e) //clear
        {
            usernameBox.Text = "";
            passwordBox.Text = "";
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
                passwordBox.PasswordChar = '\0';
            else
                passwordBox.PasswordChar = '*';
        }

		private void button1_Click(object sender, EventArgs e) //Login
		{
            if (sqlFunctions.login(usernameBox.Text, passwordBox.Text))
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
		}

		private void label6_Click(object sender, EventArgs e)
		{
            Application.Exit();
		}
    }
}