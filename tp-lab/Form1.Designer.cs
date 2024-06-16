namespace tp_lab
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
            this.comboBoxCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelOcupacion = new System.Windows.Forms.Label();
            this.labelOcupacionMax = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonVer = new System.Windows.Forms.Button();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.dataGridViewData = new System.Windows.Forms.DataGridView();
            this.labelOcupacionActual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCampo
            // 
            this.comboBoxCampo.FormattingEnabled = true;
            this.comboBoxCampo.Location = new System.Drawing.Point(29, 34);
            this.comboBoxCampo.Name = "comboBoxCampo";
            this.comboBoxCampo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCampo.TabIndex = 0;
            this.comboBoxCampo.SelectedIndexChanged += new System.EventHandler(this.comboBoxCampo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campo";
            // 
            // labelOcupacion
            // 
            this.labelOcupacion.AutoSize = true;
            this.labelOcupacion.Location = new System.Drawing.Point(26, 77);
            this.labelOcupacion.Name = "labelOcupacion";
            this.labelOcupacion.Size = new System.Drawing.Size(59, 13);
            this.labelOcupacion.TabIndex = 2;
            this.labelOcupacion.Text = "Ocupación";
            // 
            // labelOcupacionMax
            // 
            this.labelOcupacionMax.AutoSize = true;
            this.labelOcupacionMax.Location = new System.Drawing.Point(115, 77);
            this.labelOcupacionMax.Name = "labelOcupacionMax";
            this.labelOcupacionMax.Size = new System.Drawing.Size(36, 13);
            this.labelOcupacionMax.TabIndex = 3;
            this.labelOcupacionMax.Text = "/1000";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(26, 119);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(26, 13);
            this.labelDni.TabIndex = 4;
            this.labelDni.Text = "DNI";
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(29, 135);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(121, 20);
            this.textBoxDni.TabIndex = 5;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(29, 173);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(121, 23);
            this.buttonCargar.TabIndex = 6;
            this.buttonCargar.Text = "Cargar";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonCargar_Click);
            // 
            // buttonVer
            // 
            this.buttonVer.Location = new System.Drawing.Point(29, 202);
            this.buttonVer.Name = "buttonVer";
            this.buttonVer.Size = new System.Drawing.Size(121, 23);
            this.buttonVer.TabIndex = 7;
            this.buttonVer.Text = "Ver todos";
            this.buttonVer.UseVisualStyleBackColor = true;
            this.buttonVer.Click += new System.EventHandler(this.buttonVer_Click);
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(29, 231);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(121, 23);
            this.buttonReiniciar.TabIndex = 8;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // dataGridViewData
            // 
            this.dataGridViewData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewData.Location = new System.Drawing.Point(183, 18);
            this.dataGridViewData.Name = "dataGridViewData";
            this.dataGridViewData.Size = new System.Drawing.Size(453, 353);
            this.dataGridViewData.TabIndex = 9;
            // 
            // labelOcupacionActual
            // 
            this.labelOcupacionActual.AutoSize = true;
            this.labelOcupacionActual.Location = new System.Drawing.Point(96, 77);
            this.labelOcupacionActual.Name = "labelOcupacionActual";
            this.labelOcupacionActual.Size = new System.Drawing.Size(13, 13);
            this.labelOcupacionActual.TabIndex = 10;
            this.labelOcupacionActual.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 388);
            this.Controls.Add(this.labelOcupacionActual);
            this.Controls.Add(this.dataGridViewData);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.buttonVer);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.labelOcupacionMax);
            this.Controls.Add(this.labelOcupacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxCampo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelOcupacion;
        private System.Windows.Forms.Label labelOcupacionMax;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonVer;
        private System.Windows.Forms.Button buttonReiniciar;
        private System.Windows.Forms.DataGridView dataGridViewData;
        private System.Windows.Forms.Label labelOcupacionActual;
    }
}

