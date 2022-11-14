
namespace PL
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
            this.btnclickthis = new System.Windows.Forms.Button();
            this.lblcalculate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclickthis
            // 
            this.btnclickthis.Location = new System.Drawing.Point(230, 318);
            this.btnclickthis.Name = "btnclickthis";
            this.btnclickthis.Size = new System.Drawing.Size(75, 23);
            this.btnclickthis.TabIndex = 0;
            this.btnclickthis.Text = "calculate";
            this.btnclickthis.UseVisualStyleBackColor = true;
            this.btnclickthis.Click += new System.EventHandler(this.btnclickthis_Click);
            // 
            // lblcalculate
            // 
            this.lblcalculate.AutoSize = true;
            this.lblcalculate.Location = new System.Drawing.Point(248, 344);
            this.lblcalculate.Name = "lblcalculate";
            this.lblcalculate.Size = new System.Drawing.Size(35, 13);
            this.lblcalculate.TabIndex = 1;
            this.lblcalculate.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 395);
            this.Controls.Add(this.lblcalculate);
            this.Controls.Add(this.btnclickthis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclickthis;
        private System.Windows.Forms.Label lblcalculate;
    }
}

