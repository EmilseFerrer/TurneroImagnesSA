namespace TurneroImagnesSA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblPracticas = new System.Windows.Forms.Label();
            this.cbPracticas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbEstudio = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.btlimpiar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.cbHorario = new System.Windows.Forms.ComboBox();
            this.lblHorario = new System.Windows.Forms.Label();
            this.btTurnos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(233, 12);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(367, 29);
            this.lbltitulo.TabIndex = 0;
            this.lbltitulo.Text = "Diagnóstico Por Imágenes S.A";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 54);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(151, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(59, 13);
            this.lblApellido.TabIndex = 3;
            this.lblApellido.Text = "APELLIDO";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(154, 83);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // lblPracticas
            // 
            this.lblPracticas.AutoSize = true;
            this.lblPracticas.Location = new System.Drawing.Point(34, 132);
            this.lblPracticas.Name = "lblPracticas";
            this.lblPracticas.Size = new System.Drawing.Size(105, 13);
            this.lblPracticas.TabIndex = 7;
            this.lblPracticas.Text = "Seleccione Práctica ";
            // 
            // cbPracticas
            // 
            this.cbPracticas.FormattingEnabled = true;
            this.cbPracticas.Items.AddRange(new object[] {
            "",
            "Radiografía",
            "Tomografía",
            "Resonancia"});
            this.cbPracticas.Location = new System.Drawing.Point(37, 165);
            this.cbPracticas.Name = "cbPracticas";
            this.cbPracticas.Size = new System.Drawing.Size(121, 21);
            this.cbPracticas.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Seleccione el estudio";
            // 
            // cbEstudio
            // 
            this.cbEstudio.FormattingEnabled = true;
            this.cbEstudio.Items.AddRange(new object[] {
            "",
            "RX- TORAX (F Y P)",
            "RX-ABDOMEN",
            "RX-CRANEO (F Y P)",
            "RX-HOMBRO (F Y P)",
            "RX- BRAZO (F Y P)",
            "RX- CODO (F Y P)",
            "RX-MANO (F, P Y O)",
            "RX-PELVIS",
            "RX-FEMUR(F Y P)",
            "RX-RODILLA(F Y P)",
            "RX-PIERNA(F Y P)",
            "RX-PIE(F,P Y O)",
            "TC-TORAX",
            "TC-ABDOMEN(PIELOTAC)",
            "TC-PELVIS",
            "TC-HOMBRO",
            "RMN- COLANGIO",
            "RMN- PELVIS",
            "RMN-HOMBRO",
            "RMN-RODILLA"});
            this.cbEstudio.Location = new System.Drawing.Point(183, 165);
            this.cbEstudio.Name = "cbEstudio";
            this.cbEstudio.Size = new System.Drawing.Size(121, 21);
            this.cbEstudio.TabIndex = 10;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(334, 166);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(110, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(331, 132);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(101, 26);
            this.lblFecha.TabIndex = 12;
            this.lblFecha.Text = "Seleccione la fecha\r\n\r\n";
            // 
            // btlimpiar
            // 
            this.btlimpiar.Location = new System.Drawing.Point(229, 310);
            this.btlimpiar.Name = "btlimpiar";
            this.btlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btlimpiar.TabIndex = 13;
            this.btlimpiar.Text = "Limpiar";
            this.btlimpiar.UseVisualStyleBackColor = true;
            this.btlimpiar.Click += new System.EventHandler(this.btlimpiar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Location = new System.Drawing.Point(37, 310);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 23);
            this.btAceptar.TabIndex = 14;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(729, 358);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(75, 23);
            this.btSalir.TabIndex = 15;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmensaje.Location = new System.Drawing.Point(37, 240);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(0, 18);
            this.lblmensaje.TabIndex = 16;
            // 
            // cbHorario
            // 
            this.cbHorario.FormattingEnabled = true;
            this.cbHorario.Location = new System.Drawing.Point(468, 165);
            this.cbHorario.Name = "cbHorario";
            this.cbHorario.Size = new System.Drawing.Size(121, 21);
            this.cbHorario.TabIndex = 17;
            // 
            // lblHorario
            // 
            this.lblHorario.AutoSize = true;
            this.lblHorario.Location = new System.Drawing.Point(465, 132);
            this.lblHorario.Name = "lblHorario";
            this.lblHorario.Size = new System.Drawing.Size(41, 13);
            this.lblHorario.TabIndex = 18;
            this.lblHorario.Text = "Horario";
            // 
            // btTurnos
            // 
            this.btTurnos.Location = new System.Drawing.Point(135, 310);
            this.btTurnos.Name = "btTurnos";
            this.btTurnos.Size = new System.Drawing.Size(75, 23);
            this.btTurnos.TabIndex = 19;
            this.btTurnos.Text = "Ver Turnos";
            this.btTurnos.UseVisualStyleBackColor = true;
            this.btTurnos.Click += new System.EventHandler(this.btTurnos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(627, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 212);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(873, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btTurnos);
            this.Controls.Add(this.lblHorario);
            this.Controls.Add(this.cbHorario);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btlimpiar);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cbEstudio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPracticas);
            this.Controls.Add(this.lblPracticas);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lbltitulo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblPracticas;
        private System.Windows.Forms.ComboBox cbPracticas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEstudio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btlimpiar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.ComboBox cbHorario;
        private System.Windows.Forms.Label lblHorario;
        private System.Windows.Forms.Button btTurnos;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

