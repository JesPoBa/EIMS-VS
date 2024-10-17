using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Data.Common;

namespace WindowsFormsApp1.Inventory_Folder
{
    public partial class frm_AddNewItem : Form
    {
        static SqlConnection conn = null;
        static SqlCommand cmd = null;

        public frm_AddNewItem()
        {
            InitializeComponent();
            DatabaseConnection();
        }

        private void DatabaseConnection()
        {
            string url = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Documents\STI\4th_YR_1st_Semester\Capstone_2\EIMS VS\Equipment Inventory 1\Equipment Inventory\WindowsFormsApp1\EquipmentItemDB.mdf"";Integrated Security=True");

            conn = new SqlConnection(url);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            // Validate Item Name 
            if (string.IsNullOrWhiteSpace(tb_ItemName.Text))
            {
                MessageBox.Show("Item Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ItemName.Focus();
                return;
            }

            // Validate Category 
            if (cb_Category.SelectedIndex == -1)  // Check if no category is selected
            {
                MessageBox.Show("Please select a Category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_Category.Focus();
                return;
            }

            // Validate Quantity (required, and should be greater than zero)
            if (NumUD_Quantity.Value <= 0)
            {
                MessageBox.Show("Quantity should be greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                NumUD_Quantity.Focus();
                return;
            }

            // Validate Status (required, assuming it's a ComboBox)
            if (cb_Status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select the Status.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cb_Status.Focus();
                return;
            }

            // If all validations pass, proceed with saving the item
            // If all validations pass, proceed with saving the item
            SaveNewItem();

        }

        private void SaveNewItem()
        {
            try
            {
                // SQL query to insert data
                string query = "INSERT INTO TblEquipmentItems (ItemID, ItemName, Category, Description, Condition, Status, DatePurchased, SerialNo, Quantity, Cost, Image) " +
                    "VALUES (@ItemID, @ItemName, @Category, @Description, @Condition, @Status, @DatePurchased, @SerialNo, @Quantity, @Cost, @Image)";

                conn.Open();
                cmd = new SqlCommand(query, conn);

                //Add parameters from textboxes
                cmd.Parameters.AddWithValue("@ItemID", tb_ItemID.Text);
                cmd.Parameters.AddWithValue("@ItemName", tb_ItemName.Text);
                cmd.Parameters.AddWithValue("@Category", cb_Category.Text);
                cmd.Parameters.AddWithValue("@Description", tb_Description.Text);
                cmd.Parameters.AddWithValue("@Condition", cb_Condition.Text);

                cmd.Parameters.AddWithValue("@Status", cb_Status.Text);

                cmd.Parameters.AddWithValue("@DatePurchased", dateTP_DatePurchased.Value); // Use Value property instead of Text
                cmd.Parameters.AddWithValue("@SerialNo", tb_SerialNumber.Text); // Use correct textbox for SerialNo.
                cmd.Parameters.AddWithValue("@Quantity", int.Parse(NumUD_Quantity.Text)); // Parse to int
                cmd.Parameters.AddWithValue("@Cost", decimal.Parse(tb_Cost.Text)); // Parse to decimal
                cmd.Parameters.AddWithValue("@Image", ConvertImageToByteArray(pb_Image.Image)); // Convert image to byte array

                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Item added successfully.");
                    }
                    else
                    {
                        MessageBox.Show("No rows affected.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Console.WriteLine("SQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    Console.WriteLine("Error: " + ex.Message);
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Dispose();
                    }
                    frm_InventoryItems inv = new frm_InventoryItems();
                    inv.Refresh();  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        public byte[] ConvertImageToByteArray(Image image)
        {
            using (MemoryStream stream = new MemoryStream())
            {
                image.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }

        private void frm_AddNewItem_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'equipmentItemDBDataSet.TblCategory' table. You can move, or remove it, as needed.
            this.tblCategoryTableAdapter.Fill(this.equipmentItemDBDataSet.TblCategory);

        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tblEquipmentItemsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblEquipmentItemsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.equipmentItemDBDataSet);

        }

        private void btn_AddCategory_Click(object sender, EventArgs e)
        {
            // Create a new instance of the existing Add Category form
            frm_AddCategory addCategoryForm = new frm_AddCategory();
            addCategoryForm.ShowDialog();

            // Refresh the data source of the cb_Category ComboBox
            if (addCategoryForm.CategoryAdded)
            {
                LoadCategories();
                cb_Category.SelectedItem = addCategoryForm.NewCategory;
            }
        }

        private void LoadCategories()
        {
            // Load categories from the database
            string query = "SELECT Category FROM TblCategory";
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            DataTable categories = new DataTable();
            categories.Load(reader);
            reader.Close();
            conn.Close();

            cb_Category.DataSource = categories;
            cb_Category.DisplayMember = "Category";
            cb_Category.ValueMember = "Category";
        }

        private void btn_BrowseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png, *.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            openFileDialog.Title = "Select an Image File";

            if (openFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            pb_Image.Image = Image.FromFile(openFileDialog.FileName);
        }
    }
}
