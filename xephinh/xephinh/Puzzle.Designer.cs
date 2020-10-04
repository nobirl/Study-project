namespace xephinh
{
    partial class puzzle_form
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
            this.components = new System.ComponentModel.Container();
            this.choose_img = new System.Windows.Forms.Button();
            this.puzzle = new System.Windows.Forms.GroupBox();
            this.bt_lv1 = new System.Windows.Forms.Button();
            this.bt_lv2 = new System.Windows.Forms.Button();
            this.bt_lv4 = new System.Windows.Forms.Button();
            this.bt_lv5 = new System.Windows.Forms.Button();
            this.bt_lv3 = new System.Windows.Forms.Button();
            this.gb_lv = new System.Windows.Forms.GroupBox();
            this.gb_original = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_lv.SuspendLayout();
            this.SuspendLayout();
            // 
            // choose_img
            // 
            this.choose_img.Location = new System.Drawing.Point(818, 25);
            this.choose_img.Name = "choose_img";
            this.choose_img.Size = new System.Drawing.Size(65, 54);
            this.choose_img.TabIndex = 2;
            this.choose_img.Text = "Choose image";
            this.choose_img.UseVisualStyleBackColor = true;
            this.choose_img.Click += new System.EventHandler(this.choose_img_Click);
            // 
            // puzzle
            // 
            this.puzzle.Location = new System.Drawing.Point(12, 25);
            this.puzzle.Name = "puzzle";
            this.puzzle.Size = new System.Drawing.Size(800, 800);
            this.puzzle.TabIndex = 3;
            this.puzzle.TabStop = false;
            this.puzzle.Text = "Puzzle";
            // 
            // bt_lv1
            // 
            this.bt_lv1.Location = new System.Drawing.Point(77, 38);
            this.bt_lv1.Name = "bt_lv1";
            this.bt_lv1.Size = new System.Drawing.Size(199, 41);
            this.bt_lv1.TabIndex = 4;
            this.bt_lv1.Text = "Level 1";
            this.bt_lv1.UseVisualStyleBackColor = true;
            this.bt_lv1.Click += new System.EventHandler(this.bt_lv1_Click);
            // 
            // bt_lv2
            // 
            this.bt_lv2.Location = new System.Drawing.Point(77, 91);
            this.bt_lv2.Name = "bt_lv2";
            this.bt_lv2.Size = new System.Drawing.Size(199, 41);
            this.bt_lv2.TabIndex = 6;
            this.bt_lv2.Text = "Level 2";
            this.bt_lv2.UseVisualStyleBackColor = true;
            this.bt_lv2.Click += new System.EventHandler(this.bt_lv2_Click);
            // 
            // bt_lv4
            // 
            this.bt_lv4.Location = new System.Drawing.Point(77, 204);
            this.bt_lv4.Name = "bt_lv4";
            this.bt_lv4.Size = new System.Drawing.Size(199, 41);
            this.bt_lv4.TabIndex = 8;
            this.bt_lv4.Text = "Level 4";
            this.bt_lv4.UseVisualStyleBackColor = true;
            this.bt_lv4.Click += new System.EventHandler(this.bt_lv4_Click);
            // 
            // bt_lv5
            // 
            this.bt_lv5.Location = new System.Drawing.Point(77, 262);
            this.bt_lv5.Name = "bt_lv5";
            this.bt_lv5.Size = new System.Drawing.Size(199, 41);
            this.bt_lv5.TabIndex = 9;
            this.bt_lv5.Text = "Level 5";
            this.bt_lv5.UseVisualStyleBackColor = true;
            this.bt_lv5.Click += new System.EventHandler(this.bt_lv5_Click);
            // 
            // bt_lv3
            // 
            this.bt_lv3.Location = new System.Drawing.Point(77, 146);
            this.bt_lv3.Name = "bt_lv3";
            this.bt_lv3.Size = new System.Drawing.Size(199, 41);
            this.bt_lv3.TabIndex = 10;
            this.bt_lv3.Text = "Level 3";
            this.bt_lv3.UseVisualStyleBackColor = true;
            this.bt_lv3.Click += new System.EventHandler(this.bt_lv3_Click);
            // 
            // gb_lv
            // 
            this.gb_lv.Controls.Add(this.bt_lv5);
            this.gb_lv.Controls.Add(this.bt_lv3);
            this.gb_lv.Controls.Add(this.bt_lv1);
            this.gb_lv.Controls.Add(this.bt_lv2);
            this.gb_lv.Controls.Add(this.bt_lv4);
            this.gb_lv.Location = new System.Drawing.Point(818, 118);
            this.gb_lv.Name = "gb_lv";
            this.gb_lv.Size = new System.Drawing.Size(345, 340);
            this.gb_lv.TabIndex = 11;
            this.gb_lv.TabStop = false;
            this.gb_lv.Text = "Chọn level";
            // 
            // gb_original
            // 
            this.gb_original.Location = new System.Drawing.Point(844, 525);
            this.gb_original.Name = "gb_original";
            this.gb_original.Size = new System.Drawing.Size(300, 300);
            this.gb_original.TabIndex = 12;
            this.gb_original.TabStop = false;
            this.gb_original.Text = "Ảnh gốc";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(951, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1222, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(991, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 25);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(966, 480);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 39);
            this.button3.TabIndex = 16;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1236, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // puzzle_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1622, 853);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gb_original);
            this.Controls.Add(this.gb_lv);
            this.Controls.Add(this.puzzle);
            this.Controls.Add(this.choose_img);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "puzzle_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Puzzle";
            this.gb_lv.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button choose_img;
        private System.Windows.Forms.GroupBox puzzle;
        private System.Windows.Forms.Button bt_lv1;
        private System.Windows.Forms.Button bt_lv2;
        private System.Windows.Forms.Button bt_lv4;
        private System.Windows.Forms.Button bt_lv5;
        private System.Windows.Forms.Button bt_lv3;
        private System.Windows.Forms.GroupBox gb_lv;
        private System.Windows.Forms.GroupBox gb_original;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

