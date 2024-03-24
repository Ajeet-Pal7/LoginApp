using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginApp
{
    public partial class MainPage : Form
    {
        Form1 form = new Form1();
        public MainPage(Form1 form)
        {
            InitializeComponent();
            this.form = form;
        }
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            label2.Text = "Your secret code is : " + new Random().GetHashCode();
        }
        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            form.Close();
        }
    }
}
