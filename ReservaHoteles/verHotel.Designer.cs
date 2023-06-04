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
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoteles)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hoteles
            // 
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
            this.btn_regresar.Location = new System.Drawing.Point(883, 466);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 1;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // verHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 513);
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
    }
}