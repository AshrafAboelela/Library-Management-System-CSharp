namespace library.BasicData
{
    partial class purchases_data
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.pnl_1 = new DevExpress.XtraEditors.PanelControl();
            this.date_purchases = new DevExpress.XtraEditors.DateEdit();
            this.cmb_store = new System.Windows.Forms.ComboBox();
            this.cmb_vend = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_2 = new DevExpress.XtraEditors.PanelControl();
            this.cmb_item_name = new System.Windows.Forms.ComboBox();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_quantity = new System.Windows.Forms.TextBox();
            this.cmb_item_category = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.txt_remain = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_payed = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.col_category_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_category_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_1)).BeginInit();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_purchases.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_purchases.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_2)).BeginInit();
            this.pnl_2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_close);
            this.panelControl3.Controls.Add(this.btn_save);
            this.panelControl3.Controls.Add(this.btn_new);
            this.panelControl3.Location = new System.Drawing.Point(89, 413);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(255, 44);
            this.panelControl3.TabIndex = 4;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(5, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 34);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "إغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(83, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 34);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(163, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(78, 34);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(161, 182);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 34);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "إضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.date_purchases);
            this.pnl_1.Controls.Add(this.cmb_store);
            this.pnl_1.Controls.Add(this.cmb_vend);
            this.pnl_1.Controls.Add(this.label5);
            this.pnl_1.Controls.Add(this.label4);
            this.pnl_1.Controls.Add(this.txt_notes);
            this.pnl_1.Controls.Add(this.label3);
            this.pnl_1.Controls.Add(this.label2);
            this.pnl_1.Location = new System.Drawing.Point(12, 12);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(437, 77);
            this.pnl_1.TabIndex = 3;
            // 
            // date_purchases
            // 
            this.date_purchases.EditValue = null;
            this.date_purchases.Location = new System.Drawing.Point(21, 18);
            this.date_purchases.Name = "date_purchases";
            this.date_purchases.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_purchases.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_purchases.Size = new System.Drawing.Size(108, 20);
            this.date_purchases.TabIndex = 16;
            // 
            // cmb_store
            // 
            this.cmb_store.FormattingEnabled = true;
            this.cmb_store.Location = new System.Drawing.Point(21, 51);
            this.cmb_store.Name = "cmb_store";
            this.cmb_store.Size = new System.Drawing.Size(136, 21);
            this.cmb_store.TabIndex = 15;
            // 
            // cmb_vend
            // 
            this.cmb_vend.FormattingEnabled = true;
            this.cmb_vend.Location = new System.Drawing.Point(224, 17);
            this.cmb_vend.Name = "cmb_vend";
            this.cmb_vend.Size = new System.Drawing.Size(136, 21);
            this.cmb_vend.TabIndex = 14;
            this.cmb_vend.SelectedIndexChanged += new System.EventHandler(this.cmb_vend_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "المخزن";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "ملاحظات";
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(232, 55);
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(128, 20);
            this.txt_notes.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(135, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "تاريخ الشراء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "إسم المورد";
            // 
            // pnl_2
            // 
            this.pnl_2.Controls.Add(this.cmb_item_name);
            this.pnl_2.Controls.Add(this.txt_value);
            this.pnl_2.Controls.Add(this.label9);
            this.pnl_2.Controls.Add(this.txt_quantity);
            this.pnl_2.Controls.Add(this.cmb_item_category);
            this.pnl_2.Controls.Add(this.label1);
            this.pnl_2.Controls.Add(this.label6);
            this.pnl_2.Controls.Add(this.txt_price);
            this.pnl_2.Controls.Add(this.label7);
            this.pnl_2.Controls.Add(this.label8);
            this.pnl_2.Location = new System.Drawing.Point(12, 95);
            this.pnl_2.Name = "pnl_2";
            this.pnl_2.Size = new System.Drawing.Size(437, 81);
            this.pnl_2.TabIndex = 5;
            // 
            // cmb_item_name
            // 
            this.cmb_item_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_item_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_item_name.FormattingEnabled = true;
            this.cmb_item_name.Location = new System.Drawing.Point(19, 13);
            this.cmb_item_name.Name = "cmb_item_name";
            this.cmb_item_name.Size = new System.Drawing.Size(121, 21);
            this.cmb_item_name.TabIndex = 19;
            this.cmb_item_name.SelectedIndexChanged += new System.EventHandler(this.cmb_item_name_SelectedIndexChanged);
            // 
            // txt_value
            // 
            this.txt_value.Enabled = false;
            this.txt_value.Location = new System.Drawing.Point(21, 49);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(75, 20);
            this.txt_value.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(105, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 17);
            this.label9.TabIndex = 17;
            this.label9.Text = "القيمة";
            // 
            // txt_quantity
            // 
            this.txt_quantity.Location = new System.Drawing.Point(149, 52);
            this.txt_quantity.Name = "txt_quantity";
            this.txt_quantity.Size = new System.Drawing.Size(75, 20);
            this.txt_quantity.TabIndex = 16;
            this.txt_quantity.TextChanged += new System.EventHandler(this.txt_quantity_TextChanged);
            // 
            // cmb_item_category
            // 
            this.cmb_item_category.FormattingEnabled = true;
            this.cmb_item_category.Location = new System.Drawing.Point(224, 17);
            this.cmb_item_category.Name = "cmb_item_category";
            this.cmb_item_category.Size = new System.Drawing.Size(136, 21);
            this.cmb_item_category.TabIndex = 14;
            this.cmb_item_category.SelectedIndexChanged += new System.EventHandler(this.cmb_item_category_SelectedIndexChanged);
            this.cmb_item_category.SelectedValueChanged += new System.EventHandler(this.cmb_item_category_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(230, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "الكمية";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(359, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "سعر الصنف";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(278, 55);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(75, 20);
            this.txt_price.TabIndex = 4;
            this.txt_price.TextChanged += new System.EventHandler(this.txt_price_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(146, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "اسم الصنف";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "فئة الصنف";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.txt_remain);
            this.panelControl2.Controls.Add(this.label10);
            this.panelControl2.Controls.Add(this.txt_payed);
            this.panelControl2.Controls.Add(this.label11);
            this.panelControl2.Controls.Add(this.label12);
            this.panelControl2.Controls.Add(this.txt_total);
            this.panelControl2.Location = new System.Drawing.Point(12, 362);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(437, 45);
            this.panelControl2.TabIndex = 19;
            // 
            // txt_remain
            // 
            this.txt_remain.Enabled = false;
            this.txt_remain.Location = new System.Drawing.Point(5, 12);
            this.txt_remain.Name = "txt_remain";
            this.txt_remain.Size = new System.Drawing.Size(75, 20);
            this.txt_remain.TabIndex = 18;
            this.txt_remain.TextChanged += new System.EventHandler(this.txt_remain_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(86, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "المتبقى";
            // 
            // txt_payed
            // 
            this.txt_payed.Location = new System.Drawing.Point(135, 15);
            this.txt_payed.Name = "txt_payed";
            this.txt_payed.Size = new System.Drawing.Size(75, 20);
            this.txt_payed.TabIndex = 16;
            this.txt_payed.TextChanged += new System.EventHandler(this.txt_payed_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(216, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 17);
            this.label11.TabIndex = 7;
            this.label11.Text = "المدفوع";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(349, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 17);
            this.label12.TabIndex = 5;
            this.label12.Text = "اجمالى الفاتورة";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(271, 15);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(75, 20);
            this.txt_total.TabIndex = 4;
            this.txt_total.TextChanged += new System.EventHandler(this.txt_total_TextChanged);
            // 
            // dgv_items
            // 
            this.dgv_items.AllowUserToDeleteRows = false;
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_category_id,
            this.col_item_id,
            this.col_category_name,
            this.col_item_name,
            this.col_price,
            this.col_quantity,
            this.col_value});
            this.dgv_items.Location = new System.Drawing.Point(12, 222);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.ReadOnly = true;
            this.dgv_items.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_items.Size = new System.Drawing.Size(440, 140);
            this.dgv_items.TabIndex = 20;
            // 
            // col_category_id
            // 
            this.col_category_id.HeaderText = "";
            this.col_category_id.Name = "col_category_id";
            this.col_category_id.ReadOnly = true;
            this.col_category_id.Visible = false;
            // 
            // col_item_id
            // 
            this.col_item_id.HeaderText = "";
            this.col_item_id.Name = "col_item_id";
            this.col_item_id.ReadOnly = true;
            this.col_item_id.Visible = false;
            // 
            // col_category_name
            // 
            this.col_category_name.HeaderText = "فئة الصنف";
            this.col_category_name.Name = "col_category_name";
            this.col_category_name.ReadOnly = true;
            // 
            // col_item_name
            // 
            this.col_item_name.HeaderText = "اسم الصنف";
            this.col_item_name.Name = "col_item_name";
            this.col_item_name.ReadOnly = true;
            // 
            // col_price
            // 
            this.col_price.HeaderText = "سعر الصنف";
            this.col_price.Name = "col_price";
            this.col_price.ReadOnly = true;
            // 
            // col_quantity
            // 
            this.col_quantity.HeaderText = "الكمية";
            this.col_quantity.Name = "col_quantity";
            this.col_quantity.ReadOnly = true;
            // 
            // col_value
            // 
            this.col_value.HeaderText = "القيمة";
            this.col_value.Name = "col_value";
            this.col_value.ReadOnly = true;
            // 
            // purchases_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 481);
            this.Controls.Add(this.dgv_items);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.pnl_2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.pnl_1);
            this.Name = "purchases_data";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "اجراء حركة شراء";
            this.Load += new System.EventHandler(this.purchases_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_1)).EndInit();
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_purchases.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_purchases.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_2)).EndInit();
            this.pnl_2.ResumeLayout(false);
            this.pnl_2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private DevExpress.XtraEditors.PanelControl pnl_1;
        private System.Windows.Forms.ComboBox cmb_store;
        private System.Windows.Forms.ComboBox cmb_vend;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit date_purchases;
        private DevExpress.XtraEditors.PanelControl pnl_2;
        private System.Windows.Forms.ComboBox cmb_item_category;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_quantity;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox txt_remain;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_payed;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_category_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_value;
        private System.Windows.Forms.ComboBox cmb_item_name;
    }
}