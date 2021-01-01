namespace CrashBot.WinUI
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btnGoAuto = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pctLeft = new System.Windows.Forms.PictureBox();
            this.pctRight = new System.Windows.Forms.PictureBox();
            this.pctDown = new System.Windows.Forms.PictureBox();
            this.pctUp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM15";
            // 
            // btnGoAuto
            // 
            this.btnGoAuto.Location = new System.Drawing.Point(12, 26);
            this.btnGoAuto.Name = "btnGoAuto";
            this.btnGoAuto.Size = new System.Drawing.Size(175, 59);
            this.btnGoAuto.TabIndex = 5;
            this.btnGoAuto.Text = "GO AUTO";
            this.btnGoAuto.UseVisualStyleBackColor = true;
            this.btnGoAuto.Click += new System.EventHandler(this.btnGoAuto_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(741, 569);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(124, 41);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(626, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 54);
            this.label1.TabIndex = 12;
            this.label1.Text = "Joystick";
            // 
            // pctLeft
            // 
            this.pctLeft.Image = global::CrashBot.WinUI.Properties.Resources.smanjenArrow___left;
            this.pctLeft.Location = new System.Drawing.Point(224, 269);
            this.pctLeft.Name = "pctLeft";
            this.pctLeft.Size = new System.Drawing.Size(127, 77);
            this.pctLeft.TabIndex = 11;
            this.pctLeft.TabStop = false;
            this.pctLeft.Click += new System.EventHandler(this.pctLeft_Click);
            // 
            // pctRight
            // 
            this.pctRight.Image = global::CrashBot.WinUI.Properties.Resources.smanjenArrow___right;
            this.pctRight.Location = new System.Drawing.Point(546, 269);
            this.pctRight.Name = "pctRight";
            this.pctRight.Size = new System.Drawing.Size(139, 77);
            this.pctRight.TabIndex = 10;
            this.pctRight.TabStop = false;
            this.pctRight.Click += new System.EventHandler(this.pctRight_Click);
            // 
            // pctDown
            // 
            this.pctDown.Image = global::CrashBot.WinUI.Properties.Resources.smanjenArrow___down;
            this.pctDown.Location = new System.Drawing.Point(412, 393);
            this.pctDown.Name = "pctDown";
            this.pctDown.Size = new System.Drawing.Size(100, 136);
            this.pctDown.TabIndex = 9;
            this.pctDown.TabStop = false;
            this.pctDown.Click += new System.EventHandler(this.pctDown_Click);
            // 
            // pctUp
            // 
            this.pctUp.Image = global::CrashBot.WinUI.Properties.Resources.smanjenArrow;
            this.pctUp.Location = new System.Drawing.Point(412, 85);
            this.pctUp.Name = "pctUp";
            this.pctUp.Size = new System.Drawing.Size(95, 130);
            this.pctUp.TabIndex = 8;
            this.pctUp.TabStop = false;
            this.pctUp.Click += new System.EventHandler(this.pctUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CrashBot.WinUI.Properties.Resources.smanjenZnak;
            this.pictureBox1.Location = new System.Drawing.Point(380, 233);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 140);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(877, 622);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctLeft);
            this.Controls.Add(this.pctRight);
            this.Controls.Add(this.pctDown);
            this.Controls.Add(this.pctUp);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnGoAuto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Joystick";
            ((System.ComponentModel.ISupportInitialize)(this.pctLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btnGoAuto;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pctUp;
        private System.Windows.Forms.PictureBox pctDown;
        private System.Windows.Forms.PictureBox pctRight;
        private System.Windows.Forms.PictureBox pctLeft;
        private System.Windows.Forms.Label label1;
    }
}

