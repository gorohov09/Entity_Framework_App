using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Environmental_monitoring_DateBase_ADO5.Net
{
    public partial class Form1 : Form
    {
        string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\andre\source\repos\Environmental_monitoring_DateBase_ADO5.Net\Environmental_monitoring_DateBase_ADO5.Net\MyDateBase.mdf;Integrated Security=True";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}
