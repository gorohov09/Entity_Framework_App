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
            string sqlText = "SELECT ID_Emission, Name_Source, Addres, Count_Emission, Text_Emission, Date_Emission " +
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

        /// <summary>
        /// Редактирование даты, которую ввел пользователь, для выполнения SQL-скрипта
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public string RedactDateTime(string time)
        {
            //03.12.2002 -> 2002-12-03
            string result = "";
            string[] words = time.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = words.Length - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    result += $"{words[i]}";
                }
                else
                {
                    result += $"{words[i]}-";
                }              
            }

            return result;
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
                FillEmission();
            }
        }

        private void buttonAddEmission_Click(object sender, EventArgs e)
        {
            int index;
            string ID_Source, name, addres;

            string SqlText = "";
            FormAddEmission f = new FormAddEmission();

            index = dataGridViewSource.CurrentRow.Index;
            ID_Source = dataGridViewSource[0, index].Value.ToString();
            name = dataGridViewSource[1, index].Value.ToString();
            addres = dataGridViewSource[2, index].Value.ToString();
            f.FormAddEmissionlabel4.Text += $" {name} - {addres}";

            if (f.ShowDialog() == DialogResult.OK)
            {
                string date = RedactDateTime(f.textBoxAddEmission_DateEmission.Text);
                SqlText = "INSERT INTO Emission VALUES " +
                    $"('{ID_Source}','{f.textBoxAddEmission_CountEmission.Text}', N'{f.textBoxAddEmission_TextEmission.Text}', N'{date}')";
                MyExecuteNonQuery(SqlText);
                FillEmission();
            }
        }

        private void buttonRedactEmission_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText = "";
            string ID_Emission, count, text, date;

            n = dataGridViewEmission.Rows.Count;

            if (n == 1) return;

            index = dataGridViewEmission.CurrentRow.Index;
            ID_Emission = dataGridViewEmission[0, index].Value.ToString();
            count = dataGridViewEmission[3, index].Value.ToString();
            text = dataGridViewEmission[4, index].Value.ToString();
            date = dataGridViewEmission[5, index].Value.ToString();

            FormRedactEmission f = new FormRedactEmission();
            f.FormRedactEmissionlabel4.Text += $" {dataGridViewEmission[1, index].Value.ToString()} - {dataGridViewEmission[2, index].Value.ToString()}";
            f.textBoxRedactEmission_CountEmission.Text = count;
            f.textBoxRedactEmission_TextEmission.Text = text;
            f.textBoxRedactEmission_DateEmission.Text = date;

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = $"UPDATE Emission SET " +
                          $"Count_Emission = '{f.textBoxRedactEmission_CountEmission.Text}', " +
                          $"Text_Emission = N'{f.textBoxRedactEmission_TextEmission.Text}', " +
                          $"Date_Emission = '{RedactDateTime(f.textBoxRedactEmission_DateEmission.Text)}' " +
                          $"WHERE ID_Emission = {ID_Emission}";
                MyExecuteNonQuery(SqlText);
                FillEmission();
            }
        }

        private void buttonDelteEmission_Click(object sender, EventArgs e)
        {
            int index, n;
            string SqlText;
            string ID_Emission, count, text, date, name_source, addres_source;

            n = dataGridViewEmission.Rows.Count;
            if (n == 1) return;

            index = dataGridViewEmission.CurrentRow.Index;

            index = dataGridViewEmission.CurrentRow.Index;
            ID_Emission = dataGridViewEmission[0, index].Value.ToString();
            name_source = dataGridViewEmission[1, index].Value.ToString();
            addres_source = dataGridViewEmission[2, index].Value.ToString();
            count = dataGridViewEmission[3, index].Value.ToString();
            text = dataGridViewEmission[4, index].Value.ToString();
            date = dataGridViewEmission[5, index].Value.ToString();

            FormDeleteEmission f = new FormDeleteEmission();
            f.FormDeleteEmissionlabel3.Text = $"{name_source} - {addres_source} - {count} - {text}";

            if (f.ShowDialog() == DialogResult.OK)
            {
                SqlText = $"DELETE FROM Emission " +
                          $"WHERE ID_Emission = {ID_Emission}";
                MyExecuteNonQuery(SqlText);
                FillEmission();                         
            }
        }
    }
}
