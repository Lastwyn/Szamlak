using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Szamlak
{
    public partial class Form1 : Form
    {
        MySqlConnection connection = null;
        MySqlCommand parancs = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "szamlak";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                parancs = connection.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program leáll");
                Environment.Exit(0);
            }
            finally
            {
                connection.Close();
            }
            szamla_update();
        }
        private void szamla_update()
        {
            listBox1_adatok.Items.Clear();
            parancs.CommandText = "SELECT id, tulajdonosNeve, egyenleg, nyitasdatum FROM szamlak WHERE 1";
            connection.Open();
            using (MySqlDataReader dr = parancs.ExecuteReader())
            {
                while (dr.Read())
                {
                    szamla uj = new szamla(dr.GetInt32("id"), dr.GetString("tulajdonosNeve"), dr.GetDecimal("egyenleg"), dr.GetMySqlDateTime("nyitasdatum"));
                    listBox1_adatok.Items.Add(uj);
                }
            }
            connection.Close();
        }

        private void button1_be_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Adja meg a tulajdonos nevét!");
                textBox2.Focus();
                return;
            }
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Addja meg az egyenleget!");
                textBox3.Focus();
                return;
            }
            parancs.CommandText = "INSERT INTO `szamlak` (`id`, `tulajdonosNeve`, `egyenleg`, `nyitasdatum`) VALUES(NULL, @tulajdonosNeve, @egyenleg, @nyitasdatum);";
            parancs.Parameters.Clear();
            parancs.Parameters.AddWithValue("@tulajdonosNeve", textBox2.Text);
            parancs.Parameters.AddWithValue("@egyenleg", textBox3.Text);
            parancs.Parameters.AddWithValue("@nyitasdatum", dateTimePicker1.Value).ToString();
            try
            {
                connection.Open();
                if (parancs.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Sikeresen rögzítve!");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    dateTimePicker1.Value = dateTimePicker1.Value;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);

            }
            connection.Close();
            szamla_update();
        }
        private bool nincsenek_adatok()
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Nem adott meg tulajdonos nevet!");
                textBox2.Focus();
                return true;
            }           
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Nem adott meg egyenleghet!");
                textBox3.Focus();
                return true;
            }
            return false;
        }
        private void button1_modosit_Click(object sender, EventArgs e)
        {
            if (listBox1_adatok.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölve számla!");
                return;
            }
            szamla kivalasztottszamla = (szamla)listBox1_adatok.SelectedItem;
            parancs.CommandText = "UPDATE szamlak SET tulajdonosNeve = @tulajdonosNeve, egyenleg = @egyenleg, nyitasdatum = @nyitasdatum WHERE id = @id";
            parancs.Parameters.Clear();
            parancs.Parameters.AddWithValue("@id", textBox1.Text);
            parancs.Parameters.AddWithValue("@tulajdonosNeve", textBox2.Text);
            parancs.Parameters.AddWithValue("@egyenleg", textBox3.Text);
            parancs.Parameters.AddWithValue("@nyitasdatum", dateTimePicker1.Value);

            connection.Open();
            if (parancs.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Módosítás sikeres");
                connection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                dateTimePicker1.Value = dateTimePicker1.Value;
                szamla_update();
            }
            else
            {
                MessageBox.Show("Az adatok Módosítása sikertelen!");

            }
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void listBox1_adatok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1_adatok.SelectedIndex < 0)
            {
                return;
            }
            szamla kivalasztottszamla = (szamla)listBox1_adatok.SelectedItem;
            textBox1.Text = kivalasztottszamla.Id.ToString();
            textBox2.Text = kivalasztottszamla.TulajdonosNeve;
            textBox3.Text = kivalasztottszamla.Egyenleg.ToString();
            dateTimePicker1.Value = kivalasztottszamla.Nyitasdatum.GetDateTime();
            
        }

        private void button1_torol_Click(object sender, EventArgs e)
        {
            if (listBox1_adatok.SelectedIndex < 0)
            {
                return;
            }
            parancs.CommandText = "DELETE FROM szamlak WHERE id = @id";
            parancs.Parameters.Clear(); 
            parancs.Parameters.AddWithValue("@id", textBox1.Text);

            connection.Open();
            if (parancs.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("A törlés sikeres!");
                connection.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                dateTimePicker1.Value = dateTimePicker1.Value;
                szamla_update();
            }
            else
            {
                MessageBox.Show("A törlés sikertelen!");
            }
        }
    }
}
