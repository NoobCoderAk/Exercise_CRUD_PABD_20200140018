
namespace Exercise_CRUD_PABD
{
    partial class FormLogin
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
            this.label_Exit = new System.Windows.Forms.Label();
            this.button_Login = new System.Windows.Forms.Button();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Username = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.Login_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Exit
            // 
            this.label_Exit.AutoSize = true;
            this.label_Exit.Font = new System.Drawing.Font("Bahnschrift SemiBold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Exit.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_Exit.Location = new System.Drawing.Point(382, 358);
            this.label_Exit.Name = "label_Exit";
            this.label_Exit.Size = new System.Drawing.Size(39, 21);
            this.label_Exit.TabIndex = 14;
            this.label_Exit.Text = "Exit";
            this.label_Exit.Click += new System.EventHandler(this.label_Exit_Click);
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_Login.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.White;
            this.button_Login.Location = new System.Drawing.Point(339, 305);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(119, 40);
            this.button_Login.TabIndex = 13;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Password.Location = new System.Drawing.Point(301, 244);
            this.textBox_Password.Multiline = true;
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(201, 22);
            this.textBox_Password.TabIndex = 12;
            // 
            // textBox_Username
            // 
            this.textBox_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_Username.Location = new System.Drawing.Point(302, 178);
            this.textBox_Username.Multiline = true;
            this.textBox_Username.Name = "textBox_Username";
            this.textBox_Username.Size = new System.Drawing.Size(200, 24);
            this.textBox_Username.TabIndex = 11;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_Password.Location = new System.Drawing.Point(298, 224);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(71, 17);
            this.label_Password.TabIndex = 10;
            this.label_Password.Text = "Password";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Font = new System.Drawing.Font("Bahnschrift SemiBold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Username.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.label_Username.Location = new System.Drawing.Point(298, 156);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(73, 17);
            this.label_Username.TabIndex = 9;
            this.label_Username.Text = "Username";
            // 
            // Login_Label
            // 
            this.Login_Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Label.AutoSize = true;
            this.Login_Label.Font = new System.Drawing.Font("Impact", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_Label.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Login_Label.Location = new System.Drawing.Point(345, 72);
            this.Login_Label.Name = "Login_Label";
            this.Login_Label.Size = new System.Drawing.Size(108, 46);
            this.Login_Label.TabIndex = 8;
            this.Login_Label.Text = "Login";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Exit);
            this.Controls.Add(this.button_Login);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_Username);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_Username);
            this.Controls.Add(this.Login_Label);
            this.Name = "FormLogin";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Exit;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label Login_Label;
    }
}

