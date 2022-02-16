using System;

namespace Precious_metals_value
{
    partial class Price_page
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Price_page));
            this.lab_link = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ControlBox2 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.siticonePanel1 = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.calculate_button = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.price_button = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.lbl_title = new System.Windows.Forms.Label();
            this.palladium_groupbox = new System.Windows.Forms.GroupBox();
            this.lbl_palladiumprice = new System.Windows.Forms.Label();
            this.siticoneRoundedButton1 = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.platinum_groupbox = new System.Windows.Forms.GroupBox();
            this.lbl_platinumprice = new System.Windows.Forms.Label();
            this.siticoneRoundedButton2 = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.silver_goupbox = new System.Windows.Forms.GroupBox();
            this.lbl_silverprice = new System.Windows.Forms.Label();
            this.silver_button = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.gold_groupbox = new System.Windows.Forms.GroupBox();
            this.lbl_goldprice = new System.Windows.Forms.Label();
            this.gold_button = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton5 = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.siticoneRoundedButton4 = new Siticone.Desktop.UI.WinForms.SiticoneRoundedButton();
            this.siticoneEmailValidatingTool1 = new Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.palladium_groupbox.SuspendLayout();
            this.platinum_groupbox.SuspendLayout();
            this.silver_goupbox.SuspendLayout();
            this.gold_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_link
            // 
            this.lab_link.AutoSize = true;
            this.lab_link.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lab_link.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_link.LinkColor = System.Drawing.Color.Goldenrod;
            this.lab_link.Location = new System.Drawing.Point(0, 434);
            this.lab_link.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lab_link.Name = "lab_link";
            this.lab_link.Size = new System.Drawing.Size(165, 16);
            this.lab_link.TabIndex = 20;
            this.lab_link.TabStop = true;
            this.lab_link.Text = "Copyright © 2022, riccio333";
            this.lab_link.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.lab_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lab_link_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.guna2ControlBox2);
            this.panel1.Controls.Add(this.guna2ControlBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 33);
            this.panel1.TabIndex = 21;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monospac821 BT", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 14);
            this.label1.TabIndex = 24;
            this.label1.Text = "Precius metals value";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Precious_metals_value.Properties.Resources.minecraft_gold_ingot;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_down);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_move);
            // 
            // guna2ControlBox2
            // 
            this.guna2ControlBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.guna2ControlBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2ControlBox2.HoverState.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.IconColor = System.Drawing.Color.Goldenrod;
            this.guna2ControlBox2.Location = new System.Drawing.Point(708, 0);
            this.guna2ControlBox2.Name = "guna2ControlBox2";
            this.guna2ControlBox2.ShadowDecoration.Parent = this.guna2ControlBox2;
            this.guna2ControlBox2.Size = new System.Drawing.Size(45, 35);
            this.guna2ControlBox2.TabIndex = 22;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2ControlBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Location = new System.Drawing.Point(749, 0);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(51, 33);
            this.guna2ControlBox1.TabIndex = 22;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.siticonePanel1.Controls.Add(this.calculate_button);
            this.siticonePanel1.Controls.Add(this.price_button);
            this.siticonePanel1.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.siticonePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.siticonePanel1.Location = new System.Drawing.Point(0, 33);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(102, 401);
            this.siticonePanel1.TabIndex = 23;
            // 
            // calculate_button
            // 
            this.calculate_button.CheckedState.CustomBorderColor = System.Drawing.Color.Goldenrod;
            this.calculate_button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.calculate_button.CheckedState.Parent = this.calculate_button;
            this.calculate_button.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.calculate_button.CustomImages.Parent = this.calculate_button;
            this.calculate_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.calculate_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.calculate_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.calculate_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.calculate_button.DisabledState.Parent = this.calculate_button;
            this.calculate_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.calculate_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.calculate_button.ForeColor = System.Drawing.Color.White;
            this.calculate_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.calculate_button.HoverState.Parent = this.calculate_button;
            this.calculate_button.Image = global::Precious_metals_value.Properties.Resources.dollar_euro_exchange_40px;
            this.calculate_button.Location = new System.Drawing.Point(0, 180);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.ShadowDecoration.Parent = this.calculate_button;
            this.calculate_button.Size = new System.Drawing.Size(102, 36);
            this.calculate_button.TabIndex = 24;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.CheckedChanged += new System.EventHandler(this.calculate_button_CheckedChanged);
            this.calculate_button.Click += new System.EventHandler(this.siticoneButton2_Click);
            // 
            // price_button
            // 
            this.price_button.Checked = true;
            this.price_button.CheckedState.CustomBorderColor = System.Drawing.Color.Goldenrod;
            this.price_button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.price_button.CheckedState.Parent = this.price_button;
            this.price_button.CustomBorderThickness = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.price_button.CustomImages.Parent = this.price_button;
            this.price_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.price_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.price_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.price_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.price_button.DisabledState.Parent = this.price_button;
            this.price_button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.price_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.price_button.ForeColor = System.Drawing.Color.White;
            this.price_button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.price_button.HoverState.Parent = this.price_button;
            this.price_button.Image = global::Precious_metals_value.Properties.Resources.euro_50px;
            this.price_button.Location = new System.Drawing.Point(0, 151);
            this.price_button.Name = "price_button";
            this.price_button.ShadowDecoration.Parent = this.price_button;
            this.price_button.Size = new System.Drawing.Size(102, 33);
            this.price_button.TabIndex = 0;
            this.price_button.Text = "Price";
            this.price_button.Click += new System.EventHandler(this.siticoneButton1_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Montserrat Alternates Medium", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Goldenrod;
            this.lbl_title.Location = new System.Drawing.Point(211, 61);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(435, 53);
            this.lbl_title.TabIndex = 46;
            this.lbl_title.Text = "Precius metals value";
            this.lbl_title.UseCompatibleTextRendering = true;
            // 
            // palladium_groupbox
            // 
            this.palladium_groupbox.BackColor = System.Drawing.Color.Black;
            this.palladium_groupbox.Controls.Add(this.lbl_palladiumprice);
            this.palladium_groupbox.Controls.Add(this.siticoneRoundedButton1);
            this.palladium_groupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.palladium_groupbox.Location = new System.Drawing.Point(445, 246);
            this.palladium_groupbox.Name = "palladium_groupbox";
            this.palladium_groupbox.Size = new System.Drawing.Size(274, 69);
            this.palladium_groupbox.TabIndex = 45;
            this.palladium_groupbox.TabStop = false;
            this.palladium_groupbox.Text = "Palladium price";
            // 
            // lbl_palladiumprice
            // 
            this.lbl_palladiumprice.AutoSize = true;
            this.lbl_palladiumprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_palladiumprice.ForeColor = System.Drawing.Color.White;
            this.lbl_palladiumprice.Location = new System.Drawing.Point(20, 19);
            this.lbl_palladiumprice.Name = "lbl_palladiumprice";
            this.lbl_palladiumprice.Size = new System.Drawing.Size(0, 20);
            this.lbl_palladiumprice.TabIndex = 0;
            // 
            // siticoneRoundedButton1
            // 
            this.siticoneRoundedButton1.BorderRadius = 18;
            this.siticoneRoundedButton1.CheckedState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.CustomImages.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneRoundedButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneRoundedButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneRoundedButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneRoundedButton1.DisabledState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(111)))), ((int)(((byte)(106)))), ((int)(((byte)(117)))));
            this.siticoneRoundedButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton1.HoverState.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Location = new System.Drawing.Point(151, 19);
            this.siticoneRoundedButton1.Name = "siticoneRoundedButton1";
            this.siticoneRoundedButton1.ShadowDecoration.Parent = this.siticoneRoundedButton1;
            this.siticoneRoundedButton1.Size = new System.Drawing.Size(117, 38);
            this.siticoneRoundedButton1.TabIndex = 3;
            this.siticoneRoundedButton1.Text = "Palladium price";
            this.siticoneRoundedButton1.Click += new System.EventHandler(this.siticoneRoundedButton1_Click);
            // 
            // platinum_groupbox
            // 
            this.platinum_groupbox.BackColor = System.Drawing.Color.Black;
            this.platinum_groupbox.Controls.Add(this.lbl_platinumprice);
            this.platinum_groupbox.Controls.Add(this.siticoneRoundedButton2);
            this.platinum_groupbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.platinum_groupbox.Location = new System.Drawing.Point(445, 143);
            this.platinum_groupbox.Name = "platinum_groupbox";
            this.platinum_groupbox.Size = new System.Drawing.Size(274, 72);
            this.platinum_groupbox.TabIndex = 44;
            this.platinum_groupbox.TabStop = false;
            this.platinum_groupbox.Text = "Platinum price";
            this.platinum_groupbox.Enter += new System.EventHandler(this.platinum_groupbox_Enter);
            // 
            // lbl_platinumprice
            // 
            this.lbl_platinumprice.AutoSize = true;
            this.lbl_platinumprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_platinumprice.ForeColor = System.Drawing.Color.White;
            this.lbl_platinumprice.Location = new System.Drawing.Point(20, 19);
            this.lbl_platinumprice.Name = "lbl_platinumprice";
            this.lbl_platinumprice.Size = new System.Drawing.Size(0, 20);
            this.lbl_platinumprice.TabIndex = 0;
            // 
            // siticoneRoundedButton2
            // 
            this.siticoneRoundedButton2.BorderRadius = 18;
            this.siticoneRoundedButton2.CheckedState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.CustomImages.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneRoundedButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneRoundedButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneRoundedButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneRoundedButton2.DisabledState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(228)))), ((int)(((byte)(226)))));
            this.siticoneRoundedButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton2.ForeColor = System.Drawing.Color.Black;
            this.siticoneRoundedButton2.HoverState.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Location = new System.Drawing.Point(151, 19);
            this.siticoneRoundedButton2.Name = "siticoneRoundedButton2";
            this.siticoneRoundedButton2.ShadowDecoration.Parent = this.siticoneRoundedButton2;
            this.siticoneRoundedButton2.Size = new System.Drawing.Size(117, 38);
            this.siticoneRoundedButton2.TabIndex = 3;
            this.siticoneRoundedButton2.Text = "Platinum price";
            this.siticoneRoundedButton2.Click += new System.EventHandler(this.siticoneRoundedButton2_Click_2);
            // 
            // silver_goupbox
            // 
            this.silver_goupbox.BackColor = System.Drawing.Color.Black;
            this.silver_goupbox.Controls.Add(this.lbl_silverprice);
            this.silver_goupbox.Controls.Add(this.silver_button);
            this.silver_goupbox.ForeColor = System.Drawing.Color.Silver;
            this.silver_goupbox.Location = new System.Drawing.Point(135, 246);
            this.silver_goupbox.Name = "silver_goupbox";
            this.silver_goupbox.Size = new System.Drawing.Size(274, 69);
            this.silver_goupbox.TabIndex = 43;
            this.silver_goupbox.TabStop = false;
            this.silver_goupbox.Text = "Silver price";
            // 
            // lbl_silverprice
            // 
            this.lbl_silverprice.AutoSize = true;
            this.lbl_silverprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_silverprice.ForeColor = System.Drawing.Color.White;
            this.lbl_silverprice.Location = new System.Drawing.Point(24, 17);
            this.lbl_silverprice.Name = "lbl_silverprice";
            this.lbl_silverprice.Size = new System.Drawing.Size(0, 20);
            this.lbl_silverprice.TabIndex = 0;
            // 
            // silver_button
            // 
            this.silver_button.BorderRadius = 18;
            this.silver_button.CheckedState.Parent = this.silver_button;
            this.silver_button.CustomImages.Parent = this.silver_button;
            this.silver_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.silver_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.silver_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.silver_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.silver_button.DisabledState.Parent = this.silver_button;
            this.silver_button.FillColor = System.Drawing.Color.Silver;
            this.silver_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.silver_button.ForeColor = System.Drawing.Color.Black;
            this.silver_button.HoverState.Parent = this.silver_button;
            this.silver_button.Location = new System.Drawing.Point(151, 19);
            this.silver_button.Name = "silver_button";
            this.silver_button.ShadowDecoration.Parent = this.silver_button;
            this.silver_button.Size = new System.Drawing.Size(117, 38);
            this.silver_button.TabIndex = 3;
            this.silver_button.Text = "Silver price";
            this.silver_button.Click += new System.EventHandler(this.silver_button_Click);
            // 
            // gold_groupbox
            // 
            this.gold_groupbox.BackColor = System.Drawing.Color.Black;
            this.gold_groupbox.Controls.Add(this.lbl_goldprice);
            this.gold_groupbox.Controls.Add(this.gold_button);
            this.gold_groupbox.ForeColor = System.Drawing.Color.Gold;
            this.gold_groupbox.Location = new System.Drawing.Point(135, 143);
            this.gold_groupbox.Name = "gold_groupbox";
            this.gold_groupbox.Size = new System.Drawing.Size(274, 72);
            this.gold_groupbox.TabIndex = 42;
            this.gold_groupbox.TabStop = false;
            this.gold_groupbox.Text = "Gold price";
            this.gold_groupbox.Enter += new System.EventHandler(this.gold_groupbox_Enter);
            // 
            // lbl_goldprice
            // 
            this.lbl_goldprice.AutoSize = true;
            this.lbl_goldprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_goldprice.ForeColor = System.Drawing.Color.White;
            this.lbl_goldprice.Location = new System.Drawing.Point(24, 17);
            this.lbl_goldprice.Name = "lbl_goldprice";
            this.lbl_goldprice.Size = new System.Drawing.Size(0, 20);
            this.lbl_goldprice.TabIndex = 0;
            // 
            // gold_button
            // 
            this.gold_button.BorderRadius = 18;
            this.gold_button.CheckedState.Parent = this.gold_button;
            this.gold_button.CustomImages.Parent = this.gold_button;
            this.gold_button.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.gold_button.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.gold_button.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.gold_button.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.gold_button.DisabledState.Parent = this.gold_button;
            this.gold_button.FillColor = System.Drawing.Color.Gold;
            this.gold_button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gold_button.ForeColor = System.Drawing.Color.Black;
            this.gold_button.HoverState.Parent = this.gold_button;
            this.gold_button.Location = new System.Drawing.Point(151, 19);
            this.gold_button.Name = "gold_button";
            this.gold_button.ShadowDecoration.Parent = this.gold_button;
            this.gold_button.Size = new System.Drawing.Size(117, 38);
            this.gold_button.TabIndex = 3;
            this.gold_button.Text = "Gold price";
            this.gold_button.Click += new System.EventHandler(this.gold_button_Click);
            // 
            // siticoneRoundedButton5
            // 
            this.siticoneRoundedButton5.BorderRadius = 21;
            this.siticoneRoundedButton5.CheckedState.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.CustomImages.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneRoundedButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneRoundedButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneRoundedButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneRoundedButton5.DisabledState.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.FillColor = System.Drawing.Color.Goldenrod;
            this.siticoneRoundedButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton5.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton5.HoverState.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.Location = new System.Drawing.Point(459, 393);
            this.siticoneRoundedButton5.Name = "siticoneRoundedButton5";
            this.siticoneRoundedButton5.ShadowDecoration.Parent = this.siticoneRoundedButton5;
            this.siticoneRoundedButton5.Size = new System.Drawing.Size(107, 45);
            this.siticoneRoundedButton5.TabIndex = 41;
            this.siticoneRoundedButton5.Text = "API Status";
            this.siticoneRoundedButton5.Click += new System.EventHandler(this.siticoneRoundedButton5_Click);
            // 
            // siticoneRoundedButton4
            // 
            this.siticoneRoundedButton4.BorderRadius = 21;
            this.siticoneRoundedButton4.CheckedState.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.CustomImages.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneRoundedButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneRoundedButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneRoundedButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneRoundedButton4.DisabledState.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.FillColor = System.Drawing.Color.Goldenrod;
            this.siticoneRoundedButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneRoundedButton4.ForeColor = System.Drawing.Color.White;
            this.siticoneRoundedButton4.HoverState.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.Location = new System.Drawing.Point(283, 393);
            this.siticoneRoundedButton4.Name = "siticoneRoundedButton4";
            this.siticoneRoundedButton4.ShadowDecoration.Parent = this.siticoneRoundedButton4;
            this.siticoneRoundedButton4.Size = new System.Drawing.Size(104, 45);
            this.siticoneRoundedButton4.TabIndex = 40;
            this.siticoneRoundedButton4.Text = "Your API Stats";
            this.siticoneRoundedButton4.Click += new System.EventHandler(this.siticoneRoundedButton4_Click);
            // 
            // siticoneEmailValidatingTool1
            // 
            this.siticoneEmailValidatingTool1.EmailError = System.Drawing.Color.Red;
            this.siticoneEmailValidatingTool1.EmailNoError = System.Drawing.Color.White;
            // 
            // Price_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.palladium_groupbox);
            this.Controls.Add(this.platinum_groupbox);
            this.Controls.Add(this.silver_goupbox);
            this.Controls.Add(this.gold_groupbox);
            this.Controls.Add(this.siticoneRoundedButton5);
            this.Controls.Add(this.siticoneRoundedButton4);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lab_link);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Price_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Precius metals value";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.palladium_groupbox.ResumeLayout(false);
            this.palladium_groupbox.PerformLayout();
            this.platinum_groupbox.ResumeLayout(false);
            this.platinum_groupbox.PerformLayout();
            this.silver_goupbox.ResumeLayout(false);
            this.silver_goupbox.PerformLayout();
            this.gold_groupbox.ResumeLayout(false);
            this.gold_groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lab_link;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox2;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Siticone.Desktop.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.Desktop.UI.WinForms.SiticoneButton calculate_button;
        private Siticone.Desktop.UI.WinForms.SiticoneButton price_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.GroupBox palladium_groupbox;
        private System.Windows.Forms.Label lbl_palladiumprice;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton1;
        private System.Windows.Forms.GroupBox platinum_groupbox;
        private System.Windows.Forms.Label lbl_platinumprice;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton2;
        private System.Windows.Forms.GroupBox silver_goupbox;
        private System.Windows.Forms.Label lbl_silverprice;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton silver_button;
        private System.Windows.Forms.GroupBox gold_groupbox;
        private System.Windows.Forms.Label lbl_goldprice;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton gold_button;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton5;
        private Siticone.Desktop.UI.WinForms.SiticoneRoundedButton siticoneRoundedButton4;
        private Siticone.Desktop.UI.Winforms.SiticoneEmailValidatingTool siticoneEmailValidatingTool1;
    }
}

