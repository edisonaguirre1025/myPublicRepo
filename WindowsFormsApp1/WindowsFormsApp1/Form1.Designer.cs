namespace WindowsFormsApp1
{
    partial class Form1
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
            this.sTop = new System.Windows.Forms.TextBox();
            this.sLeft = new System.Windows.Forms.TextBox();
            this.sRight = new System.Windows.Forms.TextBox();
            this.sBott = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sTop
            // 
            this.sTop.Location = new System.Drawing.Point(64, 12);
            this.sTop.Name = "sTop";
            this.sTop.Size = new System.Drawing.Size(100, 20);
            this.sTop.TabIndex = 0;
            // 
            // sLeft
            // 
            this.sLeft.Location = new System.Drawing.Point(64, 38);
            this.sLeft.Name = "sLeft";
            this.sLeft.Size = new System.Drawing.Size(100, 20);
            this.sLeft.TabIndex = 1;
            // 
            // sRight
            // 
            this.sRight.Location = new System.Drawing.Point(64, 64);
            this.sRight.Name = "sRight";
            this.sRight.Size = new System.Drawing.Size(100, 20);
            this.sRight.TabIndex = 2;
            // 
            // sBott
            // 
            this.sBott.Location = new System.Drawing.Point(64, 90);
            this.sBott.Name = "sBott";
            this.sBott.Size = new System.Drawing.Size(100, 20);
            this.sBott.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "top";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "left";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "right";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "bott";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(172, 155);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.sBott);
            this.Controls.Add(this.sRight);
            this.Controls.Add(this.sLeft);
            this.Controls.Add(this.sTop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sTop;
        private System.Windows.Forms.TextBox sLeft;
        private System.Windows.Forms.TextBox sRight;
        private System.Windows.Forms.TextBox sBott;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

