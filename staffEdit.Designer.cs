namespace HMS
{
    partial class staffEdit
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
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rpGrid = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.sSSBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sSalaryBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sContactBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sNameBox = new System.Windows.Forms.TextBox();
            this.sIdBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.rpGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(482, 83);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(368, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 44;
            this.button3.Text = "Modify";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(287, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 43;
            this.button2.Text = "Registration";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rpGrid
            // 
            this.rpGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rpGrid.Location = new System.Drawing.Point(12, 130);
            this.rpGrid.Name = "rpGrid";
            this.rpGrid.Size = new System.Drawing.Size(634, 233);
            this.rpGrid.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(357, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Staff S_status : ";
            // 
            // sSSBox
            // 
            this.sSSBox.Location = new System.Drawing.Point(482, 47);
            this.sSSBox.Name = "sSSBox";
            this.sSSBox.Size = new System.Drawing.Size(149, 20);
            this.sSSBox.TabIndex = 38;
            this.sSSBox.Text = "not given";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Staff Salary : ";
            // 
            // sSalaryBox
            // 
            this.sSalaryBox.Location = new System.Drawing.Point(482, 14);
            this.sSalaryBox.Name = "sSalaryBox";
            this.sSalaryBox.Size = new System.Drawing.Size(149, 20);
            this.sSalaryBox.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Staff Contact : ";
            // 
            // sContactBox
            // 
            this.sContactBox.Location = new System.Drawing.Point(123, 83);
            this.sContactBox.Name = "sContactBox";
            this.sContactBox.Size = new System.Drawing.Size(149, 20);
            this.sContactBox.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Staff Name : ";
            // 
            // sNameBox
            // 
            this.sNameBox.Location = new System.Drawing.Point(123, 47);
            this.sNameBox.Name = "sNameBox";
            this.sNameBox.Size = new System.Drawing.Size(149, 20);
            this.sNameBox.TabIndex = 32;
            // 
            // sIdBox
            // 
            this.sIdBox.Location = new System.Drawing.Point(123, 11);
            this.sIdBox.Name = "sIdBox";
            this.sIdBox.Size = new System.Drawing.Size(149, 20);
            this.sIdBox.TabIndex = 31;
            this.sIdBox.Text = "id no";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Staff ID : ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(571, 83);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 78;
            this.button5.Text = "Give Salary";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // staffEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(657, 392);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.rpGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sSSBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.sSalaryBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sContactBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sNameBox);
            this.Controls.Add(this.sIdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "staffEdit";
            this.Text = "staffEdit";
            ((System.ComponentModel.ISupportInitialize)(this.rpGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView rpGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sSSBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sSalaryBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sContactBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox sNameBox;
        private System.Windows.Forms.TextBox sIdBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
    }
}