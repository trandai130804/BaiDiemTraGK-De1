namespace BaiKiemTraGk
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmssv = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btntim = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnkluu = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbblop = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(33, 177);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(736, 261);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(65, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Sinh Viên";
            // 
            // txtmssv
            // 
            this.txtmssv.Location = new System.Drawing.Point(160, 48);
            this.txtmssv.Name = "txtmssv";
            this.txtmssv.Size = new System.Drawing.Size(223, 22);
            this.txtmssv.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(65, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ngày Sinh";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(493, 48);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(243, 22);
            this.txthoten.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(418, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Họ Tên ";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(362, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lớp Học";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 137);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(119, 22);
            this.textBox5.TabIndex = 10;
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(140, 136);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(75, 35);
            this.btntim.TabIndex = 11;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(230, 137);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 12;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(321, 136);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 13;
            this.btnxoa.Text = "Xóa ";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(411, 136);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 14;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(504, 136);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(75, 23);
            this.btnluu.TabIndex = 15;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnkluu
            // 
            this.btnkluu.Enabled = false;
            this.btnkluu.Location = new System.Drawing.Point(603, 136);
            this.btnkluu.Name = "btnkluu";
            this.btnkluu.Size = new System.Drawing.Size(75, 23);
            this.btnkluu.TabIndex = 16;
            this.btnkluu.Text = "K.Lưu";
            this.btnkluu.UseVisualStyleBackColor = true;
            this.btnkluu.Click += new System.EventHandler(this.btnkluu_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(694, 137);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 17;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cbblop);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(56, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 119);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Chi Tiết";
            // 
            // cbblop
            // 
            this.cbblop.FormattingEnabled = true;
            this.cbblop.Location = new System.Drawing.Point(437, 72);
            this.cbblop.Name = "cbblop";
            this.cbblop.Size = new System.Drawing.Size(185, 24);
            this.cbblop.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(104, 72);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnkluu);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmssv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Danh Sách Sinh Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmssv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnkluu;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbblop;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

