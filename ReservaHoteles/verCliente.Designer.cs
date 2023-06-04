namespace ReservaHoteles
{
    partial class verCliente
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
            this.dgv_verClientes = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_borrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_verClientes
            // 
            this.dgv_verClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_verClientes.Location = new System.Drawing.Point(12, 64);
            this.dgv_verClientes.Name = "dgv_verClientes";
            this.dgv_verClientes.RowTemplate.Height = 25;
            this.dgv_verClientes.Size = new System.Drawing.Size(513, 308);
            this.dgv_verClientes.TabIndex = 0;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(12, 403);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(431, 403);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 2;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_borrar
            // 
            this.btn_borrar.Location = new System.Drawing.Point(219, 403);
            this.btn_borrar.Name = "btn_borrar";
            this.btn_borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_borrar.TabIndex = 3;
            this.btn_borrar.Text = "Eliminar";
            this.btn_borrar.UseVisualStyleBackColor = true;
            // 
            // verCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.btn_borrar);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgv_verClientes);
            this.Name = "verCliente";
            this.Text = "verCliente";
            this.Load += new System.EventHandler(this.verCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_verClientes;
        private Button btn_editar;
        private Button btn_regresar;
        private Button btn_borrar;
    }
}