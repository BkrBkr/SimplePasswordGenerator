namespace PasswordGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPW = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TrackBar();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPW
            // 
            this.txtPW.Location = new System.Drawing.Point(12, 11);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(239, 20);
            this.txtPW.TabIndex = 0;
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(12, 38);
            this.tbAmount.Maximum = 100;
            this.tbAmount.Minimum = 2;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(239, 45);
            this.tbAmount.TabIndex = 1;
            this.tbAmount.Value = 10;
            this.tbAmount.ValueChanged += new System.EventHandler(this.tbAmount_ValueChanged);
            this.tbAmount.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tbAmount_MouseUp);
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(255, 45);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(19, 13);
            this.lblCount.TabIndex = 2;
            this.lblCount.Text = "10";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 118);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.txtPW);
            this.Name = "Form1";
            this.Text = "SimplePasswordGenerator";
            ((System.ComponentModel.ISupportInitialize)(this.tbAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TrackBar tbAmount;
        private System.Windows.Forms.Label lblCount;
    }
}

