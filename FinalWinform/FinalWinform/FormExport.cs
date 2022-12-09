using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalWinform
{
    public partial class FormExport : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        SqlConnection Conn;
        int tb_DeliveryID;
        public FormExport()
        {
            InitializeComponent();
            Conn = new SqlConnection(strConn);
            Conn.Open();
            label1.Visible = false;
        }

        private void FormExport_Load(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void UpdateTable()
        {
            string sSQL = "SELECT * FROM Deliveries ORDER BY DeliveryDate DESC";
            SqlCommand cmd = new SqlCommand(sSQL, Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridExport.DataSource = dt;
            }
        }

        private void dataGridExport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridExport.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                dataGridExport.CurrentRow.Selected = true;
                tb_DeliveryID = int.Parse(dataGridExport.Rows[e.RowIndex].Cells["DeliveryID"].FormattedValue.ToString());
            }
            label1.Visible = true;
            label1.Text = $"Selected Delivery ID {tb_DeliveryID}";
        }

        private void btn_arrived_Click(object sender, EventArgs e)
        {
            string sSQL = "SELECT DeliveryStatus FROM Deliveries WHERE DeliveryID = '" + tb_DeliveryID + "'";
            SqlCommand cmdCheckDelivey = new SqlCommand(sSQL, Conn);
            SqlDataReader reader = cmdCheckDelivey.ExecuteReader();
            reader.Read();
            if(reader[0].ToString() == "Arrived")
            {
                MessageBox.Show("The export products have arrived");
            }
            else if(reader[0].ToString() == "Arriving")
            {
                reader.Close();
                DialogResult dr = MessageBox.Show($"Are you sure to update {tb_DeliveryID}'s delivery status ","Update delivery status",MessageBoxButtons.YesNo);
                if(dr == DialogResult.Yes)
                {
                    string updateStatus = "UPDATE Deliveries SET DeliveryStatus ='Arrived' WHERE DeliveryID = '" + tb_DeliveryID + "'";
                    string updateAgentStorage = "UPDATE agst SET agst.Quantity = agst.Quantity + deD.Quantity FROM AgentStorage agst INNER JOIN DeliveryDetails deD ON agst.PID = deD.PID WHERE deD.DeliveryID = " + tb_DeliveryID+"";
                    SqlCommand cmdUpdateSatus = new SqlCommand(updateStatus, Conn);
                    SqlCommand cmdUpdateStorage = new SqlCommand(updateAgentStorage, Conn);
                    cmdUpdateSatus.ExecuteNonQuery();
                    cmdUpdateStorage.ExecuteNonQuery();
                    UpdateTable();
                }
            }
        }

        private void btn_paid_Click(object sender, EventArgs e)
        {
            string sSQL = "SELECT PaymentMethod FROM Deliveries WHERE DeliveryID = '" + tb_DeliveryID + "'";
            SqlCommand cmdChecPayment = new SqlCommand(sSQL, Conn);
            SqlDataReader reader = cmdChecPayment.ExecuteReader();
            reader.Read();
            if(reader[0].ToString() != "COD")
            {
                MessageBox.Show($"Agent has paid already by using {reader[0]}");
            }
            else if(reader[0].ToString() == "COD")
            {
                reader.Close();
                DialogResult dr = MessageBox.Show($"Are you sure to update {tb_DeliveryID}'s delivery status ", "Update delivery status", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    string updatePaymentStatus = $"UPDATE Deliveries SET PaymentStatus = 'Paid' WHERE DeliveryID = {tb_DeliveryID} ";
                    SqlCommand updatePaymentStat = new SqlCommand(updatePaymentStatus, Conn);
                    updatePaymentStat.ExecuteNonQuery();
                    UpdateTable();
                }
            }
        }
    }
}
