namespace LoginApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            btnLogin = new Button();
            errInUName = new ErrorProvider(components);
            errInPW = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errInUName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errInPW).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(139, 120);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(139, 183);
            label2.Name = "label2";
            label2.Size = new Size(96, 25);
            label2.TabIndex = 0;
            label2.Text = "Password :";
            // 
            // username
            // 
            username.Location = new Point(316, 128);
            username.Name = "username";
            username.Size = new Size(335, 31);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(316, 177);
            password.Name = "password";
            password.Size = new Size(335, 31);
            password.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(367, 258);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(112, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // errInUName
            // 
            errInUName.ContainerControl = this;
            // 
            // errInPW
            // 
            errInPW.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 463);
            Controls.Add(btnLogin);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)errInUName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errInPW).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Button btnLogin;
        private ErrorProvider errInUName;
        private ErrorProvider errInPW;
    }
}
