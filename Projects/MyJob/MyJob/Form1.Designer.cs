namespace MyJob
{
    partial class Login
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
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.clickForRegister = new System.Windows.Forms.Label();
            this.registerText = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.loginEmailText = new System.Windows.Forms.TextBox();
            this.loginPasswordText = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            label1.Location = new System.Drawing.Point(221, 519);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(210, 22);
            label1.TabIndex = 44;
            label1.Text = "Don\'t have an account";
            // 
            // clickForRegister
            // 
            this.clickForRegister.AutoSize = true;
            this.clickForRegister.BackColor = System.Drawing.Color.Transparent;
            this.clickForRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clickForRegister.ForeColor = System.Drawing.SystemColors.InfoText;
            this.clickForRegister.Location = new System.Drawing.Point(265, 557);
            this.clickForRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.clickForRegister.Name = "clickForRegister";
            this.clickForRegister.Size = new System.Drawing.Size(112, 25);
            this.clickForRegister.TabIndex = 45;
            this.clickForRegister.Text = "Click Here";
            this.clickForRegister.Click += new System.EventHandler(this.clickForRegisterClick);
            // 
            // registerText
            // 
            this.registerText.AutoSize = true;
            this.registerText.BackColor = System.Drawing.Color.Transparent;
            this.registerText.Font = new System.Drawing.Font("Roboto Slab Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.registerText.ForeColor = System.Drawing.SystemColors.MenuText;
            this.registerText.Location = new System.Drawing.Point(262, 98);
            this.registerText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.registerText.Name = "registerText";
            this.registerText.Size = new System.Drawing.Size(123, 45);
            this.registerText.TabIndex = 43;
            this.registerText.Text = "LOGIN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Roboto Slab Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(148, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 27);
            this.label6.TabIndex = 41;
            this.label6.Text = "Email";
            // 
            // loginEmailText
            // 
            this.loginEmailText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.loginEmailText.Location = new System.Drawing.Point(153, 240);
            this.loginEmailText.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.loginEmailText.Name = "loginEmailText";
            this.loginEmailText.Size = new System.Drawing.Size(318, 28);
            this.loginEmailText.TabIndex = 40;
            // 
            // loginPasswordText
            // 
            this.loginPasswordText.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.loginPasswordText.HideSelection = false;
            this.loginPasswordText.Location = new System.Drawing.Point(153, 340);
            this.loginPasswordText.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.loginPasswordText.Name = "loginPasswordText";
            this.loginPasswordText.PasswordChar = '*';
            this.loginPasswordText.Size = new System.Drawing.Size(318, 28);
            this.loginPasswordText.TabIndex = 37;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.Transparent;
            this.loginButton.Font = new System.Drawing.Font("Roboto Slab Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.loginButton.Location = new System.Drawing.Point(210, 407);
            this.loginButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(201, 80);
            this.loginButton.TabIndex = 36;
            this.loginButton.Text = "LOGIN";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Roboto Slab Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(148, 295);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 27);
            this.label3.TabIndex = 35;
            this.label3.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(632, 753);
            this.Controls.Add(this.clickForRegister);
            this.Controls.Add(label1);
            this.Controls.Add(this.registerText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.loginEmailText);
            this.Controls.Add(this.loginPasswordText);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label clickForRegister;
        private System.Windows.Forms.Label registerText;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox loginEmailText;
        private System.Windows.Forms.TextBox loginPasswordText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label3;
    }
}

