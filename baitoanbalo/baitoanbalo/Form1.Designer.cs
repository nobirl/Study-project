namespace baitoanbalo
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_nhap = new System.Windows.Forms.Button();
            this.txt_maxItem = new System.Windows.Forms.TextBox();
            this.txt_maxW = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_sum_val = new System.Windows.Forms.TextBox();
            this.txt_sum_w = new System.Windows.Forms.TextBox();
            this.bt_result = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_info = new System.Windows.Forms.DataGridView();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wei = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.val = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_nhap);
            this.groupBox1.Controls.Add(this.txt_maxItem);
            this.groupBox1.Controls.Add(this.txt_maxW);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(945, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Điều Kiển";
            // 
            // bt_nhap
            // 
            this.bt_nhap.Location = new System.Drawing.Point(721, 49);
            this.bt_nhap.Margin = new System.Windows.Forms.Padding(4);
            this.bt_nhap.Name = "bt_nhap";
            this.bt_nhap.Size = new System.Drawing.Size(100, 28);
            this.bt_nhap.TabIndex = 4;
            this.bt_nhap.Text = "Nhập";
            this.bt_nhap.UseVisualStyleBackColor = true;
            this.bt_nhap.Click += new System.EventHandler(this.bt_nhap_Click);
            // 
            // txt_maxItem
            // 
            this.txt_maxItem.Location = new System.Drawing.Point(132, 52);
            this.txt_maxItem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maxItem.Name = "txt_maxItem";
            this.txt_maxItem.Size = new System.Drawing.Size(140, 22);
            this.txt_maxItem.TabIndex = 2;
            // 
            // txt_maxW
            // 
            this.txt_maxW.Location = new System.Drawing.Point(442, 52);
            this.txt_maxW.Margin = new System.Windows.Forms.Padding(4);
            this.txt_maxW.Name = "txt_maxW";
            this.txt_maxW.Size = new System.Drawing.Size(164, 22);
            this.txt_maxW.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Khối Lượng Tối Đa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Lượng Đồ Vật";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_name);
            this.groupBox2.Controls.Add(this.txt_sum_val);
            this.groupBox2.Controls.Add(this.txt_sum_w);
            this.groupBox2.Controls.Add(this.bt_result);
            this.groupBox2.Location = new System.Drawing.Point(630, 116);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(331, 385);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kết Quả";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên Đồ Vật Đã Lấy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Tổng Giá Trị";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng Khối Lượng";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(141, 231);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4);
            this.txt_name.Multiline = true;
            this.txt_name.Name = "txt_name";
            this.txt_name.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_name.Size = new System.Drawing.Size(167, 146);
            this.txt_name.TabIndex = 3;
            // 
            // txt_sum_val
            // 
            this.txt_sum_val.Location = new System.Drawing.Point(141, 169);
            this.txt_sum_val.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sum_val.Name = "txt_sum_val";
            this.txt_sum_val.Size = new System.Drawing.Size(167, 22);
            this.txt_sum_val.TabIndex = 2;
            // 
            // txt_sum_w
            // 
            this.txt_sum_w.Location = new System.Drawing.Point(141, 101);
            this.txt_sum_w.Margin = new System.Windows.Forms.Padding(4);
            this.txt_sum_w.Name = "txt_sum_w";
            this.txt_sum_w.Size = new System.Drawing.Size(167, 22);
            this.txt_sum_w.TabIndex = 1;
            // 
            // bt_result
            // 
            this.bt_result.Location = new System.Drawing.Point(107, 39);
            this.bt_result.Margin = new System.Windows.Forms.Padding(4);
            this.bt_result.Name = "bt_result";
            this.bt_result.Size = new System.Drawing.Size(100, 28);
            this.bt_result.TabIndex = 0;
            this.bt_result.Text = "Kết Quả";
            this.bt_result.UseVisualStyleBackColor = true;
            this.bt_result.Click += new System.EventHandler(this.bt_result_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // name
            // 
            this.name.HeaderText = "Tên Đồ Vật";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.Width = 300;
            // 
            // dgv_info
            // 
            this.dgv_info.AllowUserToAddRows = false;
            this.dgv_info.AllowUserToDeleteRows = false;
            this.dgv_info.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_info.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item_name,
            this.wei,
            this.val});
            this.dgv_info.Location = new System.Drawing.Point(16, 116);
            this.dgv_info.Name = "dgv_info";
            this.dgv_info.RowHeadersWidth = 51;
            this.dgv_info.RowTemplate.Height = 24;
            this.dgv_info.Size = new System.Drawing.Size(606, 377);
            this.dgv_info.TabIndex = 3;
            // 
            // item_name
            // 
            this.item_name.HeaderText = "Tên đồ vật";
            this.item_name.MinimumWidth = 6;
            this.item_name.Name = "item_name";
            this.item_name.Width = 300;
            // 
            // wei
            // 
            this.wei.HeaderText = "Trọng lượng";
            this.wei.MinimumWidth = 6;
            this.wei.Name = "wei";
            this.wei.Width = 125;
            // 
            // val
            // 
            this.val.HeaderText = "Giá trị";
            this.val.MinimumWidth = 6;
            this.val.Name = "val";
            this.val.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 510);
            this.Controls.Add(this.dgv_info);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_info)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_maxItem;
        private System.Windows.Forms.TextBox txt_maxW;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_nhap;
        private System.Windows.Forms.Button bt_result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_sum_val;
        private System.Windows.Forms.TextBox txt_sum_w;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridView dgv_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn wei;
        private System.Windows.Forms.DataGridViewTextBoxColumn val;
    }
}

