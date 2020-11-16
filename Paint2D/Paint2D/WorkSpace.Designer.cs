namespace Paint2D
{
    partial class WorkSpace
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkSpace));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fracktalCtextBox = new System.Windows.Forms.TextBox();
            this.fracktalCtrackBar1 = new System.Windows.Forms.TrackBar();
            this.isFractalCheckBox = new System.Windows.Forms.CheckBox();
            this.eraseButton = new System.Windows.Forms.Button();
            this.widthTextbox = new System.Windows.Forms.TextBox();
            this.toolCurrentPicture = new System.Windows.Forms.PictureBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton11 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton10 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton14 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton13 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton15 = new System.Windows.Forms.ToolStripButton();
            this.buttonRigthDraw = new System.Windows.Forms.Button();
            this.trackBarWidthOfPen = new System.Windows.Forms.TrackBar();
            this.buttonCurrentCollor = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton18 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picture = new System.Windows.Forms.PictureBox();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.openImageDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fracktalCtrackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCurrentPicture)).BeginInit();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidthOfPen)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.fracktalCtextBox);
            this.panel1.Controls.Add(this.fracktalCtrackBar1);
            this.panel1.Controls.Add(this.buttonRigthDraw);
            this.panel1.Controls.Add(this.isFractalCheckBox);
            this.panel1.Controls.Add(this.eraseButton);
            this.panel1.Controls.Add(this.widthTextbox);
            this.panel1.Controls.Add(this.toolCurrentPicture);
            this.panel1.Controls.Add(this.clearButton);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Controls.Add(this.trackBarWidthOfPen);
            this.panel1.Controls.Add(this.buttonCurrentCollor);
            this.panel1.Controls.Add(this.toolStrip1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1193, 93);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(608, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fractals coeficient";
            this.label1.Visible = false;
            // 
            // fracktalCtextBox
            // 
            this.fracktalCtextBox.Location = new System.Drawing.Point(582, 62);
            this.fracktalCtextBox.MaxLength = 4;
            this.fracktalCtextBox.Name = "fracktalCtextBox";
            this.fracktalCtextBox.Size = new System.Drawing.Size(164, 20);
            this.fracktalCtextBox.TabIndex = 12;
            this.fracktalCtextBox.Text = "501";
            this.fracktalCtextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fracktalCtextBox.Visible = false;
            this.fracktalCtextBox.TextChanged += new System.EventHandler(this.fracktalCtextBox_TextChanged);
            // 
            // fracktalCtrackBar1
            // 
            this.fracktalCtrackBar1.LargeChange = 1;
            this.fracktalCtrackBar1.Location = new System.Drawing.Point(582, 25);
            this.fracktalCtrackBar1.Maximum = 1000;
            this.fracktalCtrackBar1.Minimum = 1;
            this.fracktalCtrackBar1.Name = "fracktalCtrackBar1";
            this.fracktalCtrackBar1.Size = new System.Drawing.Size(164, 45);
            this.fracktalCtrackBar1.TabIndex = 11;
            this.fracktalCtrackBar1.Value = 501;
            this.fracktalCtrackBar1.Visible = false;
            this.fracktalCtrackBar1.ValueChanged += new System.EventHandler(this.fracktalCtrackBar1_ValueChanged);
            // 
            // isFractalCheckBox
            // 
            this.isFractalCheckBox.AutoSize = true;
            this.isFractalCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.isFractalCheckBox.Location = new System.Drawing.Point(428, 50);
            this.isFractalCheckBox.Name = "isFractalCheckBox";
            this.isFractalCheckBox.Size = new System.Drawing.Size(102, 28);
            this.isFractalCheckBox.TabIndex = 10;
            this.isFractalCheckBox.Text = "Fractals";
            this.isFractalCheckBox.UseVisualStyleBackColor = true;
            this.isFractalCheckBox.CheckedChanged += new System.EventHandler(this.isFractalCheckBox_CheckedChanged);
            // 
            // eraseButton
            // 
            this.eraseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("eraseButton.BackgroundImage")));
            this.eraseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.eraseButton.Location = new System.Drawing.Point(377, 38);
            this.eraseButton.Name = "eraseButton";
            this.eraseButton.Size = new System.Drawing.Size(45, 45);
            this.eraseButton.TabIndex = 9;
            this.eraseButton.UseVisualStyleBackColor = true;
            this.eraseButton.Click += new System.EventHandler(this.eraseButton_Click);
            // 
            // widthTextbox
            // 
            this.widthTextbox.Location = new System.Drawing.Point(156, 63);
            this.widthTextbox.MaxLength = 3;
            this.widthTextbox.Name = "widthTextbox";
            this.widthTextbox.Size = new System.Drawing.Size(164, 20);
            this.widthTextbox.TabIndex = 8;
            this.widthTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthTextbox.TextChanged += new System.EventHandler(this.widthTextbox_TextChanged);
            // 
            // toolCurrentPicture
            // 
            this.toolCurrentPicture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolCurrentPicture.BackgroundImage")));
            this.toolCurrentPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolCurrentPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.toolCurrentPicture.Cursor = System.Windows.Forms.Cursors.No;
            this.toolCurrentPicture.Enabled = false;
            this.toolCurrentPicture.Location = new System.Drawing.Point(105, 38);
            this.toolCurrentPicture.Name = "toolCurrentPicture";
            this.toolCurrentPicture.Size = new System.Drawing.Size(45, 45);
            this.toolCurrentPicture.TabIndex = 7;
            this.toolCurrentPicture.TabStop = false;
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.Control;
            this.clearButton.Font = new System.Drawing.Font("Consolas", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(326, 38);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(45, 45);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.AllowDrop = true;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton9,
            this.toolStripButton11,
            this.toolStripButton10,
            this.toolStripButton12,
            this.toolStripButton14,
            this.toolStripButton13,
            this.toolStripButton15});
            this.toolStrip2.Location = new System.Drawing.Point(245, 5);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(173, 25);
            this.toolStrip2.TabIndex = 6;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton9.Text = "1";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton11
            // 
            this.toolStripButton11.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton11.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton11.Image")));
            this.toolStripButton11.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton11.Name = "toolStripButton11";
            this.toolStripButton11.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton11.Text = "2";
            this.toolStripButton11.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton10
            // 
            this.toolStripButton10.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton10.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton10.Image")));
            this.toolStripButton10.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton10.Name = "toolStripButton10";
            this.toolStripButton10.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton10.Text = "3";
            this.toolStripButton10.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "4";
            this.toolStripButton12.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton14
            // 
            this.toolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton14.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton14.Image")));
            this.toolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton14.Name = "toolStripButton14";
            this.toolStripButton14.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton14.Text = "5";
            this.toolStripButton14.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton13
            // 
            this.toolStripButton13.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton13.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton13.Image")));
            this.toolStripButton13.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton13.Name = "toolStripButton13";
            this.toolStripButton13.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton13.Text = "6";
            this.toolStripButton13.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // toolStripButton15
            // 
            this.toolStripButton15.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton15.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton15.Image")));
            this.toolStripButton15.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton15.Name = "toolStripButton15";
            this.toolStripButton15.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton15.Text = "7";
            this.toolStripButton15.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // buttonRigthDraw
            // 
            this.buttonRigthDraw.BackColor = System.Drawing.Color.White;
            this.buttonRigthDraw.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRigthDraw.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRigthDraw.Location = new System.Drawing.Point(3, 38);
            this.buttonRigthDraw.Name = "buttonRigthDraw";
            this.buttonRigthDraw.Size = new System.Drawing.Size(45, 45);
            this.buttonRigthDraw.TabIndex = 2;
            this.buttonRigthDraw.Text = "R";
            this.buttonRigthDraw.UseVisualStyleBackColor = false;
            this.buttonRigthDraw.Click += new System.EventHandler(this.buttonRigthDraw_Click);
            // 
            // trackBarWidthOfPen
            // 
            this.trackBarWidthOfPen.Location = new System.Drawing.Point(156, 33);
            this.trackBarWidthOfPen.Maximum = 75;
            this.trackBarWidthOfPen.Minimum = 1;
            this.trackBarWidthOfPen.Name = "trackBarWidthOfPen";
            this.trackBarWidthOfPen.Size = new System.Drawing.Size(164, 45);
            this.trackBarWidthOfPen.TabIndex = 3;
            this.trackBarWidthOfPen.Value = 15;
            this.trackBarWidthOfPen.ValueChanged += new System.EventHandler(this.trackBarWidthOfPen_ValueChanged);
            // 
            // buttonCurrentCollor
            // 
            this.buttonCurrentCollor.BackColor = System.Drawing.Color.Black;
            this.buttonCurrentCollor.Font = new System.Drawing.Font("Consolas", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCurrentCollor.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonCurrentCollor.Location = new System.Drawing.Point(54, 38);
            this.buttonCurrentCollor.Name = "buttonCurrentCollor";
            this.buttonCurrentCollor.Size = new System.Drawing.Size(45, 45);
            this.buttonCurrentCollor.TabIndex = 1;
            this.buttonCurrentCollor.Text = "L";
            this.buttonCurrentCollor.UseVisualStyleBackColor = false;
            this.buttonCurrentCollor.Click += new System.EventHandler(this.buttonCurrentCollor_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.AllowDrop = true;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton4,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripButton18});
            this.toolStrip1.Location = new System.Drawing.Point(3, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(219, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.BackColor = System.Drawing.Color.Black;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.BackColor = System.Drawing.Color.Red;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.BackColor = System.Drawing.Color.Lime;
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton5.Text = "toolStripButton5";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.BackColor = System.Drawing.Color.Cyan;
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton6.Text = "toolStripButton6";
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.BackColor = System.Drawing.Color.Yellow;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.BackColor = System.Drawing.Color.Blue;
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton7.Text = "toolStripButton7";
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.BackColor = System.Drawing.Color.Fuchsia;
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton8.Text = "toolStripButton8";
            this.toolStripButton8.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // toolStripButton18
            // 
            this.toolStripButton18.BackColor = System.Drawing.Color.White;
            this.toolStripButton18.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton18.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripButton18.Name = "toolStripButton18";
            this.toolStripButton18.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton18.Text = "toolStripButton18";
            this.toolStripButton18.Click += new System.EventHandler(this.toolStripButton1_Click);
            this.toolStripButton18.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toolStripButton1_MouseDown);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1193, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pictureToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // pictureToolStripMenuItem
            // 
            this.pictureToolStripMenuItem.Name = "pictureToolStripMenuItem";
            this.pictureToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
            this.pictureToolStripMenuItem.Text = "Picture";
            this.pictureToolStripMenuItem.Click += new System.EventHandler(this.pictureToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.White;
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picture.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picture.Location = new System.Drawing.Point(5, 128);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(1194, 580);
            this.picture.TabIndex = 3;
            this.picture.TabStop = false;
            this.picture.Paint += new System.Windows.Forms.PaintEventHandler(this.picture_Paint);
            this.picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picture_MouseDown);
            this.picture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picture_MouseMove);
            this.picture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picture_MouseUp);
            // 
            // saveImageDialog
            // 
            this.saveImageDialog.DefaultExt = "jpg";
            // 
            // openImageDialog
            // 
            this.openImageDialog.FileName = "openFileDialog1";
            // 
            // WorkSpace
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 717);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WorkSpace";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Fractals 2D";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fracktalCtrackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toolCurrentPicture)).EndInit();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarWidthOfPen)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripButton toolStripButton18;
        public System.Windows.Forms.TrackBar trackBarWidthOfPen;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.OpenFileDialog openImageDialog;
        public System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pictureToolStripMenuItem;
        public System.Windows.Forms.Button buttonCurrentCollor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        public System.Windows.Forms.Button buttonRigthDraw;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
        private System.Windows.Forms.ToolStripButton toolStripButton10;
        private System.Windows.Forms.ToolStripButton toolStripButton11;
        private System.Windows.Forms.ToolStripButton toolStripButton12;
        private System.Windows.Forms.ToolStripButton toolStripButton14;
        private System.Windows.Forms.ToolStripButton toolStripButton13;
        private System.Windows.Forms.ToolStripButton toolStripButton15;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.PictureBox toolCurrentPicture;
        private System.Windows.Forms.TextBox widthTextbox;
        private System.Windows.Forms.Button eraseButton;
        public System.Windows.Forms.CheckBox isFractalCheckBox;
        private System.Windows.Forms.TrackBar fracktalCtrackBar1;
        public System.Windows.Forms.TextBox fracktalCtextBox;
        private System.Windows.Forms.Label label1;

    }
}

