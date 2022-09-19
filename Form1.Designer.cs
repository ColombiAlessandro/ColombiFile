namespace ColombiFile
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.controlloLunghezza = new System.Windows.Forms.Button();
            this.impostaLunghezza = new System.Windows.Forms.Button();
            this.lunghezzaMax = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // controlloLunghezza
            // 
            this.controlloLunghezza.Location = new System.Drawing.Point(21, 233);
            this.controlloLunghezza.Name = "controlloLunghezza";
            this.controlloLunghezza.Size = new System.Drawing.Size(146, 48);
            this.controlloLunghezza.TabIndex = 0;
            this.controlloLunghezza.Text = "Controllo lnghezza";
            this.controlloLunghezza.UseVisualStyleBackColor = true;
            this.controlloLunghezza.Click += new System.EventHandler(this.controlloLunghezza_Click);
            // 
            // impostaLunghezza
            // 
            this.impostaLunghezza.Location = new System.Drawing.Point(325, 233);
            this.impostaLunghezza.Name = "impostaLunghezza";
            this.impostaLunghezza.Size = new System.Drawing.Size(146, 48);
            this.impostaLunghezza.TabIndex = 1;
            this.impostaLunghezza.Text = "Imposta lunghezza";
            this.impostaLunghezza.UseVisualStyleBackColor = true;
            this.impostaLunghezza.Click += new System.EventHandler(this.impostaLunghezza_Click);
            // 
            // lunghezzaMax
            // 
            this.lunghezzaMax.Location = new System.Drawing.Point(173, 233);
            this.lunghezzaMax.Name = "lunghezzaMax";
            this.lunghezzaMax.Size = new System.Drawing.Size(146, 48);
            this.lunghezzaMax.TabIndex = 2;
            this.lunghezzaMax.Text = "Massima lunghezza";
            this.lunghezzaMax.UseVisualStyleBackColor = true;
            this.lunghezzaMax.Click += new System.EventHandler(this.lunghezzaMax_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lunghezzaMax);
            this.Controls.Add(this.impostaLunghezza);
            this.Controls.Add(this.controlloLunghezza);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button controlloLunghezza;
        private Button impostaLunghezza;
        private Button lunghezzaMax;
    }
}