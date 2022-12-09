using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using FontAwesome.Sharp;

namespace FinalWinform
{
    public partial class FormImport : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        SqlConnection Conn;
        bool insertedFirstItem = false;
        string date = DateTime.Now.ToString("M/d/yyyy");
        public FormImport()
        {
            InitializeComponent();
            Conn = new SqlConnection(strConn);
            Conn.Open();
        }

        private void FormImport_Load(object sender, EventArgs e)
        {
            btn_finishImport.Hide();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Products", Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            cmd.ExecuteNonQuery();
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.DisplayMember = "Pname";
            comboBox1.ValueMember = "Pname";
        }

        

        private void btn_newImport_Click(object sender, EventArgs e)
        {
            if(insertedFirstItem == false)
            {
                string sqlImport = "INSERT INTO Imports(ImportDate) VAlUES (@Date)";
                string sqlImportDetail = "INSERT INTO ImportDetails(ImportID,PID,Pname,Quantity,Price) VALUES ((SELECT MAX(ImportID) FROM Imports),(SELECT PID FROM Products WHERE Pname = @Pname),@Pname,@Quantity,(SELECT Price FROM Products WHERE Pname = @Pname))";
                string updateCompanyQuantity = "UPDATE com SET com.Quantity = com.Quantity + impD.Quantity FROM Company com INNER JOIN ImportDetails impD ON com.PID = impD.PID WHERE impD.ImportID = (SELECT MAX(ImportID) FROM Imports)";
                SqlCommand cmdImport = new SqlCommand(sqlImport, Conn);
                SqlCommand cmdImportDetail = new SqlCommand(sqlImportDetail, Conn);
                SqlCommand cmdUpdateCom = new SqlCommand(updateCompanyQuantity, Conn);
                cmdImport.Parameters.AddWithValue("@Date",date);
                cmdImport.ExecuteNonQuery();
                cmdImportDetail.Parameters.AddWithValue("@Pname", comboBox1.SelectedValue.ToString());
                cmdImportDetail.Parameters.AddWithValue("@Quantity", int.Parse(textBox1.Text));
                cmdImportDetail.ExecuteNonQuery();
                cmdUpdateCom.ExecuteNonQuery();
                insertedFirstItem = true;
                MessageBox.Show($"Added {textBox1.Text} {comboBox1.SelectedValue}(s). Press Import if you are done with the current process");
                btn_finishImport.Show();
            }
            else if(insertedFirstItem == true)
            {
                string sqlImportDetail = "INSERT INTO ImportDetails(ImportID,PID,Pname,Quantity,Price) VALUES ((SELECT MAX(ImportID) FROM Imports),(SELECT PID FROM Products WHERE Pname = @Pname),@Pname,@Quantity,(SELECT Price FROM Products WHERE Pname = @Pname))";
                string updateCompanyQuantity = "UPDATE com SET com.Quantity = com.Quantity + impD.Quantity FROM Company com INNER JOIN ImportDetails impD ON com.PID = impD.PID WHERE impD.ImportID = (SELECT MAX(ImportID) FROM Imports)";
                SqlCommand cmdImportDetail = new SqlCommand(sqlImportDetail, Conn);
                SqlCommand cmdUpdateCom = new SqlCommand(updateCompanyQuantity, Conn);
                cmdImportDetail.Parameters.AddWithValue("@Pname", comboBox1.SelectedValue.ToString());
                cmdImportDetail.Parameters.AddWithValue("@Quantity", int.Parse(textBox1.Text));
                cmdImportDetail.ExecuteNonQuery();
                cmdUpdateCom.ExecuteNonQuery();
                MessageBox.Show($"Added {textBox1.Text} {comboBox1.SelectedValue}(s). Press Import if you are done with the current process");
            }
            updateTable();
        }

        private void btn_finishImport_Click(object sender, EventArgs e)
        {
            insertedFirstItem = false;
            MessageBox.Show("Done importing");
            Reset();
        }

       
        private void Reset()
        {
            comboBox1.SelectedItem = null;
            textBox1.Clear();
            label3.Text = "Total Price:";
            dataGridImportDetails.DataSource = null;
            btn_finishImport.Visible = false;
        }

        private void updateTable()
        {
            comboBox1.SelectedItem = null;
            textBox1.Clear();
            string sSql = "SELECT * FROM ImportDetails WHERE ImportID = (SELECT MAX(ImportID) FROM Imports)";
            SqlCommand cmd = new SqlCommand(sSql, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                dataGridImportDetails.DataSource = dt;
            }
            string findTotalStr = "SELECT SUM(Price * Quantity) FROM ImportDetails WHERE ImportID = (SELECT MAX(ImportID) FROM Imports)";
            SqlCommand findTotal = new SqlCommand(findTotalStr, Conn);
            SqlDataReader reader = findTotal.ExecuteReader();
            reader.Read();
            label3.Text = $"Total Price: {reader[0]}$";
            reader.Close();
        }
    }
}
