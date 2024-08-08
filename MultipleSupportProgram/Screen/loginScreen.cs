using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleSupportProgram.Screen
{
    public partial class loginScreen : Form
    {
        
        int passwordBaseNumberInt;
        int passwordNumber ;
        public loginScreen()
        {
            InitializeComponent();
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {   Random random = new Random();
            passwordBaseNumberInt = random.Next(10000, 99999);
            lblpasswordBaseNumber.Text = passwordBaseNumberInt.ToString();

            
            passwordNumber = (((passwordBaseNumberInt * 7) % 100000) * 41) % 100000;
            while (passwordNumber < 10000)
            {
                passwordNumber *= 10;
            }
            


            
            
            

        }
        private void BtnGirisYap_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbPassword.Text) == passwordNumber
                //debug esnasında kolay erişim için aşağıdaki satırı etkinleştirin 
                //debug sonrası pasif duruma çekmeyi unutmayınız
                // || Convert.ToInt32(tbPassword.Text) == 1  
                )
            {   this.Hide();
                Application.DoEvents();

                MainForm mainForm = new MainForm();
                mainForm.ShowDialog();}
        }

        private void btnKodKopyala_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lblpasswordBaseNumber.Text);
        }
    }
}
