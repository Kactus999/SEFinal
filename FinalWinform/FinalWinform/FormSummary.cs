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
    public partial class FormSummary : Form
    {
        string strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
        SqlConnection Conn;
        public FormSummary()
        {
            InitializeComponent();
            Conn = new SqlConnection(strConn);
            Conn.Open();
            lb_total.Visible = false;
            lb_viewing.Visible = false;
        }

        private void btn_viewImport_Click(object sender, EventArgs e)
        {
            string month = combo_month.SelectedItem.ToString();
            string year = combo_year.SelectedItem.ToString();
            string total;
            if(month == "All")
            {
                string sSQL = $"SELECT ip.ImportID,ipdt.PID,ipdt.Pname,ipdt.Quantity,ipdt.Price FROM Imports ip INNER JOIN ImportDetails ipdt ON ip.ImportID = ipdt.ImportID WHERE YEAR(ImportDate) = {year}";
                string findTotal = $"SELECT SUM(Price * Quantity) FROM Imports ip INNER JOIN ImportDetails ipdt ON ip.ImportID = ipdt.ImportID WHERE YEAR(ImportDate) = {year}";
                SqlCommand cmd = new SqlCommand(sSQL, Conn);
                SqlCommand findTotalCmd = new SqlCommand(findTotal, Conn);
                SqlDataReader reader = findTotalCmd.ExecuteReader();
                reader.Read();
                total = reader[0].ToString();
                reader.Close();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    datagrid_summary.DataSource = dt;
                    lb_viewing.Text = $"Viewing all import of year {year}";
                    lb_viewing.Visible = true;
                    lb_total.Text = $"Total outcome: {total}$";
                    lb_total.Visible = true;
                }
            }
            else if(month != "ALL")
            {
                string sSQL = $"SELECT ip.ImportID,ipdt.PID,ipdt.Pname,ipdt.Quantity,ipdt.Price FROM Imports ip INNER JOIN ImportDetails ipdt ON ip.ImportID = ipdt.ImportID WHERE YEAR(ImportDate) = {year} AND MONTH(ImportDate) = {month}";
                string findTotal = $"SELECT SUM(Price * Quantity) FROM Imports ip INNER JOIN ImportDetails ipdt ON ip.ImportID = ipdt.ImportID WHERE YEAR(ImportDate) = {year} AND MONTH(ImportDate) = {month}";
                SqlCommand cmd = new SqlCommand(sSQL, Conn);
                SqlCommand findTotalCmd = new SqlCommand(findTotal, Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataReader reader = findTotalCmd.ExecuteReader();
                reader.Read();
                total = reader[0].ToString();
                reader.Close();
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    datagrid_summary.DataSource = dt;
                    lb_viewing.Text = $"Viewing import of {month}/{year}";
                    lb_viewing.Visible = true;
                    lb_total.Text = $"Total outcome {month}/{year}: {total}$";
                    lb_total.Visible = true;
                }
                else
                {
                    MessageBox.Show("No data");
                }
            }
        }

        private void btn_viewExport_Click(object sender, EventArgs e)
        {
            string month = combo_month.SelectedItem.ToString();
            string year = combo_year.SelectedItem.ToString();
            string total;
            if (month == "All")
            {
                string sSQL = $"SELECT de.DeliveryID,de.DeliveryDate,de.PaymentStatus,AgentID,Pname,Quantity FROM Deliveries de INNER JOIN DeliveryDetails det ON de.DeliveryID = det.DeliveryID WHERE YEAR(de.DeliveryDate) = {year}";
                string findTotal = $"SELECT SUM(Price * Quantity) FROM Deliveries de INNER JOIN DeliveryDetails det ON de.DeliveryID = det.DeliveryID WHERE YEAR(de.DeliveryDate) = {year} ";
                SqlCommand cmd = new SqlCommand(sSQL, Conn);
                SqlCommand findTotalCmd = new SqlCommand(findTotal, Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataReader reader = findTotalCmd.ExecuteReader();
                reader.Read();
                total = reader[0].ToString();
                reader.Close();
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    datagrid_summary.DataSource = dt;
                    lb_viewing.Text = $"Viewing all export of year {year}";
                    lb_viewing.Visible = true;
                    lb_total.Text = $"Total income: {total}$";
                    lb_total.Visible = true;
                }
                else
                {
                    MessageBox.Show("No data");
                }
            }
            else if(month != "All")
            {
                string sSQL = $"SELECT de.DeliveryID,de.DeliveryDate,de.PaymentStatus,AgentID,Pname,Quantity FROM Deliveries de INNER JOIN DeliveryDetails det ON de.DeliveryID = det.DeliveryID WHERE YEAR(de.DeliveryDate) = {year} AND Month(de.DeliveryDate) = {month}";
                string findTotal = $"SELECT SUM(Price * Quantity) FROM Deliveries de INNER JOIN DeliveryDetails det ON de.DeliveryID = det.DeliveryID WHERE YEAR(de.DeliveryDate) = {year} AND Month(de.DeliveryDate) = {month} ";
                SqlCommand cmd = new SqlCommand(sSQL, Conn);
                SqlCommand findTotalCmd = new SqlCommand(findTotal, Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                SqlDataReader reader = findTotalCmd.ExecuteReader();
                reader.Read();
                total = reader[0].ToString();
                reader.Close();
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    datagrid_summary.DataSource = dt;
                    lb_viewing.Text = $"Viewing export of {month}/{year}";
                    lb_viewing.Visible = true;
                    lb_total.Text = $"Total income {month}/{year}: {total}$";
                    lb_total.Visible = true;
                }
                else
                {
                    MessageBox.Show("No data");
                }
            }
        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            combo_month.SelectedIndex = 0;
            combo_year.SelectedIndex = 0;
        }

        private void btn_BestSelling_Click(object sender, EventArgs e)
        {
            string month = combo_month.SelectedItem.ToString();
            string year = combo_year.SelectedItem.ToString();
            string total;
            if(month == "All")
            {
                string sSQL = $"SELECT Pname,SUM(Quantity) AS TotalSales FROM Deliveries de INNER JOIN DeliveryDetails det ON de.DeliveryID = det.DeliveryID WHERE YEAR(de.DeliveryDate) = {year} GROUP BY Pname,Quantity ORDER BY Quantity DESC";
                SqlCommand cmd = new SqlCommand(sSQL, Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if(dt.Rows.Count > 0)
                {
                    datagrid_summary.DataSource = dt;
                    lb_viewing.Text = $"Viewing best selling products of year {year}";
                    lb_total.Text = "";
                }
                else
                {
                    MessageBox.Show("No data");
                }
            }
            else if(month != "All")
            {
                string sSQL = $"SELECT Pname,SUM(Quantity) AS TotalSales FROM Deliveries de INNER JOIN DeliveryDetails det ON de.DeliveryID = det.DeliveryID WHERE YEAR(de.DeliveryDate) = {year} AND MONTH(de.DeliveryDate) = {month} GROUP BY Pname,Quantity ORDER BY Quantity DESC";
                SqlCommand cmd = new SqlCommand(sSQL, Conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    datagrid_summary.DataSource = dt;
                    lb_viewing.Text = $"Viewing best selling products of {month}/{year}";
                    lb_total.Text = "";
                }
                else
                {
                    MessageBox.Show("No data");
                }

            }
        }
    }
}
