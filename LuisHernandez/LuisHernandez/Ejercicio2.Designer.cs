namespace LuisHernandez
{
    partial class Ejercicio2
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
            this.label1 = new System.Windows.Forms.Label();
            this.ProductoUnoTextBox = new System.Windows.Forms.TextBox();
            this.ProductoDosTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProductoTresTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CalcularDescuentoButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese el valor del producto 1:";
            // 
            // ProductoUnoTextBox
            // 
            this.ProductoUnoTextBox.Location = new System.Drawing.Point(428, 118);
            this.ProductoUnoTextBox.Name = "ProductoUnoTextBox";
            this.ProductoUnoTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductoUnoTextBox.TabIndex = 1;
            // 
            // ProductoDosTextBox
            // 
            this.ProductoDosTextBox.Location = new System.Drawing.Point(428, 157);
            this.ProductoDosTextBox.Name = "ProductoDosTextBox";
            this.ProductoDosTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductoDosTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(237, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingrese el valor del producto 2:";
            // 
            // ProductoTresTextBox
            // 
            this.ProductoTresTextBox.Location = new System.Drawing.Point(428, 192);
            this.ProductoTresTextBox.Name = "ProductoTresTextBox";
            this.ProductoTresTextBox.Size = new System.Drawing.Size(100, 20);
            this.ProductoTresTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese el valor del producto 3:";
            // 
            // CalcularDescuentoButton
            // 
            this.CalcularDescuentoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcularDescuentoButton.Location = new System.Drawing.Point(322, 248);
            this.CalcularDescuentoButton.Name = "CalcularDescuentoButton";
            this.CalcularDescuentoButton.Size = new System.Drawing.Size(99, 40);
            this.CalcularDescuentoButton.TabIndex = 6;
            this.CalcularDescuentoButton.Text = "Calcular Descuento";
            this.CalcularDescuentoButton.UseVisualStyleBackColor = true;
            this.CalcularDescuentoButton.Click += new System.EventHandler(this.CalcularDescuentoButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(301, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Calculo del Descuento\r\n";
            // 
            // Ejercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CalcularDescuentoButton);
            this.Controls.Add(this.ProductoTresTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProductoDosTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductoUnoTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Ejercicio2";
            this.Text = "Ejercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductoUnoTextBox;
        private System.Windows.Forms.TextBox ProductoDosTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ProductoTresTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button CalcularDescuentoButton;
        private System.Windows.Forms.Label label4;
    }
}