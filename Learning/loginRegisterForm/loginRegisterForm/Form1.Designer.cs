namespace loginRegisterForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sign = new System.Windows.Forms.TabPage();
            this.signINN = new System.Windows.Forms.Button();
            this.passText = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.signUp = new System.Windows.Forms.TabPage();
            this.registerNameTextbox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.register_Button = new System.Windows.Forms.Button();
            this.registerPassTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.registerEmailTextBo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registerPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.registerNameText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registerAgeTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.registerEmailTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.sign.SuspendLayout();
            this.signUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sign);
            this.tabControl1.Controls.Add(this.signUp);
            this.tabControl1.Location = new System.Drawing.Point(12, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(761, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // sign
            // 
            this.sign.Controls.Add(this.signINN);
            this.sign.Controls.Add(this.passText);
            this.sign.Controls.Add(this.label10);
            this.sign.Controls.Add(this.emailText);
            this.sign.Controls.Add(this.label11);
            this.sign.Location = new System.Drawing.Point(4, 25);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(753, 425);
            this.sign.TabIndex = 2;
            this.sign.Text = "sign IN";
            this.sign.UseVisualStyleBackColor = true;
            // 
            // signINN
            // 
            this.signINN.Location = new System.Drawing.Point(153, 152);
            this.signINN.Name = "signINN";
            this.signINN.Size = new System.Drawing.Size(75, 51);
            this.signINN.TabIndex = 14;
            this.signINN.Text = "signIn";
            this.signINN.UseVisualStyleBackColor = true;
            this.signINN.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passText
            // 
            this.passText.Location = new System.Drawing.Point(120, 100);
            this.passText.Name = "passText";
            this.passText.Size = new System.Drawing.Size(163, 22);
            this.passText.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(47, 103);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 16);
            this.label10.TabIndex = 12;
            this.label10.Text = "Password";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(120, 62);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(163, 22);
            this.emailText.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(47, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 16);
            this.label11.TabIndex = 10;
            this.label11.Text = "Email:";
            // 
            // signUp
            // 
            this.signUp.Controls.Add(this.registerNameTextbox);
            this.signUp.Controls.Add(this.label9);
            this.signUp.Controls.Add(this.register_Button);
            this.signUp.Controls.Add(this.registerPassTextBox);
            this.signUp.Controls.Add(this.label7);
            this.signUp.Controls.Add(this.registerEmailTextBo);
            this.signUp.Controls.Add(this.label8);
            this.signUp.Location = new System.Drawing.Point(4, 25);
            this.signUp.Name = "signUp";
            this.signUp.Size = new System.Drawing.Size(753, 425);
            this.signUp.TabIndex = 1;
            this.signUp.Text = "signUp";
            this.signUp.UseVisualStyleBackColor = true;
            // 
            // registerNameTextbox
            // 
            this.registerNameTextbox.Location = new System.Drawing.Point(122, 74);
            this.registerNameTextbox.Name = "registerNameTextbox";
            this.registerNameTextbox.Size = new System.Drawing.Size(163, 22);
            this.registerNameTextbox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(49, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Name:";
            // 
            // register_Button
            // 
            this.register_Button.Location = new System.Drawing.Point(155, 192);
            this.register_Button.Name = "register_Button";
            this.register_Button.Size = new System.Drawing.Size(75, 23);
            this.register_Button.TabIndex = 9;
            this.register_Button.Text = "SIGN UP";
            this.register_Button.UseVisualStyleBackColor = true;
            this.register_Button.Click += new System.EventHandler(this.register_Button_Click);
            // 
            // registerPassTextBox
            // 
            this.registerPassTextBox.Location = new System.Drawing.Point(122, 140);
            this.registerPassTextBox.Name = "registerPassTextBox";
            this.registerPassTextBox.Size = new System.Drawing.Size(163, 22);
            this.registerPassTextBox.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registerEmailTextBo
            // 
            this.registerEmailTextBo.Location = new System.Drawing.Point(122, 102);
            this.registerEmailTextBo.Name = "registerEmailTextBo";
            this.registerEmailTextBo.Size = new System.Drawing.Size(163, 22);
            this.registerEmailTextBo.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Email:";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(156, 128);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(75, 23);
            this.loginbtn.TabIndex = 4;
            this.loginbtn.Text = "LOGİN";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(121, 83);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(163, 22);
            this.passwordTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(121, 29);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(163, 22);
            this.emailTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email:";
            // 
            // registerPasswordTextBox
            // 
            this.registerPasswordTextBox.Location = new System.Drawing.Point(119, 184);
            this.registerPasswordTextBox.Name = "registerPasswordTextBox";
            this.registerPasswordTextBox.Size = new System.Drawing.Size(163, 22);
            this.registerPasswordTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // registerNameText
            // 
            this.registerNameText.Location = new System.Drawing.Point(119, 35);
            this.registerNameText.Name = "registerNameText";
            this.registerNameText.Size = new System.Drawing.Size(163, 22);
            this.registerNameText.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Name:";
            // 
            // registerAgeTextBox
            // 
            this.registerAgeTextBox.Location = new System.Drawing.Point(119, 81);
            this.registerAgeTextBox.Name = "registerAgeTextBox";
            this.registerAgeTextBox.Size = new System.Drawing.Size(163, 22);
            this.registerAgeTextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Age";
            // 
            // registerEmailTextBox
            // 
            this.registerEmailTextBox.Location = new System.Drawing.Point(119, 131);
            this.registerEmailTextBox.Name = "registerEmailTextBox";
            this.registerEmailTextBox.Size = new System.Drawing.Size(163, 22);
            this.registerEmailTextBox.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Email:";
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(150, 238);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(100, 23);
            this.registerBtn.TabIndex = 12;
            this.registerBtn.Text = "REGİSTER";
            this.registerBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 466);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.sign.ResumeLayout(false);
            this.sign.PerformLayout();
            this.signUp.ResumeLayout(false);
            this.signUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage register;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox registerEmailTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox registerAgeTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox registerPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox registerNameText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.TabPage signUp;
        private System.Windows.Forms.TextBox registerNameTextbox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button register_Button;
        private System.Windows.Forms.TextBox registerPassTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox registerEmailTextBo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage sign;
        private System.Windows.Forms.Button signINN;
        private System.Windows.Forms.TextBox passText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label label11;
    }
}

