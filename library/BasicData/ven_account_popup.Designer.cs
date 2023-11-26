namespace library.BasicData
{
    partial class ven_account_popup
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
            this.btn_close = new System.Windows.Forms.Button();
            this.dgv_search = new System.Windows.Forms.DataGridView();
            this.ven_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payed_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remain_value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payed_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.account_notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(12, 314);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(76, 34);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "إغلاق";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // dgv_search
            // 
            this.dgv_search.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_search.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ven_name,
            this.payed_value,
            this.remain_value,
            this.payed_date,
            this.account_notes});
            this.dgv_search.Location = new System.Drawing.Point(12, 12);
            this.dgv_search.Name = "dgv_search";
            this.dgv_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_search.Size = new System.Drawing.Size(551, 276);
            this.dgv_search.TabIndex = 6;
            // 
            // ven_name
            // 
            this.ven_name.DataPropertyName = "ven_name";
            this.ven_name.HeaderText = "اسم المورد";
            this.ven_name.Name = "ven_name";
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
            // payed_date
            // 
            this.payed_date.DataPropertyName = "payed_date";
            this.payed_date.HeaderText = "تاريخ السداد";
            this.payed_date.Name = "payed_date";
            // 
            // account_notes
            // 
            this.account_notes.DataPropertyName = "account_notes";
            this.account_notes.HeaderText = "ملاحظات";
            this.account_notes.Name = "account_notes";
            // 
            // ven_account_popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 357);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.dgv_search);
            this.Name = "ven_account_popup";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "عرض حسابات مورد";
            this.Load += new System.EventHandler(this.ven_account_popup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_search)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.DataGridView dgv_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn ven_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn payed_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn remain_value;
        private System.Windows.Forms.DataGridViewTextBoxColumn payed_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn account_notes;
    }
}