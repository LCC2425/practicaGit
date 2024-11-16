namespace ejercicioTelegrama
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
            txtTelegrama = new TextBox();
            txtPrecio = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button2 = new Button();
            radioOrinario = new RadioButton();
            radioUrgente = new RadioButton();
            SuspendLayout();
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(188, 74);
            txtTelegrama.Margin = new Padding(3, 4, 3, 4);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(412, 197);
            txtTelegrama.TabIndex = 10;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(240, 384);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(83, 27);
            txtPrecio.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(188, 36);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 7;
            label2.Text = "Texto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 388);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 8;
            label1.Text = "Coste:";
            // 
            // button2
            // 
            button2.Location = new Point(455, 342);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(157, 73);
            button2.TabIndex = 6;
            button2.Text = "Calcular";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // radioOrinario
            // 
            radioOrinario.AutoSize = true;
            radioOrinario.Location = new Point(188, 296);
            radioOrinario.Name = "radioOrinario";
            radioOrinario.Size = new Size(93, 24);
            radioOrinario.TabIndex = 11;
            radioOrinario.TabStop = true;
            radioOrinario.Text = "Ordinario";
            radioOrinario.UseVisualStyleBackColor = true;
            // 
            // radioUrgente
            // 
            radioUrgente.AutoSize = true;
            radioUrgente.Location = new Point(311, 296);
            radioUrgente.Name = "radioUrgente";
            radioUrgente.Size = new Size(83, 24);
            radioUrgente.TabIndex = 11;
            radioUrgente.TabStop = true;
            radioUrgente.Text = "Urgente";
            radioUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioUrgente);
            Controls.Add(radioOrinario);
            Controls.Add(txtTelegrama);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTelegrama;
        private TextBox txtPrecio;
        private Label label2;
        private Label label1;
        private Button button2;
        private RadioButton radioOrinario;
        private RadioButton radioUrgente;
    }
}
