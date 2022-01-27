
namespace k4_kasir {
  partial class PaymentSession {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentSession));
      this.label1 = new System.Windows.Forms.Label();
      this.lblNotif = new System.Windows.Forms.Label();
      this.btnBatal = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.btnBayar = new System.Windows.Forms.Button();
      this.msTxtMasukkanUang = new System.Windows.Forms.MaskedTextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Nirmala UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.IndianRed;
      this.label1.Location = new System.Drawing.Point(112, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(140, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "PEMBAYARAN";
      // 
      // lblNotif
      // 
      this.lblNotif.AutoSize = true;
      this.lblNotif.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblNotif.Location = new System.Drawing.Point(79, 89);
      this.lblNotif.Name = "lblNotif";
      this.lblNotif.Size = new System.Drawing.Size(107, 13);
      this.lblNotif.TabIndex = 4;
      this.lblNotif.Text = "Uang anda kurang!";
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
      this.btnBatal.Location = new System.Drawing.Point(193, 119);
      this.btnBatal.Name = "btnBatal";
      this.btnBatal.Size = new System.Drawing.Size(100, 32);
      this.btnBatal.TabIndex = 37;
      this.btnBatal.Text = "KEMBALI";
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
      // btnBayar
      // 
      this.btnBayar.BackColor = System.Drawing.Color.IndianRed;
      this.btnBayar.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnBayar.FlatAppearance.BorderSize = 0;
      this.btnBayar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnBayar.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnBayar.ForeColor = System.Drawing.Color.White;
      this.btnBayar.Location = new System.Drawing.Point(79, 119);
      this.btnBayar.Name = "btnBayar";
      this.btnBayar.Size = new System.Drawing.Size(83, 32);
      this.btnBayar.TabIndex = 36;
      this.btnBayar.Text = "BAYAR";
      this.btnBayar.UseVisualStyleBackColor = false;
      this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
      // 
      // msTxtMasukkanUang
      // 
      this.msTxtMasukkanUang.BackColor = System.Drawing.SystemColors.Menu;
      this.msTxtMasukkanUang.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.msTxtMasukkanUang.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.msTxtMasukkanUang.Location = new System.Drawing.Point(82, 52);
      this.msTxtMasukkanUang.Name = "msTxtMasukkanUang";
      this.msTxtMasukkanUang.PromptChar = ' ';
      this.msTxtMasukkanUang.Size = new System.Drawing.Size(192, 20);
      this.msTxtMasukkanUang.TabIndex = 45;
      this.msTxtMasukkanUang.ValidatingType = typeof(int);
      this.msTxtMasukkanUang.TextChanged += new System.EventHandler(this.msTxtMasukkanUang_textChanged);
      // 
      // PaymentSession
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(365, 177);
      this.Controls.Add(this.msTxtMasukkanUang);
      this.Controls.Add(this.btnBatal);
      this.Controls.Add(this.btnBayar);
      this.Controls.Add(this.lblNotif);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "PaymentSession";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "PaymentSession";
      this.TopMost = true;
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label lblNotif;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnBayar;
    private System.Windows.Forms.MaskedTextBox msTxtMasukkanUang;
    private System.Windows.Forms.ImageList imageList1;
  }
}