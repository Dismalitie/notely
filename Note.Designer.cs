namespace notely
{
    partial class Note
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Note));
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nodrag = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.update = new System.Windows.Forms.Timer(this.components);
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneDragControl2 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.siticoneElipse1 = new Siticone.UI.WinForms.SiticoneElipse(this.components);
            this.fade_out = new System.Windows.Forms.Timer(this.components);
            this.fade_in = new System.Windows.Forms.Timer(this.components);
            this.opacity_fade_in = new System.Windows.Forms.Timer(this.components);
            this.opacity_fade_out = new System.Windows.Forms.Timer(this.components);
            this.visibility = new System.Windows.Forms.PictureBox();
            this.min = new System.Windows.Forms.PictureBox();
            this.exit = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visibility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(169)))), ((int)(((byte)(46)))));
            this.panel1.Controls.Add(this.visibility);
            this.panel1.Controls.Add(this.min);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.exit);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-8, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(316, 47);
            this.panel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(169)))), ((int)(((byte)(46)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(20, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "New Note";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nodrag
            // 
            this.nodrag.Location = new System.Drawing.Point(174, 384);
            this.nodrag.Name = "nodrag";
            this.nodrag.Size = new System.Drawing.Size(200, 34);
            this.nodrag.TabIndex = 1;
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(149)))), ((int)(((byte)(26)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBox1.Location = new System.Drawing.Point(13, 46);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(272, 271);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "Put your notes here!";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // update
            // 
            this.update.Enabled = true;
            this.update.Tick += new System.EventHandler(this.update_Tick);
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this.panel1;
            // 
            // siticoneDragControl2
            // 
            this.siticoneDragControl2.TargetControl = this.textBox1;
            // 
            // siticoneElipse1
            // 
            this.siticoneElipse1.BorderRadius = 15;
            this.siticoneElipse1.TargetControl = this;
            // 
            // fade_out
            // 
            this.fade_out.Interval = 30;
            this.fade_out.Tick += new System.EventHandler(this.fade_out_Tick);
            // 
            // fade_in
            // 
            this.fade_in.Enabled = true;
            this.fade_in.Interval = 30;
            this.fade_in.Tick += new System.EventHandler(this.fade_in_Tick);
            // 
            // opacity_fade_in
            // 
            this.opacity_fade_in.Enabled = true;
            this.opacity_fade_in.Interval = 200;
            // 
            // opacity_fade_out
            // 
            this.opacity_fade_out.Enabled = true;
            this.opacity_fade_out.Interval = 200;
            // 
            // visibility
            // 
            this.visibility.BackgroundImage = global::notely.Properties.Resources.eye_off;
            this.visibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.visibility.Location = new System.Drawing.Point(195, 18);
            this.visibility.Name = "visibility";
            this.visibility.Size = new System.Drawing.Size(20, 20);
            this.visibility.TabIndex = 9;
            this.visibility.TabStop = false;
            this.visibility.Click += new System.EventHandler(this.visibility_Click);
            // 
            // min
            // 
            this.min.BackgroundImage = global::notely.Properties.Resources.chevron_up;
            this.min.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.min.Location = new System.Drawing.Point(221, 18);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(20, 20);
            this.min.TabIndex = 8;
            this.min.TabStop = false;
            this.min.Click += new System.EventHandler(this.min_Click);
            // 
            // exit
            // 
            this.exit.BackgroundImage = global::notely.Properties.Resources.x;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exit.Location = new System.Drawing.Point(273, 18);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(20, 20);
            this.exit.TabIndex = 6;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::notely.Properties.Resources.pin;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(247, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(149)))), ((int)(((byte)(26)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(295, 329);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.nodrag);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Note";
            this.Opacity = 0D;
            this.Text = "Note";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Note_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visibility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.Panel nodrag;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox min;
        private System.Windows.Forms.Timer update;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;
        private Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl2;
        private System.Windows.Forms.PictureBox visibility;
        private Siticone.UI.WinForms.SiticoneElipse siticoneElipse1;
        private System.Windows.Forms.Timer fade_out;
        private System.Windows.Forms.Timer fade_in;
        private System.Windows.Forms.Timer opacity_fade_in;
        private System.Windows.Forms.Timer opacity_fade_out;
    }
}