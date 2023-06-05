namespace ReservaHoteles
{
    partial class verFactura
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
            this.dgv_verFacturas = new System.Windows.Forms.DataGridView();
            this.btn_regresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_verFacturas
            // 
            this.dgv_verFacturas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.dgv_verFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_verFacturas.Location = new System.Drawing.Point(12, 44);
            this.dgv_verFacturas.Name = "dgv_verFacturas";
            this.dgv_verFacturas.RowTemplate.Height = 25;
            this.dgv_verFacturas.Size = new System.Drawing.Size(610, 352);
            this.dgv_verFacturas.TabIndex = 0;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_regresar.Location = new System.Drawing.Point(547, 439);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 1;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = false;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // verFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(634, 483);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.dgv_verFacturas);
            this.Name = "verFactura";
            this.Text = "verFactura";
            this.Load += new System.EventHandler(this.verFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgv_verFacturas;
        private Button btn_regresar;
    }
}