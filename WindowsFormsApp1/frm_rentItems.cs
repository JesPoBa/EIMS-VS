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

namespace WindowsFormsApp1
{
    public partial class frm_rentItems : Form
    {
        
        
        public frm_rentItems()
        {
            InitializeComponent();
        }

        public void databaseConnection()
        {
            string url = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\Equipment Inventory 10_15_2024\Equipment Inventory 10_12_2024\Equipment Inventory 1\Equipment Inventory\WindowsFormsApp1\EquipmentItemDB.mdf"";Integrated Security=True");
            string transferQuery = "INSERT INTO TblRentItems (ItemID, ItemName, Category, Description, Condition, Status, DatePurchased, SerialNo, Quantity, Cost, Image) SELECT ItemID, ItemName, Category, Description, Condition, Status, DatePurchased, SerialNo, Quantity, Cost, Image FROM TblEquipmentItems";
            
            using (SqlConnection conn = new SqlConnection(url))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(transferQuery, conn);
                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    tblRentItemsBindingSource.EndEdit();
                    tblRentItemsTableAdapter.Update(equipmentItemDBDataSet.TblRentItems);
                    dgv_RentItems.Refresh();
                    MessageBox.Show($"{rowsAffected} rows transferred successfully");
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured: " + ex.Message );
                }
            }
            
        }

        private void frm_rentItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipmentItemDBDataSet.TblRentItems' table. You can move, or remove it, as needed.
            this.tblRentItemsTableAdapter.Fill(this.equipmentItemDBDataSet.TblRentItems);
            // TODO: This line of code loads data into the 'equipmentItemDBDataSet.TblRentItems' table. You can move, or remove it, as needed.
            this.tblRentItemsTableAdapter.Fill(this.equipmentItemDBDataSet.TblRentItems);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            databaseConnection();
        }

        private void cb_ChooseItemName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
