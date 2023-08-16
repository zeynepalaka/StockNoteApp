namespace ExampleFullStack
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            btnExit = new Button();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            btnLogin = new Button();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Font = new Font("Constantia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnExit.ForeColor = Color.MediumSlateBlue;
            btnExit.Location = new Point(489, 360);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(242, 54);
            btnExit.TabIndex = 4;
            btnExit.Text = "Kapat";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Constantia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(446, 161);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 26);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Constantia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(511, 208);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 26);
            label2.TabIndex = 1;
            label2.Text = "Şifre:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(590, 208);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(156, 30);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(590, 157);
            txtUserName.Margin = new Padding(4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(156, 30);
            txtUserName.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Constantia", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = Color.MediumSlateBlue;
            btnLogin.Location = new Point(489, 298);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(242, 54);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Giriş Yap";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Monotype Corsiva", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(535, 75);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(134, 39);
            label4.TabIndex = 1;
            label4.Text = "Giriş Yap";
            label4.Click += label4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(397, 506);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // UserLoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumSlateBlue;
            ClientSize = new Size(826, 545);
            Controls.Add(pictureBox1);
            Controls.Add(txtUserName);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(btnExit);
            Font = new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UserLoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserLogin";
            Load += UserLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Button btnLogin;
        private Label label4;
        private PictureBox pictureBox1;
    }
}