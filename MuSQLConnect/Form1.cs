using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuSQLConnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        String connectionString = null;
        bool isOpen = false;
        MySqlConnection conn = null;
        private void btn_Click(object sender, EventArgs e)
        {
            connectionString = String.Format("server={0};userid={1}" +
                ";password={2};database={3}",textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);

            try
            {
                if(isOpen)
                {
                    conn.Close();
                    // dispose zalecane przy zamykaniu połączenia z bazą
                    conn.Dispose();
                    isOpen = false;
                    btn.Text = "Połącz";
                }
                else
                {
                    conn = new MySqlConnection(connectionString);
                    conn.Open();
                    isOpen = true;
                    btn.Text = "Rozłącz";
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            lvGrid.Items.Clear();
            lvGrid.Columns.Clear();

            try
            {
                MySqlCommand cmd = new MySqlCommand(tbSQL.Text, conn);
                //dobrze uzywać mysqldatareader w contest managera
                using (MySqlDataReader rdr = cmd.ExecuteReader())
                {
                    //pobranie nazw kolumny z sql i dodanie ich do lvgrid
                    for (int i = 0; i < rdr.FieldCount; i++)
                    {
                        lvGrid.Columns.Add(rdr.GetName(i));
                    }

                    //pobranie danych z sql

                    while (rdr.Read())
                    {
                        string[] arr = new string[rdr.FieldCount];//tworzymy tablicę n-elemetową na podsatwie liczby kolumn

                        for (int i = 0; i < rdr.FieldCount; i++)
                        {
                            if(rdr.IsDBNull(i))
                            {
                                arr[i] = "(null)";
                            }
                            arr[i] = rdr.GetString(i);
                        }

                        //wrzucamy dane do lvgrid
                        lvGrid.Items.Add(new ListViewItem(arr));
                    }
                    
                    //pojawił sie bląd odnośnie wartości nullowych więc dodano 
                   //linie  84 - 87
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
