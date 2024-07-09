namespace Data_Laundry
{
    partial class MenuUtama
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
            menuStrip1 = new MenuStrip();
            dataMasterToolStripMenuItem = new ToolStripMenuItem();
            paketLaudryToolStripMenuItem = new ToolStripMenuItem();
            dataKasirToolStripMenuItem = new ToolStripMenuItem();
            dataTransaksiToolStripMenuItem = new ToolStripMenuItem();
            dataUserToolStripMenuItem = new ToolStripMenuItem();
            transaksiToolStripMenuItem = new ToolStripMenuItem();
            dataPelangganToolStripMenuItem = new ToolStripMenuItem();
            kasir1ToolStripMenuItem = new ToolStripMenuItem();
            kasir2ToolStripMenuItem = new ToolStripMenuItem();
            kasir3ToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dataMasterToolStripMenuItem, transaksiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(596, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dataMasterToolStripMenuItem
            // 
            dataMasterToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { paketLaudryToolStripMenuItem, dataKasirToolStripMenuItem, dataTransaksiToolStripMenuItem, dataUserToolStripMenuItem });
            dataMasterToolStripMenuItem.Name = "dataMasterToolStripMenuItem";
            dataMasterToolStripMenuItem.Size = new Size(104, 24);
            dataMasterToolStripMenuItem.Text = "Data Master";
            // 
            // paketLaudryToolStripMenuItem
            // 
            paketLaudryToolStripMenuItem.Name = "paketLaudryToolStripMenuItem";
            paketLaudryToolStripMenuItem.Size = new Size(224, 26);
            paketLaudryToolStripMenuItem.Text = "Paket Laudry";
            // 
            // dataKasirToolStripMenuItem
            // 
            dataKasirToolStripMenuItem.Name = "dataKasirToolStripMenuItem";
            dataKasirToolStripMenuItem.Size = new Size(224, 26);
            dataKasirToolStripMenuItem.Text = "Data Kasir";
            // 
            // dataTransaksiToolStripMenuItem
            // 
            dataTransaksiToolStripMenuItem.Name = "dataTransaksiToolStripMenuItem";
            dataTransaksiToolStripMenuItem.Size = new Size(224, 26);
            dataTransaksiToolStripMenuItem.Text = "Data Transaksi";
            // 
            // dataUserToolStripMenuItem
            // 
            dataUserToolStripMenuItem.Name = "dataUserToolStripMenuItem";
            dataUserToolStripMenuItem.Size = new Size(224, 26);
            dataUserToolStripMenuItem.Text = "Data User";
            // 
            // transaksiToolStripMenuItem
            // 
            transaksiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dataPelangganToolStripMenuItem, kasir1ToolStripMenuItem, kasir2ToolStripMenuItem, kasir3ToolStripMenuItem });
            transaksiToolStripMenuItem.Name = "transaksiToolStripMenuItem";
            transaksiToolStripMenuItem.Size = new Size(82, 24);
            transaksiToolStripMenuItem.Text = "Transaksi";
            // 
            // dataPelangganToolStripMenuItem
            // 
            dataPelangganToolStripMenuItem.Name = "dataPelangganToolStripMenuItem";
            dataPelangganToolStripMenuItem.Size = new Size(224, 26);
            dataPelangganToolStripMenuItem.Text = "Data Pelanggan";
            // 
            // kasir1ToolStripMenuItem
            // 
            kasir1ToolStripMenuItem.Name = "kasir1ToolStripMenuItem";
            kasir1ToolStripMenuItem.Size = new Size(224, 26);
            kasir1ToolStripMenuItem.Text = "Kasir 1";
            // 
            // kasir2ToolStripMenuItem
            // 
            kasir2ToolStripMenuItem.Name = "kasir2ToolStripMenuItem";
            kasir2ToolStripMenuItem.Size = new Size(224, 26);
            kasir2ToolStripMenuItem.Text = "Kasir 2";
            // 
            // kasir3ToolStripMenuItem
            // 
            kasir3ToolStripMenuItem.Name = "kasir3ToolStripMenuItem";
            kasir3ToolStripMenuItem.Size = new Size(224, 26);
            kasir3ToolStripMenuItem.Text = "Kasir 3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(232, 58);
            label1.Name = "label1";
            label1.Size = new Size(119, 23);
            label1.TabIndex = 1;
            label1.Text = "Manu Utama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 165);
            label2.Name = "label2";
            label2.Size = new Size(122, 20);
            label2.TabIndex = 2;
            label2.Text = "Selamat Datang";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(258, 210);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 3;
            label3.Text = "______";
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 339);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "MenuUtama";
            Text = "Menu Utama";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dataMasterToolStripMenuItem;
        private ToolStripMenuItem paketLaudryToolStripMenuItem;
        private ToolStripMenuItem dataTransaksiToolStripMenuItem;
        private ToolStripMenuItem dataKasirToolStripMenuItem;
        private ToolStripMenuItem dataUserToolStripMenuItem;
        private ToolStripMenuItem transaksiToolStripMenuItem;
        private ToolStripMenuItem dataPelangganToolStripMenuItem;
        private ToolStripMenuItem kasir1ToolStripMenuItem;
        private ToolStripMenuItem kasir2ToolStripMenuItem;
        private ToolStripMenuItem kasir3ToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}