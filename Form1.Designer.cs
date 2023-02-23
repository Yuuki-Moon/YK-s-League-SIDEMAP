namespace LeagueSidemap
{
    partial class MainForm
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
            this.MapBmp = new System.Windows.Forms.PictureBox();
            this.CameraTimer = new System.Windows.Forms.Timer(this.components);
            this.SettingsPannel = new System.Windows.Forms.Panel();
            this.SliderPosY = new System.Windows.Forms.TrackBar();
            this.SliderPosX = new System.Windows.Forms.TrackBar();
            this.SliderCaptureSize = new System.Windows.Forms.TrackBar();
            this.SliderWindowSize = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtbResX = new System.Windows.Forms.TextBox();
            this.txtbResY = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MapBmp)).BeginInit();
            this.SettingsPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderPosY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderPosX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderCaptureSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderWindowSize)).BeginInit();
            this.SuspendLayout();
            // 
            // MapBmp
            // 
            this.MapBmp.Location = new System.Drawing.Point(0, 0);
            this.MapBmp.Name = "MapBmp";
            this.MapBmp.Size = new System.Drawing.Size(350, 350);
            this.MapBmp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MapBmp.TabIndex = 0;
            this.MapBmp.TabStop = false;
            this.MapBmp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MapBmp_MouseClick);
            this.MapBmp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MapBmp_MouseDown);
            // 
            // CameraTimer
            // 
            this.CameraTimer.Enabled = true;
            this.CameraTimer.Tick += new System.EventHandler(this.CameraTimer_Tick);
            // 
            // SettingsPannel
            // 
            this.SettingsPannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsPannel.Controls.Add(this.txtbResY);
            this.SettingsPannel.Controls.Add(this.txtbResX);
            this.SettingsPannel.Controls.Add(this.button2);
            this.SettingsPannel.Controls.Add(this.button1);
            this.SettingsPannel.Controls.Add(this.SliderPosY);
            this.SettingsPannel.Controls.Add(this.SliderPosX);
            this.SettingsPannel.Controls.Add(this.SliderCaptureSize);
            this.SettingsPannel.Controls.Add(this.SliderWindowSize);
            this.SettingsPannel.Controls.Add(this.label4);
            this.SettingsPannel.Controls.Add(this.label3);
            this.SettingsPannel.Controls.Add(this.label2);
            this.SettingsPannel.Controls.Add(this.label1);
            this.SettingsPannel.Location = new System.Drawing.Point(0, 0);
            this.SettingsPannel.Name = "SettingsPannel";
            this.SettingsPannel.Size = new System.Drawing.Size(330, 273);
            this.SettingsPannel.TabIndex = 1;
            this.SettingsPannel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SettingsPannel_MouseClick);
            // 
            // SliderPosY
            // 
            this.SliderPosY.Location = new System.Drawing.Point(24, 228);
            this.SliderPosY.Name = "SliderPosY";
            this.SliderPosY.Size = new System.Drawing.Size(170, 45);
            this.SliderPosY.TabIndex = 7;
            // 
            // SliderPosX
            // 
            this.SliderPosX.Location = new System.Drawing.Point(26, 164);
            this.SliderPosX.Name = "SliderPosX";
            this.SliderPosX.Size = new System.Drawing.Size(170, 45);
            this.SliderPosX.TabIndex = 6;
            // 
            // SliderCaptureSize
            // 
            this.SliderCaptureSize.Location = new System.Drawing.Point(24, 100);
            this.SliderCaptureSize.Name = "SliderCaptureSize";
            this.SliderCaptureSize.Size = new System.Drawing.Size(170, 45);
            this.SliderCaptureSize.TabIndex = 5;
            this.SliderCaptureSize.MouseCaptureChanged += new System.EventHandler(this.trackBar2_MouseCaptureChanged);
            // 
            // SliderWindowSize
            // 
            this.SliderWindowSize.Location = new System.Drawing.Point(26, 36);
            this.SliderWindowSize.Name = "SliderWindowSize";
            this.SliderWindowSize.Size = new System.Drawing.Size(170, 45);
            this.SliderWindowSize.TabIndex = 4;
            this.SliderWindowSize.MouseCaptureChanged += new System.EventHandler(this.SliderWindowSize_MouseCaptureChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Capture Position Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capture Position X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Capture Size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Window Size";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(302, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(215, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Set Resolution";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtbResX
            // 
            this.txtbResX.Location = new System.Drawing.Point(215, 176);
            this.txtbResX.Name = "txtbResX";
            this.txtbResX.Size = new System.Drawing.Size(110, 20);
            this.txtbResX.TabIndex = 10;
            this.txtbResX.Text = "1920";
            // 
            // txtbResY
            // 
            this.txtbResY.Location = new System.Drawing.Point(215, 202);
            this.txtbResY.Name = "txtbResY";
            this.txtbResY.Size = new System.Drawing.Size(110, 20);
            this.txtbResY.TabIndex = 11;
            this.txtbResY.Text = "1080";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 397);
            this.Controls.Add(this.SettingsPannel);
            this.Controls.Add(this.MapBmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "YK\'s League SIDEMAP";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MapBmp)).EndInit();
            this.SettingsPannel.ResumeLayout(false);
            this.SettingsPannel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SliderPosY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderPosX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderCaptureSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SliderWindowSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox MapBmp;
        private System.Windows.Forms.Timer CameraTimer;
        private System.Windows.Forms.Panel SettingsPannel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar SliderCaptureSize;
        private System.Windows.Forms.TrackBar SliderWindowSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar SliderPosY;
        private System.Windows.Forms.TrackBar SliderPosX;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtbResY;
        private System.Windows.Forms.TextBox txtbResX;
        private System.Windows.Forms.Button button2;
    }
}

