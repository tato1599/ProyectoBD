namespace ReservaHoteles
{
    partial class verReservacion
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
            this.dgv_verReservaciones = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verReservaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_verReservaciones
            // 
            this.dgv_verReservaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_verReservaciones.Location = new System.Drawing.Point(12, 55);
            this.dgv_verReservaciones.Name = "dgv_verReservaciones";
            this.dgv_verReservaciones.RowTemplate.Height = 25;
            this.dgv_verReservaciones.Size = new System.Drawing.Size(776, 321);
            this.dgv_verReservaciones.TabIndex = 0;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(18, 407);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(713, 407);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 2;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // verReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgv_verReservaciones);
            this.Name = "verReservacion";
            this.Text = "verReservacion";
            this.Load += new System.EventHandler(this.verReservacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verReservaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_verReservaciones;
        private Button btn_editar;
        private Button btn_regresar;
    }
}