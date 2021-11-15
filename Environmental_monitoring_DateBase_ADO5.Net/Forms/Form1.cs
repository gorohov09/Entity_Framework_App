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
using Environmental_monitoring_DateBase_ADO5.Net.Forms;

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
            string sqlText = "SELECT Name_Source, Addres, Count_Emission, Text_Emission, Date_Emission " +
                             "FROM Emission " +
                             "JOIN Source ON Emission.ID_Source = Source.ID_Source";
            SqlDataAdapter da = new SqlDataAdapter(sqlText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Emission]");
            dataGridViewEmission.DataSource = ds.Tables["[Emission]"].DefaultView;
        }

        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection con;
            SqlCommand cmd;

            con = new SqlConnection(ConnStr);
            con.Open();
            cmd = con.CreateCommand();
            cmd.CommandText = SqlText;
            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void buttonAddSource_Click(object sender, EventArgs e)
        {
            string SqlText = "";
            FormAddSource formAdd = new FormAddSource();

            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                SqlText = $"INSERT INTO Source VALUES (N'{formAdd.textBoxAddSource_NameSource.Text}', N'{formAdd.textBoxAddSource_AdresSource.Text}')";
                MyExecuteNonQuery(SqlText);
                FillSource();
            }
        }

        private void buttonRedactSource_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "";
            string ID_Source, name, addres;

            n = dataGridViewSource.Rows.Count;
            if (n == 1) return;

            FormRedactSource formRedact = new FormRedactSource();

            index = dataGridViewSource.CurrentRow.Index;
            ID_Source = dataGridViewSource[0, index].Value.ToString();
            name = dataGridViewSource[1, index].Value.ToString();
            addres = dataGridViewSource[2, index].Value.ToString();

            formRedact.textBoxRedactSource_NameSource.Text = name;
            formRedact.textBoxRedactSource_AdresSource.Text = addres;

            if (formRedact.ShowDialog() == DialogResult.OK)
            {
                SqlText = "UPDATE Source SET " +
                    $"Name_Source = N'{formRedact.textBoxRedactSource_NameSource.Text}', Addres = N'{formRedact.textBoxRedactSource_AdresSource.Text}' " +
                    $"WHERE ID_Source = {ID_Source}";
                MyExecuteNonQuery(SqlText);
                FillSource();
            }

        }

        private void buttonDeleteSource_Click(object sender, EventArgs e)
        {
            int index, n;
            string ID_Source;
            string name, addres;

            string SqlText = "";

            n = dataGridViewSource.Rows.Count;

            if (n == 1) return;

            FormDeleteSource formDelete = new FormDeleteSource();

            index = dataGridViewSource.CurrentRow.Index;
            ID_Source = dataGridViewSource[0, index].Value.ToString();

            SqlText = $"DELETE FROM Source " +
                      $"WHERE ID_Source = {ID_Source}";

            name = dataGridViewSource[1, index].Value.ToString();
            addres = dataGridViewSource[2, index].Value.ToString();

            formDelete.FormDeleteSourcelabel2.Text = $"{ID_Source} - {name} - {addres}";

            if (formDelete.ShowDialog() == DialogResult.OK)
            {
                MyExecuteNonQuery(SqlText);
                FillSource();
            }
        }
    }
}
