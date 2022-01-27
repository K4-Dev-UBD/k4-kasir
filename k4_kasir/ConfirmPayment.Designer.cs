
namespace k4_kasir {
  partial class ConfirmPayment {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmPayment));
      this.label1 = new System.Windows.Forms.Label();
      this.listViewPesanan = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.label2 = new System.Windows.Forms.Label();
      this.txtSubtotal = new System.Windows.Forms.TextBox();
      this.txtPotonganHarga = new System.Windows.Forms.TextBox();
      this.txtTotalHarga = new System.Windows.Forms.TextBox();
      this.btnBatal = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.btnLanjut = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.IndianRed;
      this.label1.Location = new System.Drawing.Point(172, 19);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(214, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "KONFIRMASI PESANAN";
      // 
      // listViewPesanan
      // 
      this.listViewPesanan.BackColor = System.Drawing.Color.WhiteSmoke;
      this.listViewPesanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listViewPesanan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.listViewPesanan.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listViewPesanan.HideSelection = false;
      this.listViewPesanan.Location = new System.Drawing.Point(42, 57);
      this.listViewPesanan.Name = "listViewPesanan";
      this.listViewPesanan.Scrollable = false;
      this.listViewPesanan.Size = new System.Drawing.Size(475, 217);
      this.listViewPesanan.TabIndex = 1;
      this.listViewPesanan.UseCompatibleStateImageBehavior = false;
      this.listViewPesanan.View = System.Windows.Forms.View.Details;
      this.listViewPesanan.Enter += new System.EventHandler(this.listViewPesanan_enter);
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "QTY";
      this.columnHeader1.Width = 45;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "NAMA MAKANAN";
      this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader2.Width = 280;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "HARGA (Rp)";
      this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader3.Width = 150;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.Transparent;
      this.label2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.IndianRed;
      this.label2.Location = new System.Drawing.Point(86, 299);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 19);
      this.label2.TabIndex = 10;
      this.label2.Text = "SUBTOTAL";
      // 
      // txtSubtotal
      // 
      this.txtSubtotal.BackColor = System.Drawing.SystemColors.Menu;
      this.txtSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtSubtotal.Location = new System.Drawing.Point(332, 302);
      this.txtSubtotal.Multiline = true;
      this.txtSubtotal.Name = "txtSubtotal";
      this.txtSubtotal.ReadOnly = true;
      this.txtSubtotal.Size = new System.Drawing.Size(132, 17);
      this.txtSubtotal.TabIndex = 42;
      // 
      // txtPotonganHarga
      // 
      this.txtPotonganHarga.BackColor = System.Drawing.SystemColors.Menu;
      this.txtPotonganHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtPotonganHarga.Location = new System.Drawing.Point(332, 336);
      this.txtPotonganHarga.Multiline = true;
      this.txtPotonganHarga.Name = "txtPotonganHarga";
      this.txtPotonganHarga.ReadOnly = true;
      this.txtPotonganHarga.Size = new System.Drawing.Size(132, 17);
      this.txtPotonganHarga.TabIndex = 43;
      // 
      // txtTotalHarga
      // 
      this.txtTotalHarga.BackColor = System.Drawing.SystemColors.Menu;
      this.txtTotalHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtTotalHarga.Location = new System.Drawing.Point(332, 373);
      this.txtTotalHarga.Multiline = true;
      this.txtTotalHarga.Name = "txtTotalHarga";
      this.txtTotalHarga.ReadOnly = true;
      this.txtTotalHarga.Size = new System.Drawing.Size(132, 17);
      this.txtTotalHarga.TabIndex = 44;
      // 
      // btnBatal
      // 
      this.btnBatal.BackColor = System.Drawing.Color.Transparent;
      this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnBatal.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
      this.btnBatal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBatal.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBatal.ForeColor = System.Drawing.Color.IndianRed;
      this.btnBatal.ImageKey = "back.png";
      this.btnBatal.ImageList = this.imageList1;
      this.btnBatal.Location = new System.Drawing.Point(316, 417);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(101, 32);
      this.btnBatal.TabIndex = 46;
      this.btnBatal.Text = "KEMBALI";
      this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
      this.imageList1.Images.SetKeyName(11, "add.png");
      this.imageList1.Images.SetKeyName(12, "check-mark.png");
      this.imageList1.Images.SetKeyName(13, "next.png");
      this.imageList1.Images.SetKeyName(14, "upload.png");
      this.imageList1.Images.SetKeyName(15, "back.png");
      // 
      // btnLanjut
      // 
      this.btnLanjut.BackColor = System.Drawing.Color.IndianRed;
      this.btnLanjut.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnLanjut.FlatAppearance.BorderSize = 0;
      this.btnLanjut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnLanjut.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnLanjut.ForeColor = System.Drawing.Color.White;
      this.btnLanjut.ImageKey = "(none)";
      this.btnLanjut.ImageList = this.imageList1;
      this.btnLanjut.Location = new System.Drawing.Point(128, 417);
      this.btnLanjut.Name = "btnLanjut";
      this.btnLanjut.Size = new System.Drawing.Size(100, 32);
      this.btnLanjut.TabIndex = 45;
      this.btnLanjut.Text = "LANJUT";
      this.btnLanjut.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnLanjut.UseVisualStyleBackColor = false;
      this.btnLanjut.Click += new System.EventHandler(this.btnLanjutKePembayaran_click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.Transparent;
      this.label3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.IndianRed;
      this.label3.Location = new System.Drawing.Point(86, 336);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(142, 19);
      this.label3.TabIndex = 47;
      this.label3.Text = "POTONGAN HARGA";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.Transparent;
      this.label4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.IndianRed;
      this.label4.Location = new System.Drawing.Point(86, 373);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(104, 19);
      this.label4.TabIndex = 48;
      this.label4.Text = "TOTAL HARGA";
      // 
      // ConfirmPayment
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoScroll = true;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(558, 470);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnLanjut);
      this.Controls.Add(this.txtTotalHarga);
      this.Controls.Add(this.txtPotonganHarga);
      this.Controls.Add(this.txtSubtotal);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.listViewPesanan);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "ConfirmPayment";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ConfirmPayment";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ListView listViewPesanan;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtPotonganHarga;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnLanjut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ImageList imageList1;
  }
}