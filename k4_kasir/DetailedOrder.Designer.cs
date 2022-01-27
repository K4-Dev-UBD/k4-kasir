
namespace k4_kasir {
  partial class DetailedOrder {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailedOrder));
      this.listViewPesanan = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.label1 = new System.Windows.Forms.Label();
      this.btnBatal = new System.Windows.Forms.Button();
      this.btnSelesai = new System.Windows.Forms.Button();
      this.btnKembali = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.SuspendLayout();
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
      this.listViewPesanan.ForeColor = System.Drawing.SystemColors.WindowText;
      this.listViewPesanan.HideSelection = false;
      this.listViewPesanan.Location = new System.Drawing.Point(79, 63);
      this.listViewPesanan.Name = "listViewPesanan";
      this.listViewPesanan.Size = new System.Drawing.Size(511, 305);
      this.listViewPesanan.TabIndex = 0;
      this.listViewPesanan.UseCompatibleStateImageBehavior = false;
      this.listViewPesanan.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "QTY";
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "NAMA MAKANAN";
      this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader2.Width = 300;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "KATEGORI";
      this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader3.Width = 150;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Nirmala UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.IndianRed;
      this.label1.Location = new System.Drawing.Point(246, 18);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(177, 25);
      this.label1.TabIndex = 5;
      this.label1.Text = "JUMLAH PESANAN";
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
      this.btnBatal.Location = new System.Drawing.Point(292, 394);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(93, 32);
      this.btnBatal.TabIndex = 48;
      this.btnBatal.Text = "BATAL";
      this.btnBatal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnBatal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnBatal.UseVisualStyleBackColor = false;
      this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
      // 
      // btnSelesai
      // 
      this.btnSelesai.BackColor = System.Drawing.Color.IndianRed;
      this.btnSelesai.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSelesai.FlatAppearance.BorderSize = 0;
      this.btnSelesai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSelesai.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSelesai.ForeColor = System.Drawing.Color.White;
      this.btnSelesai.ImageKey = "check-mark.png";
      this.btnSelesai.ImageList = this.imageList1;
      this.btnSelesai.Location = new System.Drawing.Point(120, 394);
      this.btnSelesai.Name = "btnSelesai";
      this.btnSelesai.Size = new System.Drawing.Size(89, 32);
      this.btnSelesai.TabIndex = 47;
      this.btnSelesai.Text = "SELESAI";
      this.btnSelesai.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSelesai.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
      this.btnSelesai.UseVisualStyleBackColor = false;
      this.btnSelesai.Click += new System.EventHandler(this.btnSelesai_Click);
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
      this.btnKembali.ImageKey = "back.png";
      this.btnKembali.ImageList = this.imageList1;
      this.btnKembali.Location = new System.Drawing.Point(462, 394);
      this.btnKembali.Name = "btnKembali";
      this.btnKembali.Size = new System.Drawing.Size(93, 32);
      this.btnKembali.TabIndex = 49;
      this.btnKembali.Text = "KEMBALI";
      this.btnKembali.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnKembali.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
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
      this.imageList1.Images.SetKeyName(15, "back.png");
      // 
      // DetailedOrder
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(669, 450);
      this.Controls.Add(this.btnKembali);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnSelesai);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.listViewPesanan);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "DetailedOrder";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "DetailedOrder";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.detailedOrder_shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ListView listViewPesanan;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnSelesai;
        private System.Windows.Forms.Button btnKembali;
    private System.Windows.Forms.ImageList imageList1;
  }
}