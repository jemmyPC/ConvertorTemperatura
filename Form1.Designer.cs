namespace DPRN1_U1_EA_JEPC
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSalida = new System.Windows.Forms.ComboBox();
            this.comboBoxEntrada = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.salida = new System.Windows.Forms.TextBox();
            this.ingreso = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Conversor de Temperatura";
            // 
            // comboBoxSalida
            // 
            this.comboBoxSalida.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSalida.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxSalida.DropDownHeight = 120;
            this.comboBoxSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSalida.DropDownWidth = 180;
            this.comboBoxSalida.FormattingEnabled = true;
            this.comboBoxSalida.IntegralHeight = false;
            this.comboBoxSalida.ItemHeight = 13;
            this.comboBoxSalida.Items.AddRange(new object[] {
            "Celsius",
            " farenhait",
            "kelvin"});
            this.comboBoxSalida.Location = new System.Drawing.Point(315, 103);
            this.comboBoxSalida.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxSalida.Name = "comboBoxSalida";
            this.comboBoxSalida.Size = new System.Drawing.Size(202, 21);
            this.comboBoxSalida.TabIndex = 5;
            this.comboBoxSalida.SelectedIndexChanged += new System.EventHandler(this.comboBoxSalida_SelectedIndexChanged);
            // 
            // comboBoxEntrada
            // 
            this.comboBoxEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxEntrada.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBoxEntrada.DropDownHeight = 120;
            this.comboBoxEntrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEntrada.DropDownWidth = 180;
            this.comboBoxEntrada.FormattingEnabled = true;
            this.comboBoxEntrada.IntegralHeight = false;
            this.comboBoxEntrada.ItemHeight = 13;
            this.comboBoxEntrada.Items.AddRange(new object[] {
            "Celsius",
            "farenhait",
            "kelvin"});
            this.comboBoxEntrada.Location = new System.Drawing.Point(15, 100);
            this.comboBoxEntrada.Margin = new System.Windows.Forms.Padding(6);
            this.comboBoxEntrada.Name = "comboBoxEntrada";
            this.comboBoxEntrada.Size = new System.Drawing.Size(194, 21);
            this.comboBoxEntrada.TabIndex = 6;
            this.comboBoxEntrada.SelectedIndexChanged += new System.EventHandler(this.comboBoxEntrada_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(236, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 67);
            this.label2.TabIndex = 7;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salida
            // 
            this.salida.Location = new System.Drawing.Point(316, 65);
            this.salida.Name = "salida";
            this.salida.Size = new System.Drawing.Size(201, 20);
            this.salida.TabIndex = 8;
            // 
            // ingreso
            // 
            this.ingreso.Location = new System.Drawing.Point(15, 66);
            this.ingreso.Name = "ingreso";
            this.ingreso.Size = new System.Drawing.Size(194, 20);
            this.ingreso.TabIndex = 9;
            this.ingreso.TextChanged += new System.EventHandler(this.ingreso_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(555, 148);
            this.Controls.Add(this.ingreso);
            this.Controls.Add(this.salida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEntrada);
            this.Controls.Add(this.comboBoxSalida);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calcular Grados";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSalida;
        private System.Windows.Forms.ComboBox comboBoxEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox salida;
        private System.Windows.Forms.TextBox ingreso;
    }
}

