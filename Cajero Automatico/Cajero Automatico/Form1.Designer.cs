using System;

namespace Cajero_Automatico
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
            this.lblcantidad = new System.Windows.Forms.Label();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnretirar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcan = new System.Windows.Forms.TextBox();
            this.lblcambio = new System.Windows.Forms.Label();
            this.btnpagar = new System.Windows.Forms.Button();
            this.lblcantidadapagar = new System.Windows.Forms.Label();
            this.txtefectivo = new System.Windows.Forms.TextBox();
            this.lblnumeroprimo = new System.Windows.Forms.Label();
            this.lblfibo = new System.Windows.Forms.Label();
            this.btnrealizar = new System.Windows.Forms.Button();
            this.btnrfibocci = new System.Windows.Forms.Button();
            this.lblprimoresp = new System.Windows.Forms.Label();
            this.lblfiboresp = new System.Windows.Forms.Label();
            this.txtnumprimo = new System.Windows.Forms.TextBox();
            this.txtfibocci = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidad.Location = new System.Drawing.Point(38, 32);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(89, 20);
            this.lblcantidad.TabIndex = 0;
            this.lblcantidad.Text = "Cantidad:";
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrespuesta.Location = new System.Drawing.Point(38, 190);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(104, 20);
            this.lblrespuesta.TabIndex = 1;
            this.lblrespuesta.Text = "Respuesta:";
            this.lblrespuesta.Click += new System.EventHandler(this.lblrespuesta_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(133, 32);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 27);
            this.txtcantidad.TabIndex = 2;
            // 
            // btnretirar
            // 
            this.btnretirar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnretirar.Location = new System.Drawing.Point(102, 96);
            this.btnretirar.Name = "btnretirar";
            this.btnretirar.Size = new System.Drawing.Size(123, 51);
            this.btnretirar.TabIndex = 3;
            this.btnretirar.Text = "Retirar";
            this.btnretirar.UseVisualStyleBackColor = true;
            this.btnretirar.Click += new System.EventHandler(this.btnprocesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cantidad:";
            // 
            // txtcan
            // 
            this.txtcan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcan.Location = new System.Drawing.Point(537, 29);
            this.txtcan.Name = "txtcan";
            this.txtcan.Size = new System.Drawing.Size(100, 27);
            this.txtcan.TabIndex = 6;
            // 
            // lblcambio
            // 
            this.lblcambio.AutoSize = true;
            this.lblcambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcambio.Location = new System.Drawing.Point(549, 133);
            this.lblcambio.Name = "lblcambio";
            this.lblcambio.Size = new System.Drawing.Size(110, 20);
            this.lblcambio.TabIndex = 7;
            this.lblcambio.Text = "Respuesta: ";
            // 
            // btnpagar
            // 
            this.btnpagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpagar.Location = new System.Drawing.Point(389, 133);
            this.btnpagar.Name = "btnpagar";
            this.btnpagar.Size = new System.Drawing.Size(123, 51);
            this.btnpagar.TabIndex = 8;
            this.btnpagar.Text = "Pagar:";
            this.btnpagar.UseVisualStyleBackColor = true;
            this.btnpagar.Click += new System.EventHandler(this.btnpagar_Click);
            // 
            // lblcantidadapagar
            // 
            this.lblcantidadapagar.AutoSize = true;
            this.lblcantidadapagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcantidadapagar.Location = new System.Drawing.Point(364, 32);
            this.lblcantidadapagar.Name = "lblcantidadapagar";
            this.lblcantidadapagar.Size = new System.Drawing.Size(158, 20);
            this.lblcantidadapagar.TabIndex = 9;
            this.lblcantidadapagar.Text = "Cantidad a pagar:";
            // 
            // txtefectivo
            // 
            this.txtefectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtefectivo.Location = new System.Drawing.Point(528, 78);
            this.txtefectivo.Name = "txtefectivo";
            this.txtefectivo.Size = new System.Drawing.Size(100, 27);
            this.txtefectivo.TabIndex = 10;
            // 
            // lblnumeroprimo
            // 
            this.lblnumeroprimo.AutoSize = true;
            this.lblnumeroprimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumeroprimo.Location = new System.Drawing.Point(839, 39);
            this.lblnumeroprimo.Name = "lblnumeroprimo";
            this.lblnumeroprimo.Size = new System.Drawing.Size(135, 20);
            this.lblnumeroprimo.TabIndex = 11;
            this.lblnumeroprimo.Text = "Numero Primo:";
            // 
            // lblfibo
            // 
            this.lblfibo.AutoSize = true;
            this.lblfibo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfibo.Location = new System.Drawing.Point(839, 139);
            this.lblfibo.Name = "lblfibo";
            this.lblfibo.Size = new System.Drawing.Size(96, 20);
            this.lblfibo.TabIndex = 12;
            this.lblfibo.Text = "Fibonacci:";
            // 
            // btnrealizar
            // 
            this.btnrealizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrealizar.Location = new System.Drawing.Point(1133, 32);
            this.btnrealizar.Name = "btnrealizar";
            this.btnrealizar.Size = new System.Drawing.Size(110, 46);
            this.btnrealizar.TabIndex = 15;
            this.btnrealizar.Text = "Realizar:";
            this.btnrealizar.UseVisualStyleBackColor = true;
            this.btnrealizar.Click += new System.EventHandler(this.btnrealizar_Click);
            // 
            // btnrfibocci
            // 
            this.btnrfibocci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrfibocci.Location = new System.Drawing.Point(1113, 139);
            this.btnrfibocci.Name = "btnrfibocci";
            this.btnrfibocci.Size = new System.Drawing.Size(110, 45);
            this.btnrfibocci.TabIndex = 16;
            this.btnrfibocci.Text = "Realizar:";
            this.btnrfibocci.UseVisualStyleBackColor = true;
            this.btnrfibocci.Click += new System.EventHandler(this.btnreali_Click);
            // 
            // lblprimoresp
            // 
            this.lblprimoresp.AutoSize = true;
            this.lblprimoresp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprimoresp.Location = new System.Drawing.Point(1276, 42);
            this.lblprimoresp.Name = "lblprimoresp";
            this.lblprimoresp.Size = new System.Drawing.Size(104, 20);
            this.lblprimoresp.TabIndex = 17;
            this.lblprimoresp.Text = "Respuesta:";
            // 
            // lblfiboresp
            // 
            this.lblfiboresp.AutoSize = true;
            this.lblfiboresp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblfiboresp.Location = new System.Drawing.Point(1256, 142);
            this.lblfiboresp.Name = "lblfiboresp";
            this.lblfiboresp.Size = new System.Drawing.Size(104, 20);
            this.lblfiboresp.TabIndex = 18;
            this.lblfiboresp.Text = "Respuesta:";
            // 
            // txtnumprimo
            // 
            this.txtnumprimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumprimo.Location = new System.Drawing.Point(989, 36);
            this.txtnumprimo.Name = "txtnumprimo";
            this.txtnumprimo.Size = new System.Drawing.Size(100, 27);
            this.txtnumprimo.TabIndex = 19;
            // 
            // txtfibocci
            // 
            this.txtfibocci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfibocci.Location = new System.Drawing.Point(969, 142);
            this.txtfibocci.Name = "txtfibocci";
            this.txtfibocci.Size = new System.Drawing.Size(100, 27);
            this.txtfibocci.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1523, 569);
            this.Controls.Add(this.txtfibocci);
            this.Controls.Add(this.txtnumprimo);
            this.Controls.Add(this.lblfiboresp);
            this.Controls.Add(this.lblprimoresp);
            this.Controls.Add(this.btnrfibocci);
            this.Controls.Add(this.btnrealizar);
            this.Controls.Add(this.lblfibo);
            this.Controls.Add(this.lblnumeroprimo);
            this.Controls.Add(this.txtefectivo);
            this.Controls.Add(this.lblcantidadapagar);
            this.Controls.Add(this.btnpagar);
            this.Controls.Add(this.lblcambio);
            this.Controls.Add(this.txtcan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnretirar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblcantidad);
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void lblrespuesta_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label lblcantidad;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnretirar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcan;
        private System.Windows.Forms.Label lblcambio;
        private System.Windows.Forms.Button btnpagar;
        private System.Windows.Forms.Label lblcantidadapagar;
        private System.Windows.Forms.TextBox txtefectivo;
        private System.Windows.Forms.Label lblnumeroprimo;
        private System.Windows.Forms.Label lblfibo;
        private System.Windows.Forms.Button btnrealizar;
        private System.Windows.Forms.Button btnrfibocci;
        private System.Windows.Forms.Label lblprimoresp;
        private System.Windows.Forms.Label lblfiboresp;
        private System.Windows.Forms.TextBox txtnumprimo;
        private System.Windows.Forms.TextBox txtfibocci;
    }
}

