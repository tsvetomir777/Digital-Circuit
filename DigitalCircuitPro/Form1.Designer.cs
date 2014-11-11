namespace DigitalCircuitPro
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pbLines = new System.Windows.Forms.PictureBox();
            this.Source = new System.Windows.Forms.PictureBox();
            this.Sink = new System.Windows.Forms.PictureBox();
            this.NotGate = new System.Windows.Forms.PictureBox();
            this.OrGate = new System.Windows.Forms.PictureBox();
            this.AndGate = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotGate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrGate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AndGate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "100x50_andgate.png");
            this.imageList1.Images.SetKeyName(1, "100x50_notGate2.png");
            this.imageList1.Images.SetKeyName(2, "100x50_orgate.png");
            this.imageList1.Images.SetKeyName(3, "100x100_SINK_OFF.png");
            this.imageList1.Images.SetKeyName(4, "100x100_sinkon.png");
            this.imageList1.Images.SetKeyName(5, "100x100_sourceoff.png");
            this.imageList1.Images.SetKeyName(6, "100x100_sourceon.png");
            this.imageList1.Images.SetKeyName(7, "delete-256.png");
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(227, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 443);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(308, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Silver;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator6,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripSeparator5,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.toolStripSeparator4,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripSeparator10,
            this.toolStripSeparator9,
            this.toolStripButton3,
            this.toolStripSeparator8,
            this.toolStripSeparator7,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(791, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.ForeColor = System.Drawing.Color.Blue;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(63, 22);
            this.toolStripLabel1.Text = "Colorblind";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton1.Text = "Reset";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(35, 22);
            this.toolStripButton2.Text = "Save";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(37, 22);
            this.toolStripButton3.Text = "Load";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DigitalCircuitPro.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(11, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::DigitalCircuitPro.Properties.Resources.Crisp_Paper_vertical_stripes_Grey_Seamless_Patterns_For_Website_Background;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.pictureBox11);
            this.panel2.Controls.Add(this.pbLines);
            this.panel2.Controls.Add(this.Source);
            this.panel2.Controls.Add(this.Sink);
            this.panel2.Controls.Add(this.NotGate);
            this.panel2.Controls.Add(this.OrGate);
            this.panel2.Controls.Add(this.AndGate);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(12, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 374);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = global::DigitalCircuitPro.Properties.Resources.connection;
            this.pictureBox11.Location = new System.Drawing.Point(98, 313);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(75, 50);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox11.TabIndex = 9;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox11_Click);
            // 
            // pbLines
            // 
            this.pbLines.Image = ((System.Drawing.Image)(resources.GetObject("pbLines.Image")));
            this.pbLines.Location = new System.Drawing.Point(17, 313);
            this.pbLines.Name = "pbLines";
            this.pbLines.Size = new System.Drawing.Size(75, 50);
            this.pbLines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLines.TabIndex = 8;
            this.pbLines.TabStop = false;
            this.pbLines.Click += new System.EventHandler(this.pbLines_Click);
            // 
            // Source
            // 
            this.Source.Image = global::DigitalCircuitPro.Properties.Resources.source_OFF1;
            this.Source.Location = new System.Drawing.Point(96, 222);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(75, 50);
            this.Source.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Source.TabIndex = 7;
            this.Source.TabStop = false;
            this.Source.Click += new System.EventHandler(this.Source_Click_1);
            // 
            // Sink
            // 
            this.Sink.Image = global::DigitalCircuitPro.Properties.Resources.SINK_OFF1;
            this.Sink.Location = new System.Drawing.Point(17, 222);
            this.Sink.Name = "Sink";
            this.Sink.Size = new System.Drawing.Size(75, 50);
            this.Sink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sink.TabIndex = 6;
            this.Sink.TabStop = false;
            this.Sink.Click += new System.EventHandler(this.Sink_Click_1);
            // 
            // NotGate
            // 
            this.NotGate.Image = global::DigitalCircuitPro.Properties.Resources.notgate;
            this.NotGate.Location = new System.Drawing.Point(50, 130);
            this.NotGate.Name = "NotGate";
            this.NotGate.Size = new System.Drawing.Size(90, 40);
            this.NotGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotGate.TabIndex = 5;
            this.NotGate.TabStop = false;
            this.NotGate.Click += new System.EventHandler(this.NotGate_Click_1);
            // 
            // OrGate
            // 
            this.OrGate.Image = global::DigitalCircuitPro.Properties.Resources.orgate;
            this.OrGate.Location = new System.Drawing.Point(50, 88);
            this.OrGate.Name = "OrGate";
            this.OrGate.Size = new System.Drawing.Size(90, 40);
            this.OrGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OrGate.TabIndex = 4;
            this.OrGate.TabStop = false;
            this.OrGate.Click += new System.EventHandler(this.OrGate_Click_1);
            // 
            // AndGate
            // 
            this.AndGate.Image = global::DigitalCircuitPro.Properties.Resources.andgate;
            this.AndGate.Location = new System.Drawing.Point(50, 46);
            this.AndGate.Name = "AndGate";
            this.AndGate.Size = new System.Drawing.Size(90, 40);
            this.AndGate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AndGate.TabIndex = 3;
            this.AndGate.TabStop = false;
            this.AndGate.Click += new System.EventHandler(this.AndGate_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::DigitalCircuitPro.Properties.Resources.options_category;
            this.pictureBox4.Location = new System.Drawing.Point(47, 277);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(93, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DigitalCircuitPro.Properties.Resources.sink_source_category;
            this.pictureBox3.Location = new System.Drawing.Point(17, 176);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(154, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::DigitalCircuitPro.Properties.Resources.gates_category;
            this.pictureBox2.Location = new System.Drawing.Point(37, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(108, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton4.Text = "New form";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 487);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "DIGITAL CIRCUIT";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Source)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotGate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrGate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AndGate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void OrGate_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void NotGate_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Sink_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Source_Click(object sender, System.EventArgs e)
        {
            throw new System.NotImplementedException();
        }

     

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox AndGate;
        private System.Windows.Forms.PictureBox NotGate;
        private System.Windows.Forms.PictureBox OrGate;
        private System.Windows.Forms.PictureBox Sink;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pbLines;
        private System.Windows.Forms.PictureBox Source;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
    }
}

