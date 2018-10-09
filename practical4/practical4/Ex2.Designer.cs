namespace practical4
{
    partial class Ex2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mark = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student Marks :";
            // 
            // txt_mark
            // 
            this.txt_mark.Location = new System.Drawing.Point(193, 73);
            this.txt_mark.Name = "txt_mark";
            this.txt_mark.Size = new System.Drawing.Size(160, 20);
            this.txt_mark.TabIndex = 1;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(305, 275);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 2;
            this.Calculate.Text = "Result";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 347);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.txt_mark);
            this.Controls.Add(this.label1);
            this.Name = "Ex2";
            this.Text = "Ex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_mark;
        private System.Windows.Forms.Button Calculate;
    }
}