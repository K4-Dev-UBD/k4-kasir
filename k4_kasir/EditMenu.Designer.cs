
namespace k4_kasir {
  partial class EditMenu {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMenu));
      this.gambarBarang = new System.Windows.Forms.PictureBox();
      this.btnKembali = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.btnSimpan = new System.Windows.Forms.Button();
      this.btnAturGambar = new System.Windows.Forms.Button();
      this.txtStok = new System.Windows.Forms.TextBox();
      this.txtHarga = new System.Windows.Forms.TextBox();
      this.txtNama = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblKategori = new System.Windows.Forms.Label();
      this.cbKategori = new System.Windows.Forms.ComboBox();
      this.btnHapus = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.gambarBarang)).BeginInit();
      this.SuspendLayout();
      // 
      // gambarBarang
      // 
      this.gambarBarang.BackColor = System.Drawing.Color.WhiteSmoke;
      this.gambarBarang.Image = global::k4_kasir.Properties.Resources.fast_food;
      this.gambarBarang.Location = new System.Drawing.Point(-1, -2);
      this.gambarBarang.Name = "gambarBarang";
      this.gambarBarang.Size = new System.Drawing.Size(277, 156);
      this.gambarBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.gambarBarang.TabIndex = 17;
      this.gambarBarang.TabStop = false;
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
      this.btnKembali.ImageKey = "cancel.png";
      this.btnKembali.ImageList = this.imageList1;
      this.btnKembali.Location = new System.Drawing.Point(154, 402);
      this.btnKembali.Name = "btnKembali";
      this.btnKembali.Size = new System.Drawing.Size(80, 32);
      this.btnKembali.TabIndex = 37;
      this.btnKembali.Text = "BATAL";
      this.btnKembali.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnKembali.UseVisualStyleBackColor = false;
      this.btnKembali.Click += new System.EventHandler(this.btnKembali_click);
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
      this.imageList1.Images.SetKeyName(11, "add.png");
      this.imageList1.Images.SetKeyName(12, "check-mark.png");
      this.imageList1.Images.SetKeyName(13, "next.png");
      this.imageList1.Images.SetKeyName(14, "upload.png");
      this.imageList1.Images.SetKeyName(15, "trash.png");
      // 
      // btnSimpan
      // 
      this.btnSimpan.BackColor = System.Drawing.Color.IndianRed;
      this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSimpan.FlatAppearance.BorderSize = 0;
      this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSimpan.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSimpan.ForeColor = System.Drawing.Color.White;
      this.btnSimpan.ImageKey = "diskette.png";
      this.btnSimpan.ImageList = this.imageList1;
      this.btnSimpan.Location = new System.Drawing.Point(40, 402);
      this.btnSimpan.Name = "btnSimpan";
      this.btnSimpan.Size = new System.Drawing.Size(90, 32);
      this.btnSimpan.TabIndex = 36;
      this.btnSimpan.Text = "SIMPAN";
      this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnSimpan.UseVisualStyleBackColor = false;
      this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
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
      this.btnAturGambar.Location = new System.Drawing.Point(63, 174);
      this.btnAturGambar.Name = "btnAturGambar";
      this.btnAturGambar.Size = new System.Drawing.Size(143, 32);
      this.btnAturGambar.TabIndex = 38;
      this.btnAturGambar.Text = "ATUR GAMBAR";
      this.btnAturGambar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnAturGambar.UseVisualStyleBackColor = false;
      this.btnAturGambar.Click += new System.EventHandler(this.btnAturGambar_Click);
      // 
      // txtStok
      // 
      this.txtStok.BackColor = System.Drawing.SystemColors.Menu;
      this.txtStok.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtStok.Location = new System.Drawing.Point(118, 315);
      this.txtStok.Multiline = true;
      this.txtStok.Name = "txtStok";
      this.txtStok.Size = new System.Drawing.Size(132, 17);
      this.txtStok.TabIndex = 49;
      // 
      // txtHarga
      // 
      this.txtHarga.BackColor = System.Drawing.SystemColors.Menu;
      this.txtHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtHarga.Location = new System.Drawing.Point(118, 277);
      this.txtHarga.Multiline = true;
      this.txtHarga.Name = "txtHarga";
      this.txtHarga.Size = new System.Drawing.Size(132, 17);
      this.txtHarga.TabIndex = 48;
      // 
      // txtNama
      // 
      this.txtNama.BackColor = System.Drawing.SystemColors.Menu;
      this.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtNama.Location = new System.Drawing.Point(118, 235);
      this.txtNama.Multiline = true;
      this.txtNama.Name = "txtNama";
      this.txtNama.ReadOnly = true;
      this.txtNama.Size = new System.Drawing.Size(132, 17);
      this.txtNama.TabIndex = 47;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.IndianRed;
      this.label3.Location = new System.Drawing.Point(25, 315);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(40, 17);
      this.label3.TabIndex = 46;
      this.label3.Text = "STOK";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.IndianRed;
      this.label1.Location = new System.Drawing.Point(25, 274);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(53, 17);
      this.label1.TabIndex = 45;
      this.label1.Text = "HARGA";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.IndianRed;
      this.label2.Location = new System.Drawing.Point(25, 235);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 17);
      this.label2.TabIndex = 44;
      this.label2.Text = "NAMA";
      // 
      // lblKategori
      // 
      this.lblKategori.AutoSize = true;
      this.lblKategori.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblKategori.ForeColor = System.Drawing.Color.IndianRed;
      this.lblKategori.Location = new System.Drawing.Point(25, 355);
      this.lblKategori.Name = "lblKategori";
      this.lblKategori.Size = new System.Drawing.Size(70, 17);
      this.lblKategori.TabIndex = 51;
      this.lblKategori.Text = "KATEGORI";
      // 
      // cbKategori
      // 
      this.cbKategori.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
      this.cbKategori.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
      this.cbKategori.BackColor = System.Drawing.SystemColors.Menu;
      this.cbKategori.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.cbKategori.FormattingEnabled = true;
      this.cbKategori.Location = new System.Drawing.Point(118, 354);
      this.cbKategori.Name = "cbKategori";
      this.cbKategori.Size = new System.Drawing.Size(132, 21);
      this.cbKategori.TabIndex = 50;
      // 
      // btnHapus
      // 
      this.btnHapus.BackColor = System.Drawing.Color.Transparent;
      this.btnHapus.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnHapus.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
      this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnHapus.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnHapus.ForeColor = System.Drawing.Color.IndianRed;
      this.btnHapus.ImageKey = "trash.png";
      this.btnHapus.ImageList = this.imageList1;
      this.btnHapus.Location = new System.Drawing.Point(95, 451);
      this.btnHapus.Name = "btnHapus";
      this.btnHapus.Size = new System.Drawing.Size(84, 32);
      this.btnHapus.TabIndex = 52;
      this.btnHapus.Text = "HAPUS";
      this.btnHapus.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnHapus.UseVisualStyleBackColor = false;
      this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
      // 
      // EditMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(275, 496);
      this.Controls.Add(this.btnHapus);
      this.Controls.Add(this.lblKategori);
      this.Controls.Add(this.cbKategori);
      this.Controls.Add(this.txtStok);
      this.Controls.Add(this.txtHarga);
      this.Controls.Add(this.txtNama);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.btnAturGambar);
      this.Controls.Add(this.btnKembali);
      this.Controls.Add(this.btnSimpan);
      this.Controls.Add(this.gambarBarang);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "EditMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "EditMenu";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.EditMenu_shown);
      ((System.ComponentModel.ISupportInitialize)(this.gambarBarang)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.PictureBox gambarBarang;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnAturGambar;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblKategori;
    private System.Windows.Forms.ComboBox cbKategori;
    private System.Windows.Forms.Button btnHapus;
    private System.Windows.Forms.ImageList imageList1;
  }
}