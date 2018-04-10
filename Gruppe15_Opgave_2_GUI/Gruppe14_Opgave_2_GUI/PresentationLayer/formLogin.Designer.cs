namespace Gruppe15_Opgave_2_GUI
{
    partial class formLogin
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
            this.SocSecBox = new System.Windows.Forms.TextBox();
            this.PwBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SocSecBox
            // 
            this.SocSecBox.Location = new System.Drawing.Point(67, 67);
            this.SocSecBox.Name = "SocSecBox";
            this.SocSecBox.Size = new System.Drawing.Size(177, 31);
            this.SocSecBox.TabIndex = 0;
            // 
            // PwBox
            // 
            this.PwBox.Location = new System.Drawing.Point(67, 163);
            this.PwBox.Name = "PwBox";
            this.PwBox.Size = new System.Drawing.Size(177, 31);
            this.PwBox.TabIndex = 1;
            this.PwBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PwBox_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kodeord";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(139, 216);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(105, 44);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 294);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PwBox);
            this.Controls.Add(this.SocSecBox);
            this.Name = "formLogin";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SocSecBox;
        private System.Windows.Forms.TextBox PwBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLogin;
    }
}