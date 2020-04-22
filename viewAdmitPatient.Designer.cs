namespace HMS
{
    partial class viewAdmitPatient
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
            this.admitGrid = new System.Windows.Forms.DataGridView();
            this.View = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.admitGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 357);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admitGrid
            // 
            this.admitGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.admitGrid.Location = new System.Drawing.Point(12, 12);
            this.admitGrid.Name = "admitGrid";
            this.admitGrid.Size = new System.Drawing.Size(533, 309);
            this.admitGrid.TabIndex = 1;
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(452, 357);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(93, 26);
            this.View.TabIndex = 64;
            this.View.Text = "View";
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // viewAdmitPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(558, 392);
            this.Controls.Add(this.View);
            this.Controls.Add(this.admitGrid);
            this.Controls.Add(this.button1);
            this.Name = "viewAdmitPatient";
            this.Text = "viewAdmitPatient";
            ((System.ComponentModel.ISupportInitialize)(this.admitGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView admitGrid;
        private System.Windows.Forms.Button View;
    }
}