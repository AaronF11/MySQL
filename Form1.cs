using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MySQL
{
    public partial class DlgDataBase : Form
    {
        DBConnection conn = new DBConnection();
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public DlgDataBase()
        {
            InitializeComponent();
            conn.Connect();
        }

        private void BtnConectar_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Connection.Open();
                cmd = new MySqlCommand("Select * From datos", conn.Connection);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                DtgDatos.DataSource = dt.DefaultView;
                conn.Connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sigo trabjando en eso UwU");
        }
    }
}
