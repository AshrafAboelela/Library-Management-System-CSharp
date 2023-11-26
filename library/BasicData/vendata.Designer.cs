namespace library.BasicData
{
    partial class vendata
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
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.panel_vendata = new DevExpress.XtraEditors.PanelControl();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_venname = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_ven_search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panel_vendata)).BeginInit();
            this.panel_vendata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_id);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Controls.Add(this.panel_vendata);
            this.panelControl1.Controls.Add(this.groupControl1);
            this.panelControl1.Location = new System.Drawing.Point(7, 2);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(448, 361);
            this.panelControl1.TabIndex = 1;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(40, 47);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 17);
            this.lbl_id.TabIndex = 7;
            this.lbl_id.Visible = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_close);
            this.panelControl3.Controls.Add(this.btn_delete);
            this.panelControl3.Controls.Add(this.btn_update);
            this.panelControl3.Controls.Add(this.btn_save);
            this.panelControl3.Controls.Add(this.btn_new);
            this.panelControl3.Location = new System.Drawing.Point(5, 286);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(438, 44);
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
            // panel_vendata
            // 
            this.panel_vendata.Controls.Add(this.label6);
            this.panel_vendata.Controls.Add(this.txt_notes);
            this.panel_vendata.Controls.Add(this.label5);
            this.panel_vendata.Controls.Add(this.txt_mob);
            this.panel_vendata.Controls.Add(this.label4);
            this.panel_vendata.Controls.Add(this.txt_tel);
            this.panel_vendata.Controls.Add(this.label3);
            this.panel_vendata.Controls.Add(this.txt_address);
            this.panel_vendata.Controls.Add(this.label2);
            this.panel_vendata.Controls.Add(this.txt_venname);
            this.panel_vendata.Location = new System.Drawing.Point(5, 124);
            this.panel_vendata.Name = "panel_vendata";
            this.panel_vendata.Size = new System.Drawing.Size(437, 146);
            this.panel_vendata.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "ملاحظات";
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(29, 91);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(331, 41);
            this.txt_notes.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(163, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "الموبايل";
            // 
            // txt_mob
            // 
            this.txt_mob.Location = new System.Drawing.Point(29, 55);
            this.txt_mob.Name = "txt_mob";
            this.txt_mob.Size = new System.Drawing.Size(128, 20);
            this.txt_mob.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(366, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "التليفون";
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(232, 55);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(128, 20);
            this.txt_tel.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "العنوان";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(29, 17);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(128, 20);
            this.txt_address.TabIndex = 2;
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
            // txt_venname
            // 
            this.txt_venname.Location = new System.Drawing.Point(232, 17);
            this.txt_venname.Name = "txt_venname";
            this.txt_venname.Size = new System.Drawing.Size(128, 20);
            this.txt_venname.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.cmb_ven_search);
            this.groupControl1.Location = new System.Drawing.Point(92, 19);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(248, 87);
            this.groupControl1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "بحــــث";
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
            // cmb_ven_search
            // 
            this.cmb_ven_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_ven_search.FormattingEnabled = true;
            this.cmb_ven_search.Location = new System.Drawing.Point(88, 50);
            this.cmb_ven_search.Name = "cmb_ven_search";
            this.cmb_ven_search.Size = new System.Drawing.Size(137, 21);
            this.cmb_ven_search.TabIndex = 0;
            // 
            // vendata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 368);
            this.Controls.Add(this.panelControl1);
            this.Name = "vendata";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تسجيل بيانات الموردين";
            this.Load += new System.EventHandler(this.vendata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panel_vendata)).EndInit();
            this.panel_vendata.ResumeLayout(false);
            this.panel_vendata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private DevExpress.XtraEditors.PanelControl panel_vendata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_venname;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmb_ven_search;
        private System.Windows.Forms.TextBox txt_notes;
        private System.Windows.Forms.Label lbl_id;
    }
}