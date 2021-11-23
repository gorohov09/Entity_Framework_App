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
            MyDbContext context = new MyDbContext();
            var sources = from x in context.Sources
                          select new
                          {
                              Id = x.Id,
                              Name = x.Name,
                              Address = x.Address
                          };

            dataGridViewSource.DataSource = sources.ToList();
        }

        private void FillEmission()
        {
            MyDbContext context = new MyDbContext();
            var emission = from x in context.Emissions
                           select new
                           {
                               Id = x.Id,
                               Name_Source = x.Source.Name,
                               Count = x.Count,
                               Text = x.Text,
                               Date = x.Date
                           };
            dataGridViewEmission.DataSource = emission.ToList();
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
            FormAddSource formAdd = new FormAddSource();

            if (formAdd.ShowDialog() == DialogResult.OK)
            {
                MyDbContext context = new MyDbContext();
                Source source = new Source()
                {
                    Name = formAdd.textBoxAddSource_NameSource.Text,
                    Address = formAdd.textBoxAddSource_AdresSource.Text
                };
                context.Sources.Add(source);
                context.SaveChanges();
                FillSource();
            }
        }

        private void buttonRedactSource_Click(object sender, EventArgs e)
        {
            int index, n, ID_Source;
            string SqlText = "";
            string name, addres;

            n = dataGridViewSource.Rows.Count;
            if (n == 0) return;

            FormRedactSource formRedact = new FormRedactSource();

            index = dataGridViewSource.CurrentRow.Index;
            ID_Source = Convert.ToInt32(dataGridViewSource[0, index].Value.ToString());
            name = dataGridViewSource[1, index].Value.ToString();
            addres = dataGridViewSource[2, index].Value.ToString();

            formRedact.textBoxRedactSource_NameSource.Text = name;
            formRedact.textBoxRedactSource_AdresSource.Text = addres;

            if (formRedact.ShowDialog() == DialogResult.OK)
            {
                MyDbContext context = new MyDbContext();
                var source = context.Sources.SingleOrDefault(x => x.Id == ID_Source);
                if (source != null)
                {
                    source.Name = formRedact.textBoxRedactSource_NameSource.Text;
                    source.Address = formRedact.textBoxRedactSource_AdresSource.Text;
                }
                context.SaveChanges();
                FillSource();
                FillEmission();
            }

        }

        private void buttonDeleteSource_Click(object sender, EventArgs e)
        {
            int index, n, ID_Source;
            string name, addres;

            string SqlText = "";

            n = dataGridViewSource.Rows.Count;

            if (n == 0) return;

            FormDeleteSource formDelete = new FormDeleteSource();

            index = dataGridViewSource.CurrentRow.Index;
            ID_Source = Convert.ToInt32(dataGridViewSource[0, index].Value.ToString());

            name = dataGridViewSource[1, index].Value.ToString();
            addres = dataGridViewSource[2, index].Value.ToString();

            formDelete.FormDeleteSourcelabel2.Text = $"{ID_Source} - {name} - {addres}";

            if (formDelete.ShowDialog() == DialogResult.OK)
            {
                MyDbContext context = new MyDbContext();
                var source = context.Sources.SingleOrDefault(x => x.Id == ID_Source);
                context.Sources.Remove(source);
                context.SaveChanges();
                FillSource();
                FillEmission();
            }
        }

        private void buttonAddEmission_Click(object sender, EventArgs e)
        {
            int index;
            string ID_Source, name, addres;

            FormAddEmission f = new FormAddEmission();

            index = dataGridViewSource.CurrentRow.Index;
            ID_Source = dataGridViewSource[0, index].Value.ToString();
            name = dataGridViewSource[1, index].Value.ToString();
            addres = dataGridViewSource[2, index].Value.ToString();
            f.FormAddEmissionlabel4.Text += $" {name} - {addres}";

            if (f.ShowDialog() == DialogResult.OK)
            {
                string date = RedactDateTime(f.textBoxAddEmission_DateEmission.Text);
                MyDbContext context = new MyDbContext();
                Emission emission = new Emission()
                {
                    SourceId = Convert.ToInt32(ID_Source),
                    Count = Convert.ToInt32(f.textBoxAddEmission_CountEmission.Text),
                    Text = f.textBoxAddEmission_TextEmission.Text,
                    Date = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)
                };
                context.Emissions.Add(emission);
                context.SaveChanges();
                FillEmission();
            }
        }

        private void buttonRedactEmission_Click(object sender, EventArgs e)
        {
            int index, n, ID_Emission;
            string count, text, date;

            n = dataGridViewEmission.Rows.Count;

            if (n == 0) return;

            index = dataGridViewEmission.CurrentRow.Index;
            ID_Emission = Convert.ToInt32(dataGridViewEmission[0, index].Value.ToString());
            count = dataGridViewEmission[2, index].Value.ToString();
            text = dataGridViewEmission[3, index].Value.ToString();
            date = dataGridViewEmission[4, index].Value.ToString();

            FormRedactEmission f = new FormRedactEmission();
            f.FormRedactEmissionlabel4.Text += $" {dataGridViewEmission[1, index].Value.ToString()} - {dataGridViewEmission[2, index].Value.ToString()}";
            f.textBoxRedactEmission_CountEmission.Text = count;
            f.textBoxRedactEmission_TextEmission.Text = text;
            f.textBoxRedactEmission_DateEmission.Text = date;

            if (f.ShowDialog() == DialogResult.OK)
            {
                MyDbContext context = new MyDbContext();
                var emission = context.Emissions.SingleOrDefault(x => x.Id == ID_Emission);
                emission.Count = Convert.ToInt32(f.textBoxRedactEmission_CountEmission.Text);
                emission.Text = f.textBoxRedactEmission_TextEmission.Text;
                date = RedactDateTime(f.textBoxRedactEmission_DateEmission.Text);
                emission.Date = DateTime.ParseExact(date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                context.SaveChanges();
                FillEmission();
            }
        }

        private void buttonDelteEmission_Click(object sender, EventArgs e)
        {
            int index, n, ID_Emission, count;
            string text, date, name_source;

            n = dataGridViewEmission.Rows.Count;
            if (n == 0) return;

            index = dataGridViewEmission.CurrentRow.Index;

            index = dataGridViewEmission.CurrentRow.Index;
            ID_Emission = Convert.ToInt32(dataGridViewEmission[0, index].Value.ToString());
            name_source = dataGridViewEmission[1, index].Value.ToString();
            count = Convert.ToInt32(dataGridViewEmission[2, index].Value.ToString());
            text = dataGridViewEmission[3, index].Value.ToString();
            date = dataGridViewEmission[4, index].Value.ToString();

            FormDeleteEmission f = new FormDeleteEmission();
            f.FormDeleteEmissionlabel3.Text = $"{name_source} - {count} - {text} - {date}";

            if (f.ShowDialog() == DialogResult.OK)
            {
                MyDbContext context = new MyDbContext();
                var emission = context.Emissions.SingleOrDefault(x => x.Id == ID_Emission);
                context.Emissions.Remove(emission);
                context.SaveChanges();
                FillEmission();
            }
        }

        private void buttonMinEmission_Click(object sender, EventArgs e)
        {
            MinEmission f = new MinEmission();

            MyDbContext context = new MyDbContext();
            var min_sources = from s in context.Sources
                              join x in context.Emissions on s.Id equals x.SourceId
                              group new { s, x } by new { s.Id, s.Name }
                              into g
                              select new
                              {
                                  Name_Source = g.Key.Name,
                                  Min_Emission = g.Min(t => t.x.Count)
                              };

            f.dataGridViewMinEmission.DataSource = min_sources.ToList();
            f.ShowDialog();
        }

        private void buttonMaxEmission_Click(object sender, EventArgs e)
        {
            MaxEmission f = new MaxEmission();

            MyDbContext context = new MyDbContext();
            var max_sources = from s in context.Sources
                              join x in context.Emissions on s.Id equals x.SourceId
                              group new { s, x } by new { s.Id, s.Name }
                              into g
                              select new
                              {
                                  Name_Source = g.Key.Name,
                                  Min_Emission = g.Max(t => t.x.Count)
                              };

            f.dataGridViewMaxEmission.DataSource = max_sources.ToList();
            f.ShowDialog();
        }

        private void buttonAvgEmission_Click(object sender, EventArgs e)
        {
            AverageEmission f = new AverageEmission();

            MyDbContext context = new MyDbContext();
            var ave_sources = from s in context.Sources
                              join x in context.Emissions on s.Id equals x.SourceId
                              group new { s, x } by new { s.Id, s.Name }
                              into g
                              select new
                              {
                                  Name_Source = g.Key.Name,
                                  Min_Emission = g.Average(t => t.x.Count)
                              };

            f.dataGridViewAverageEmission.DataSource = ave_sources.ToList();
            f.ShowDialog();
        }
    }
}
