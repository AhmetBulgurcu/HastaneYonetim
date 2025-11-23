using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HastaneYonetim
{
    public partial class GirisForm : Form
    {
        SqlConnection Connection = new SqlConnection("Data Source=DESKTOP-ABCD123;Initial Catalog=HastaneDB;Integrated Security=True");
       // SqlConnection Connection = new SqlConnection("Data Source=DESKTOP-I366MTG\\SQLEXPRESS01;Initial Catalog=HastaneYonetim;Integrated Security=True;Trust Server Certificate=True");
        public GirisForm() => InitializeComponent();

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
