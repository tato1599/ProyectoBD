namespace ReservaHoteles
{
    partial class crearHotel
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
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.tb_telefono = new System.Windows.Forms.TextBox();
            this.cb_categoria = new System.Windows.Forms.ComboBox();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.pb_imagen = new System.Windows.Forms.PictureBox();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_regresar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_nombre
            // 
            this.tb_nombre.Location = new System.Drawing.Point(129, 60);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(214, 23);
            this.tb_nombre.TabIndex = 0;
            // 
            // tb_direccion
            // 
            this.tb_direccion.Location = new System.Drawing.Point(129, 102);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(214, 23);
            this.tb_direccion.TabIndex = 1;
            // 
            // tb_telefono
            // 
            this.tb_telefono.Location = new System.Drawing.Point(129, 145);
            this.tb_telefono.Name = "tb_telefono";
            this.tb_telefono.Size = new System.Drawing.Size(214, 23);
            this.tb_telefono.TabIndex = 2;
            // 
            // cb_categoria
            // 
            this.cb_categoria.FormattingEnabled = true;
            this.cb_categoria.Location = new System.Drawing.Point(129, 189);
            this.cb_categoria.Name = "cb_categoria";
            this.cb_categoria.Size = new System.Drawing.Size(100, 23);
            this.cb_categoria.TabIndex = 3;
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Location = new System.Drawing.Point(129, 231);
            this.tb_descripcion.Multiline = true;
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(214, 84);
            this.tb_descripcion.TabIndex = 4;
            // 
            // pb_imagen
            // 
            this.pb_imagen.Location = new System.Drawing.Point(394, 70);
            this.pb_imagen.Name = "pb_imagen";
            this.pb_imagen.Size = new System.Drawing.Size(226, 245);
            this.pb_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_imagen.TabIndex = 5;
            this.pb_imagen.TabStop = false;
            this.pb_imagen.Click += new System.EventHandler(this.pb_imagen_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(43, 375);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 6;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // btn_regresar
            // 
            this.btn_regresar.Location = new System.Drawing.Point(288, 375);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar.TabIndex = 7;
            this.btn_regresar.Text = "Regresar";
            this.btn_regresar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Direccion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripcion";
            // 
            // crearHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_regresar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.pb_imagen);
            this.Controls.Add(this.tb_descripcion);
            this.Controls.Add(this.cb_categoria);
            this.Controls.Add(this.tb_telefono);
            this.Controls.Add(this.tb_direccion);
            this.Controls.Add(this.tb_nombre);
            this.Name = "crearHotel";
            this.Text = "crearHotel";
            ((System.ComponentModel.ISupportInitialize)(this.pb_imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tb_nombre;
        private TextBox tb_direccion;
        private TextBox tb_telefono;
        private ComboBox cb_categoria;
        private TextBox tb_descripcion;
        private PictureBox pb_imagen;
        private Button btn_guardar;
        private Button btn_regresar;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}