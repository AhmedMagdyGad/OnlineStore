using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineStore;
public partial class WelcomePageAfterRegistration:Form
{
    public WelcomePageAfterRegistration()
    {
        InitializeComponent();
    }

    private void btn_Login_Click(object sender,EventArgs e)
    {
        this.Hide();
        new LoginPage().Show();
    }
}
