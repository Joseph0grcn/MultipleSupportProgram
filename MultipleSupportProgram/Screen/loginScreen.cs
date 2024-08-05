using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleSupportProgram.Screen
{
    public partial class loginScreen : Form
    {
        bool passwordCheck = false;
        int passwordBaseNumberInt;
        int passwordNumber ;
        public loginScreen()
        {
            InitializeComponent();
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {   Random random = new Random();
            passwordBaseNumber.Text = random.Next(10000, 99999).ToString();
            passwordBaseNumberInt = Convert.ToInt32(passwordBaseNumber.Text);
            // base number ı işleme sok
            //passwordNumber = (passwordBaseNumberInt*3)%10000;
            passwordNumber = passwordBaseNumberInt;

        }
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPassword.Text) == passwordNumber)
            {   this.Hide();
                Application.DoEvents();

                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();}
        }

        
    }
}
