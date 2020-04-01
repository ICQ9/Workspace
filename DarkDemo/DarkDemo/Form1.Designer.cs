namespace DarkDemo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.blue = new System.Windows.Forms.Panel();
            this.Counter = new System.Windows.Forms.Button();
            this.NBR = new System.Windows.Forms.Button();
            this.Profile_Log = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Panel_Profile_Log = new System.Windows.Forms.Panel();
            this.Panel_NBR = new System.Windows.Forms.Panel();
            this.panel_Counter_Cheker = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Label_Profile = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.Panel_Profile_Log.SuspendLayout();
            this.Panel_NBR.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.blue);
            this.panel1.Controls.Add(this.Counter);
            this.panel1.Controls.Add(this.NBR);
            this.panel1.Controls.Add(this.Profile_Log);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 519);
            this.panel1.TabIndex = 0;
            // 
            // blue
            // 
            this.blue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(185)))), ((int)(((byte)(235)))));
            this.blue.Location = new System.Drawing.Point(156, 116);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(10, 79);
            this.blue.TabIndex = 6;
            // 
            // Counter
            // 
            this.Counter.FlatAppearance.BorderSize = 0;
            this.Counter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Counter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Counter.ForeColor = System.Drawing.Color.White;
            this.Counter.Image = global::DarkDemo.Properties.Resources.business_and_finance;
            this.Counter.Location = new System.Drawing.Point(3, 301);
            this.Counter.Name = "Counter";
            this.Counter.Size = new System.Drawing.Size(163, 79);
            this.Counter.TabIndex = 1;
            this.Counter.Text = "Counter Cheker";
            this.Counter.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Counter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Counter.UseVisualStyleBackColor = true;
            this.Counter.Click += new System.EventHandler(this.Counter_Click);
            // 
            // NBR
            // 
            this.NBR.FlatAppearance.BorderSize = 0;
            this.NBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NBR.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NBR.ForeColor = System.Drawing.Color.White;
            this.NBR.Image = global::DarkDemo.Properties.Resources.document;
            this.NBR.Location = new System.Drawing.Point(0, 209);
            this.NBR.Name = "NBR";
            this.NBR.Size = new System.Drawing.Size(163, 79);
            this.NBR.TabIndex = 1;
            this.NBR.Text = "NBR";
            this.NBR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NBR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.NBR.UseVisualStyleBackColor = true;
            this.NBR.Click += new System.EventHandler(this.NBR_Click);
            // 
            // Profile_Log
            // 
            this.Profile_Log.FlatAppearance.BorderSize = 0;
            this.Profile_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Profile_Log.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_Log.ForeColor = System.Drawing.Color.White;
            this.Profile_Log.Image = ((System.Drawing.Image)(resources.GetObject("Profile_Log.Image")));
            this.Profile_Log.Location = new System.Drawing.Point(0, 116);
            this.Profile_Log.Name = "Profile_Log";
            this.Profile_Log.Size = new System.Drawing.Size(163, 79);
            this.Profile_Log.TabIndex = 1;
            this.Profile_Log.Text = "Profile Log";
            this.Profile_Log.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Profile_Log.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Profile_Log.UseVisualStyleBackColor = true;
            this.Profile_Log.Click += new System.EventHandler(this.Profile_Log_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(166, 76);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.pictureBox3.Image = global::DarkDemo.Properties.Resources.Mixer;
            this.pictureBox3.Location = new System.Drawing.Point(27, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::DarkDemo.Properties.Resources.Mixer;
            this.label2.Location = new System.Drawing.Point(21, -24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 117);
            this.label2.TabIndex = 0;
            // 
            // Panel_Profile_Log
            // 
            this.Panel_Profile_Log.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.Panel_Profile_Log.Controls.Add(this.Label_Profile);
            this.Panel_Profile_Log.Controls.Add(this.Panel_NBR);
            this.Panel_Profile_Log.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Profile_Log.Location = new System.Drawing.Point(166, 280);
            this.Panel_Profile_Log.Name = "Panel_Profile_Log";
            this.Panel_Profile_Log.Size = new System.Drawing.Size(627, 239);
            this.Panel_Profile_Log.TabIndex = 1;
            // 
            // Panel_NBR
            // 
            this.Panel_NBR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.Panel_NBR.Controls.Add(this.panel_Counter_Cheker);
            this.Panel_NBR.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_NBR.Location = new System.Drawing.Point(0, 3);
            this.Panel_NBR.Name = "Panel_NBR";
            this.Panel_NBR.Size = new System.Drawing.Size(627, 236);
            this.Panel_NBR.TabIndex = 2;
            // 
            // panel_Counter_Cheker
            // 
            this.panel_Counter_Cheker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.panel_Counter_Cheker.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_Counter_Cheker.Location = new System.Drawing.Point(0, -3);
            this.panel_Counter_Cheker.Name = "panel_Counter_Cheker";
            this.panel_Counter_Cheker.Size = new System.Drawing.Size(627, 239);
            this.panel_Counter_Cheker.TabIndex = 3;
            // 
            // Minimize
            // 
            this.Minimize.FlatAppearance.BorderSize = 0;
            this.Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Minimize.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.Image = global::DarkDemo.Properties.Resources.button;
            this.Minimize.Location = new System.Drawing.Point(723, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(26, 26);
            this.Minimize.TabIndex = 5;
            this.Minimize.UseVisualStyleBackColor = true;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.Image = global::DarkDemo.Properties.Resources.close__1_;
            this.Close.Location = new System.Drawing.Point(767, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 26);
            this.Close.TabIndex = 4;
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Label_Profile
            // 
            this.Label_Profile.AutoSize = true;
            this.Label_Profile.Location = new System.Drawing.Point(253, 0);
            this.Label_Profile.Name = "Label_Profile";
            this.Label_Profile.Size = new System.Drawing.Size(91, 21);
            this.Label_Profile.TabIndex = 3;
            this.Label_Profile.Text = "Profile_Log";
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(793, 519);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Panel_Profile_Log);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.Panel_Profile_Log.ResumeLayout(false);
            this.Panel_Profile_Log.PerformLayout();
            this.Panel_NBR.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button NBR;
        private System.Windows.Forms.Button Profile_Log;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel Panel_Profile_Log;
        private System.Windows.Forms.Button Counter;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Minimize;
        private System.Windows.Forms.Panel blue;
        private System.Windows.Forms.Panel Panel_NBR;
        private System.Windows.Forms.Panel panel_Counter_Cheker;
        private System.Windows.Forms.Label Label_Profile;
    }
}

