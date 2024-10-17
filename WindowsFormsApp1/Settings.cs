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
    public partial class frm_Settings : Form
    {
        static SqlConnection conn = null;
        static SqlCommand cmd = null;

        public frm_Settings()
        {
            InitializeComponent();
            DatabaseConnection();

        }

        private void DatabaseConnection()
        {
            string url = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\Equipment Inventory 10_15_2024\Equipment Inventory 10_12_2024\Equipment Inventory 1\Equipment Inventory\WindowsFormsApp1\uaDB.mdf"";Integrated Security=True");

            conn = new SqlConnection(url);
        }

        private void frm_Settings_Load(object sender, EventArgs e)
        {
            if(ulog.type == "A")
            {
                adduseradmin.Visible = true;
            }
            else if(ulog.type == "U")
            {
                adduseradmin.Visible= false;
            }
            // TODO: This line of code loads data into the 'appData.tbllog' table. You can move, or remove it, as needed.
            this.tbllogTableAdapter.Fill(this.appData.tbllog);
            Edit(false);

        }

        private void Edit(bool value)
        {
            txt_userName.Enabled = value;
            txt_password.Enabled = value;
            cb_role.Enabled = value;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            try
            {
               
                Edit(true);
                appData.tbllog.AddtbllogRow(appData.tbllog.NewtbllogRow());
                tbllogBindingSource.MoveLast(); 
                txt_userName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Edit(true );
            txt_userName.Focus();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO tbllog VALUES (@Username, @Password, @Role)";
                conn.Open();
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Username", txt_userName.Text);
                cmd.Parameters.AddWithValue("@Password", txt_password.Text);
                cmd.Parameters.AddWithValue("@Role", cb_role.Text);
                int records = cmd.ExecuteNonQuery();
                
              
                Edit(false );
                tbllogBindingSource.EndEdit();
                tbllogTableAdapter.Update(appData.tbllog);
                dgv_adminuser.Refresh();
                txt_userName.Focus();
                MessageBox.Show("Your data has been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                appData.tbllog.RejectChanges();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to delete this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                tbllogBindingSource.RemoveCurrent();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Edit(false);
            tbllogBindingSource.ResetBindings(false);
        }

        private void btn_ChangeProfilePicture_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    pictureBox_ProfilePicture.ImageLocation = imageLocation;
                }
            }
            catch
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_adminuser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
