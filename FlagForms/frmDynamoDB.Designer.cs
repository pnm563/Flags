namespace DataAccess.DynamoDB
{
    partial class frmDynamoDB
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
            this.Batched = new System.Windows.Forms.Button();
            this.Sequential = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Batched
            // 
            this.Batched.Location = new System.Drawing.Point(57, 120);
            this.Batched.Name = "Batched";
            this.Batched.Size = new System.Drawing.Size(75, 23);
            this.Batched.TabIndex = 0;
            this.Batched.Text = "Batched";
            this.Batched.UseVisualStyleBackColor = true;
            this.Batched.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sequential
            // 
            this.Sequential.Location = new System.Drawing.Point(363, 214);
            this.Sequential.Name = "Sequential";
            this.Sequential.Size = new System.Drawing.Size(75, 23);
            this.Sequential.TabIndex = 1;
            this.Sequential.Text = "Sequential";
            this.Sequential.UseVisualStyleBackColor = true;
            this.Sequential.Click += new System.EventHandler(this.Sequential_Click);
            // 
            // frmDynamoDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Sequential);
            this.Controls.Add(this.Batched);
            this.Name = "frmDynamoDB";
            this.Text = "frmDynamoDB";
            this.Load += new System.EventHandler(this.frmDynamoDB_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Batched;
        private System.Windows.Forms.Button Sequential;
    }
}