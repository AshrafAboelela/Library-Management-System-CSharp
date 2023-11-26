namespace library.BasicData
{
    partial class cust_account_data
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
            this.btn_new = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.pnl_1 = new DevExpress.XtraEditors.PanelControl();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_notes = new System.Windows.Forms.TextBox();
            this.date_convert = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_payed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_remain = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label4 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.cmb_search = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_1)).BeginInit();
            this.pnl_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_convert.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_convert.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btn_new);
            this.panelControl3.Controls.Add(this.btn_close);
            this.panelControl3.Controls.Add(this.btn_save);
            this.panelControl3.Location = new System.Drawing.Point(5, 320);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(279, 44);
            this.panelControl3.TabIndex = 5;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(192, 5);
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
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(112, 5);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(74, 34);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "حفظ";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // pnl_1
            // 
            this.pnl_1.Controls.Add(this.label5);
            this.pnl_1.Controls.Add(this.txt_notes);
            this.pnl_1.Controls.Add(this.date_convert);
            this.pnl_1.Controls.Add(this.label3);
            this.pnl_1.Controls.Add(this.txt_payed);
            this.pnl_1.Controls.Add(this.label1);
            this.pnl_1.Controls.Add(this.label2);
            this.pnl_1.Controls.Add(this.txt_remain);
            this.pnl_1.Location = new System.Drawing.Point(31, 103);
            this.pnl_1.Name = "pnl_1";
            this.pnl_1.Size = new System.Drawing.Size(230, 196);
            this.pnl_1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(173, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "ملاحظات";
            // 
            // txt_notes
            // 
            this.txt_notes.Location = new System.Drawing.Point(11, 127);
            this.txt_notes.Multiline = true;
            this.txt_notes.Name = "txt_notes";
            this.txt_notes.Size = new System.Drawing.Size(162, 51);
            this.txt_notes.TabIndex = 6;
            // 
            // date_convert
            // 
            this.date_convert.EditValue = null;
            this.date_convert.Location = new System.Drawing.Point(15, 89);
            this.date_convert.Name = "date_convert";
            this.date_convert.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_convert.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.date_convert.Size = new System.Drawing.Size(132, 20);
            this.date_convert.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(153, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "تاريخ السداد";
            // 
            // txt_payed
            // 
            this.txt_payed.Location = new System.Drawing.Point(15, 51);
            this.txt_payed.Name = "txt_payed";
            this.txt_payed.Size = new System.Drawing.Size(128, 20);
            this.txt_payed.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(149, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "المبلغ المدفوع";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "المبلغ المتبقى";
            // 
            // txt_remain
            // 
            this.txt_remain.Location = new System.Drawing.Point(15, 15);
            this.txt_remain.Name = "txt_remain";
            this.txt_remain.Size = new System.Drawing.Size(132, 20);
            this.txt_remain.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.cmb_search);
            this.groupControl1.Location = new System.Drawing.Point(36, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(235, 87);
            this.groupControl1.TabIndex = 7;
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
            // cmb_search
            // 
            this.cmb_search.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmb_search.FormattingEnabled = true;
            this.cmb_search.Location = new System.Drawing.Point(88, 50);
            this.cmb_search.Name = "cmb_search";
            this.cmb_search.Size = new System.Drawing.Size(137, 21);
            this.cmb_search.TabIndex = 0;
            // 
            // cust_account_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 373);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.panelControl3);
            this.Controls.Add(this.pnl_1);
            this.Name = "cust_account_data";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "مدفوعات عميل";
            this.Load += new System.EventHandler(this.cust_account_data_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_1)).EndInit();
            this.pnl_1.ResumeLayout(false);
            this.pnl_1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.date_convert.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.date_convert.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_save;
        private DevExpress.XtraEditors.PanelControl pnl_1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_payed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_remain;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox cmb_search;
        private DevExpress.XtraEditors.DateEdit date_convert;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_notes;
    }
}