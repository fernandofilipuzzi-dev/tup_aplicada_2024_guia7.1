namespace Ejercicio1
{
    partial class FormVer
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
            this.Resultados = new System.Windows.Forms.GroupBox();
            this.tbVer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Resultados.SuspendLayout();
            this.SuspendLayout();
            // 
            // Resultados
            // 
            this.Resultados.Controls.Add(this.tbVer);
            this.Resultados.Location = new System.Drawing.Point(10, 14);
            this.Resultados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Resultados.Name = "Resultados";
            this.Resultados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Resultados.Size = new System.Drawing.Size(589, 324);
            this.Resultados.TabIndex = 0;
            this.Resultados.TabStop = false;
            this.Resultados.Text = "Resultados";
            // 
            // tbVer
            // 
            this.tbVer.Location = new System.Drawing.Point(19, 29);
            this.tbVer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbVer.Multiline = true;
            this.tbVer.Name = "tbVer";
            this.tbVer.Size = new System.Drawing.Size(562, 282);
            this.tbVer.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(230, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormVer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 387);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Resultados);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormVer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormVer";
            this.Load += new System.EventHandler(this.FormVer_Load);
            this.Resultados.ResumeLayout(false);
            this.Resultados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Resultados;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tbVer;
    }
}