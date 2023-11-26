namespace library.BasicData
{
    partial class storedata
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_id = new System.Windows.Forms.Label();
            this.dgv_store = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.store_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.store_address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.store_notes = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.pnl_data = new DevExpress.XtraEditors.PanelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_store_notes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_store_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_store_name = new System.Windows.Forms.TextBox();
            this.cmb_emp = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_store_search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_data)).BeginInit();
            this.pnl_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_id);
            this.panelControl1.Controls.Add(this.dgv_store);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.pnl_data);
            this.panelControl1.Location = new System.Drawing.Point(3, 105);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(531, 305);
            this.panelControl1.TabIndex = 3;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(491, 113);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 4;
            this.lbl_id.Visible = false;
            // 
            // dgv_store
            // 
            this.dgv_store.Location = new System.Drawing.Point(11, 147);
            this.dgv_store.MainView = this.gridView1;
            this.dgv_store.Name = "dgv_store";
            this.dgv_store.Size = new System.Drawing.Size(506, 138);
            this.dgv_store.TabIndex = 3;
            this.dgv_store.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.store_name,
            this.store_address,
            this.store_notes});
            this.gridView1.GridControl = this.dgv_store;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // store_name
            // 
            this.store_name.Caption = "اسم المخزن";
            this.store_name.FieldName = "store_name";
            this.store_name.Name = "store_name";
            this.store_name.Visible = true;
            this.store_name.VisibleIndex = 0;
            // 
            // store_address
            // 
            this.store_address.Caption = "عنوان المخزن";
            this.store_address.FieldName = "store_address";
            this.store_address.Name = "store_address";
            this.store_address.Visible = true;
            this.store_address.VisibleIndex = 1;
            // 
            // store_notes
            // 
            this.store_notes.Caption = "ملاحظات";
            this.store_notes.FieldName = "store_notes";
            this.store_notes.Name = "store_notes";
            this.store_notes.Visible = true;
            this.store_notes.VisibleIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_close);
            this.panelControl3.Controls.Add(this.btn_delete);
            this.panelControl3.Controls.Add(this.btn_update);
            this.panelControl3.Controls.Add(this.btn_save);
            this.panelControl3.Controls.Add(this.btn_new);
            this.panelControl3.Location = new System.Drawing.Point(39, 97);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(441, 44);
            this.panelControl3.TabIndex = 2;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(21, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 34);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "إغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(103, 5);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 34);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "حذف";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(184, 5);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(71, 34);
            this.btn_update.TabIndex = 2;
            this.btn_update.Text = "تعديل";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(261, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 34);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(341, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(78, 34);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.label6);
            this.pnl_data.Controls.Add(this.txt_store_notes);
            this.pnl_data.Controls.Add(this.label3);
            this.pnl_data.Controls.Add(this.txt_store_address);
            this.pnl_data.Controls.Add(this.label1);
            this.pnl_data.Controls.Add(this.label2);
            this.pnl_data.Controls.Add(this.txt_store_name);
            this.pnl_data.Controls.Add(this.cmb_emp);
            this.pnl_data.Location = new System.Drawing.Point(6, 5);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(511, 86);
            this.pnl_data.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(170, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "ملاحظات";
            // 
            // txt_store_notes
            // 
            this.txt_store_notes.Location = new System.Drawing.Point(5, 53);
            this.txt_store_notes.Name = "txt_store_notes";
            this.txt_store_notes.Size = new System.Drawing.Size(153, 20);
            this.txt_store_notes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(169, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "عنوان المخزن";
            // 
            // txt_store_address
            // 
            this.txt_store_address.Location = new System.Drawing.Point(5, 15);
            this.txt_store_address.Name = "txt_store_address";
            this.txt_store_address.Size = new System.Drawing.Size(152, 20);
            this.txt_store_address.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(426, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "الموظف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "إسم المخزن";
            // 
            // txt_store_name
            // 
            this.txt_store_name.Location = new System.Drawing.Point(262, 15);
            this.txt_store_name.Name = "txt_store_name";
            this.txt_store_name.Size = new System.Drawing.Size(152, 20);
            this.txt_store_name.TabIndex = 0;
            // 
            // cmb_emp
            // 
            this.cmb_emp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_emp.FormattingEnabled = true;
            this.cmb_emp.Location = new System.Drawing.Point(262, 53);
            this.cmb_emp.Name = "cmb_emp";
            this.cmb_emp.Size = new System.Drawing.Size(152, 21);
            this.cmb_emp.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.cmb_store_search);
            this.groupControl1.Location = new System.Drawing.Point(154, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(209, 87);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "بحــــث";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Location = new System.Drawing.Point(15, 46);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(56, 24);
            this.simpleButton1.TabIndex = 1;
            this.simpleButton1.Text = "بحث";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // cmb_store_search
            // 
            this.cmb_store_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_store_search.FormattingEnabled = true;
            this.cmb_store_search.Location = new System.Drawing.Point(88, 50);
            this.cmb_store_search.Name = "cmb_store_search";
            this.cmb_store_search.Size = new System.Drawing.Size(111, 21);
            this.cmb_store_search.TabIndex = 0;
            // 
            // storedata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 419);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl1);
            this.Name = "storedata";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تسجيل بيانات المخازن";
            this.Load += new System.EventHandler(this.storedata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_store)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_data)).EndInit();
            this.pnl_data.ResumeLayout(false);
            this.pnl_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dgv_store;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private DevExpress.XtraEditors.PanelControl pnl_data;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_store_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_store_name;
        private System.Windows.Forms.ComboBox cmb_emp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_store_notes;
        private DevExpress.XtraGrid.Columns.GridColumn store_name;
        private DevExpress.XtraGrid.Columns.GridColumn store_address;
        private DevExpress.XtraGrid.Columns.GridColumn store_notes;
        private System.Windows.Forms.Label lbl_id;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmb_store_search;
    }
}