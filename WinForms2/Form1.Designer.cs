
namespace WinForms2
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
            this.Inserir = new System.Windows.Forms.Button();
            this.SelecionaInsere = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Inserir
            // 
            this.Inserir.Location = new System.Drawing.Point(70, 62);
            this.Inserir.Name = "Inserir";
            this.Inserir.Size = new System.Drawing.Size(191, 85);
            this.Inserir.TabIndex = 0;
            this.Inserir.Text = "Inserir";
            this.Inserir.UseVisualStyleBackColor = true;
            this.Inserir.Click += new System.EventHandler(this.Inserir_Click);
            // 
            // SelecionaInsere
            // 
            this.SelecionaInsere.Location = new System.Drawing.Point(480, 61);
            this.SelecionaInsere.Name = "SelecionaInsere";
            this.SelecionaInsere.Size = new System.Drawing.Size(175, 86);
            this.SelecionaInsere.TabIndex = 1;
            this.SelecionaInsere.Text = "Selecionar e Inserir";
            this.SelecionaInsere.UseVisualStyleBackColor = true;
            this.SelecionaInsere.Click += new System.EventHandler(this.SelecionaInsere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelecionaInsere);
            this.Controls.Add(this.Inserir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Inserir;
        private System.Windows.Forms.Button SelecionaInsere;
    }
}

