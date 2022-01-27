
namespace k4_kasir {
  partial class AddMenu {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddMenu));
      this.gambarBarang = new System.Windows.Forms.PictureBox();
      this.btnSimpan = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.btnKembali = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.txtHarga = new System.Windows.Forms.TextBox();
      this.txtStok = new System.Windows.Forms.TextBox();
      this.btnAturGambar = new System.Windows.Forms.Button();
      this.cbKategori = new System.Windows.Forms.ComboBox();
      this.lblKategori = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.gambarBarang)).BeginInit();
      this.SuspendLayout();
      // 
      // gambarBarang
      // 
      this.gambarBarang.BackColor = System.Drawing.Color.WhiteSmoke;
      this.gambarBarang.Image = global::k4_kasir.Properties.Resources.fast_food;
      this.gambarBarang.Location = new System.Drawing.Point(-1, -1);
      this.gambarBarang.Name = "gambarBarang";
      this.gambarBarang.Size = new System.Drawing.Size(277, 156);
      this.gambarBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.gambarBarang.TabIndex = 27;
      this.gambarBarang.TabStop = false;
      // 
      // btnSimpan
      // 
      this.btnSimpan.BackColor = System.Drawing.Color.IndianRed;
      this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSimpan.FlatAppearance.BorderSize = 0;
      this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSimpan.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSimpan.ForeColor = System.Drawing.Color.White;
      this.btnSimpan.ImageIndex = 9;
      this.btnSimpan.ImageList = this.imageList1;
      this.btnSimpan.Location = new System.Drawing.Point(28, 402);
      this.btnSimpan.Name = "btnSimpan";
      this.btnSimpan.Size = new System.Drawing.Size(89, 32);
      this.btnSimpan.TabIndex = 34;
      this.btnSimpan.Text = "SIMPAN";
      this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnSimpan.UseVisualStyleBackColor = false;
      this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
      // 
      // imageList1
      // 
      this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
      this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
      this.imageList1.Images.SetKeyName(0, "contract.png");
      this.imageList1.Images.SetKeyName(1, "fast-food.ico");
      this.imageList1.Images.SetKeyName(2, "queue.png");
      this.imageList1.Images.SetKeyName(3, "reload.png");
      this.imageList1.Images.SetKeyName(4, "restaurant.png");
      this.imageList1.Images.SetKeyName(5, "settings.png");
      this.imageList1.Images.SetKeyName(6, "shopping-cart.png");
      this.imageList1.Images.SetKeyName(7, "reload.png");
      this.imageList1.Images.SetKeyName(8, "cancel.png");
      this.imageList1.Images.SetKeyName(9, "diskette.png");
      this.imageList1.Images.SetKeyName(10, "plus.png");
      this.imageList1.Images.SetKeyName(11, "upload.png");
      // 
      // btnKembali
      // 
      this.btnKembali.BackColor = System.Drawing.Color.Transparent;
      this.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnKembali.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
      this.btnKembali.FlatAppearance.BorderSize = 0;
      this.btnKembali.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnKembali.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnKembali.ForeColor = System.Drawing.Color.IndianRed;
      this.btnKembali.ImageIndex = 8;
      this.btnKembali.ImageList = this.imageList1;
      this.btnKembali.Location = new System.Drawing.Point(142, 402);
      this.btnKembali.Name = "btnKembali";
      this.btnKembali.Size = new System.Drawing.Size(104, 32);
      this.btnKembali.TabIndex = 35;
      this.btnKembali.Text = "BATAL";
      this.btnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnKembali.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnKembali.UseVisualStyleBackColor = false;
      this.btnKembali.Click += new System.EventHandler(this.btnKembali_click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.IndianRed;
      this.label2.Location = new System.Drawing.Point(25, 235);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 17);
      this.label2.TabIndex = 38;
      this.label2.Text = "NAMA*";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.IndianRed;
      this.label1.Location = new System.Drawing.Point(25, 273);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(58, 17);
      this.label1.TabIndex = 39;
      this.label1.Text = "HARGA*";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.IndianRed;
      this.label3.Location = new System.Drawing.Point(25, 311);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(46, 17);
      this.label3.TabIndex = 40;
      this.label3.Text = "STOK*";
      // 
      // txtNama
      // 
      this.txtNama.BackColor = System.Drawing.SystemColors.Menu;
      this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtNama.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtNama.Location = new System.Drawing.Point(118, 234);
      this.txtNama.Multiline = true;
      this.txtNama.Name = "txtNama";
      this.txtNama.Size = new System.Drawing.Size(132, 17);
      this.txtNama.TabIndex = 41;
      // 
      // txtHarga
      // 
      this.txtHarga.BackColor = System.Drawing.SystemColors.Menu;
      this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtHarga.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHarga.Location = new System.Drawing.Point(118, 272);
      this.txtHarga.Multiline = true;
      this.txtHarga.Name = "txtHarga";
      this.txtHarga.Size = new System.Drawing.Size(132, 17);
      this.txtHarga.TabIndex = 42;
      // 
      // txtStok
      // 
      this.txtStok.BackColor = System.Drawing.SystemColors.MenuBar;
      this.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtStok.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtStok.Location = new System.Drawing.Point(118, 310);
      this.txtStok.Multiline = true;
      this.txtStok.Name = "txtStok";
      this.txtStok.Size = new System.Drawing.Size(132, 17);
      this.txtStok.TabIndex = 43;
      // 
      // btnAturGambar
      // 
      this.btnAturGambar.BackColor = System.Drawing.Color.IndianRed;
      this.btnAturGambar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAturGambar.FlatAppearance.BorderSize = 0;
      this.btnAturGambar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAturGambar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnAturGambar.ForeColor = System.Drawing.Color.White;
      this.btnAturGambar.ImageKey = "upload.png";
      this.btnAturGambar.ImageList = this.imageList1;
      this.btnAturGambar.Location = new System.Drawing.Point(60, 175);
      this.btnAturGambar.Name = "btnAturGambar";
      this.btnAturGambar.Size = new System.Drawing.Size(154, 32);
      this.btnAturGambar.TabIndex = 44;
      this.btnAturGambar.Text = "ATUR GAMBAR*";
      this.btnAturGambar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnAturGambar.UseVisualStyleBackColor = false;
      this.btnAturGambar.Click += new System.EventHandler(this.btnAturGambar_Click);
      // 
      // cbKategori
      // 
      this.cbKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.cbKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cbKategori.BackColor = System.Drawing.SystemColors.Menu;
      this.cbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbKategori.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbKategori.FormattingEnabled = true;
      this.cbKategori.Location = new System.Drawing.Point(118, 348);
      this.cbKategori.Name = "cbKategori";
      this.cbKategori.Size = new System.Drawing.Size(132, 21);
      this.cbKategori.TabIndex = 46;
      // 
      // lblKategori
      // 
      this.lblKategori.AutoSize = true;
      this.lblKategori.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKategori.ForeColor = System.Drawing.Color.IndianRed;
      this.lblKategori.Location = new System.Drawing.Point(25, 349);
      this.lblKategori.Name = "lblKategori";
      this.lblKategori.Size = new System.Drawing.Size(76, 17);
      this.lblKategori.TabIndex = 47;
      this.lblKategori.Text = "KATEGORI*";
      // 
      // AddMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(275, 462);
      this.Controls.Add(this.lblKategori);
      this.Controls.Add(this.cbKategori);
      this.Controls.Add(this.btnAturGambar);
      this.Controls.Add(this.txtStok);
      this.Controls.Add(this.txtHarga);
      this.Controls.Add(this.txtNama);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnKembali);
      this.Controls.Add(this.btnSimpan);
      this.Controls.Add(this.gambarBarang);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "AddMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "AddMenu";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.AddMenu_Show);
      ((System.ComponentModel.ISupportInitialize)(this.gambarBarang)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.PictureBox gambarBarang;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Button btnAturGambar;
    private System.Windows.Forms.ComboBox cbKategori;
    private System.Windows.Forms.Label lblKategori;
    private System.Windows.Forms.ImageList imageList1;
  }
}