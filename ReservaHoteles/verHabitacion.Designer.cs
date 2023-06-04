namespace ReservaHoteles
{
    partial class verHabitacion
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
            this.dgv_habitacion = new System.Windows.Forms.DataGridView();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_habitacion
            // 
            this.dgv_habitacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_habitacion.Location = new System.Drawing.Point(12, 75);
            this.dgv_habitacion.Name = "dgv_habitacion";
            this.dgv_habitacion.RowTemplate.Height = 25;
            this.dgv_habitacion.Size = new System.Drawing.Size(776, 352);
            this.dgv_habitacion.TabIndex = 0;
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(12, 462);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(713, 473);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 2;
            this.btn_regresar.Text = "regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // verHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.dgv_habitacion);
            this.Name = "verHabitacion";
            this.Text = "verHabitacion";
            this.Load += new System.EventHandler(this.verHabitacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_habitacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_habitacion;
        private Button btn_editar;
        private Button btn_regresar;
    }
}