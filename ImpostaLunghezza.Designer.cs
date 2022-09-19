namespace ColombiFile
{
    partial class ImpostaLunghezza
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
            this.valore = new System.Windows.Forms.NumericUpDown();
            this.confermaButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valore)).BeginInit();
            this.SuspendLayout();
            // 
            // valore
            // 
            this.valore.Location = new System.Drawing.Point(299, 183);
            this.valore.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.valore.Name = "valore";
            this.valore.Size = new System.Drawing.Size(120, 23);
            this.valore.TabIndex = 0;
            // 
            // confermaButton
            // 
            this.confermaButton.Location = new System.Drawing.Point(299, 277);
            this.confermaButton.Name = "confermaButton";
            this.confermaButton.Size = new System.Drawing.Size(120, 23);
            this.confermaButton.TabIndex = 1;
            this.confermaButton.Text = "Conferma";
            this.confermaButton.UseVisualStyleBackColor = true;
            this.confermaButton.Click += new System.EventHandler(this.confermaButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Il valore non può essere minore di quello iniziale";
            // 
            // ImpostaLunghezza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.confermaButton);
            this.Controls.Add(this.valore);
            this.Name = "ImpostaLunghezza";
            this.Text = "ImpostaLunghezza";
            this.Load += new System.EventHandler(this.ImpostaLunghezza_Load);
            ((System.ComponentModel.ISupportInitialize)(this.valore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown valore;
        private Button confermaButton;
        private Label label1;
    }
}