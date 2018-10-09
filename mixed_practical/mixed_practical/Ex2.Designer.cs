namespace mixed_practical
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.txt_rating = new System.Windows.Forms.TextBox();
            this.btn_eval = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Approval for Drive";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(49, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Your Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(49, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Enter your Ratings";
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(211, 103);
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(174, 20);
            this.txt_age.TabIndex = 2;
            // 
            // txt_rating
            // 
            this.txt_rating.Location = new System.Drawing.Point(211, 133);
            this.txt_rating.Name = "txt_rating";
            this.txt_rating.Size = new System.Drawing.Size(174, 20);
            this.txt_rating.TabIndex = 2;
            // 
            // btn_eval
            // 
            this.btn_eval.Location = new System.Drawing.Point(68, 275);
            this.btn_eval.Name = "btn_eval";
            this.btn_eval.Size = new System.Drawing.Size(75, 23);
            this.btn_eval.TabIndex = 3;
            this.btn_eval.Text = "Evaluate";
            this.btn_eval.UseVisualStyleBackColor = true;
            this.btn_eval.Click += new System.EventHandler(this.btn_eval_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(310, 275);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Ex2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 390);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_eval);
            this.Controls.Add(this.txt_rating);
            this.Controls.Add(this.txt_age);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Ex2";
            this.Text = "Ex2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.TextBox txt_rating;
        private System.Windows.Forms.Button btn_eval;
        private System.Windows.Forms.Button btn_exit;
    }
}