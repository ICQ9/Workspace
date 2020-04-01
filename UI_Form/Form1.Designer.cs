namespace UI_Form
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Button_Counter_Cheker = new System.Windows.Forms.Button();
            this.orange = new System.Windows.Forms.Panel();
            this.button_NBR = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Profile_Log = new System.Windows.Forms.Button();
            this.Panel_Profile = new System.Windows.Forms.Panel();
            this.Panel_Counter = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_Profile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(10)))), ((int)(((byte)(202)))), ((int)(((byte)(205)))));
            this.panel1.Controls.Add(this.Button_Counter_Cheker);
            this.panel1.Controls.Add(this.orange);
            this.panel1.Controls.Add(this.button_NBR);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Button_Profile_Log);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(196, 502);
            this.panel1.TabIndex = 0;
            this.panel1.Visible = false;
            // 
            // Button_Counter_Cheker
            // 
            this.Button_Counter_Cheker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Counter_Cheker.Image = global::UI_Form.Properties.Resources.inventory;
            this.Button_Counter_Cheker.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Counter_Cheker.Location = new System.Drawing.Point(0, 216);
            this.Button_Counter_Cheker.Name = "Button_Counter_Cheker";
            this.Button_Counter_Cheker.Size = new System.Drawing.Size(196, 91);
            this.Button_Counter_Cheker.TabIndex = 2;
            this.Button_Counter_Cheker.Text = "Counter Cheker ";
            this.Button_Counter_Cheker.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Counter_Cheker.UseVisualStyleBackColor = true;
            this.Button_Counter_Cheker.Click += new System.EventHandler(this.Button_Counter_Cheker_Click);
            // 
            // orange
            // 
            this.orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.orange.Location = new System.Drawing.Point(186, 116);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(10, 94);
            this.orange.TabIndex = 2;
            // 
            // button_NBR
            // 
            this.button_NBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NBR.Image = global::UI_Form.Properties.Resources.userIcon;
            this.button_NBR.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button_NBR.Location = new System.Drawing.Point(0, 313);
            this.button_NBR.Name = "button_NBR";
            this.button_NBR.Size = new System.Drawing.Size(196, 90);
            this.button_NBR.TabIndex = 3;
            this.button_NBR.Text = "NBR";
            this.button_NBR.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_NBR.UseVisualStyleBackColor = true;
            this.button_NBR.Click += new System.EventHandler(this.button_NBR_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 93);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.pictureBox1.Image = global::UI_Form.Properties.Resources.Mixer;
            this.pictureBox1.Location = new System.Drawing.Point(54, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admixer Loger";
            // 
            // Button_Profile_Log
            // 
            this.Button_Profile_Log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Profile_Log.Image = global::UI_Form.Properties.Resources.userIcon;
            this.Button_Profile_Log.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Button_Profile_Log.Location = new System.Drawing.Point(0, 116);
            this.Button_Profile_Log.Name = "Button_Profile_Log";
            this.Button_Profile_Log.Size = new System.Drawing.Size(196, 94);
            this.Button_Profile_Log.TabIndex = 1;
            this.Button_Profile_Log.Text = "Profile Log";
            this.Button_Profile_Log.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Button_Profile_Log.UseVisualStyleBackColor = true;
            // 
            // Panel_Profile
            // 
            this.Panel_Profile.Controls.Add(this.Panel_Counter);
            this.Panel_Profile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Profile.Location = new System.Drawing.Point(196, 216);
            this.Panel_Profile.Name = "Panel_Profile";
            this.Panel_Profile.Size = new System.Drawing.Size(1078, 286);
            this.Panel_Profile.TabIndex = 1;
            // 
            // Panel_Counter
            // 
            this.Panel_Counter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel_Counter.Location = new System.Drawing.Point(0, 20);
            this.Panel_Counter.Name = "Panel_Counter";
            this.Panel_Counter.Size = new System.Drawing.Size(1078, 266);
            this.Panel_Counter.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(41)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1274, 502);
            this.Controls.Add(this.Panel_Profile);
            this.Controls.Add(this.panel1);
            this.Enabled = false;
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_Profile.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Profile_Log;
        private System.Windows.Forms.Button button_NBR;
        private System.Windows.Forms.Button Button_Counter_Cheker;
        private System.Windows.Forms.Panel Panel_Profile;
        private System.Windows.Forms.Panel Panel_Counter;
        private System.Windows.Forms.Panel orange;
    }
}

