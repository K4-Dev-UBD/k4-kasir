
namespace k4_kasir {
  partial class DetailedMenu {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedMenu));
      this.lblNamaMenu = new System.Windows.Forms.Label();
      this.lblStok = new System.Windows.Forms.Label();
      this.lblHarga = new System.Windows.Forms.Label();
      this.gambarBarang = new System.Windows.Forms.PictureBox();
      this.btnBatal = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.btnSimpan = new System.Windows.Forms.Button();
      this.msTxtCount = new System.Windows.Forms.MaskedTextBox();
      this.cbPedas = new System.Windows.Forms.CheckBox();
      this.cbGoreng = new System.Windows.Forms.CheckBox();
      this.cbAsin = new System.Windows.Forms.CheckBox();
      this.btnPlus = new System.Windows.Forms.Button();
      this.btnMin = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.cbEs = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.gambarBarang)).BeginInit();
      this.SuspendLayout();
      // 
      // lblNamaMenu
      // 
      this.lblNamaMenu.AutoSize = true;
      this.lblNamaMenu.BackColor = System.Drawing.Color.IndianRed;
      this.lblNamaMenu.Font = new System.Drawing.Font("Nirmala UI", 20F, System.Drawing.FontStyle.Bold);
      this.lblNamaMenu.ForeColor = System.Drawing.Color.White;
      this.lblNamaMenu.Location = new System.Drawing.Point(44, 171);
      this.lblNamaMenu.Name = "lblNamaMenu";
      this.lblNamaMenu.Size = new System.Drawing.Size(190, 37);
      this.lblNamaMenu.TabIndex = 3;
      this.lblNamaMenu.Text = "NAMA MENU";
      this.lblNamaMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblStok
      // 
      this.lblStok.AutoSize = true;
      this.lblStok.BackColor = System.Drawing.Color.Transparent;
      this.lblStok.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold);
      this.lblStok.Location = new System.Drawing.Point(113, 287);
      this.lblStok.Name = "lblStok";
      this.lblStok.Size = new System.Drawing.Size(51, 15);
      this.lblStok.TabIndex = 6;
      this.lblStok.Text = "stok: 10";
      // 
      // lblHarga
      // 
      this.lblHarga.AutoSize = true;
      this.lblHarga.BackColor = System.Drawing.Color.Transparent;
      this.lblHarga.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold);
      this.lblHarga.ForeColor = System.Drawing.Color.Firebrick;
      this.lblHarga.Location = new System.Drawing.Point(109, 227);
      this.lblHarga.Name = "lblHarga";
      this.lblHarga.Size = new System.Drawing.Size(0, 21);
      this.lblHarga.TabIndex = 4;
      // 
      // gambarBarang
      // 
      this.gambarBarang.BackColor = System.Drawing.Color.White;
      this.gambarBarang.Image = global::k4_kasir.Properties.Resources.fast_food;
      this.gambarBarang.Location = new System.Drawing.Point(0, 0);
      this.gambarBarang.Name = "gambarBarang";
      this.gambarBarang.Size = new System.Drawing.Size(278, 156);
      this.gambarBarang.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.gambarBarang.TabIndex = 2;
      this.gambarBarang.TabStop = false;
      // 
      // btnBatal
      // 
      this.btnBatal.BackColor = System.Drawing.Color.Transparent;
      this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
      this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBatal.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBatal.ForeColor = System.Drawing.Color.IndianRed;
      this.btnBatal.ImageKey = "cancel.png";
      this.btnBatal.ImageList = this.imageList1;
      this.btnBatal.Location = new System.Drawing.Point(157, 375);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(93, 32);
      this.btnBatal.TabIndex = 13;
      this.btnBatal.Text = "BATAL";
      this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnBatal.UseVisualStyleBackColor = false;
      this.btnBatal.Click += new System.EventHandler(this.btnBatal_click);
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
      this.btnSimpan.Location = new System.Drawing.Point(29, 375);
      this.btnSimpan.Name = "btnSimpan";
      this.btnSimpan.Size = new System.Drawing.Size(94, 32);
      this.btnSimpan.TabIndex = 14;
      this.btnSimpan.Text = "PESAN";
      this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSimpan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnSimpan.UseVisualStyleBackColor = false;
      this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
      // 
      // msTxtCount
      // 
      this.msTxtCount.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.msTxtCount.HidePromptOnLeave = true;
      this.msTxtCount.Location = new System.Drawing.Point(124, 258);
      this.msTxtCount.Mask = "000";
      this.msTxtCount.Name = "msTxtCount";
      this.msTxtCount.PromptChar = ' ';
      this.msTxtCount.Size = new System.Drawing.Size(30, 23);
      this.msTxtCount.TabIndex = 15;
      this.msTxtCount.Text = "0";
      this.msTxtCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.msTxtCount.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
      this.msTxtCount.ValidatingType = typeof(int);
      this.msTxtCount.TextChanged += new System.EventHandler(this.msTxtCount_TextChanged);
      // 
      // cbPedas
      // 
      this.cbPedas.AutoSize = true;
      this.cbPedas.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbPedas.Location = new System.Drawing.Point(49, 318);
      this.cbPedas.Name = "cbPedas";
      this.cbPedas.Size = new System.Drawing.Size(57, 19);
      this.cbPedas.TabIndex = 16;
      this.cbPedas.Text = "Pedas";
      this.cbPedas.UseVisualStyleBackColor = true;
      this.cbPedas.CheckedChanged += new System.EventHandler(this.cbPedas_checkedChanged);
      // 
      // cbGoreng
      // 
      this.cbGoreng.AutoSize = true;
      this.cbGoreng.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbGoreng.Location = new System.Drawing.Point(111, 318);
      this.cbGoreng.Name = "cbGoreng";
      this.cbGoreng.Size = new System.Drawing.Size(65, 19);
      this.cbGoreng.TabIndex = 17;
      this.cbGoreng.Text = "Goreng";
      this.cbGoreng.UseVisualStyleBackColor = true;
      this.cbGoreng.CheckedChanged += new System.EventHandler(this.cbGoreng_checkedChanged);
      // 
      // cbAsin
      // 
      this.cbAsin.AutoSize = true;
      this.cbAsin.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbAsin.Location = new System.Drawing.Point(182, 318);
      this.cbAsin.Name = "cbAsin";
      this.cbAsin.Size = new System.Drawing.Size(49, 19);
      this.cbAsin.TabIndex = 18;
      this.cbAsin.Text = "Asin";
      this.cbAsin.UseVisualStyleBackColor = true;
      this.cbAsin.CheckedChanged += new System.EventHandler(this.cbAsin_checkedChanged);
      // 
      // btnPlus
      // 
      this.btnPlus.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnPlus.Location = new System.Drawing.Point(171, 257);
      this.btnPlus.Name = "btnPlus";
      this.btnPlus.Size = new System.Drawing.Size(24, 23);
      this.btnPlus.TabIndex = 19;
      this.btnPlus.Text = "+";
      this.btnPlus.UseVisualStyleBackColor = true;
      this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
      // 
      // btnMin
      // 
      this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnMin.Location = new System.Drawing.Point(83, 257);
      this.btnMin.Name = "btnMin";
      this.btnMin.Size = new System.Drawing.Size(24, 23);
      this.btnMin.TabIndex = 20;
      this.btnMin.Text = "-";
      this.btnMin.UseVisualStyleBackColor = true;
      this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Nirmala UI", 8F, System.Drawing.FontStyle.Bold);
      this.label1.ForeColor = System.Drawing.Color.Firebrick;
      this.label1.Location = new System.Drawing.Point(86, 222);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(24, 13);
      this.label1.TabIndex = 21;
      this.label1.Text = "Rp.";
      // 
      // cbEs
      // 
      this.cbEs.AutoSize = true;
      this.cbEs.Font = new System.Drawing.Font("Nirmala UI", 8.259F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbEs.Location = new System.Drawing.Point(120, 341);
      this.cbEs.Name = "cbEs";
      this.cbEs.Size = new System.Drawing.Size(37, 19);
      this.cbEs.TabIndex = 22;
      this.cbEs.Text = "Es";
      this.cbEs.UseVisualStyleBackColor = true;
      this.cbEs.CheckedChanged += new System.EventHandler(this.cbEs_checkedChanged);
      // 
      // DetailedMenu
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(278, 422);
      this.ControlBox = false;
      this.Controls.Add(this.cbEs);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnMin);
      this.Controls.Add(this.btnPlus);
      this.Controls.Add(this.cbAsin);
      this.Controls.Add(this.cbGoreng);
      this.Controls.Add(this.cbPedas);
      this.Controls.Add(this.msTxtCount);
      this.Controls.Add(this.btnSimpan);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.gambarBarang);
      this.Controls.Add(this.lblNamaMenu);
      this.Controls.Add(this.lblHarga);
      this.Controls.Add(this.lblStok);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "DetailedMenu";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DetailedMenu";
      this.TopMost = true;
      ((System.ComponentModel.ISupportInitialize)(this.gambarBarang)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.PictureBox gambarBarang;
    private System.Windows.Forms.Label lblNamaMenu;
    private System.Windows.Forms.Label lblStok;
    private System.Windows.Forms.Label lblHarga;
    private System.Windows.Forms.Button btnBatal;
    private System.Windows.Forms.Button btnSimpan;
    private System.Windows.Forms.MaskedTextBox msTxtCount;
    private System.Windows.Forms.CheckBox cbPedas;
    private System.Windows.Forms.CheckBox cbGoreng;
    private System.Windows.Forms.CheckBox cbAsin;
    private System.Windows.Forms.Button btnPlus;
    private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.CheckBox cbEs;
    private System.Windows.Forms.ImageList imageList1;
  }
}