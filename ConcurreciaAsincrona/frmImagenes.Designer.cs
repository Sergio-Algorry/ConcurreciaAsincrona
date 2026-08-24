namespace ConcurreciaAsincrona
{
    partial class frmImagenes
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
            btSecuencial = new Button();
            btParalelo = new Button();
            SuspendLayout();
            // 
            // btSecuencial
            // 
            btSecuencial.AutoSize = true;
            btSecuencial.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btSecuencial.Location = new Point(18, 29);
            btSecuencial.Name = "btSecuencial";
            btSecuencial.Size = new Size(122, 38);
            btSecuencial.TabIndex = 0;
            btSecuencial.Text = "Secuencial";
            btSecuencial.UseVisualStyleBackColor = true;
            btSecuencial.Click += btSecuencial_Click;
            // 
            // btParalelo
            // 
            btParalelo.AutoSize = true;
            btParalelo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btParalelo.Location = new Point(178, 29);
            btParalelo.Name = "btParalelo";
            btParalelo.Size = new Size(122, 38);
            btParalelo.TabIndex = 1;
            btParalelo.Text = "Paralelo";
            btParalelo.UseVisualStyleBackColor = true;
            btParalelo.Click += btParalelo_Click;
            // 
            // frmImagenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 101);
            Controls.Add(btParalelo);
            Controls.Add(btSecuencial);
            Name = "frmImagenes";
            Text = "frmImagenes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btSecuencial;
        private Button btParalelo;
    }
}