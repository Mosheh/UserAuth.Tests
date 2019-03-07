using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAuth.Domain;
using UserAuth.Infra;
using UserAuth.Servicee;

namespace UserAuth.Win.UI
{
    public partial class Form1 : Form
    {
        private IUserService _userService;

        public Form1()
        {
            InitializeComponent();

            _userService = new UserService();

            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User(textBoxName.Text);
                user.Email = textBoxEmail.Text;
                user.SetPassword(textBoxPasswd.Text, textBoxConformPasswd.Text);
                _userService.Add(user);
                MessageBox.Show("User was save");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
