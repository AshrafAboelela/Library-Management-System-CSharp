namespace library.BasicData
{
    partial class empdata
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
            this.panel_emp_data = new DevExpress.XtraEditors.PanelControl();
            this.lbl_id = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.pnl_empdata = new DevExpress.XtraEditors.PanelControl();
            this.cmb_emptype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_idno = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_mob = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_empname = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label1 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_emp_search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panel_emp_data)).BeginInit();
            this.panel_emp_data.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_empdata)).BeginInit();
            this.pnl_empdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_emp_data
            // 
            this.panel_emp_data.Controls.Add(this.lbl_id);
            this.panel_emp_data.Controls.Add(this.panelControl3);
            this.panel_emp_data.Controls.Add(this.pnl_empdata);
            this.panel_emp_data.Controls.Add(this.groupControl1);
            this.panel_emp_data.Location = new System.Drawing.Point(-1, 3);
            this.panel_emp_data.Name = "panel_emp_data";
            this.panel_emp_data.Size = new System.Drawing.Size(448, 392);
            this.panel_emp_data.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(400, 57);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(0, 13);
            this.lbl_id.TabIndex = 3;
            this.lbl_id.Visible = false;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_close);
            this.panelControl3.Controls.Add(this.btn_delete);
            this.panelControl3.Controls.Add(this.btn_update);
            this.panelControl3.Controls.Add(this.btn_save);
            this.panelControl3.Controls.Add(this.btn_new);
            this.panelControl3.Location = new System.Drawing.Point(5, 319);
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
            this.btn_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(341, 5);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(78, 34);
            this.btn_new.TabIndex = 0;
            this.btn_new.Text = "جديد";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnl_empdata
            // 
            this.pnl_empdata.Controls.Add(this.cmb_emptype);
            this.pnl_empdata.Controls.Add(this.label8);
            this.pnl_empdata.Controls.Add(this.label7);
            this.pnl_empdata.Controls.Add(this.txt_salary);
            this.pnl_empdata.Controls.Add(this.label6);
            this.pnl_empdata.Controls.Add(this.txt_idno);
            this.pnl_empdata.Controls.Add(this.label5);
            this.pnl_empdata.Controls.Add(this.txt_mob);
            this.pnl_empdata.Controls.Add(this.label4);
            this.pnl_empdata.Controls.Add(this.txt_tel);
            this.pnl_empdata.Controls.Add(this.label3);
            this.pnl_empdata.Controls.Add(this.txt_address);
            this.pnl_empdata.Controls.Add(this.label2);
            this.pnl_empdata.Controls.Add(this.txt_empname);
            this.pnl_empdata.Location = new System.Drawing.Point(6, 124);
            this.pnl_empdata.Name = "pnl_empdata";
            this.pnl_empdata.Size = new System.Drawing.Size(437, 160);
            this.pnl_empdata.TabIndex = 1;
            // 
            // cmb_emptype
            // 
            this.cmb_emptype.FormattingEnabled = true;
            this.cmb_emptype.Location = new System.Drawing.Point(11, 14);
            this.cmb_emptype.Name = "cmb_emptype";
            this.cmb_emptype.Size = new System.Drawing.Size(136, 21);
            this.cmb_emptype.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(366, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "العنوان";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(139, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "المرتب الاساسى";
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(11, 91);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(128, 20);
            this.txt_salary.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(366, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "رقم البطاقة";
            // 
            // txt_idno
            // 
            this.txt_idno.Location = new System.Drawing.Point(232, 91);
            this.txt_idno.Name = "txt_idno";
            this.txt_idno.Size = new System.Drawing.Size(128, 20);
            this.txt_idno.TabIndex = 8;
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
            this.txt_mob.Location = new System.Drawing.Point(11, 55);
            this.txt_mob.Name = "txt_mob";
            this.txt_mob.Size = new System.Drawing.Size(146, 20);
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
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "نوع الوظيفة";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(11, 127);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(349, 20);
            this.txt_address.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(366, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "إسم الموظف";
            // 
            // txt_empname
            // 
            this.txt_empname.Location = new System.Drawing.Point(232, 17);
            this.txt_empname.Name = "txt_empname";
            this.txt_empname.Size = new System.Drawing.Size(128, 20);
            this.txt_empname.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.cmb_emp_search);
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
            // cmb_emp_search
            // 
            this.cmb_emp_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_emp_search.FormattingEnabled = true;
            this.cmb_emp_search.Location = new System.Drawing.Point(88, 50);
            this.cmb_emp_search.Name = "cmb_emp_search";
            this.cmb_emp_search.Size = new System.Drawing.Size(137, 21);
            this.cmb_emp_search.TabIndex = 0;
            // 
            // empdata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 407);
            this.Controls.Add(this.panel_emp_data);
            this.KeyPreview = true;
            this.Name = "empdata";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "تسجيل بيانات الموظفين";
            this.Load += new System.EventHandler(this.empdata_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panel_emp_data)).EndInit();
            this.panel_emp_data.ResumeLayout(false);
            this.panel_emp_data.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_empdata)).EndInit();
            this.pnl_empdata.ResumeLayout(false);
            this.pnl_empdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panel_emp_data;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_new;
        private DevExpress.XtraEditors.PanelControl pnl_empdata;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_idno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_mob;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_empname;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmb_emp_search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_salary;
        private System.Windows.Forms.ComboBox cmb_emptype;
        private System.Windows.Forms.Label lbl_id;
    }
}