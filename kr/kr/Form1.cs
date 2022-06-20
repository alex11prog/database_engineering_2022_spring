using MySql.Data.MySqlClient;
using NHibernate;
using NHibernate.Cfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kr
{
    public partial class Form1 : Form
    {
        
        private NHibernate.Cfg.Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;
        
        public struct cat
        {
            public int id_cat;
            public string name;
            public string descr;
            public cat(int _id_cat, string _name, string _descr)
            {
                id_cat = _id_cat;
                name = _name;
                descr = _descr;
            }
        }
        List<cat> cats = new List<cat>();

        private void button_load_hibernate_Click(object sender, EventArgs e)
        {
            myConfiguration = new NHibernate.Cfg.Configuration();
            myConfiguration.Configure();
            myConfiguration.AddAssembly(typeof(category).Assembly);
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();
            using (mySession.BeginTransaction())
            {
                ICriteria criteria = mySession.CreateCriteria<category>();
                IList<category> list = criteria.List<category>();
                StringBuilder messageString = new StringBuilder(); 
                cats.Clear();
                foreach (category category in list)
                {
                    cats.Add(new cat(category.id_cat, category.name, category.descr));
                }
            }
            DataTable HB_dt = new DataTable();
            HB_dt.Columns.Add("Идентификатор", typeof(int));
            HB_dt.Columns.Add("Наименование", typeof(string));
            HB_dt.Columns.Add("Описание", typeof(string));
            for (int i = 0; i < cats.Count; i++)
            {
                HB_dt.Rows.Add(cats[i].id_cat, cats[i].name, cats[i].descr);
            }
            dataGridViewHB.DataSource = HB_dt;

        }
        public Form1()
        {
            InitializeComponent();
            this.Text = "Учет бюджета";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pdbDataSet.expenses_operation". При необходимости она может быть перемещена или удалена.
            this.expenses_operationTableAdapter.Fill(this.pdbDataSet.expenses_operation);
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder mysqlCSB;
            mysqlCSB = new MySqlConnectionStringBuilder();
            mysqlCSB.Server = "localhost";
            mysqlCSB.Database = "pdb";
            mysqlCSB.UserID = "root";
            mysqlCSB.Password = "root";
            DataTable dt = new DataTable();

            string queryString = @"select sum(summ) from expenses_operation";
            using (MySqlConnection con = new MySqlConnection())
            {
                con.ConnectionString = mysqlCSB.ConnectionString;
                MySqlCommand com = new MySqlCommand(queryString, con);
                try
                {
                    con.Open();
                    using (MySqlDataReader dr = com.ExecuteReader())
                    {
                        if (dr.HasRows) {
                            dt.Load(dr);
                            label_calc.Text = "Общая сумма расходов: " + dt.Rows[0]["sum(summ)"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                con.Close();
            }
        }
    }
}
