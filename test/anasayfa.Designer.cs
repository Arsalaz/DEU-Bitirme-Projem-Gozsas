namespace test
{
    partial class Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Anasayfa));
            menuStrip1 = new MenuStrip();
            veriGirToolStripMenuItem = new ToolStripMenuItem();
            elleVeriGirToolStripMenuItem = new ToolStripMenuItem();
            okulKaydetToolStripMenuItem = new ToolStripMenuItem();
            sasılıkTestiToolStripMenuItem = new ToolStripMenuItem();
            kontrolToolStripMenuItem = new ToolStripMenuItem();
            resimKontrolToolStripMenuItem = new ToolStripMenuItem();
            yardımVeKullanımToolStripMenuItem = new ToolStripMenuItem();
            dataGridView1 = new DataGridView();
            yenile = new Button();
            yazdırToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ActiveCaption;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { veriGirToolStripMenuItem, sasılıkTestiToolStripMenuItem, kontrolToolStripMenuItem, yardımVeKullanımToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1211, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // veriGirToolStripMenuItem
            // 
            veriGirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { elleVeriGirToolStripMenuItem, okulKaydetToolStripMenuItem });
            veriGirToolStripMenuItem.Name = "veriGirToolStripMenuItem";
            veriGirToolStripMenuItem.Size = new Size(70, 24);
            veriGirToolStripMenuItem.Text = "Veri gir";
            // 
            // elleVeriGirToolStripMenuItem
            // 
            elleVeriGirToolStripMenuItem.Name = "elleVeriGirToolStripMenuItem";
            elleVeriGirToolStripMenuItem.Size = new Size(172, 26);
            elleVeriGirToolStripMenuItem.Text = "Elle veri gir";
            elleVeriGirToolStripMenuItem.Click += elleVeriGirToolStripMenuItem_Click;
            // 
            // okulKaydetToolStripMenuItem
            // 
            okulKaydetToolStripMenuItem.Name = "okulKaydetToolStripMenuItem";
            okulKaydetToolStripMenuItem.Size = new Size(172, 26);
            okulKaydetToolStripMenuItem.Text = "Okul Kaydet";
            okulKaydetToolStripMenuItem.Click += okulKaydetToolStripMenuItem_Click;
            // 
            // sasılıkTestiToolStripMenuItem
            // 
            sasılıkTestiToolStripMenuItem.Name = "sasılıkTestiToolStripMenuItem";
            sasılıkTestiToolStripMenuItem.Size = new Size(98, 24);
            sasılıkTestiToolStripMenuItem.Text = "Şaşılık Testi";
            sasılıkTestiToolStripMenuItem.Click += brucknerTestiToolStripMenuItem_Click;
            // 
            // kontrolToolStripMenuItem
            // 
            kontrolToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resimKontrolToolStripMenuItem, yazdırToolStripMenuItem });
            kontrolToolStripMenuItem.Name = "kontrolToolStripMenuItem";
            kontrolToolStripMenuItem.Size = new Size(72, 24);
            kontrolToolStripMenuItem.Text = "Kontrol";
            // 
            // resimKontrolToolStripMenuItem
            // 
            resimKontrolToolStripMenuItem.Name = "resimKontrolToolStripMenuItem";
            resimKontrolToolStripMenuItem.Size = new Size(224, 26);
            resimKontrolToolStripMenuItem.Text = "Resim kontrol";
            resimKontrolToolStripMenuItem.Click += resimKontrolToolStripMenuItem_Click;
            // 
            // yardımVeKullanımToolStripMenuItem
            // 
            yardımVeKullanımToolStripMenuItem.Name = "yardımVeKullanımToolStripMenuItem";
            yardımVeKullanımToolStripMenuItem.Size = new Size(150, 24);
            yardımVeKullanımToolStripMenuItem.Text = "Yardım ve Kullanım";
            yardımVeKullanımToolStripMenuItem.Click += yardımVeKullanımToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.GridColor = SystemColors.Menu;
            dataGridView1.Location = new Point(12, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1187, 569);
            dataGridView1.TabIndex = 1;
            // 
            // yenile
            // 
            yenile.Location = new Point(12, 616);
            yenile.Name = "yenile";
            yenile.Size = new Size(1187, 29);
            yenile.TabIndex = 2;
            yenile.Text = "Listeyi Yenile";
            yenile.UseVisualStyleBackColor = true;
            yenile.Click += yenile_Click;
            // 
            // yazdırToolStripMenuItem
            // 
            yazdırToolStripMenuItem.Name = "yazdırToolStripMenuItem";
            yazdırToolStripMenuItem.Size = new Size(224, 26);
            yazdırToolStripMenuItem.Text = "Yazdır";
            yazdırToolStripMenuItem.Click += yazdırToolStripMenuItem_Click;
            // 
            // Anasayfa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 657);
            Controls.Add(yenile);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Anasayfa";
            StartPosition = FormStartPosition.Manual;
            Text = "Ana Sayfa";
            Load += Anasayfa_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem veriGirToolStripMenuItem;
        private ToolStripMenuItem elleVeriGirToolStripMenuItem;
        private ToolStripMenuItem sasılıkTestiToolStripMenuItem;
        private DataGridView dataGridView1;
        private Button yenile;
        private ToolStripMenuItem okulKaydetToolStripMenuItem;
        private ToolStripMenuItem kontrolToolStripMenuItem;
        private ToolStripMenuItem resimKontrolToolStripMenuItem;
        private ToolStripMenuItem yardımVeKullanımToolStripMenuItem;
        private ToolStripMenuItem yazdırToolStripMenuItem;
    }
}
