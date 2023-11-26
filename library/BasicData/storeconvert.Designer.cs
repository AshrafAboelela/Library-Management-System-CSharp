namespace library.BasicData
{
    partial class storeconvert
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btn_add = new System.Windows.Forms.Button();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.date_convert = new DevExpress.XtraEditors.DateEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_quantity_converted = new System.Windows.Forms.TextBox();
            this.txt_quantity_convert = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_store_to = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_store_from = new System.Windows.Forms.ComboBox();
            this.cmb_item_name = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_quantityto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_quantityfrom = new System.Windows.Forms.TextBox();
            this.cmb_item_category = new System.Windows.Forms.ComboBox();
            this.dgv_convert = new System.Windows.Forms.DataGridView();
            this.iitem_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.converted_quan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.store_to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.convert_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_convert.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_convert.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_convert)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.dgv_convert);
            this.panelControl1.Controls.Add(this.btn_add);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(3, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(578, 360);
            this.panelControl1.TabIndex = 3;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(223, 226);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(118, 34);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "اضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.button3);
            this.panelControl3.Controls.Add(this.btn_save);
            this.panelControl3.Controls.Add(this.btn_new);
            this.panelControl3.Location = new System.Drawing.Point(171, 388);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(273, 44);
            this.panelControl3.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(9, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(71, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "إغلاق";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(86, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 34);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(166, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(78, 34);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.button4);
            this.panelControl2.Controls.Add(this.label11);
            this.panelControl2.Controls.Add(this.label10);
            this.panelControl2.Controls.Add(this.txt_notes);
            this.panelControl2.Controls.Add(this.date_convert);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Controls.Add(this.txt_quantity_converted);
            this.panelControl2.Controls.Add(this.txt_quantity_convert);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Controls.Add(this.cmb_store_to);
            this.panelControl2.Controls.Add(this.label4);
            this.panelControl2.Controls.Add(this.label5);
            this.panelControl2.Controls.Add(this.cmb_store_from);
            this.panelControl2.Controls.Add(this.cmb_item_name);
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.txt_quantityto);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.txt_quantityfrom);
            this.panelControl2.Controls.Add(this.cmb_item_category);
            this.panelControl2.Location = new System.Drawing.Point(22, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(550, 220);
            this.panelControl2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(246, 134);
            this.button4.Name = "button4";
            this.button4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button4.Size = new System.Drawing.Size(33, 29);
            this.button4.TabIndex = 20;
            this.button4.Text = "<<";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(443, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 17);
            this.label11.TabIndex = 19;
            this.label11.Text = "التاريخ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(190, 185);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "ملاحظات";
            // 
            // txt_notes
            // 
            this.txt_notes.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_notes.Location = new System.Drawing.Point(14, 180);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(163, 33);
            this.txt_notes.TabIndex = 17;
            this.txt_notes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date_convert
            // 
            this.date_convert.EditValue = null;
            this.date_convert.Location = new System.Drawing.Point(319, 182);
            this.date_convert.Name = "date_convert";
            this.date_convert.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_convert.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_convert.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.date_convert.Size = new System.Drawing.Size(112, 20);
            this.date_convert.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(160, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 14;
            this.label7.Text = "بعد التحويل";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(438, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "الكمية المحولة";
            // 
            // txt_quantity_converted
            // 
            this.txt_quantity_converted.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity_converted.Location = new System.Drawing.Point(14, 140);
            this.txt_quantity_converted.Name = "txt_quantity_converted";
            this.txt_quantity_converted.Size = new System.Drawing.Size(140, 23);
            this.txt_quantity_converted.TabIndex = 12;
            this.txt_quantity_converted.Text = "0";
            this.txt_quantity_converted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_quantity_convert
            // 
            this.txt_quantity_convert.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantity_convert.Location = new System.Drawing.Point(319, 140);
            this.txt_quantity_convert.Name = "txt_quantity_convert";
            this.txt_quantity_convert.Size = new System.Drawing.Size(112, 23);
            this.txt_quantity_convert.TabIndex = 11;
            this.txt_quantity_convert.Text = "0";
            this.txt_quantity_convert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(188, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "الكمية الحالية";
            // 
            // cmb_store_to
            // 
            this.cmb_store_to.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_store_to.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_store_to.FormattingEnabled = true;
            this.cmb_store_to.Location = new System.Drawing.Point(14, 52);
            this.cmb_store_to.Name = "cmb_store_to";
            this.cmb_store_to.Size = new System.Drawing.Size(140, 21);
            this.cmb_store_to.TabIndex = 9;
            this.cmb_store_to.SelectedIndexChanged += new System.EventHandler(this.cmb_store_to_SelectedIndexChanged);
            this.cmb_store_to.SelectedValueChanged += new System.EventHandler(this.cmb_store_to_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "المخزن المحول منه";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(157, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "المخزن المحول اليه";
            // 
            // cmb_store_from
            // 
            this.cmb_store_from.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_store_from.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_store_from.FormattingEnabled = true;
            this.cmb_store_from.Location = new System.Drawing.Point(319, 52);
            this.cmb_store_from.Name = "cmb_store_from";
            this.cmb_store_from.Size = new System.Drawing.Size(100, 21);
            this.cmb_store_from.TabIndex = 6;
            this.cmb_store_from.SelectedIndexChanged += new System.EventHandler(this.cmb_store_from_SelectedIndexChanged);
            this.cmb_store_from.SelectedValueChanged += new System.EventHandler(this.cmb_store_from_SelectedValueChanged);
            // 
            // cmb_item_name
            // 
            this.cmb_item_name.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_item_name.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_item_name.FormattingEnabled = true;
            this.cmb_item_name.Location = new System.Drawing.Point(14, 9);
            this.cmb_item_name.Name = "cmb_item_name";
            this.cmb_item_name.Size = new System.Drawing.Size(140, 21);
            this.cmb_item_name.TabIndex = 5;
            this.cmb_item_name.SelectedIndexChanged += new System.EventHandler(this.cmb_item_name_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "الكمية الحالية";
            // 
            // txt_quantityto
            // 
            this.txt_quantityto.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantityto.Location = new System.Drawing.Point(14, 94);
            this.txt_quantityto.Name = "txt_quantityto";
            this.txt_quantityto.Size = new System.Drawing.Size(163, 23);
            this.txt_quantityto.TabIndex = 3;
            this.txt_quantityto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantityto.TextChanged += new System.EventHandler(this.txt_quantityto_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "فئة الصنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "إسم الصنف";
            // 
            // txt_quantityfrom
            // 
            this.txt_quantityfrom.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_quantityfrom.Location = new System.Drawing.Point(306, 94);
            this.txt_quantityfrom.Name = "txt_quantityfrom";
            this.txt_quantityfrom.Size = new System.Drawing.Size(125, 23);
            this.txt_quantityfrom.TabIndex = 0;
            this.txt_quantityfrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_quantityfrom.TextChanged += new System.EventHandler(this.txt_quantityfrom_TextChanged);
            // 
            // cmb_item_category
            // 
            this.cmb_item_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_item_category.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmb_item_category.FormattingEnabled = true;
            this.cmb_item_category.Location = new System.Drawing.Point(297, 9);
            this.cmb_item_category.Name = "cmb_item_category";
            this.cmb_item_category.Size = new System.Drawing.Size(140, 21);
            this.cmb_item_category.TabIndex = 0;
            this.cmb_item_category.SelectedIndexChanged += new System.EventHandler(this.cmb_item_category_SelectedIndexChanged);
            this.cmb_item_category.SelectedValueChanged += new System.EventHandler(this.cmb_item_category_SelectedValueChanged);
            // 
            // dgv_convert
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_convert.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_convert.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_convert.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iitem_name,
            this.item_cat,
            this.converted_quan,
            this.store_from,
            this.store_to,
            this.convert_date});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_convert.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_convert.Location = new System.Drawing.Point(0, 262);
            this.dgv_convert.Name = "dgv_convert";
            this.dgv_convert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_convert.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_convert.Size = new System.Drawing.Size(578, 117);
            this.dgv_convert.TabIndex = 4;
            // 
            // iitem_name
            // 
            this.iitem_name.HeaderText = "اسم الصنف";
            this.iitem_name.Name = "iitem_name";
            // 
            // item_cat
            // 
            this.item_cat.HeaderText = "فئة الصنف";
            this.item_cat.Name = "item_cat";
            // 
            // converted_quan
            // 
            this.converted_quan.HeaderText = "الكمية المحولة";
            this.converted_quan.Name = "converted_quan";
            // 
            // store_from
            // 
            this.store_from.HeaderText = "المخزن المحول منه";
            this.store_from.Name = "store_from";
            // 
            // store_to
            // 
            this.store_to.HeaderText = "المخزن المحول اليه";
            this.store_to.Name = "store_to";
            // 
            // convert_date
            // 
            this.convert_date.HeaderText = "تاريخ التحويل";
            this.convert_date.Name = "convert_date";
            // 
            // storeconvert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 435);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl3);
            this.Name = "storeconvert";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تحويلات المخازن";
            this.Load += new System.EventHandler(this.storeconvert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_convert.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_convert.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_convert)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quantityto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_quantityfrom;
        private System.Windows.Forms.ComboBox cmb_item_category;
        private System.Windows.Forms.ComboBox cmb_item_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_store_to;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_store_from;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_quantity_converted;
        private System.Windows.Forms.TextBox txt_quantity_convert;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_notes;
        private DevExpress.XtraEditors.DateEdit date_convert;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgv_convert;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DataGridViewTextBoxColumn iitem_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn converted_quan;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_from;
        private System.Windows.Forms.DataGridViewTextBoxColumn store_to;
        private System.Windows.Forms.DataGridViewTextBoxColumn convert_date;
    }
}