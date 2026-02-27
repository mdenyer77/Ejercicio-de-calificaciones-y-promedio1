namespace WinFormsApp1
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
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtNota3 = new TextBox();
            txtNota4 = new TextBox();
            txtCompletivo = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            lblPromedio = new Label();
            btnLimpiar_click = new Button();
            SuspendLayout();
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(81, 50);
            txtNota1.Margin = new Padding(2, 2, 2, 2);
            txtNota1.Name = "txtNota1";
            txtNota1.PlaceholderText = "Nota 1";
            txtNota1.Size = new Size(106, 23);
            txtNota1.TabIndex = 0;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(230, 50);
            txtNota2.Margin = new Padding(2, 2, 2, 2);
            txtNota2.Name = "txtNota2";
            txtNota2.PlaceholderText = "Nota 2";
            txtNota2.Size = new Size(106, 23);
            txtNota2.TabIndex = 1;
            // 
            // txtNota3
            // 
            txtNota3.Location = new Point(384, 50);
            txtNota3.Margin = new Padding(2, 2, 2, 2);
            txtNota3.Name = "txtNota3";
            txtNota3.PlaceholderText = "Nota 3";
            txtNota3.Size = new Size(106, 23);
            txtNota3.TabIndex = 2;
            // 
            // txtNota4
            // 
            txtNota4.Location = new Point(538, 50);
            txtNota4.Margin = new Padding(2, 2, 2, 2);
            txtNota4.Name = "txtNota4";
            txtNota4.PlaceholderText = "Nota 4";
            txtNota4.Size = new Size(106, 23);
            txtNota4.TabIndex = 3;
            // 
            // txtCompletivo
            // 
            txtCompletivo.Location = new Point(60, 218);
            txtCompletivo.Margin = new Padding(2, 2, 2, 2);
            txtCompletivo.Name = "txtCompletivo";
            txtCompletivo.PlaceholderText = "Completivo";
            txtCompletivo.Size = new Size(106, 23);
            txtCompletivo.TabIndex = 4;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(128, 145);
            btnCalcular.Margin = new Padding(2, 2, 2, 2);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(78, 20);
            btnCalcular.TabIndex = 5;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(284, 151);
            lblResultado.Margin = new Padding(2, 0, 2, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(62, 15);
            lblResultado.TabIndex = 6;
            lblResultado.Text = " Resultado";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Location = new Point(447, 151);
            lblPromedio.Margin = new Padding(2, 0, 2, 0);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(59, 15);
            lblPromedio.TabIndex = 7;
            lblPromedio.Text = "Promedio";
            lblPromedio.Click += lblPromedio_Click;
            // 
            // btnLimpiar_click
            // 
            btnLimpiar_click.Location = new Point(550, 145);
            btnLimpiar_click.Margin = new Padding(2, 2, 2, 2);
            btnLimpiar_click.Name = "btnLimpiar_click";
            btnLimpiar_click.Size = new Size(78, 20);
            btnLimpiar_click.TabIndex = 8;
            btnLimpiar_click.Text = "Limpiar";
            btnLimpiar_click.UseVisualStyleBackColor = true;
            btnLimpiar_click.Click += btnLimpiar_click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(747, 329);
            Controls.Add(btnLimpiar_click);
            Controls.Add(lblPromedio);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtCompletivo);
            Controls.Add(txtNota4);
            Controls.Add(txtNota3);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtNota3;
        private TextBox txtNota4;
        private TextBox txtCompletivo;
        private Button btnCalcular;
        private Label lblResultado;
        private Label lblPromedio;
        private Button btnLimpiar_click;
    }
}
