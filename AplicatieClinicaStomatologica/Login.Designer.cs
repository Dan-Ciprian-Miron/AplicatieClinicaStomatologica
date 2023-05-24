
namespace ProiectDisertatie
{
    partial class LoginForm
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
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelClose = new System.Windows.Forms.Label();
            this.labelClinica_smileDENT = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelParola = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxParola = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonPacientNou = new System.Windows.Forms.Button();
            this.pictureBoxEcranPornire = new System.Windows.Forms.PictureBox();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcranPornire)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panelLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.panelLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelLogin.Controls.Add(this.labelClose);
            this.panelLogin.Controls.Add(this.pictureBoxEcranPornire);
            this.panelLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogin.Location = new System.Drawing.Point(0, 0);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(480, 160);
            this.panelLogin.TabIndex = 0;
            // 
            // labelClose
            // 
            this.labelClose.AutoSize = true;
            this.labelClose.BackColor = System.Drawing.Color.DarkCyan;
            this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClose.ForeColor = System.Drawing.Color.White;
            this.labelClose.Location = new System.Drawing.Point(445, 0);
            this.labelClose.Name = "labelClose";
            this.labelClose.Size = new System.Drawing.Size(35, 32);
            this.labelClose.TabIndex = 9;
            this.labelClose.Text = "X";
            this.labelClose.Click += new System.EventHandler(this.labelClose_Click);
            // 
            // labelClinica_smileDENT
            // 
            this.labelClinica_smileDENT.AutoSize = true;
            this.labelClinica_smileDENT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelClinica_smileDENT.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClinica_smileDENT.ForeColor = System.Drawing.Color.DarkCyan;
            this.labelClinica_smileDENT.Location = new System.Drawing.Point(5, 182);
            this.labelClinica_smileDENT.Name = "labelClinica_smileDENT";
            this.labelClinica_smileDENT.Size = new System.Drawing.Size(463, 39);
            this.labelClinica_smileDENT.TabIndex = 2;
            this.labelClinica_smileDENT.Text = "Clinica Stomatologica smileDENT";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserName.Location = new System.Drawing.Point(38, 312);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(137, 29);
            this.labelUserName.TabIndex = 3;
            this.labelUserName.Text = "UserName";
            // 
            // labelParola
            // 
            this.labelParola.AutoSize = true;
            this.labelParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParola.Location = new System.Drawing.Point(38, 365);
            this.labelParola.Name = "labelParola";
            this.labelParola.Size = new System.Drawing.Size(89, 29);
            this.labelParola.TabIndex = 4;
            this.labelParola.Text = "Parola";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBoxUserName.Location = new System.Drawing.Point(191, 309);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(242, 34);
            this.textBoxUserName.TabIndex = 5;
            // 
            // textBoxParola
            // 
            this.textBoxParola.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.textBoxParola.Location = new System.Drawing.Point(191, 362);
            this.textBoxParola.Name = "textBoxParola";
            this.textBoxParola.PasswordChar = '*';
            this.textBoxParola.Size = new System.Drawing.Size(242, 34);
            this.textBoxParola.TabIndex = 6;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.DarkCyan;
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonLogin.Location = new System.Drawing.Point(112, 427);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(254, 57);
            this.buttonLogin.TabIndex = 7;
            this.buttonLogin.Text = "Logare";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonPacientNou
            // 
            this.buttonPacientNou.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.buttonPacientNou.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.buttonPacientNou.Location = new System.Drawing.Point(112, 490);
            this.buttonPacientNou.Name = "buttonPacientNou";
            this.buttonPacientNou.Size = new System.Drawing.Size(254, 57);
            this.buttonPacientNou.TabIndex = 8;
            this.buttonPacientNou.Text = "Pacient Nou";
            this.buttonPacientNou.UseVisualStyleBackColor = false;
            this.buttonPacientNou.Click += new System.EventHandler(this.buttonPacientNou_Click);
            // 
            // pictureBoxEcranPornire
            // 
            this.pictureBoxEcranPornire.BackColor = System.Drawing.Color.DarkSlateGray;
            this.pictureBoxEcranPornire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxEcranPornire.Image = global::ProiectDisertatie.Properties.Resources.smiledent_low_resolution_color_logo2;
            this.pictureBoxEcranPornire.Location = new System.Drawing.Point(128, 0);
            this.pictureBoxEcranPornire.Name = "pictureBoxEcranPornire";
            this.pictureBoxEcranPornire.Size = new System.Drawing.Size(216, 160);
            this.pictureBoxEcranPornire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxEcranPornire.TabIndex = 1;
            this.pictureBoxEcranPornire.TabStop = false;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelAdmin.Location = new System.Drawing.Point(186, 550);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(86, 29);
            this.labelAdmin.TabIndex = 9;
            this.labelAdmin.Text = "Admin";
            this.labelAdmin.Click += new System.EventHandler(this.labelAdmin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(480, 600);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.buttonPacientNou);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxParola);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelParola);
            this.Controls.Add(this.labelUserName);
            this.Controls.Add(this.labelClinica_smileDENT);
            this.Controls.Add(this.panelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEcranPornire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox pictureBoxEcranPornire;
        private System.Windows.Forms.Label labelClinica_smileDENT;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelParola;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxParola;
        private System.Windows.Forms.Label labelClose;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonPacientNou;
        private System.Windows.Forms.Label labelAdmin;
    }
}