
namespace k4_kasir {
  partial class MainPage {
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
      this.mainTabControl = new System.Windows.Forms.TabControl();
      this.menuTab = new System.Windows.Forms.TabPage();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.listMinuman = new System.Windows.Forms.ListBox();
      this.btnMinimzed = new System.Windows.Forms.Button();
      this.btnClose = new System.Windows.Forms.Button();
      this.trolleyIcon = new System.Windows.Forms.PictureBox();
      this.lblOrderCount = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnSegarkan = new System.Windows.Forms.Button();
      this.imageList1 = new System.Windows.Forms.ImageList(this.components);
      this.btnAturUlang = new System.Windows.Forms.Button();
      this.btnKonfirmasi = new System.Windows.Forms.Button();
      this.listMakanan = new System.Windows.Forms.ListBox();
      this.addEditMenuTab = new System.Windows.Forms.TabPage();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.btnTambahMenu = new System.Windows.Forms.Button();
      this.listEditMinuman = new System.Windows.Forms.ListBox();
      this.listEditMakanan = new System.Windows.Forms.ListBox();
      this.antrianTab = new System.Windows.Forms.TabPage();
      this.button5 = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.listViewAntrian = new System.Windows.Forms.ListView();
      this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.historyTab = new System.Windows.Forms.TabPage();
      this.button7 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.listViewRiwayatTransaksi = new System.Windows.Forms.ListView();
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.mainTabControl.SuspendLayout();
      this.menuTab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trolleyIcon)).BeginInit();
      this.addEditMenuTab.SuspendLayout();
      this.antrianTab.SuspendLayout();
      this.historyTab.SuspendLayout();
      this.SuspendLayout();
      // 
      // mainTabControl
      // 
      this.mainTabControl.Controls.Add(this.menuTab);
      this.mainTabControl.Controls.Add(this.addEditMenuTab);
      this.mainTabControl.Controls.Add(this.antrianTab);
      this.mainTabControl.Controls.Add(this.historyTab);
      this.mainTabControl.Cursor = System.Windows.Forms.Cursors.Hand;
      this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainTabControl.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.mainTabControl.HotTrack = true;
      this.mainTabControl.ImageList = this.imageList1;
      this.mainTabControl.Location = new System.Drawing.Point(0, 0);
      this.mainTabControl.Name = "mainTabControl";
      this.mainTabControl.SelectedIndex = 0;
      this.mainTabControl.ShowToolTips = true;
      this.mainTabControl.Size = new System.Drawing.Size(882, 485);
      this.mainTabControl.TabIndex = 1;
      // 
      // menuTab
      // 
      this.menuTab.BackColor = System.Drawing.Color.WhiteSmoke;
      this.menuTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
      this.menuTab.Controls.Add(this.label4);
      this.menuTab.Controls.Add(this.label3);
      this.menuTab.Controls.Add(this.label2);
      this.menuTab.Controls.Add(this.listMinuman);
      this.menuTab.Controls.Add(this.btnMinimzed);
      this.menuTab.Controls.Add(this.btnClose);
      this.menuTab.Controls.Add(this.trolleyIcon);
      this.menuTab.Controls.Add(this.lblOrderCount);
      this.menuTab.Controls.Add(this.label1);
      this.menuTab.Controls.Add(this.btnSegarkan);
      this.menuTab.Controls.Add(this.btnAturUlang);
      this.menuTab.Controls.Add(this.btnKonfirmasi);
      this.menuTab.Controls.Add(this.listMakanan);
      this.menuTab.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.menuTab.ImageKey = "restaurant.png";
      this.menuTab.Location = new System.Drawing.Point(4, 24);
      this.menuTab.Name = "menuTab";
      this.menuTab.Padding = new System.Windows.Forms.Padding(3);
      this.menuTab.Size = new System.Drawing.Size(874, 457);
      this.menuTab.TabIndex = 0;
      this.menuTab.Text = "Menu";
      this.menuTab.ToolTipText = "Daftar Menu";
      this.menuTab.Enter += new System.EventHandler(this.mainTab_Enter);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BackColor = System.Drawing.Color.IndianRed;
      this.label4.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.White;
      this.label4.Location = new System.Drawing.Point(624, 153);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(200, 46);
      this.label4.TabIndex = 325;
      this.label4.Text = "MINUMAN";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.BackColor = System.Drawing.Color.IndianRed;
      this.label3.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.Color.White;
      this.label3.Location = new System.Drawing.Point(24, 153);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(201, 46);
      this.label3.TabIndex = 324;
      this.label3.Text = "MAKANAN";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.Color.IndianRed;
      this.label2.Font = new System.Drawing.Font("Nirmala UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.White;
      this.label2.Location = new System.Drawing.Point(340, 32);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(207, 62);
      this.label2.TabIndex = 323;
      this.label2.Text = "M E N U";
      // 
      // listMinuman
      // 
      this.listMinuman.BackColor = System.Drawing.Color.WhiteSmoke;
      this.listMinuman.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listMinuman.Cursor = System.Windows.Forms.Cursors.Hand;
      this.listMinuman.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listMinuman.ForeColor = System.Drawing.Color.IndianRed;
      this.listMinuman.FormattingEnabled = true;
      this.listMinuman.ItemHeight = 25;
      this.listMinuman.Location = new System.Drawing.Point(663, 238);
      this.listMinuman.Name = "listMinuman";
      this.listMinuman.Size = new System.Drawing.Size(176, 125);
      this.listMinuman.Sorted = true;
      this.listMinuman.TabIndex = 322;
      this.listMinuman.DoubleClick += new System.EventHandler(this.listMinuman_selected);
      // 
      // btnMinimzed
      // 
      this.btnMinimzed.BackColor = System.Drawing.Color.Transparent;
      this.btnMinimzed.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnMinimzed.FlatAppearance.BorderSize = 0;
      this.btnMinimzed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.btnMinimzed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.btnMinimzed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnMinimzed.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMinimzed.ForeColor = System.Drawing.Color.DarkGray;
      this.btnMinimzed.Location = new System.Drawing.Point(793, 3);
      this.btnMinimzed.Name = "btnMinimzed";
      this.btnMinimzed.Size = new System.Drawing.Size(31, 28);
      this.btnMinimzed.TabIndex = 321;
      this.btnMinimzed.Text = "-";
      this.btnMinimzed.UseVisualStyleBackColor = false;
      this.btnMinimzed.Click += new System.EventHandler(this.btnMinimzed_Click);
      // 
      // btnClose
      // 
      this.btnClose.BackColor = System.Drawing.Color.Transparent;
      this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
      this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
      this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClose.ForeColor = System.Drawing.Color.DarkGray;
      this.btnClose.Location = new System.Drawing.Point(837, 3);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(31, 28);
      this.btnClose.TabIndex = 312;
      this.btnClose.Text = "X";
      this.btnClose.UseVisualStyleBackColor = false;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // trolleyIcon
      // 
      this.trolleyIcon.BackColor = System.Drawing.Color.Transparent;
      this.trolleyIcon.Cursor = System.Windows.Forms.Cursors.Hand;
      this.trolleyIcon.Image = global::k4_kasir.Properties.Resources.shopping_cart;
      this.trolleyIcon.Location = new System.Drawing.Point(757, 48);
      this.trolleyIcon.Name = "trolleyIcon";
      this.trolleyIcon.Size = new System.Drawing.Size(67, 46);
      this.trolleyIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.trolleyIcon.TabIndex = 310;
      this.trolleyIcon.TabStop = false;
      this.trolleyIcon.Click += new System.EventHandler(this.trolleyIcon_click);
      // 
      // lblOrderCount
      // 
      this.lblOrderCount.AutoSize = true;
      this.lblOrderCount.BackColor = System.Drawing.Color.Transparent;
      this.lblOrderCount.Cursor = System.Windows.Forms.Cursors.Hand;
      this.lblOrderCount.Font = new System.Drawing.Font("Nirmala UI", 11F, System.Drawing.FontStyle.Bold);
      this.lblOrderCount.ForeColor = System.Drawing.Color.IndianRed;
      this.lblOrderCount.Location = new System.Drawing.Point(825, 48);
      this.lblOrderCount.Name = "lblOrderCount";
      this.lblOrderCount.Size = new System.Drawing.Size(0, 20);
      this.lblOrderCount.TabIndex = 309;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.Color.Transparent;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
      this.label1.ForeColor = System.Drawing.Color.Black;
      this.label1.Location = new System.Drawing.Point(360, 37);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 24);
      this.label1.TabIndex = 305;
      // 
      // btnSegarkan
      // 
      this.btnSegarkan.BackColor = System.Drawing.Color.Transparent;
      this.btnSegarkan.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSegarkan.FlatAppearance.BorderSize = 0;
      this.btnSegarkan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnSegarkan.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnSegarkan.ForeColor = System.Drawing.Color.IndianRed;
      this.btnSegarkan.ImageIndex = 7;
      this.btnSegarkan.ImageList = this.imageList1;
      this.btnSegarkan.Location = new System.Drawing.Point(590, 398);
      this.btnSegarkan.Name = "btnSegarkan";
      this.btnSegarkan.Size = new System.Drawing.Size(253, 34);
      this.btnSegarkan.TabIndex = 308;
      this.btnSegarkan.Text = "SEGARKAN";
      this.btnSegarkan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnSegarkan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnSegarkan.UseVisualStyleBackColor = false;
      this.btnSegarkan.Click += new System.EventHandler(this.btnSegarkan_Click);
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
      // 
      // btnAturUlang
      // 
      this.btnAturUlang.BackColor = System.Drawing.Color.White;
      this.btnAturUlang.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAturUlang.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
      this.btnAturUlang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnAturUlang.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnAturUlang.ForeColor = System.Drawing.Color.IndianRed;
      this.btnAturUlang.Location = new System.Drawing.Point(311, 398);
      this.btnAturUlang.Name = "btnAturUlang";
      this.btnAturUlang.Size = new System.Drawing.Size(253, 34);
      this.btnAturUlang.TabIndex = 304;
      this.btnAturUlang.Text = "ATUR ULANG PESANAN";
      this.btnAturUlang.UseVisualStyleBackColor = false;
      this.btnAturUlang.Click += new System.EventHandler(this.btnAturUlang_Click);
      // 
      // btnKonfirmasi
      // 
      this.btnKonfirmasi.BackColor = System.Drawing.Color.IndianRed;
      this.btnKonfirmasi.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnKonfirmasi.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
      this.btnKonfirmasi.FlatAppearance.BorderSize = 0;
      this.btnKonfirmasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnKonfirmasi.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnKonfirmasi.ForeColor = System.Drawing.Color.White;
      this.btnKonfirmasi.Location = new System.Drawing.Point(32, 398);
      this.btnKonfirmasi.Name = "btnKonfirmasi";
      this.btnKonfirmasi.Size = new System.Drawing.Size(253, 34);
      this.btnKonfirmasi.TabIndex = 303;
      this.btnKonfirmasi.Text = "KONFIRMASI";
      this.btnKonfirmasi.UseVisualStyleBackColor = false;
      this.btnKonfirmasi.Click += new System.EventHandler(this.btnKonfirmasi_click);
      // 
      // listMakanan
      // 
      this.listMakanan.BackColor = System.Drawing.Color.WhiteSmoke;
      this.listMakanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listMakanan.Cursor = System.Windows.Forms.Cursors.Hand;
      this.listMakanan.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listMakanan.ForeColor = System.Drawing.Color.IndianRed;
      this.listMakanan.FormattingEnabled = true;
      this.listMakanan.ItemHeight = 25;
      this.listMakanan.Location = new System.Drawing.Point(47, 238);
      this.listMakanan.Name = "listMakanan";
      this.listMakanan.Size = new System.Drawing.Size(176, 125);
      this.listMakanan.Sorted = true;
      this.listMakanan.TabIndex = 306;
      this.listMakanan.DoubleClick += new System.EventHandler(this.listMakanan_selected);
      // 
      // addEditMenuTab
      // 
      this.addEditMenuTab.BackColor = System.Drawing.Color.WhiteSmoke;
      this.addEditMenuTab.Controls.Add(this.label6);
      this.addEditMenuTab.Controls.Add(this.label5);
      this.addEditMenuTab.Controls.Add(this.button4);
      this.addEditMenuTab.Controls.Add(this.button3);
      this.addEditMenuTab.Controls.Add(this.btnTambahMenu);
      this.addEditMenuTab.Controls.Add(this.listEditMinuman);
      this.addEditMenuTab.Controls.Add(this.listEditMakanan);
      this.addEditMenuTab.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.addEditMenuTab.ImageKey = "settings.png";
      this.addEditMenuTab.Location = new System.Drawing.Point(4, 24);
      this.addEditMenuTab.Name = "addEditMenuTab";
      this.addEditMenuTab.Size = new System.Drawing.Size(874, 457);
      this.addEditMenuTab.TabIndex = 1;
      this.addEditMenuTab.Text = "Tambah / Edit";
      this.addEditMenuTab.ToolTipText = "Tambah / Edit Menu";
      this.addEditMenuTab.Enter += new System.EventHandler(this.addEditTab_Enter);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.BackColor = System.Drawing.Color.IndianRed;
      this.label6.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.White;
      this.label6.Location = new System.Drawing.Point(625, 117);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(200, 46);
      this.label6.TabIndex = 333;
      this.label6.Text = "MINUMAN";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.BackColor = System.Drawing.Color.IndianRed;
      this.label5.Font = new System.Drawing.Font("Nirmala UI", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(33, 117);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(201, 46);
      this.label5.TabIndex = 332;
      this.label5.Text = "MAKANAN";
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.Transparent;
      this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button4.ForeColor = System.Drawing.Color.DarkGray;
      this.button4.Location = new System.Drawing.Point(793, 3);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(31, 28);
      this.button4.TabIndex = 331;
      this.button4.Text = "-";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.btnMinimzed_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Transparent;
      this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button3.ForeColor = System.Drawing.Color.DarkGray;
      this.button3.Location = new System.Drawing.Point(837, 3);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(31, 28);
      this.button3.TabIndex = 330;
      this.button3.Text = "X";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnTambahMenu
      // 
      this.btnTambahMenu.BackColor = System.Drawing.Color.IndianRed;
      this.btnTambahMenu.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnTambahMenu.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
      this.btnTambahMenu.FlatAppearance.BorderSize = 0;
      this.btnTambahMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnTambahMenu.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnTambahMenu.ForeColor = System.Drawing.Color.White;
      this.btnTambahMenu.ImageKey = "add.png";
      this.btnTambahMenu.ImageList = this.imageList1;
      this.btnTambahMenu.Location = new System.Drawing.Point(41, 43);
      this.btnTambahMenu.Name = "btnTambahMenu";
      this.btnTambahMenu.Size = new System.Drawing.Size(784, 34);
      this.btnTambahMenu.TabIndex = 329;
      this.btnTambahMenu.Text = "TAMBAH MENU";
      this.btnTambahMenu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      this.btnTambahMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
      this.btnTambahMenu.UseVisualStyleBackColor = false;
      this.btnTambahMenu.Click += new System.EventHandler(this.btnTambahMenu_click);
      // 
      // listEditMinuman
      // 
      this.listEditMinuman.BackColor = System.Drawing.Color.WhiteSmoke;
      this.listEditMinuman.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listEditMinuman.Cursor = System.Windows.Forms.Cursors.Hand;
      this.listEditMinuman.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listEditMinuman.ForeColor = System.Drawing.Color.IndianRed;
      this.listEditMinuman.FormattingEnabled = true;
      this.listEditMinuman.ItemHeight = 25;
      this.listEditMinuman.Location = new System.Drawing.Point(657, 199);
      this.listEditMinuman.Name = "listEditMinuman";
      this.listEditMinuman.Size = new System.Drawing.Size(176, 225);
      this.listEditMinuman.Sorted = true;
      this.listEditMinuman.TabIndex = 328;
      this.listEditMinuman.DoubleClick += new System.EventHandler(this.listEditMinuman_selected);
      // 
      // listEditMakanan
      // 
      this.listEditMakanan.BackColor = System.Drawing.Color.WhiteSmoke;
      this.listEditMakanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listEditMakanan.Cursor = System.Windows.Forms.Cursors.Hand;
      this.listEditMakanan.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listEditMakanan.ForeColor = System.Drawing.Color.IndianRed;
      this.listEditMakanan.FormattingEnabled = true;
      this.listEditMakanan.ItemHeight = 25;
      this.listEditMakanan.Location = new System.Drawing.Point(58, 199);
      this.listEditMakanan.Name = "listEditMakanan";
      this.listEditMakanan.Size = new System.Drawing.Size(176, 225);
      this.listEditMakanan.Sorted = true;
      this.listEditMakanan.TabIndex = 323;
      this.listEditMakanan.DoubleClick += new System.EventHandler(this.listEditMakanan_selected);
      // 
      // antrianTab
      // 
      this.antrianTab.BackColor = System.Drawing.Color.WhiteSmoke;
      this.antrianTab.Controls.Add(this.button5);
      this.antrianTab.Controls.Add(this.button6);
      this.antrianTab.Controls.Add(this.listViewAntrian);
      this.antrianTab.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.antrianTab.ImageKey = "queue.png";
      this.antrianTab.Location = new System.Drawing.Point(4, 24);
      this.antrianTab.Name = "antrianTab";
      this.antrianTab.Size = new System.Drawing.Size(874, 457);
      this.antrianTab.TabIndex = 2;
      this.antrianTab.Text = "Antrian";
      this.antrianTab.ToolTipText = "Daftar Antrian";
      this.antrianTab.Enter += new System.EventHandler(this.antrianTab_enter);
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.Transparent;
      this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button5.FlatAppearance.BorderSize = 0;
      this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button5.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button5.ForeColor = System.Drawing.Color.DarkGray;
      this.button5.Location = new System.Drawing.Point(793, 3);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(31, 28);
      this.button5.TabIndex = 333;
      this.button5.Text = "-";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new System.EventHandler(this.btnMinimzed_Click);
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.Color.Transparent;
      this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button6.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button6.ForeColor = System.Drawing.Color.DarkGray;
      this.button6.Location = new System.Drawing.Point(837, 3);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(31, 28);
      this.button6.TabIndex = 332;
      this.button6.Text = "X";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // listViewAntrian
      // 
      this.listViewAntrian.BackColor = System.Drawing.Color.WhiteSmoke;
      this.listViewAntrian.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listViewAntrian.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader8,
            this.columnHeader3,
            this.columnHeader9,
            this.columnHeader10});
      this.listViewAntrian.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listViewAntrian.FullRowSelect = true;
      this.listViewAntrian.GridLines = true;
      this.listViewAntrian.HideSelection = false;
      this.listViewAntrian.Location = new System.Drawing.Point(-4, 33);
      this.listViewAntrian.Name = "listViewAntrian";
      this.listViewAntrian.Size = new System.Drawing.Size(878, 424);
      this.listViewAntrian.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.listViewAntrian.TabIndex = 1;
      this.listViewAntrian.UseCompatibleStateImageBehavior = false;
      this.listViewAntrian.View = System.Windows.Forms.View.Details;
      this.listViewAntrian.DoubleClick += new System.EventHandler(this.listViewAntrian_doubleClick);
      // 
      // columnHeader5
      // 
      this.columnHeader5.Text = "ID Antrian";
      this.columnHeader5.Width = 200;
      // 
      // columnHeader8
      // 
      this.columnHeader8.Text = "Nomor Antrian";
      this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader8.Width = 100;
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Jumlah Pesanan";
      this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader3.Width = 150;
      // 
      // columnHeader9
      // 
      this.columnHeader9.Text = "Tanggal";
      this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader9.Width = 220;
      // 
      // columnHeader10
      // 
      this.columnHeader10.Text = "Status Pesanan";
      this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader10.Width = 200;
      // 
      // historyTab
      // 
      this.historyTab.BackColor = System.Drawing.Color.WhiteSmoke;
      this.historyTab.Controls.Add(this.button7);
      this.historyTab.Controls.Add(this.button8);
      this.historyTab.Controls.Add(this.listViewRiwayatTransaksi);
      this.historyTab.Cursor = System.Windows.Forms.Cursors.Arrow;
      this.historyTab.ImageKey = "contract.png";
      this.historyTab.Location = new System.Drawing.Point(4, 24);
      this.historyTab.Name = "historyTab";
      this.historyTab.Size = new System.Drawing.Size(874, 457);
      this.historyTab.TabIndex = 3;
      this.historyTab.Text = "Riwayat Transaksi";
      this.historyTab.ToolTipText = "Daftar Riwayat Pesanan";
      this.historyTab.Enter += new System.EventHandler(this.listViewRiwayatTransaksi_enter);
      // 
      // button7
      // 
      this.button7.BackColor = System.Drawing.Color.Transparent;
      this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button7.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button7.ForeColor = System.Drawing.Color.DarkGray;
      this.button7.Location = new System.Drawing.Point(793, 3);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(31, 28);
      this.button7.TabIndex = 335;
      this.button7.Text = "-";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new System.EventHandler(this.btnMinimzed_Click);
      // 
      // button8
      // 
      this.button8.BackColor = System.Drawing.Color.Transparent;
      this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
      this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button8.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button8.ForeColor = System.Drawing.Color.DarkGray;
      this.button8.Location = new System.Drawing.Point(837, 3);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(31, 28);
      this.button8.TabIndex = 334;
      this.button8.Text = "X";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // listViewRiwayatTransaksi
      // 
      this.listViewRiwayatTransaksi.BackColor = System.Drawing.Color.WhiteSmoke;
      this.listViewRiwayatTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.listViewRiwayatTransaksi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
      this.listViewRiwayatTransaksi.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.listViewRiwayatTransaksi.GridLines = true;
      this.listViewRiwayatTransaksi.HideSelection = false;
      this.listViewRiwayatTransaksi.Location = new System.Drawing.Point(0, 37);
      this.listViewRiwayatTransaksi.Name = "listViewRiwayatTransaksi";
      this.listViewRiwayatTransaksi.Size = new System.Drawing.Size(874, 420);
      this.listViewRiwayatTransaksi.Sorting = System.Windows.Forms.SortOrder.Descending;
      this.listViewRiwayatTransaksi.TabIndex = 1;
      this.listViewRiwayatTransaksi.UseCompatibleStateImageBehavior = false;
      this.listViewRiwayatTransaksi.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "ID Transaksi";
      this.columnHeader1.Width = 170;
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "Total (Rp)";
      this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader2.Width = 200;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "Tanggal";
      this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader4.Width = 200;
      // 
      // columnHeader6
      // 
      this.columnHeader6.Text = "ID Antrian";
      this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader6.Width = 170;
      // 
      // columnHeader7
      // 
      this.columnHeader7.Text = "Status Pesanan";
      this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.columnHeader7.Width = 120;
      // 
      // MainPage
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(882, 485);
      this.Controls.Add(this.mainTabControl);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainPage";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "K4 KASIR";
      this.TopMost = true;
      this.Shown += new System.EventHandler(this.mainPage_Shown);
      this.mainTabControl.ResumeLayout(false);
      this.menuTab.ResumeLayout(false);
      this.menuTab.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trolleyIcon)).EndInit();
      this.addEditMenuTab.ResumeLayout(false);
      this.addEditMenuTab.PerformLayout();
      this.antrianTab.ResumeLayout(false);
      this.historyTab.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TabControl mainTabControl;
    private System.Windows.Forms.TabPage menuTab;
    private System.Windows.Forms.PictureBox trolleyIcon;
    private System.Windows.Forms.Label lblOrderCount;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSegarkan;
    private System.Windows.Forms.Button btnAturUlang;
    private System.Windows.Forms.Button btnKonfirmasi;
    private System.Windows.Forms.ListBox listMakanan;
    private System.Windows.Forms.TabPage addEditMenuTab;
    private System.Windows.Forms.TabPage antrianTab;
    private System.Windows.Forms.TabPage historyTab;
    private System.Windows.Forms.ListView listViewRiwayatTransaksi;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.ColumnHeader columnHeader6;
    private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimzed;
    private System.Windows.Forms.ListBox listMinuman;
    private System.Windows.Forms.Button btnTambahMenu;
    private System.Windows.Forms.ListBox listEditMinuman;
    private System.Windows.Forms.ListBox listEditMakanan;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.ColumnHeader columnHeader7;
    private System.Windows.Forms.ListView listViewAntrian;
    private System.Windows.Forms.ColumnHeader columnHeader5;
    private System.Windows.Forms.ColumnHeader columnHeader8;
    private System.Windows.Forms.ColumnHeader columnHeader9;
    private System.Windows.Forms.ColumnHeader columnHeader10;
    private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}