namespace WinFormsApp1
{
    partial class MasaOzellikleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasaOzellikleri));
            this.secilenDeger = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.minBaslik = new System.Windows.Forms.Label();
            this.maxBaslik = new System.Windows.Forms.Label();
            this.aralikBaslik = new System.Windows.Forms.Label();
            this.hizEvet = new System.Windows.Forms.Button();
            this.hizHayir = new System.Windows.Forms.Button();
            this.hizliLabel = new System.Windows.Forms.Label();
            this.tekHayir = new System.Windows.Forms.Button();
            this.tekEvet = new System.Windows.Forms.Button();
            this.rovansHayir = new System.Windows.Forms.Button();
            this.rovansEvet = new System.Windows.Forms.Button();
            this.teketekLabel = new System.Windows.Forms.Label();
            this.rovansLabel = new System.Windows.Forms.Label();
            this.filtrele = new System.Windows.Forms.Button();
            this.sonuc = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // secilenDeger
            // 
            this.secilenDeger.AutoSize = true;
            this.secilenDeger.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.secilenDeger.Location = new System.Drawing.Point(610, 75);
            this.secilenDeger.Name = "secilenDeger";
            this.secilenDeger.Size = new System.Drawing.Size(36, 17);
            this.secilenDeger.TabIndex = 1;
            this.secilenDeger.Text = "200$";
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.LargeChange = 100;
            this.trackBar1.Location = new System.Drawing.Point(261, 117);
            this.trackBar1.Maximum = 5000;
            this.trackBar1.Minimum = 200;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.RightToLeftLayout = true;
            this.trackBar1.Size = new System.Drawing.Size(742, 45);
            this.trackBar1.TabIndex = 2;
            this.trackBar1.TabStop = false;
            this.trackBar1.Value = 200;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // minBaslik
            // 
            this.minBaslik.AutoSize = true;
            this.minBaslik.Location = new System.Drawing.Point(224, 117);
            this.minBaslik.Name = "minBaslik";
            this.minBaslik.Size = new System.Drawing.Size(31, 30);
            this.minBaslik.TabIndex = 3;
            this.minBaslik.Text = "min\r\n200$\r\n";
            // 
            // maxBaslik
            // 
            this.maxBaslik.AutoSize = true;
            this.maxBaslik.Location = new System.Drawing.Point(1009, 117);
            this.maxBaslik.Name = "maxBaslik";
            this.maxBaslik.Size = new System.Drawing.Size(37, 30);
            this.maxBaslik.TabIndex = 4;
            this.maxBaslik.Text = "max\r\n5000$\r\n";
            // 
            // aralikBaslik
            // 
            this.aralikBaslik.AutoSize = true;
            this.aralikBaslik.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.aralikBaslik.Location = new System.Drawing.Point(114, 117);
            this.aralikBaslik.Name = "aralikBaslik";
            this.aralikBaslik.Size = new System.Drawing.Size(97, 20);
            this.aralikBaslik.TabIndex = 5;
            this.aralikBaslik.Text = "Bahis Araligi";
            // 
            // hizEvet
            // 
            this.hizEvet.BackColor = System.Drawing.Color.White;
            this.hizEvet.Location = new System.Drawing.Point(279, 298);
            this.hizEvet.Name = "hizEvet";
            this.hizEvet.Size = new System.Drawing.Size(75, 23);
            this.hizEvet.TabIndex = 6;
            this.hizEvet.Text = "EVET";
            this.hizEvet.UseVisualStyleBackColor = false;
            this.hizEvet.Click += new System.EventHandler(this.hizEvet_Click);
            // 
            // hizHayir
            // 
            this.hizHayir.BackColor = System.Drawing.Color.White;
            this.hizHayir.ForeColor = System.Drawing.Color.Black;
            this.hizHayir.Location = new System.Drawing.Point(351, 298);
            this.hizHayir.Name = "hizHayir";
            this.hizHayir.Size = new System.Drawing.Size(75, 23);
            this.hizHayir.TabIndex = 7;
            this.hizHayir.Text = "HAYIR";
            this.hizHayir.UseVisualStyleBackColor = false;
            this.hizHayir.Click += new System.EventHandler(this.hizHayir_Click);
            // 
            // hizliLabel
            // 
            this.hizliLabel.AutoSize = true;
            this.hizliLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hizliLabel.Location = new System.Drawing.Point(333, 254);
            this.hizliLabel.Name = "hizliLabel";
            this.hizliLabel.Size = new System.Drawing.Size(36, 17);
            this.hizliLabel.TabIndex = 8;
            this.hizliLabel.Text = "Hizli";
            // 
            // tekHayir
            // 
            this.tekHayir.BackColor = System.Drawing.Color.White;
            this.tekHayir.ForeColor = System.Drawing.Color.Black;
            this.tekHayir.Location = new System.Drawing.Point(626, 298);
            this.tekHayir.Name = "tekHayir";
            this.tekHayir.Size = new System.Drawing.Size(75, 23);
            this.tekHayir.TabIndex = 10;
            this.tekHayir.Text = "HAYIR";
            this.tekHayir.UseVisualStyleBackColor = false;
            this.tekHayir.Click += new System.EventHandler(this.tekHayir_Click);
            // 
            // tekEvet
            // 
            this.tekEvet.BackColor = System.Drawing.Color.White;
            this.tekEvet.Location = new System.Drawing.Point(554, 298);
            this.tekEvet.Name = "tekEvet";
            this.tekEvet.Size = new System.Drawing.Size(75, 23);
            this.tekEvet.TabIndex = 9;
            this.tekEvet.Text = "EVET";
            this.tekEvet.UseVisualStyleBackColor = false;
            this.tekEvet.Click += new System.EventHandler(this.tekEvet_Click);
            // 
            // rovansHayir
            // 
            this.rovansHayir.BackColor = System.Drawing.Color.White;
            this.rovansHayir.ForeColor = System.Drawing.Color.Black;
            this.rovansHayir.Location = new System.Drawing.Point(928, 298);
            this.rovansHayir.Name = "rovansHayir";
            this.rovansHayir.Size = new System.Drawing.Size(75, 23);
            this.rovansHayir.TabIndex = 12;
            this.rovansHayir.Text = "HAYIR";
            this.rovansHayir.UseVisualStyleBackColor = false;
            this.rovansHayir.Click += new System.EventHandler(this.rovansHayir_Click);
            // 
            // rovansEvet
            // 
            this.rovansEvet.BackColor = System.Drawing.Color.White;
            this.rovansEvet.Location = new System.Drawing.Point(856, 298);
            this.rovansEvet.Name = "rovansEvet";
            this.rovansEvet.Size = new System.Drawing.Size(75, 23);
            this.rovansEvet.TabIndex = 11;
            this.rovansEvet.Text = "EVET";
            this.rovansEvet.UseVisualStyleBackColor = false;
            this.rovansEvet.Click += new System.EventHandler(this.rovansEvet_Click);
            // 
            // teketekLabel
            // 
            this.teketekLabel.AutoSize = true;
            this.teketekLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.teketekLabel.Location = new System.Drawing.Point(597, 254);
            this.teketekLabel.Name = "teketekLabel";
            this.teketekLabel.Size = new System.Drawing.Size(61, 17);
            this.teketekLabel.TabIndex = 13;
            this.teketekLabel.Text = "Teke Tek";
            // 
            // rovansLabel
            // 
            this.rovansLabel.AutoSize = true;
            this.rovansLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rovansLabel.Location = new System.Drawing.Point(899, 254);
            this.rovansLabel.Name = "rovansLabel";
            this.rovansLabel.Size = new System.Drawing.Size(60, 17);
            this.rovansLabel.TabIndex = 14;
            this.rovansLabel.Text = "Rovansli";
            // 
            // filtrele
            // 
            this.filtrele.Location = new System.Drawing.Point(554, 380);
            this.filtrele.Name = "filtrele";
            this.filtrele.Size = new System.Drawing.Size(147, 46);
            this.filtrele.TabIndex = 15;
            this.filtrele.Text = "FILTRELE";
            this.filtrele.UseVisualStyleBackColor = true;
            this.filtrele.Click += new System.EventHandler(this.filtrele_Click);
            // 
            // sonuc
            // 
            this.sonuc.AutoSize = true;
            this.sonuc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.sonuc.Location = new System.Drawing.Point(279, 491);
            this.sonuc.Name = "sonuc";
            this.sonuc.Size = new System.Drawing.Size(0, 21);
            this.sonuc.TabIndex = 16;
            this.sonuc.Visible = false;
            // 
            // MasaOzellikleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 567);
            this.Controls.Add(this.sonuc);
            this.Controls.Add(this.filtrele);
            this.Controls.Add(this.rovansLabel);
            this.Controls.Add(this.teketekLabel);
            this.Controls.Add(this.rovansHayir);
            this.Controls.Add(this.rovansEvet);
            this.Controls.Add(this.tekHayir);
            this.Controls.Add(this.tekEvet);
            this.Controls.Add(this.hizliLabel);
            this.Controls.Add(this.hizHayir);
            this.Controls.Add(this.hizEvet);
            this.Controls.Add(this.aralikBaslik);
            this.Controls.Add(this.maxBaslik);
            this.Controls.Add(this.minBaslik);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.secilenDeger);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MasaOzellikleri";
            this.Text = "Masa Ozelliklerini Seciniz";
            this.Load += new System.EventHandler(this.MasaOzellikleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label secilenDeger;
        private TrackBar trackBar1;
        private Label minBaslik;
        private Label maxBaslik;
        private Label aralikBaslik;
        private Button hizEvet;
        private Button hizHayir;
        private Label hizliLabel;
        private Button tekHayir;
        private Button tekEvet;
        private Button rovansHayir;
        private Button rovansEvet;
        private Label teketekLabel;
        private Label rovansLabel;
        private Button filtrele;
        private Label sonuc;
    }
}