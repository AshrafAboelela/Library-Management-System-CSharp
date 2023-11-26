namespace library.BasicData
{
    partial class itemdata
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
            this.dgv_item_category = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.item_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.item_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.item_mini = new DevExpress.XtraGrid.Columns.GridColumn();
            this.category_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.category_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mini = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name_item = new System.Windows.Forms.TextBox();
            this.cmb_item_category = new System.Windows.Forms.ComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_item_search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_category)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Controls.Add(this.lbl_id);
            this.panelControl1.Controls.Add(this.dgv_item_category);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Location = new System.Drawing.Point(1, 3);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(448, 379);
            this.panelControl1.TabIndex = 2;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(405, 68);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 17);
            this.lbl_id.TabIndex = 8;
            this.lbl_id.Visible = false;
            // 
            // dgv_item_category
            // 
            this.dgv_item_category.Location = new System.Drawing.Point(6, 212);
            this.dgv_item_category.MainView = this.gridView1;
            this.dgv_item_category.Name = "dgv_item_category";
            this.dgv_item_category.Size = new System.Drawing.Size(433, 162);
            this.dgv_item_category.TabIndex = 3;
            this.dgv_item_category.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.dgv_item_category.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_item_category_KeyDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.item_id,
            this.item_name,
            this.item_mini,
            this.category_id,
            this.category_name});
            this.gridView1.GridControl = this.dgv_item_category;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // item_id
            // 
            this.item_id.AppearanceCell.Options.UseTextOptions = true;
            this.item_id.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.item_id.AppearanceHeader.Options.UseTextOptions = true;
            this.item_id.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.item_id.FieldName = "item_id";
            this.item_id.Name = "item_id";
            // 
            // item_name
            // 
            this.item_name.AppearanceHeader.Options.UseTextOptions = true;
            this.item_name.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.item_name.Caption = "اسم الصنف";
            this.item_name.FieldName = "item_name";
            this.item_name.Name = "item_name";
            this.item_name.Visible = true;
            this.item_name.VisibleIndex = 0;
            // 
            // item_mini
            // 
            this.item_mini.Caption = "الحد الأدنى";
            this.item_mini.FieldName = "item_mini";
            this.item_mini.Name = "item_mini";
            this.item_mini.Visible = true;
            this.item_mini.VisibleIndex = 1;
            // 
            // category_id
            // 
            this.category_id.FieldName = "category_id";
            this.category_id.Name = "category_id";
            // 
            // category_name
            // 
            this.category_name.Caption = "فئة الصنف";
            this.category_name.FieldName = "category_name";
            this.category_name.Name = "category_name";
            this.category_name.Visible = true;
            this.category_name.VisibleIndex = 2;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_new);
            this.panelControl3.Controls.Add(this.btn_close);
            this.panelControl3.Controls.Add(this.btn_delete);
            this.panelControl3.Controls.Add(this.btn_update);
            this.panelControl3.Controls.Add(this.btn_save);
            this.panelControl3.Location = new System.Drawing.Point(5, 162);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(438, 44);
            this.panelControl3.TabIndex = 2;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(341, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(74, 34);
            this.btn_new.TabIndex = 5;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(21, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 34);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "إغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
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
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.label3);
            this.panelControl2.Controls.Add(this.txt_mini);
            this.panelControl2.Controls.Add(this.label1);
            this.panelControl2.Controls.Add(this.label2);
            this.panelControl2.Controls.Add(this.txt_name_item);
            this.panelControl2.Controls.Add(this.cmb_item_category);
            this.panelControl2.Location = new System.Drawing.Point(234, 24);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(209, 132);
            this.panelControl2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(139, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "الحد الأدنى";
            // 
            // txt_mini
            // 
            this.txt_mini.Location = new System.Drawing.Point(5, 93);
            this.txt_mini.Name = "txt_mini";
            this.txt_mini.Size = new System.Drawing.Size(122, 20);
            this.txt_mini.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "فئة الصنف";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(139, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "إسم الصنف";
            // 
            // txt_name_item
            // 
            this.txt_name_item.Location = new System.Drawing.Point(5, 16);
            this.txt_name_item.Name = "txt_name_item";
            this.txt_name_item.Size = new System.Drawing.Size(122, 20);
            this.txt_name_item.TabIndex = 0;
            // 
            // cmb_item_category
            // 
            this.cmb_item_category.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_item_category.FormattingEnabled = true;
            this.cmb_item_category.Location = new System.Drawing.Point(5, 54);
            this.cmb_item_category.Name = "cmb_item_category";
            this.cmb_item_category.Size = new System.Drawing.Size(122, 21);
            this.cmb_item_category.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.cmb_item_search);
            this.groupControl1.Location = new System.Drawing.Point(11, 40);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(209, 87);
            this.groupControl1.TabIndex = 9;
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
            // cmb_item_search
            // 
            this.cmb_item_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_item_search.FormattingEnabled = true;
            this.cmb_item_search.Location = new System.Drawing.Point(88, 50);
            this.cmb_item_search.Name = "cmb_item_search";
            this.cmb_item_search.Size = new System.Drawing.Size(111, 21);
            this.cmb_item_search.TabIndex = 0;
            // 
            // itemdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 391);
            this.Controls.Add(this.panelControl1);
            this.KeyPreview = true;
            this.Name = "itemdata";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تسجيل بيانات الاصناف";
            this.Load += new System.EventHandler(this.itemdata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_item_category)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl dgv_item_category;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn item_id;
        private DevExpress.XtraGrid.Columns.GridColumn item_name;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name_item;
        private System.Windows.Forms.ComboBox cmb_item_category;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mini;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn item_mini;
        private DevExpress.XtraGrid.Columns.GridColumn category_id;
        private DevExpress.XtraGrid.Columns.GridColumn category_name;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Label lbl_id;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmb_item_search;
    }
}