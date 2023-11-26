namespace library.BasicData
{
    partial class cust_account_popup
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
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.btn_close = new System.Windows.Forms.Button();
            this.cust_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payed_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_payed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_search
            // 
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cust_name,
            this.payed_value,
            this.remain_value,
            this.date_payed,
            this.account_notes});
            this.dgv_search.Location = new System.Drawing.Point(12, 12);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_search.Size = new System.Drawing.Size(551, 217);
            this.dgv_search.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 235);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 34);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "إغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // cust_name
            // 
            this.cust_name.DataPropertyName = "cust_name";
            this.cust_name.HeaderText = "اسم العميل";
            this.cust_name.Name = "cust_name";
            // 
            // payed_value
            // 
            this.payed_value.DataPropertyName = "payed_value";
            this.payed_value.HeaderText = "المبلغ المدفوع";
            this.payed_value.Name = "payed_value";
            // 
            // remain_value
            // 
            this.remain_value.DataPropertyName = "remain_value";
            this.remain_value.HeaderText = "المبلغ المتبقى";
            this.remain_value.Name = "remain_value";
            // 
            // date_payed
            // 
            this.date_payed.DataPropertyName = "date_payed";
            this.date_payed.HeaderText = "تاريخ السداد";
            this.date_payed.Name = "date_payed";
            // 
            // account_notes
            // 
            this.account_notes.DataPropertyName = "account_notes";
            this.account_notes.HeaderText = "ملاحظات";
            this.account_notes.Name = "account_notes";
            // 
            // cust_account_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 279);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_search);
            this.Name = "cust_account_popup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "عرض حركات عميل";
            this.Load += new System.EventHandler(this.cust_account_popup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn payed_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_payed;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_notes;
    }
}