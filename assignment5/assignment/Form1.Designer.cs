namespace assignment
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.comboCate = new System.Windows.Forms.ComboBox();
            this.comboItem = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.lblPrice = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btnGotoCart = new System.Windows.Forms.Button();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.txt_address = new System.Windows.Forms.Panel();
            this.datagrideView = new System.Windows.Forms.DataGridView();
            this.colNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUnitP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbi_total_price = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.text_address = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.txt_address.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrideView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(195, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(274, 22);
            this.txtID.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(274, 22);
            this.txtName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Contact No";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(195, 86);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(274, 22);
            this.txtContact.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(195, 190);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(274, 22);
            this.txtEmail.TabIndex = 3;
            // 
            // comboCate
            // 
            this.comboCate.FormattingEnabled = true;
            this.comboCate.Items.AddRange(new object[] {
            "Category1",
            "Category2",
            "Category3",
            "Category4",
            "Category5"});
            this.comboCate.Location = new System.Drawing.Point(195, 228);
            this.comboCate.Name = "comboCate";
            this.comboCate.Size = new System.Drawing.Size(480, 24);
            this.comboCate.TabIndex = 4;
            this.comboCate.SelectedIndexChanged += new System.EventHandler(this.comboCate_SelectedIndexChanged);
            // 
            // comboItem
            // 
            this.comboItem.FormattingEnabled = true;
            this.comboItem.Location = new System.Drawing.Point(195, 274);
            this.comboItem.Name = "comboItem";
            this.comboItem.Size = new System.Drawing.Size(480, 24);
            this.comboItem.TabIndex = 5;
            this.comboItem.SelectedIndexChanged += new System.EventHandler(this.comboItem_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Select the category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 281);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Select the  item";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(53, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Quntity";
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(195, 323);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(112, 22);
            this.txtQty.TabIndex = 6;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(362, 320);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 23);
            this.btn_ok.TabIndex = 7;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(491, 328);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(168, 17);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price for the selected ites";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::assignment.Properties.Resources.Online_Shopping_PNG_Clipart;
            this.pictureBox1.Location = new System.Drawing.Point(512, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(226, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(768, 47);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(107, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(768, 90);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(107, 23);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            // 
            // btnGotoCart
            // 
            this.btnGotoCart.Location = new System.Drawing.Point(768, 146);
            this.btnGotoCart.Name = "btnGotoCart";
            this.btnGotoCart.Size = new System.Drawing.Size(107, 23);
            this.btnGotoCart.TabIndex = 3;
            this.btnGotoCart.Text = "Go to Cart";
            this.btnGotoCart.UseVisualStyleBackColor = true;
            this.btnGotoCart.Click += new System.EventHandler(this.btnGotoCart_Click);
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(768, 322);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(107, 23);
            this.btnAddToCart.TabIndex = 8;
            this.btnAddToCart.Text = "Add to Cart";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // txt_address
            // 
            this.txt_address.Controls.Add(this.datagrideView);
            this.txt_address.Controls.Add(this.btnClear);
            this.txt_address.Controls.Add(this.btnOrder);
            this.txt_address.Controls.Add(this.lbi_total_price);
            this.txt_address.Location = new System.Drawing.Point(12, 351);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(863, 237);
            this.txt_address.TabIndex = 5;
            // 
            // datagrideView
            // 
            this.datagrideView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrideView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNO,
            this.colItem,
            this.colUnitP,
            this.colQty,
            this.colPrice});
            this.datagrideView.Location = new System.Drawing.Point(0, 3);
            this.datagrideView.Name = "datagrideView";
            this.datagrideView.RowTemplate.Height = 24;
            this.datagrideView.Size = new System.Drawing.Size(691, 200);
            this.datagrideView.TabIndex = 0;
            // 
            // colNO
            // 
            this.colNO.HeaderText = "NO";
            this.colNO.Name = "colNO";
            // 
            // colItem
            // 
            this.colItem.HeaderText = "Item";
            this.colItem.Name = "colItem";
            this.colItem.Width = 200;
            // 
            // colUnitP
            // 
            this.colUnitP.HeaderText = "Unit Price";
            this.colUnitP.Name = "colUnitP";
            this.colUnitP.Width = 120;
            // 
            // colQty
            // 
            this.colQty.HeaderText = "Qty";
            this.colQty.Name = "colQty";
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.Width = 200;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(756, 53);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Remove";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(756, 141);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbi_total_price
            // 
            this.lbi_total_price.AutoSize = true;
            this.lbi_total_price.Location = new System.Drawing.Point(93, 206);
            this.lbi_total_price.Name = "lbi_total_price";
            this.lbi_total_price.Size = new System.Drawing.Size(53, 17);
            this.lbi_total_price.TabIndex = 0;
            this.lbi_total_price.Text = "Quntity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(53, 128);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Address";
            // 
            // text_address
            // 
            this.text_address.Location = new System.Drawing.Point(195, 125);
            this.text_address.Multiline = true;
            this.text_address.Name = "text_address";
            this.text_address.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.text_address.Size = new System.Drawing.Size(274, 44);
            this.text_address.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 600);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.btnGotoCart);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.comboItem);
            this.Controls.Add(this.comboCate);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_address);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.txt_address.ResumeLayout(false);
            this.txt_address.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrideView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.ComboBox comboCate;
        private System.Windows.Forms.ComboBox comboItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btnGotoCart;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Panel txt_address;
        private System.Windows.Forms.DataGridView datagrideView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn colItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUnitP;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.Label lbi_total_price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox text_address;
    }
}

