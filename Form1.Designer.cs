namespace _14deMay
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCaja1 = new System.Windows.Forms.TextBox();
            this.txtCaja3 = new System.Windows.Forms.TextBox();
            this.txtCaja2 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCaja1
            // 
            this.txtCaja1.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja1.Location = new System.Drawing.Point(118, 47);
            this.txtCaja1.Name = "txtCaja1";
            this.txtCaja1.Size = new System.Drawing.Size(206, 32);
            this.txtCaja1.TabIndex = 0;
            // 
            // txtCaja3
            // 
            this.txtCaja3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja3.Location = new System.Drawing.Point(118, 178);
            this.txtCaja3.Name = "txtCaja3";
            this.txtCaja3.Size = new System.Drawing.Size(206, 32);
            this.txtCaja3.TabIndex = 1;
            // 
            // txtCaja2
            // 
            this.txtCaja2.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCaja2.Location = new System.Drawing.Point(118, 115);
            this.txtCaja2.Name = "txtCaja2";
            this.txtCaja2.Size = new System.Drawing.Size(206, 32);
            this.txtCaja2.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(118, 248);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(206, 42);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(458, 410);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCaja2);
            this.Controls.Add(this.txtCaja3);
            this.Controls.Add(this.txtCaja1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaja1;
        private System.Windows.Forms.TextBox txtCaja3;
        private System.Windows.Forms.TextBox txtCaja2;
        private System.Windows.Forms.Button btnGuardar;
    }
}

