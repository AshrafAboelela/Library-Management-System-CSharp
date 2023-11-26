namespace library.BasicData
{
    partial class distributeitems
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
            this.btn_add = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.cmb_item = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_store = new System.Windows.Forms.ComboBox();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_distribute = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_items = new System.Windows.Forms.DataGridView();
            this.col_store_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_store_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(11, 43);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(74, 34);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "إضافة";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.cmb_item);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.cmb_store);
            this.panelControl2.Location = new System.Drawing.Point(105, 5);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(288, 91);
            this.panelControl2.TabIndex = 4;
            // 
            // cmb_item
            // 
            this.cmb_item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_item.FormattingEnabled = true;
            this.cmb_item.Location = new System.Drawing.Point(32, 55);
            this.cmb_item.Name = "cmb_item";
            this.cmb_item.Size = new System.Drawing.Size(172, 21);
            this.cmb_item.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(215, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "اسم المخزن";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "إسم الصنف";
            // 
            // cmb_store
            // 
            this.cmb_store.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_store.FormattingEnabled = true;
            this.cmb_store.Location = new System.Drawing.Point(32, 20);
            this.cmb_store.Name = "cmb_store";
            this.cmb_store.Size = new System.Drawing.Size(172, 21);
            this.cmb_store.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_close);
            this.panelControl3.Controls.Add(this.btn_distribute);
            this.panelControl3.Controls.Add(this.btn_save);
            this.panelControl3.Location = new System.Drawing.Point(57, 339);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(326, 44);
            this.panelControl3.TabIndex = 7;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(6, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 34);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "إغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_distribute
            // 
            this.btn_distribute.Location = new System.Drawing.Point(191, 5);
            this.btn_distribute.Name = "btn_distribute";
            this.btn_distribute.Size = new System.Drawing.Size(122, 34);
            this.btn_distribute.TabIndex = 2;
            this.btn_distribute.Text = "توزيع اتوماتيك";
            this.btn_distribute.UseVisualStyleBackColor = true;
            this.btn_distribute.Click += new System.EventHandler(this.btn_distribute_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(100, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 34);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_items
            // 
            this.dgv_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_items.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_store_id,
            this.col_item_id,
            this.col_store_name,
            this.col_item_name});
            this.dgv_items.Location = new System.Drawing.Point(36, 102);
            this.dgv_items.Name = "dgv_items";
            this.dgv_items.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_items.Size = new System.Drawing.Size(357, 220);
            this.dgv_items.TabIndex = 8;
            // 
            // col_store_id
            // 
            this.col_store_id.HeaderText = "";
            this.col_store_id.Name = "col_store_id";
            this.col_store_id.Visible = false;
            // 
            // col_item_id
            // 
            this.col_item_id.HeaderText = "";
            this.col_item_id.Name = "col_item_id";
            this.col_item_id.Visible = false;
            // 
            // col_store_name
            // 
            this.col_store_name.HeaderText = "المخزن";
            this.col_store_name.Name = "col_store_name";
            // 
            // col_item_name
            // 
            this.col_item_name.HeaderText = "اسم الصنف";
            this.col_item_name.Name = "col_item_name";
            // 
            // distributeitems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 421);
            this.Controls.Add(this.dgv_items);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.panelControl2);
            this.Name = "distributeitems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "توزيع الاصناف على المخازن";
            this.Load += new System.EventHandler(this.distributeitems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_store;
        private System.Windows.Forms.ComboBox cmb_item;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_distribute;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridView dgv_items;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_store_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_store_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_item_name;
    }
}