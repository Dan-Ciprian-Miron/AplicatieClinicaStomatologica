
using System;

namespace ProiectDisertatie
{
    partial class EcranPornire
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
            this.pictureBoxEcranPornire = new System.Windows.Forms.PictureBox();
            this.labelClinica_smileDENT = new System.Windows.Forms.Label();
            this.labelCopyright = new System.Windows.Forms.Label();
            this.pBar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcranPornire)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxEcranPornire
            // 
            this.pictureBoxEcranPornire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxEcranPornire.Image = global::ProiectDisertatie.Properties.Resources.smiledent_low_resolution_color_logo2;
            this.pictureBoxEcranPornire.Location = new System.Drawing.Point(1, 47);
            this.pictureBoxEcranPornire.Name = "pictureBoxEcranPornire";
            this.pictureBoxEcranPornire.Size = new System.Drawing.Size(428, 295);
            this.pictureBoxEcranPornire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEcranPornire.TabIndex = 0;
            this.pictureBoxEcranPornire.TabStop = false;
            this.pictureBoxEcranPornire.Click += new System.EventHandler(this.pictureBoxEcranPornire_Click);
            // 
            // labelClinica_smileDENT
            // 
            this.labelClinica_smileDENT.AutoSize = true;
            this.labelClinica_smileDENT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelClinica_smileDENT.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClinica_smileDENT.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelClinica_smileDENT.Location = new System.Drawing.Point(12, 9);
            this.labelClinica_smileDENT.Name = "labelClinica_smileDENT";
            this.labelClinica_smileDENT.Size = new System.Drawing.Size(398, 35);
            this.labelClinica_smileDENT.TabIndex = 1;
            this.labelClinica_smileDENT.Text = "Clinica Stomatologica smileDENT";
            // 
            // labelCopyright
            // 
            this.labelCopyright.AutoSize = true;
            this.labelCopyright.Font = new System.Drawing.Font("Calibri", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCopyright.Location = new System.Drawing.Point(258, 569);
            this.labelCopyright.Name = "labelCopyright";
            this.labelCopyright.Size = new System.Drawing.Size(152, 17);
            this.labelCopyright.TabIndex = 3;
            this.labelCopyright.Text = "CopyRight | 2023 @ MDC";
            // 
            // pBar
            // 
            this.pBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.pBar.AnimationSpeed = 500;
            this.pBar.BackColor = System.Drawing.Color.Transparent;
            this.pBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pBar.ForeColor = System.Drawing.Color.White;
            this.pBar.InnerColor = System.Drawing.Color.DarkSeaGreen;
            this.pBar.InnerMargin = 2;
            this.pBar.InnerWidth = -1;
            this.pBar.Location = new System.Drawing.Point(92, 348);
            this.pBar.MarqueeAnimationSpeed = 2000;
            this.pBar.Name = "pBar";
            this.pBar.OuterColor = System.Drawing.Color.DarkCyan;
            this.pBar.OuterMargin = -25;
            this.pBar.OuterWidth = 26;
            this.pBar.ProgressColor = System.Drawing.Color.MediumAquamarine;
            this.pBar.ProgressWidth = 20;
            this.pBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.pBar.Size = new System.Drawing.Size(240, 218);
            this.pBar.StartAngle = 270;
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.pBar.SubscriptText = "";
            this.pBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.pBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.pBar.SuperscriptText = "";
            this.pBar.TabIndex = 4;
            this.pBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.pBar.Value = 68;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EcranPornire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(430, 595);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.labelCopyright);
            this.Controls.Add(this.labelClinica_smileDENT);
            this.Controls.Add(this.pictureBoxEcranPornire);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EcranPornire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
            this.Load += new System.EventHandler(this.EcranPornire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcranPornire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxEcranPornire;
        private System.Windows.Forms.Label labelClinica_smileDENT;
        private System.Windows.Forms.Label labelCopyright;
        private CircularProgressBar.CircularProgressBar pBar;
        private System.Windows.Forms.Timer timer1;
    }
}

