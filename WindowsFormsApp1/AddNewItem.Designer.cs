namespace WindowsFormsApp1.Inventory_Folder
{
    partial class frm_AddNewItem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label itemIDLabel;
            System.Windows.Forms.Label itemNameLabel;
            System.Windows.Forms.Label categoryLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label conditionLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label datePurchasedLabel;
            System.Windows.Forms.Label serialNoLabel;
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label costLabel;
            System.Windows.Forms.Label imageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AddNewItem));
            this.btn_SaveItem = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tblEquipmentItemsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.tblEquipmentItemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.equipmentItemDBDataSet = new WindowsFormsApp1.EquipmentItemDBDataSet();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tblEquipmentItemsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.tb_ItemID = new System.Windows.Forms.TextBox();
            this.tb_ItemName = new System.Windows.Forms.TextBox();
            this.cb_Category = new System.Windows.Forms.ComboBox();
            this.tblCategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_Description = new System.Windows.Forms.TextBox();
            this.cb_Condition = new System.Windows.Forms.ComboBox();
            this.cb_Status = new System.Windows.Forms.ComboBox();
            this.dateTP_DatePurchased = new System.Windows.Forms.DateTimePicker();
            this.tb_SerialNumber = new System.Windows.Forms.TextBox();
            this.NumUD_Quantity = new System.Windows.Forms.NumericUpDown();
            this.tb_Cost = new System.Windows.Forms.TextBox();
            this.btn_BrowseImage = new System.Windows.Forms.Button();
            this.btn_AddCategory = new System.Windows.Forms.Button();
            this.pb_Image = new System.Windows.Forms.PictureBox();
            this.tblEquipmentItemsTableAdapter = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TblEquipmentItemsTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TableAdapterManager();
            this.tblCategoryTableAdapter = new WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TblCategoryTableAdapter();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            itemIDLabel = new System.Windows.Forms.Label();
            itemNameLabel = new System.Windows.Forms.Label();
            categoryLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            conditionLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            datePurchasedLabel = new System.Windows.Forms.Label();
            serialNoLabel = new System.Windows.Forms.Label();
            quantityLabel = new System.Windows.Forms.Label();
            costLabel = new System.Windows.Forms.Label();
            imageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentItemsBindingNavigator)).BeginInit();
            this.tblEquipmentItemsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentItemsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // itemIDLabel
            // 
            itemIDLabel.AutoSize = true;
            itemIDLabel.Location = new System.Drawing.Point(76, 84);
            itemIDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            itemIDLabel.Name = "itemIDLabel";
            itemIDLabel.Size = new System.Drawing.Size(44, 13);
            itemIDLabel.TabIndex = 9;
            itemIDLabel.Text = "Item ID:";
            // 
            // itemNameLabel
            // 
            itemNameLabel.AutoSize = true;
            itemNameLabel.Location = new System.Drawing.Point(58, 112);
            itemNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            itemNameLabel.Name = "itemNameLabel";
            itemNameLabel.Size = new System.Drawing.Size(61, 13);
            itemNameLabel.TabIndex = 10;
            itemNameLabel.Text = "Item Name:";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Location = new System.Drawing.Point(65, 145);
            categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new System.Drawing.Size(52, 13);
            categoryLabel.TabIndex = 11;
            categoryLabel.Text = "Category:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(56, 180);
            descriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 12;
            descriptionLabel.Text = "Description:";
            // 
            // conditionLabel
            // 
            conditionLabel.AutoSize = true;
            conditionLabel.Location = new System.Drawing.Point(64, 258);
            conditionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            conditionLabel.Name = "conditionLabel";
            conditionLabel.Size = new System.Drawing.Size(54, 13);
            conditionLabel.TabIndex = 13;
            conditionLabel.Text = "Condition:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(79, 290);
            statusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 14;
            statusLabel.Text = "Status:";
            // 
            // datePurchasedLabel
            // 
            datePurchasedLabel.AutoSize = true;
            datePurchasedLabel.Location = new System.Drawing.Point(355, 83);
            datePurchasedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            datePurchasedLabel.Name = "datePurchasedLabel";
            datePurchasedLabel.Size = new System.Drawing.Size(87, 13);
            datePurchasedLabel.TabIndex = 15;
            datePurchasedLabel.Text = "Date Purchased:";
            // 
            // serialNoLabel
            // 
            serialNoLabel.AutoSize = true;
            serialNoLabel.Location = new System.Drawing.Point(389, 116);
            serialNoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            serialNoLabel.Name = "serialNoLabel";
            serialNoLabel.Size = new System.Drawing.Size(53, 13);
            serialNoLabel.TabIndex = 17;
            serialNoLabel.Text = "Serial No:";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(393, 143);
            quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(49, 13);
            quantityLabel.TabIndex = 19;
            quantityLabel.Text = "Quantity:";
            // 
            // costLabel
            // 
            costLabel.AutoSize = true;
            costLabel.Location = new System.Drawing.Point(411, 173);
            costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            costLabel.Name = "costLabel";
            costLabel.Size = new System.Drawing.Size(31, 13);
            costLabel.TabIndex = 21;
            costLabel.Text = "Cost:";
            // 
            // imageLabel
            // 
            imageLabel.AutoSize = true;
            imageLabel.Location = new System.Drawing.Point(403, 199);
            imageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            imageLabel.Name = "imageLabel";
            imageLabel.Size = new System.Drawing.Size(39, 13);
            imageLabel.TabIndex = 23;
            imageLabel.Text = "Image:";
            // 
            // btn_SaveItem
            // 
            this.btn_SaveItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(223)))), ((int)(((byte)(177)))));
            this.btn_SaveItem.FlatAppearance.BorderSize = 0;
            this.btn_SaveItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveItem.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveItem.Location = new System.Drawing.Point(446, 347);
            this.btn_SaveItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_SaveItem.Name = "btn_SaveItem";
            this.btn_SaveItem.Size = new System.Drawing.Size(92, 26);
            this.btn_SaveItem.TabIndex = 4;
            this.btn_SaveItem.Text = "Save Item";
            this.btn_SaveItem.UseVisualStyleBackColor = false;
            this.btn_SaveItem.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(223)))), ((int)(((byte)(177)))));
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI Symbol", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(557, 347);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(92, 26);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(38, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tblEquipmentItemsBindingNavigator
            // 
            this.tblEquipmentItemsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tblEquipmentItemsBindingNavigator.BindingSource = this.tblEquipmentItemsBindingSource;
            this.tblEquipmentItemsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tblEquipmentItemsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tblEquipmentItemsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tblEquipmentItemsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tblEquipmentItemsBindingNavigatorSaveItem,
            this.toolStripDropDownButton1});
            this.tblEquipmentItemsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tblEquipmentItemsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tblEquipmentItemsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tblEquipmentItemsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tblEquipmentItemsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tblEquipmentItemsBindingNavigator.Name = "tblEquipmentItemsBindingNavigator";
            this.tblEquipmentItemsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tblEquipmentItemsBindingNavigator.Size = new System.Drawing.Size(683, 27);
            this.tblEquipmentItemsBindingNavigator.TabIndex = 9;
            this.tblEquipmentItemsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // tblEquipmentItemsBindingSource
            // 
            this.tblEquipmentItemsBindingSource.DataMember = "TblEquipmentItems";
            this.tblEquipmentItemsBindingSource.DataSource = this.equipmentItemDBDataSet;
            // 
            // equipmentItemDBDataSet
            // 
            this.equipmentItemDBDataSet.DataSetName = "EquipmentItemDBDataSet";
            this.equipmentItemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // tblEquipmentItemsBindingNavigatorSaveItem
            // 
            this.tblEquipmentItemsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tblEquipmentItemsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tblEquipmentItemsBindingNavigatorSaveItem.Image")));
            this.tblEquipmentItemsBindingNavigatorSaveItem.Name = "tblEquipmentItemsBindingNavigatorSaveItem";
            this.tblEquipmentItemsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.tblEquipmentItemsBindingNavigatorSaveItem.Text = "Save Data";
            this.tblEquipmentItemsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tblEquipmentItemsBindingNavigatorSaveItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(33, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // tb_ItemID
            // 
            this.tb_ItemID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "ItemID", true));
            this.tb_ItemID.Location = new System.Drawing.Point(122, 82);
            this.tb_ItemID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ItemID.Name = "tb_ItemID";
            this.tb_ItemID.Size = new System.Drawing.Size(190, 20);
            this.tb_ItemID.TabIndex = 10;
            // 
            // tb_ItemName
            // 
            this.tb_ItemName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "ItemName", true));
            this.tb_ItemName.Location = new System.Drawing.Point(122, 110);
            this.tb_ItemName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_ItemName.Name = "tb_ItemName";
            this.tb_ItemName.Size = new System.Drawing.Size(190, 20);
            this.tb_ItemName.TabIndex = 11;
            // 
            // cb_Category
            // 
            this.cb_Category.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Category", true));
            this.cb_Category.DataSource = this.tblCategoryBindingSource;
            this.cb_Category.DisplayMember = "Category";
            this.cb_Category.FormattingEnabled = true;
            this.cb_Category.Location = new System.Drawing.Point(122, 142);
            this.cb_Category.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Category.Name = "cb_Category";
            this.cb_Category.Size = new System.Drawing.Size(190, 21);
            this.cb_Category.TabIndex = 12;
            // 
            // tblCategoryBindingSource
            // 
            this.tblCategoryBindingSource.DataMember = "TblCategory";
            this.tblCategoryBindingSource.DataSource = this.equipmentItemDBDataSet;
            // 
            // tb_Description
            // 
            this.tb_Description.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Description", true));
            this.tb_Description.Location = new System.Drawing.Point(122, 177);
            this.tb_Description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Description.Multiline = true;
            this.tb_Description.Name = "tb_Description";
            this.tb_Description.Size = new System.Drawing.Size(190, 71);
            this.tb_Description.TabIndex = 13;
            // 
            // cb_Condition
            // 
            this.cb_Condition.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Condition", true));
            this.cb_Condition.FormattingEnabled = true;
            this.cb_Condition.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Damaged"});
            this.cb_Condition.Location = new System.Drawing.Point(122, 256);
            this.cb_Condition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Condition.Name = "cb_Condition";
            this.cb_Condition.Size = new System.Drawing.Size(190, 21);
            this.cb_Condition.TabIndex = 14;
            // 
            // cb_Status
            // 
            this.cb_Status.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Status", true));
            this.cb_Status.FormattingEnabled = true;
            this.cb_Status.Items.AddRange(new object[] {
            "Available",
            "Checked Out",
            "Under Maintenance"});
            this.cb_Status.Location = new System.Drawing.Point(122, 288);
            this.cb_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Status.Name = "cb_Status";
            this.cb_Status.Size = new System.Drawing.Size(190, 21);
            this.cb_Status.TabIndex = 15;
            // 
            // dateTP_DatePurchased
            // 
            this.dateTP_DatePurchased.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblEquipmentItemsBindingSource, "DatePurchased", true));
            this.dateTP_DatePurchased.Location = new System.Drawing.Point(449, 83);
            this.dateTP_DatePurchased.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTP_DatePurchased.Name = "dateTP_DatePurchased";
            this.dateTP_DatePurchased.Size = new System.Drawing.Size(189, 20);
            this.dateTP_DatePurchased.TabIndex = 16;
            // 
            // tb_SerialNumber
            // 
            this.tb_SerialNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "SerialNo", true));
            this.tb_SerialNumber.Location = new System.Drawing.Point(449, 113);
            this.tb_SerialNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_SerialNumber.Name = "tb_SerialNumber";
            this.tb_SerialNumber.Size = new System.Drawing.Size(189, 20);
            this.tb_SerialNumber.TabIndex = 18;
            // 
            // NumUD_Quantity
            // 
            this.NumUD_Quantity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tblEquipmentItemsBindingSource, "Quantity", true));
            this.NumUD_Quantity.Location = new System.Drawing.Point(449, 141);
            this.NumUD_Quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NumUD_Quantity.Name = "NumUD_Quantity";
            this.NumUD_Quantity.Size = new System.Drawing.Size(188, 20);
            this.NumUD_Quantity.TabIndex = 20;
            // 
            // tb_Cost
            // 
            this.tb_Cost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tblEquipmentItemsBindingSource, "Cost", true));
            this.tb_Cost.Location = new System.Drawing.Point(448, 170);
            this.tb_Cost.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Cost.Name = "tb_Cost";
            this.tb_Cost.Size = new System.Drawing.Size(189, 20);
            this.tb_Cost.TabIndex = 22;
            // 
            // btn_BrowseImage
            // 
            this.btn_BrowseImage.Location = new System.Drawing.Point(444, 199);
            this.btn_BrowseImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_BrowseImage.Name = "btn_BrowseImage";
            this.btn_BrowseImage.Size = new System.Drawing.Size(70, 19);
            this.btn_BrowseImage.TabIndex = 26;
            this.btn_BrowseImage.Text = "Add Image";
            this.btn_BrowseImage.UseVisualStyleBackColor = true;
            this.btn_BrowseImage.Click += new System.EventHandler(this.btn_BrowseImage_Click);
            // 
            // btn_AddCategory
            // 
            this.btn_AddCategory.BackColor = System.Drawing.SystemColors.Control;
            this.btn_AddCategory.FlatAppearance.BorderSize = 0;
            this.btn_AddCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddCategory.Image = global::WindowsFormsApp1.Properties.Resources.add_icon;
            this.btn_AddCategory.Location = new System.Drawing.Point(317, 143);
            this.btn_AddCategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_AddCategory.Name = "btn_AddCategory";
            this.btn_AddCategory.Size = new System.Drawing.Size(14, 17);
            this.btn_AddCategory.TabIndex = 25;
            this.btn_AddCategory.UseVisualStyleBackColor = false;
            this.btn_AddCategory.Click += new System.EventHandler(this.btn_AddCategory_Click);
            // 
            // pb_Image
            // 
            this.pb_Image.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_Image.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.tblEquipmentItemsBindingSource, "Image", true));
            this.pb_Image.Image = global::WindowsFormsApp1.Properties.Resources.add_icon_1;
            this.pb_Image.Location = new System.Drawing.Point(443, 227);
            this.pb_Image.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_Image.Name = "pb_Image";
            this.pb_Image.Size = new System.Drawing.Size(206, 97);
            this.pb_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_Image.TabIndex = 24;
            this.pb_Image.TabStop = false;
            // 
            // tblEquipmentItemsTableAdapter
            // 
            this.tblEquipmentItemsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TblCategoryTableAdapter = null;
            this.tableAdapterManager.TblEquipmentItemsTableAdapter = this.tblEquipmentItemsTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.EquipmentItemDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tblCategoryTableAdapter
            // 
            this.tblCategoryTableAdapter.ClearBeforeFill = true;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // frm_AddNewItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(683, 396);
            this.Controls.Add(this.btn_BrowseImage);
            this.Controls.Add(this.btn_AddCategory);
            this.Controls.Add(imageLabel);
            this.Controls.Add(this.pb_Image);
            this.Controls.Add(costLabel);
            this.Controls.Add(this.tb_Cost);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.NumUD_Quantity);
            this.Controls.Add(serialNoLabel);
            this.Controls.Add(this.tb_SerialNumber);
            this.Controls.Add(datePurchasedLabel);
            this.Controls.Add(this.dateTP_DatePurchased);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.cb_Status);
            this.Controls.Add(conditionLabel);
            this.Controls.Add(this.cb_Condition);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.tb_Description);
            this.Controls.Add(categoryLabel);
            this.Controls.Add(this.cb_Category);
            this.Controls.Add(itemNameLabel);
            this.Controls.Add(this.tb_ItemName);
            this.Controls.Add(itemIDLabel);
            this.Controls.Add(this.tb_ItemID);
            this.Controls.Add(this.tblEquipmentItemsBindingNavigator);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_SaveItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_AddNewItem";
            this.Text = "Add New Item";
            this.Load += new System.EventHandler(this.frm_AddNewItem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentItemsBindingNavigator)).EndInit();
            this.tblEquipmentItemsBindingNavigator.ResumeLayout(false);
            this.tblEquipmentItemsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblEquipmentItemsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentItemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumUD_Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_SaveItem;
        private System.Windows.Forms.Button btn_Cancel;
        private EquipmentItemDBDataSet equipmentItemDBDataSet;
        private System.Windows.Forms.BindingSource tblEquipmentItemsBindingSource;
        private EquipmentItemDBDataSetTableAdapters.TblEquipmentItemsTableAdapter tblEquipmentItemsTableAdapter;
        private EquipmentItemDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton tblEquipmentItemsBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator tblEquipmentItemsBindingNavigator;
        private System.Windows.Forms.TextBox tb_ItemID;
        private System.Windows.Forms.TextBox tb_ItemName;
        private System.Windows.Forms.ComboBox cb_Category;
        private System.Windows.Forms.TextBox tb_Description;
        private System.Windows.Forms.ComboBox cb_Condition;
        private System.Windows.Forms.ComboBox cb_Status;
        private System.Windows.Forms.DateTimePicker dateTP_DatePurchased;
        private System.Windows.Forms.TextBox tb_SerialNumber;
        private System.Windows.Forms.NumericUpDown NumUD_Quantity;
        private System.Windows.Forms.TextBox tb_Cost;
        private System.Windows.Forms.PictureBox pb_Image;
        private System.Windows.Forms.Button btn_AddCategory;
        private System.Windows.Forms.Button btn_BrowseImage;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.BindingSource tblCategoryBindingSource;
        private EquipmentItemDBDataSetTableAdapters.TblCategoryTableAdapter tblCategoryTableAdapter;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    }
}