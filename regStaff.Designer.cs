namespace HMS
{
    partial class regStaff
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
            this.button3 = new System.Windows.Forms.Button();
            this.s_salaryStatusBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.s_salaryBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.s_contactBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.s_nameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.s_idBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button3.Location = new System.Drawing.Point(12, 348);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 33;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // s_salaryStatusBox
            // 
            this.s_salaryStatusBox.Location = new System.Drawing.Point(117, 280);
            this.s_salaryStatusBox.Name = "s_salaryStatusBox";
            this.s_salaryStatusBox.Size = new System.Drawing.Size(179, 20);
            this.s_salaryStatusBox.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Salary_status :";
            // 
            // s_salaryBox
            // 
            this.s_salaryBox.Location = new System.Drawing.Point(117, 217);
            this.s_salaryBox.Name = "s_salaryBox";
            this.s_salaryBox.Size = new System.Drawing.Size(179, 20);
            this.s_salaryBox.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Salary :";
            // 
            // s_contactBox
            // 
            this.s_contactBox.Location = new System.Drawing.Point(117, 158);
            this.s_contactBox.Name = "s_contactBox";
            this.s_contactBox.Size = new System.Drawing.Size(179, 20);
            this.s_contactBox.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Contact :";
            // 
            // s_nameBox
            // 
            this.s_nameBox.Location = new System.Drawing.Point(117, 91);
            this.s_nameBox.Name = "s_nameBox";
            this.s_nameBox.Size = new System.Drawing.Size(179, 20);
            this.s_nameBox.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Name :";
            // 
            // s_idBox
            // 
            this.s_idBox.Location = new System.Drawing.Point(117, 30);
            this.s_idBox.Name = "s_idBox";
            this.s_idBox.Size = new System.Drawing.Size(179, 20);
            this.s_idBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "ID :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // regStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(727, 377);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.s_salaryStatusBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.s_salaryBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.s_contactBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.s_nameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s_idBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "regStaff";
            this.Text = "regStaff";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox s_salaryStatusBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox s_salaryBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox s_contactBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox s_nameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox s_idBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}