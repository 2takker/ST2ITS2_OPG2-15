namespace Gruppe15_Opgave_2_GUI
{
    partial class dataGUI
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
            this.btnBS = new System.Windows.Forms.Button();
            this.btnBT = new System.Windows.Forms.Button();
            this.btnBMI = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rBtn5Days = new System.Windows.Forms.RadioButton();
            this.rBtn10Day = new System.Windows.Forms.RadioButton();
            this.rBtn1Month = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnBS
            // 
            this.btnBS.Enabled = false;
            this.btnBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBS.Location = new System.Drawing.Point(30, 40);
            this.btnBS.Name = "btnBS";
            this.btnBS.Size = new System.Drawing.Size(226, 226);
            this.btnBS.TabIndex = 0;
            this.btnBS.Text = "Vis mit blodsukker";
            this.btnBS.UseVisualStyleBackColor = true;
            this.btnBS.Click += new System.EventHandler(this.btnBS_Click);
            // 
            // btnBT
            // 
            this.btnBT.Enabled = false;
            this.btnBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBT.Location = new System.Drawing.Point(30, 272);
            this.btnBT.Name = "btnBT";
            this.btnBT.Size = new System.Drawing.Size(226, 226);
            this.btnBT.TabIndex = 1;
            this.btnBT.Text = "Vis mit blodtryk";
            this.btnBT.UseVisualStyleBackColor = true;
            this.btnBT.Click += new System.EventHandler(this.btnBT_Click);
            // 
            // btnBMI
            // 
            this.btnBMI.Enabled = false;
            this.btnBMI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMI.Location = new System.Drawing.Point(30, 504);
            this.btnBMI.Name = "btnBMI";
            this.btnBMI.Size = new System.Drawing.Size(226, 226);
            this.btnBMI.TabIndex = 2;
            this.btnBMI.Text = "Vis min vægt og BMI";
            this.btnBMI.UseVisualStyleBackColor = true;
            this.btnBMI.Click += new System.EventHandler(this.btnBMI_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Enabled = false;
            this.btnDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoctor.Location = new System.Drawing.Point(526, 285);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(226, 226);
            this.btnDoctor.TabIndex = 3;
            this.btnDoctor.Text = "Send mine oplysninger til lægen";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(478, 77);
            this.label1.TabIndex = 4;
            this.label1.Text = "Hvor lang tid er dine mine oplysninger tilgængelig for lægen:";
            // 
            // rBtn5Days
            // 
            this.rBtn5Days.AutoSize = true;
            this.rBtn5Days.Checked = true;
            this.rBtn5Days.Location = new System.Drawing.Point(526, 167);
            this.rBtn5Days.Name = "rBtn5Days";
            this.rBtn5Days.Size = new System.Drawing.Size(109, 29);
            this.rBtn5Days.TabIndex = 5;
            this.rBtn5Days.TabStop = true;
            this.rBtn5Days.Text = "5 dage";
            this.rBtn5Days.UseVisualStyleBackColor = true;
            // 
            // rBtn10Day
            // 
            this.rBtn10Day.AutoSize = true;
            this.rBtn10Day.Location = new System.Drawing.Point(526, 202);
            this.rBtn10Day.Name = "rBtn10Day";
            this.rBtn10Day.Size = new System.Drawing.Size(121, 29);
            this.rBtn10Day.TabIndex = 6;
            this.rBtn10Day.Text = "10 dage";
            this.rBtn10Day.UseVisualStyleBackColor = true;
            // 
            // rBtn1Month
            // 
            this.rBtn1Month.AutoSize = true;
            this.rBtn1Month.Location = new System.Drawing.Point(526, 237);
            this.rBtn1Month.Name = "rBtn1Month";
            this.rBtn1Month.Size = new System.Drawing.Size(126, 29);
            this.rBtn1Month.TabIndex = 7;
            this.rBtn1Month.Text = "1 måned";
            this.rBtn1Month.UseVisualStyleBackColor = true;
            // 
            // dataGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 761);
            this.Controls.Add(this.rBtn1Month);
            this.Controls.Add(this.rBtn10Day);
            this.Controls.Add(this.rBtn5Days);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnBMI);
            this.Controls.Add(this.btnBT);
            this.Controls.Add(this.btnBS);
            this.Name = "dataGUI";
            this.Text = "Sundhedssytem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBS;
        private System.Windows.Forms.Button btnBT;
        private System.Windows.Forms.Button btnBMI;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rBtn5Days;
        private System.Windows.Forms.RadioButton rBtn10Day;
        private System.Windows.Forms.RadioButton rBtn1Month;
    }
}

