namespace ConcurreciaAsincrona
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btComenzar = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btComenzar
            // 
            btComenzar.Location = new Point(12, 52);
            btComenzar.Name = "btComenzar";
            btComenzar.Size = new Size(226, 50);
            btComenzar.TabIndex = 0;
            btComenzar.Text = "Comenzar una tarea";
            btComenzar.UseVisualStyleBackColor = true;
            btComenzar.Click += btComenzar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(263, 206);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(123, 114);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(244, 52);
            button1.Name = "button1";
            button1.Size = new Size(220, 50);
            button1.TabIndex = 2;
            button1.Text = "Comenzar varias tareas";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(470, 52);
            button2.Name = "button2";
            button2.Size = new Size(220, 50);
            button2.TabIndex = 3;
            button2.Text = "Ejecutar en paralelo";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(btComenzar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btComenzar;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
    }
}
