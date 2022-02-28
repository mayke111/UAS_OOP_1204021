using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UAS_OOP_1204021
{
    public partial class FormViewMahasiswa : Form
    {
        public FormViewMahasiswa()
        {
            InitializeComponent();
        }
        private SqlConnection conn;
        private SqlCommand cmd1;
        private SqlDataAdapter DataAdapter;
        private DataSet DataSet;
        private void FormViewMahasiswa_Load(object sender, EventArgs e)
        {
            string constr = @"Data Source=DESKTOP-8FP6M3O\MAYKESQL;Initial Catalog=UAS;Integrated Security=True";
            conn = new SqlConnection(constr);
            conn.Open();
            cmd1 = new SqlCommand();
            cmd1.Connection = conn;
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "select * from ms_mhs";
            DataSet = new DataSet();
            DataAdapter = new SqlDataAdapter(cmd1);
            DataAdapter.Fill(DataSet, "ms_mhs");
            dgMhs.DataSource = DataSet;
            dgMhs.DataMember = "ms_mhs";
            dgMhs.Refresh();
            conn.Close();
        }
    }
}
