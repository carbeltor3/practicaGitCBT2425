﻿namespace ejercicioTelegrama
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelegrama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rbtOrdinario = new System.Windows.Forms.RadioButton();
            this.rbtUrgente = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Texto";
            // 
            // txtTelegrama
            // 
            this.txtTelegrama.Location = new System.Drawing.Point(46, 101);
            this.txtTelegrama.Multiline = true;
            this.txtTelegrama.Name = "txtTelegrama";
            this.txtTelegrama.Size = new System.Drawing.Size(459, 122);
            this.txtTelegrama.TabIndex = 1;
            this.txtTelegrama.TextChanged += new System.EventHandler(this.txtTelegrama_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coste :";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(104, 292);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(128, 20);
            this.txtPrecio.TabIndex = 4;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(294, 271);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(162, 51);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rbtOrdinario
            // 
            this.rbtOrdinario.AutoSize = true;
            this.rbtOrdinario.Checked = true;
            this.rbtOrdinario.Location = new System.Drawing.Point(43, 239);
            this.rbtOrdinario.Name = "rbtOrdinario";
            this.rbtOrdinario.Size = new System.Drawing.Size(67, 17);
            this.rbtOrdinario.TabIndex = 6;
            this.rbtOrdinario.TabStop = true;
            this.rbtOrdinario.Text = "Ordinario";
            this.rbtOrdinario.UseVisualStyleBackColor = true;
            // 
            // rbtUrgente
            // 
            this.rbtUrgente.AutoSize = true;
            this.rbtUrgente.Location = new System.Drawing.Point(147, 239);
            this.rbtUrgente.Name = "rbtUrgente";
            this.rbtUrgente.Size = new System.Drawing.Size(63, 17);
            this.rbtUrgente.TabIndex = 7;
            this.rbtUrgente.Text = "Urgente";
            this.rbtUrgente.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 465);
            this.Controls.Add(this.rbtUrgente);
            this.Controls.Add(this.rbtOrdinario);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTelegrama);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "CBT2425";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelegrama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rbtOrdinario;
        private System.Windows.Forms.RadioButton rbtUrgente;
    }
}

