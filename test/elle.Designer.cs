namespace test
{
    partial class elle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(elle));
            adl = new Label();
            soyadl = new Label();
            numaral = new Label();
            sinifl = new Label();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            kaydetb = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            textBox5 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // adl
            // 
            adl.AutoSize = true;
            adl.Font = new Font("Segoe UI", 12F);
            adl.Location = new Point(12, 59);
            adl.Name = "adl";
            adl.Size = new Size(41, 28);
            adl.TabIndex = 2;
            adl.Text = "Ad:";
            // 
            // soyadl
            // 
            soyadl.AutoSize = true;
            soyadl.Font = new Font("Segoe UI", 12F);
            soyadl.Location = new Point(12, 120);
            soyadl.Name = "soyadl";
            soyadl.Size = new Size(71, 28);
            soyadl.TabIndex = 3;
            soyadl.Text = "Soyad:";
            // 
            // numaral
            // 
            numaral.AutoSize = true;
            numaral.Font = new Font("Segoe UI", 12F);
            numaral.Location = new Point(12, 181);
            numaral.Name = "numaral";
            numaral.Size = new Size(86, 28);
            numaral.TabIndex = 4;
            numaral.Text = "Numara:";
            // 
            // sinifl
            // 
            sinifl.AutoSize = true;
            sinifl.Font = new Font("Segoe UI", 12F);
            sinifl.Location = new Point(12, 242);
            sinifl.Name = "sinifl";
            sinifl.Size = new Size(54, 28);
            sinifl.TabIndex = 5;
            sinifl.Text = "Sınıf:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(278, 32);
            label1.TabIndex = 6;
            label1.Text = "Öğrenci Bilgilerini Giriniz";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 90);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(278, 27);
            textBox1.TabIndex = 7;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 151);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(278, 27);
            textBox2.TabIndex = 8;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 212);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(278, 27);
            textBox3.TabIndex = 9;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 273);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 27);
            textBox4.TabIndex = 10;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // kaydetb
            // 
            kaydetb.Location = new Point(109, 380);
            kaydetb.Name = "kaydetb";
            kaydetb.Size = new Size(94, 29);
            kaydetb.TabIndex = 11;
            kaydetb.Text = "Kaydet";
            kaydetb.UseVisualStyleBackColor = true;
            kaydetb.Click += kaydetb_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(324, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(614, 349);
            dataGridView1.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(397, 9);
            label2.Name = "label2";
            label2.Size = new Size(151, 32);
            label2.TabIndex = 13;
            label2.Text = "Okul Tablosu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(12, 315);
            label3.Name = "label3";
            label3.Size = new Size(77, 28);
            label3.TabIndex = 14;
            label3.Text = "Okul ID";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 346);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(278, 27);
            textBox5.TabIndex = 15;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // elle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 421);
            Controls.Add(textBox5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(kaydetb);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(sinifl);
            Controls.Add(numaral);
            Controls.Add(soyadl);
            Controls.Add(adl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "elle";
            Text = "Elle Giriş";
            Load += elle_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label adl;
        private Label soyadl;
        private Label numaral;
        private Label sinifl;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button kaydetb;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private TextBox textBox5;
    }
}