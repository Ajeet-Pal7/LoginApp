namespace LoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(username.Text))
            {
                errInUName.SetError(username,"username can't be empty");
            }else if (String.IsNullOrEmpty(password.Text))
            {
                errInUName.Clear();
                errInPW.SetError(password,"Password can't be empty");
            }
            else if(username.Text == "admin" && password.Text == "password")
            {
                new MainPage(this).Show();
            }else
            {
                errInUName.SetError(username, "Invalid username");
                errInPW.SetError(password, "Invalid password");
            }
        }
    }
}
