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
            FillSource();
            FillEmission();
        }

        private void FillSource()
        {
            string sqlText = "SELECT * FROM [Source]";
            SqlDataAdapter da = new SqlDataAdapter(sqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Source]");
            dataGridViewSource.DataSource = ds.Tables["[Source]"].DefaultView;
        }

        private void FillEmission()
        {
            string sqlText = "SELECT * " +
                             "FROM Emission " +
                             "JOIN Source ON Emission.ID_Source = Source.ID_Source";
            SqlDataAdapter da = new SqlDataAdapter(sqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Emission]");
            dataGridViewEmission.DataSource = ds.Tables["[Emission]"].DefaultView;
        }

        
    }
}
