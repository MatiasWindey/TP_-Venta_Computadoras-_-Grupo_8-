namespace TPVentaOnlineFront
{
    partial class Inicio
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
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(160, 172);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(338, 26);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Menu Inicial";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(460, 118);
            label2.Name = "label2";
            label2.Size = new Size(176, 20);
            label2.TabIndex = 2;
            label2.Text = "Interactuar como Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(93, 118);
            label3.Name = "label3";
            label3.Size = new Size(223, 20);
            label3.TabIndex = 3;
            label3.Text = "Interactuar Como Administrador";
            // 
            // button2
            // 
            button2.Location = new Point(503, 172);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Ingresar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Inicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
    }
}