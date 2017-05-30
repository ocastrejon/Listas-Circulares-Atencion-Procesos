namespace Listas_Circulares_Atencion_de_Proceso
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
            this.lblMostrarActividad = new System.Windows.Forms.Label();
            this.lblListadoProcesosPendientes = new System.Windows.Forms.Label();
            this.lblNumProcesosPendientes = new System.Windows.Forms.Label();
            this.lbltotalProcesosAtendidos = new System.Windows.Forms.Label();
            this.lblCiclosPendientes = new System.Windows.Forms.Label();
            this.txtMostrarActividad = new System.Windows.Forms.TextBox();
            this.txtListaProcesosPendientes = new System.Windows.Forms.TextBox();
            this.txtProcesosAtendidos = new System.Windows.Forms.TextBox();
            this.txtProcesosPendientes = new System.Windows.Forms.TextBox();
            this.txtCiclosPendientes = new System.Windows.Forms.TextBox();
            this.lblNumeroMaximoP = new System.Windows.Forms.Label();
            this.txtNumMaximoProcesos = new System.Windows.Forms.TextBox();
            this.lblCiclosOcio = new System.Windows.Forms.Label();
            this.txtCilcosOcio = new System.Windows.Forms.TextBox();
            this.bttonMostrarReportes = new System.Windows.Forms.Button();
            this.bttonComenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMostrarActividad
            // 
            this.lblMostrarActividad.AutoSize = true;
            this.lblMostrarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarActividad.Location = new System.Drawing.Point(597, 20);
            this.lblMostrarActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMostrarActividad.Name = "lblMostrarActividad";
            this.lblMostrarActividad.Size = new System.Drawing.Size(110, 29);
            this.lblMostrarActividad.TabIndex = 6;
            this.lblMostrarActividad.Text = "Actividad";
            // 
            // lblListadoProcesosPendientes
            // 
            this.lblListadoProcesosPendientes.AutoSize = true;
            this.lblListadoProcesosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListadoProcesosPendientes.Location = new System.Drawing.Point(296, 20);
            this.lblListadoProcesosPendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListadoProcesosPendientes.Name = "lblListadoProcesosPendientes";
            this.lblListadoProcesosPendientes.Size = new System.Drawing.Size(241, 29);
            this.lblListadoProcesosPendientes.TabIndex = 7;
            this.lblListadoProcesosPendientes.Text = "Procesos pendientes";
            // 
            // lblNumProcesosPendientes
            // 
            this.lblNumProcesosPendientes.AutoSize = true;
            this.lblNumProcesosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumProcesosPendientes.Location = new System.Drawing.Point(25, 107);
            this.lblNumProcesosPendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumProcesosPendientes.Name = "lblNumProcesosPendientes";
            this.lblNumProcesosPendientes.Size = new System.Drawing.Size(241, 29);
            this.lblNumProcesosPendientes.TabIndex = 8;
            this.lblNumProcesosPendientes.Text = "Procesos pendientes";
            // 
            // lbltotalProcesosAtendidos
            // 
            this.lbltotalProcesosAtendidos.AutoSize = true;
            this.lbltotalProcesosAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalProcesosAtendidos.Location = new System.Drawing.Point(24, 368);
            this.lbltotalProcesosAtendidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltotalProcesosAtendidos.Name = "lbltotalProcesosAtendidos";
            this.lbltotalProcesosAtendidos.Size = new System.Drawing.Size(208, 58);
            this.lbltotalProcesosAtendidos.TabIndex = 9;
            this.lbltotalProcesosAtendidos.Text = "Total de procesos\r\nterminados";
            // 
            // lblCiclosPendientes
            // 
            this.lblCiclosPendientes.AutoSize = true;
            this.lblCiclosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclosPendientes.Location = new System.Drawing.Point(25, 282);
            this.lblCiclosPendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiclosPendientes.Name = "lblCiclosPendientes";
            this.lblCiclosPendientes.Size = new System.Drawing.Size(184, 29);
            this.lblCiclosPendientes.TabIndex = 10;
            this.lblCiclosPendientes.Text = "Ciclos restantes";
            // 
            // txtMostrarActividad
            // 
            this.txtMostrarActividad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMostrarActividad.Location = new System.Drawing.Point(602, 53);
            this.txtMostrarActividad.Margin = new System.Windows.Forms.Padding(4);
            this.txtMostrarActividad.Multiline = true;
            this.txtMostrarActividad.Name = "txtMostrarActividad";
            this.txtMostrarActividad.ReadOnly = true;
            this.txtMostrarActividad.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMostrarActividad.Size = new System.Drawing.Size(281, 454);
            this.txtMostrarActividad.TabIndex = 18;
            this.txtMostrarActividad.TabStop = false;
            // 
            // txtListaProcesosPendientes
            // 
            this.txtListaProcesosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtListaProcesosPendientes.Location = new System.Drawing.Point(301, 53);
            this.txtListaProcesosPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtListaProcesosPendientes.Multiline = true;
            this.txtListaProcesosPendientes.Name = "txtListaProcesosPendientes";
            this.txtListaProcesosPendientes.ReadOnly = true;
            this.txtListaProcesosPendientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtListaProcesosPendientes.Size = new System.Drawing.Size(282, 304);
            this.txtListaProcesosPendientes.TabIndex = 19;
            this.txtListaProcesosPendientes.TabStop = false;
            // 
            // txtProcesosAtendidos
            // 
            this.txtProcesosAtendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcesosAtendidos.Location = new System.Drawing.Point(29, 430);
            this.txtProcesosAtendidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcesosAtendidos.Name = "txtProcesosAtendidos";
            this.txtProcesosAtendidos.ReadOnly = true;
            this.txtProcesosAtendidos.Size = new System.Drawing.Size(245, 34);
            this.txtProcesosAtendidos.TabIndex = 20;
            this.txtProcesosAtendidos.TabStop = false;
            // 
            // txtProcesosPendientes
            // 
            this.txtProcesosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcesosPendientes.Location = new System.Drawing.Point(29, 140);
            this.txtProcesosPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtProcesosPendientes.Name = "txtProcesosPendientes";
            this.txtProcesosPendientes.ReadOnly = true;
            this.txtProcesosPendientes.Size = new System.Drawing.Size(246, 34);
            this.txtProcesosPendientes.TabIndex = 17;
            this.txtProcesosPendientes.TabStop = false;
            // 
            // txtCiclosPendientes
            // 
            this.txtCiclosPendientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiclosPendientes.Location = new System.Drawing.Point(30, 315);
            this.txtCiclosPendientes.Margin = new System.Windows.Forms.Padding(4);
            this.txtCiclosPendientes.Name = "txtCiclosPendientes";
            this.txtCiclosPendientes.ReadOnly = true;
            this.txtCiclosPendientes.Size = new System.Drawing.Size(246, 34);
            this.txtCiclosPendientes.TabIndex = 21;
            this.txtCiclosPendientes.TabStop = false;
            // 
            // lblNumeroMaximoP
            // 
            this.lblNumeroMaximoP.AutoSize = true;
            this.lblNumeroMaximoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroMaximoP.Location = new System.Drawing.Point(24, 20);
            this.lblNumeroMaximoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumeroMaximoP.Name = "lblNumeroMaximoP";
            this.lblNumeroMaximoP.Size = new System.Drawing.Size(222, 29);
            this.lblNumeroMaximoP.TabIndex = 11;
            this.lblNumeroMaximoP.Text = "Procesos formados";
            // 
            // txtNumMaximoProcesos
            // 
            this.txtNumMaximoProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumMaximoProcesos.Location = new System.Drawing.Point(29, 53);
            this.txtNumMaximoProcesos.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumMaximoProcesos.Name = "txtNumMaximoProcesos";
            this.txtNumMaximoProcesos.ReadOnly = true;
            this.txtNumMaximoProcesos.Size = new System.Drawing.Size(245, 34);
            this.txtNumMaximoProcesos.TabIndex = 16;
            this.txtNumMaximoProcesos.TabStop = false;
            // 
            // lblCiclosOcio
            // 
            this.lblCiclosOcio.AutoSize = true;
            this.lblCiclosOcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclosOcio.Location = new System.Drawing.Point(25, 196);
            this.lblCiclosOcio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCiclosOcio.Name = "lblCiclosOcio";
            this.lblCiclosOcio.Size = new System.Drawing.Size(132, 29);
            this.lblCiclosOcio.TabIndex = 12;
            this.lblCiclosOcio.Text = "Ciclos ocio";
            // 
            // txtCilcosOcio
            // 
            this.txtCilcosOcio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCilcosOcio.Location = new System.Drawing.Point(29, 229);
            this.txtCilcosOcio.Margin = new System.Windows.Forms.Padding(4);
            this.txtCilcosOcio.Name = "txtCilcosOcio";
            this.txtCilcosOcio.ReadOnly = true;
            this.txtCilcosOcio.Size = new System.Drawing.Size(246, 34);
            this.txtCilcosOcio.TabIndex = 15;
            this.txtCilcosOcio.TabStop = false;
            // 
            // bttonMostrarReportes
            // 
            this.bttonMostrarReportes.AutoSize = true;
            this.bttonMostrarReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonMostrarReportes.Location = new System.Drawing.Point(364, 439);
            this.bttonMostrarReportes.Margin = new System.Windows.Forms.Padding(4);
            this.bttonMostrarReportes.Name = "bttonMostrarReportes";
            this.bttonMostrarReportes.Size = new System.Drawing.Size(133, 68);
            this.bttonMostrarReportes.TabIndex = 14;
            this.bttonMostrarReportes.Text = "Mostrar\r\nReportes";
            this.bttonMostrarReportes.UseVisualStyleBackColor = true;
            this.bttonMostrarReportes.Click += new System.EventHandler(this.bttonMostrarReportes_Click);
            // 
            // bttonComenzar
            // 
            this.bttonComenzar.AutoSize = true;
            this.bttonComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttonComenzar.Location = new System.Drawing.Point(364, 378);
            this.bttonComenzar.Margin = new System.Windows.Forms.Padding(4);
            this.bttonComenzar.Name = "bttonComenzar";
            this.bttonComenzar.Size = new System.Drawing.Size(133, 39);
            this.bttonComenzar.TabIndex = 13;
            this.bttonComenzar.Text = "Comenzar";
            this.bttonComenzar.UseVisualStyleBackColor = true;
            this.bttonComenzar.Click += new System.EventHandler(this.bttonComenzar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 536);
            this.Controls.Add(this.lblMostrarActividad);
            this.Controls.Add(this.lblListadoProcesosPendientes);
            this.Controls.Add(this.lblNumProcesosPendientes);
            this.Controls.Add(this.lbltotalProcesosAtendidos);
            this.Controls.Add(this.lblCiclosPendientes);
            this.Controls.Add(this.txtMostrarActividad);
            this.Controls.Add(this.txtListaProcesosPendientes);
            this.Controls.Add(this.txtProcesosAtendidos);
            this.Controls.Add(this.txtProcesosPendientes);
            this.Controls.Add(this.txtCiclosPendientes);
            this.Controls.Add(this.lblNumeroMaximoP);
            this.Controls.Add(this.txtNumMaximoProcesos);
            this.Controls.Add(this.lblCiclosOcio);
            this.Controls.Add(this.txtCilcosOcio);
            this.Controls.Add(this.bttonMostrarReportes);
            this.Controls.Add(this.bttonComenzar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMostrarActividad;
        private System.Windows.Forms.Label lblListadoProcesosPendientes;
        private System.Windows.Forms.Label lblNumProcesosPendientes;
        private System.Windows.Forms.Label lbltotalProcesosAtendidos;
        private System.Windows.Forms.Label lblCiclosPendientes;
        private System.Windows.Forms.TextBox txtMostrarActividad;
        private System.Windows.Forms.TextBox txtListaProcesosPendientes;
        private System.Windows.Forms.TextBox txtProcesosAtendidos;
        private System.Windows.Forms.TextBox txtProcesosPendientes;
        private System.Windows.Forms.TextBox txtCiclosPendientes;
        private System.Windows.Forms.Label lblNumeroMaximoP;
        private System.Windows.Forms.TextBox txtNumMaximoProcesos;
        private System.Windows.Forms.Label lblCiclosOcio;
        private System.Windows.Forms.TextBox txtCilcosOcio;
        private System.Windows.Forms.Button bttonMostrarReportes;
        private System.Windows.Forms.Button bttonComenzar;
    }
}

