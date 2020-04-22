namespace HMS
{
    partial class bill
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
            this.label1 = new System.Windows.Forms.Label();
            this.bIdBox = new System.Windows.Forms.TextBox();
            this.pIdBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dIdBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bAmBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bStBox = new System.Windows.Forms.TextBox();
            this.billGrid = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.billGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bill ID : ";
            // 
            // bIdBox
            // 
            this.bIdBox.Location = new System.Drawing.Point(276, 12);
            this.bIdBox.Name = "bIdBox";
            this.bIdBox.Size = new System.Drawing.Size(149, 20);
            this.bIdBox.TabIndex = 3;
            this.bIdBox.Text = "id no";
            // 
            // pIdBox
            // 
            this.pIdBox.Location = new System.Drawing.Point(83, 54);
            this.pIdBox.Name = "pIdBox";
            this.pIdBox.Size = new System.Drawing.Size(149, 20);
            this.pIdBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Patient ID :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Doctor ID :";
            // 
            // dIdBox
            // 
            this.dIdBox.Location = new System.Drawing.Point(442, 53);
            this.dIdBox.Name = "dIdBox";
            this.dIdBox.Size = new System.Drawing.Size(149, 20);
            this.dIdBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Bill Amount :";
            // 
            // bAmBox
            // 
            this.bAmBox.Location = new System.Drawing.Point(83, 93);
            this.bAmBox.Name = "bAmBox";
            this.bAmBox.Size = new System.Drawing.Size(149, 20);
            this.bAmBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Bill Status :";
            // 
            // bStBox
            // 
            this.bStBox.Location = new System.Drawing.Point(442, 89);
            this.bStBox.Name = "bStBox";
            this.bStBox.Size = new System.Drawing.Size(149, 20);
            this.bStBox.TabIndex = 11;
            this.bStBox.Text = "not given";
            // 
            // billGrid
            // 
            this.billGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billGrid.Location = new System.Drawing.Point(12, 165);
            this.billGrid.Name = "billGrid";
            this.billGrid.Size = new System.Drawing.Size(577, 190);
            this.billGrid.TabIndex = 13;
            this.billGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.billGrid_CellContentClick);
            this.billGrid.DoubleClick += new System.EventHandler(this.billGrid_DoubleClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(157, 135);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(75, 23);
            this.button8.TabIndex = 17;
            this.button8.Text = "Modify";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(330, 136);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 16;
            this.button7.Text = "Remove";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(31, 135);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 18;
            this.button6.Text = "Insert";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(411, 136);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 19;
            this.button5.Text = "Update Cost";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click_1);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(496, 136);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 23);
            this.button9.TabIndex = 20;
            this.button9.Text = "Set Bill Status";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(617, 386);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.billGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bStBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bAmBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dIdBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pIdBox);
            this.Controls.Add(this.bIdBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "bill";
            this.Text = "bill";
            ((System.ComponentModel.ISupportInitialize)(this.billGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bIdBox;
        private System.Windows.Forms.TextBox pIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dIdBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox bAmBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bStBox;
        private System.Windows.Forms.DataGridView billGrid;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button9;
    }
}