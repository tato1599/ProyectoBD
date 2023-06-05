namespace ReservaHoteles
{
    partial class verHotel
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
            this.dgv_hoteles = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hoteles
            // 
            this.dgv_hoteles.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgv_hoteles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoteles.Location = new System.Drawing.Point(31, 39);
            this.dgv_hoteles.Name = "dgv_hoteles";
            this.dgv_hoteles.RowTemplate.Height = 25;
            this.dgv_hoteles.Size = new System.Drawing.Size(927, 387);
            this.dgv_hoteles.TabIndex = 0;
            this.dgv_hoteles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoteles_CellContentClick);
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_regresar.Location = new System.Drawing.Point(883, 466);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 1;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_editar.Location = new System.Drawing.Point(35, 467);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 23);
            this.btn_editar.TabIndex = 2;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // verHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(974, 513);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.dgv_hoteles);
            this.Name = "verHotel";
            this.Text = "verHotel";
            this.Load += new System.EventHandler(this.verHotel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoteles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_hoteles;
        private Button btn_regresar;
        private Button btn_editar;
    }
}