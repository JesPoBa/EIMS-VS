using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Inventory_Folder;

namespace WindowsFormsApp1
{
    public partial class frm_InventoryItems : Form
    {

        public frm_InventoryItems()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0'Data Source"
                + Application.StartupPath + @"\db");
        }

        private void btn_AddNewItem_Click(object sender, EventArgs e)
        {
            frm_AddNewItem adi = new frm_AddNewItem();
            adi.Show();
        }

        private void frm_InventoryItems_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipmentItemDBDataSet.TblReturnedItems' table. You can move, or remove it, as needed.
            this.tblReturnedItemsTableAdapter.Fill(this.equipmentItemDBDataSet.TblReturnedItems);
            // TODO: This line of code loads data into the 'equipmentItemDBDataSet.TblRentItems' table. You can move, or remove it, as needed.
            this.tblRentItemsTableAdapter.Fill(this.equipmentItemDBDataSet.TblRentItems);
            // TODO: This line of code loads data into the 'equipmentItemDBDataSet.TblEquipmentItems' table. You can move, or remove it, as needed.
            this.tblEquipmentItemsTableAdapter.Fill(this.equipmentItemDBDataSet.TblEquipmentItems);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            dgv_InventoryList.Refresh();
        }

        private void btn_rentItem_Click(object sender, EventArgs e)
        {
            frm_rentItems rentItemForm = new frm_rentItems();
            rentItemForm.Show();
        }
    }
}
