namespace Baithi_Cau2_NguyenMinhKhang_02PM16B1D1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txt_hoten = new TextBox();
            txt_msnv = new TextBox();
            txt_chucvu = new TextBox();
            txt_luong = new TextBox();
            dt_1 = new DataGridView();
            label6 = new Label();
            txt_teamz = new TextBox();
            button2 = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dt_1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(550, 113);
            button1.Name = "button1";
            button1.Size = new Size(100, 47);
            button1.TabIndex = 1;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(260, 24);
            label1.Name = "label1";
            label1.Size = new Size(330, 43);
            label1.TabIndex = 2;
            label1.Text = "Quản Lý Nhân Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 113);
            label2.Name = "label2";
            label2.Size = new Size(84, 27);
            label2.TabIndex = 3;
            label2.Text = "Họ Tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 159);
            label3.Name = "label3";
            label3.Size = new Size(78, 27);
            label3.TabIndex = 3;
            label3.Text = "MSNV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 200);
            label4.Name = "label4";
            label4.Size = new Size(98, 27);
            label4.TabIndex = 3;
            label4.Text = "Chức Vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 241);
            label5.Name = "label5";
            label5.Size = new Size(76, 27);
            label5.TabIndex = 3;
            label5.Text = "Lương";
            // 
            // txt_hoten
            // 
            txt_hoten.Location = new Point(169, 110);
            txt_hoten.Name = "txt_hoten";
            txt_hoten.Size = new Size(266, 35);
            txt_hoten.TabIndex = 4;
            // 
            // txt_msnv
            // 
            txt_msnv.Location = new Point(169, 151);
            txt_msnv.Name = "txt_msnv";
            txt_msnv.Size = new Size(266, 35);
            txt_msnv.TabIndex = 4;
            // 
            // txt_chucvu
            // 
            txt_chucvu.Location = new Point(169, 192);
            txt_chucvu.Name = "txt_chucvu";
            txt_chucvu.Size = new Size(266, 35);
            txt_chucvu.TabIndex = 4;
            // 
            // txt_luong
            // 
            txt_luong.Location = new Point(169, 233);
            txt_luong.Name = "txt_luong";
            txt_luong.Size = new Size(266, 35);
            txt_luong.TabIndex = 4;
            // 
            // dt_1
            // 
            dt_1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dt_1.Location = new Point(24, 340);
            dt_1.Name = "dt_1";
            dt_1.Size = new Size(726, 257);
            dt_1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 282);
            label6.Name = "label6";
            label6.Size = new Size(103, 27);
            label6.TabIndex = 3;
            label6.Text = "TeamSize";
            // 
            // txt_teamz
            // 
            txt_teamz.Location = new Point(169, 274);
            txt_teamz.Name = "txt_teamz";
            txt_teamz.Size = new Size(266, 35);
            txt_teamz.TabIndex = 4;
            // 
            // button2
            // 
            button2.Location = new Point(550, 180);
            button2.Name = "button2";
            button2.Size = new Size(100, 56);
            button2.TabIndex = 7;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(550, 258);
            button3.Name = "button3";
            button3.Size = new Size(100, 51);
            button3.TabIndex = 9;
            button3.Text = "Sửa";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 600);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(dt_1);
            Controls.Add(txt_teamz);
            Controls.Add(txt_luong);
            Controls.Add(txt_chucvu);
            Controls.Add(txt_msnv);
            Controls.Add(label6);
            Controls.Add(txt_hoten);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IsMdiContainer = true;
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Quản Lý Nhân Viên";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dt_1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Label label4;
        private Label label5;
        private TextBox txt_hoten;
        private TextBox txt_msnv;
        private TextBox txt_chucvu;
        private TextBox txt_luong;
        private DataGridView dt_1;
        private Label label6;
        private TextBox txt_teamz;
        private Button bnt_xoa;
        private Button button3;
    }
}
