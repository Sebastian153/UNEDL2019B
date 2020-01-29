namespace WindowsFormsApp1
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
            this.groupBox_Datos_Personales = new System.Windows.Forms.GroupBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.label_direccion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker_Fecha_de_Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox_Datos_Bancarios = new System.Windows.Forms.GroupBox();
            this.groupBox_Sexo = new System.Windows.Forms.GroupBox();
            this.radioButton_Femenino = new System.Windows.Forms.RadioButton();
            this.radioButton_Masculino = new System.Windows.Forms.RadioButton();
            this.radioButton_Otro = new System.Windows.Forms.RadioButton();
            this.label_Cantidad = new System.Windows.Forms.Label();
            this.label_Saldo = new System.Windows.Forms.Label();
            this.label_Fecha_de_Ejecucion = new System.Windows.Forms.Label();
            this.dateTimePicker_Fecha_de_Ejecucion = new System.Windows.Forms.DateTimePicker();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Apellido = new System.Windows.Forms.TextBox();
            this.textBox_Cantidad = new System.Windows.Forms.TextBox();
            this.textBox_Saldo = new System.Windows.Forms.TextBox();
            this.groupBox_Operacion = new System.Windows.Forms.GroupBox();
            this.radioButton_deposito = new System.Windows.Forms.RadioButton();
            this.radioButton_Retiro = new System.Windows.Forms.RadioButton();
            this.radioButton_COnsulta = new System.Windows.Forms.RadioButton();
            this.button_Ejecutar = new System.Windows.Forms.Button();
            this.button1_Limpiar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.button_Edicion = new System.Windows.Forms.Button();
            this.groupBox_Datos_Personales.SuspendLayout();
            this.groupBox_Datos_Bancarios.SuspendLayout();
            this.groupBox_Sexo.SuspendLayout();
            this.groupBox_Operacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Datos_Personales
            // 
            this.groupBox_Datos_Personales.Controls.Add(this.textBox_Apellido);
            this.groupBox_Datos_Personales.Controls.Add(this.textBox_Nombre);
            this.groupBox_Datos_Personales.Controls.Add(this.groupBox_Sexo);
            this.groupBox_Datos_Personales.Controls.Add(this.label4);
            this.groupBox_Datos_Personales.Controls.Add(this.label_direccion);
            this.groupBox_Datos_Personales.Controls.Add(this.label3);
            this.groupBox_Datos_Personales.Controls.Add(this.dateTimePicker_Fecha_de_Nacimiento);
            this.groupBox_Datos_Personales.Controls.Add(this.label2);
            this.groupBox_Datos_Personales.Controls.Add(this.textBox_direccion);
            this.groupBox_Datos_Personales.Location = new System.Drawing.Point(23, 23);
            this.groupBox_Datos_Personales.Name = "groupBox_Datos_Personales";
            this.groupBox_Datos_Personales.Size = new System.Drawing.Size(688, 217);
            this.groupBox_Datos_Personales.TabIndex = 0;
            this.groupBox_Datos_Personales.TabStop = false;
            this.groupBox_Datos_Personales.Text = "groupBox_Datos_Personales";
            this.groupBox_Datos_Personales.Enter += new System.EventHandler(this.groupBox_Datos_Personales_Enter);
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(517, 31);
            this.textBox_direccion.Multiline = true;
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(156, 128);
            this.textBox_direccion.TabIndex = 11;
            // 
            // label_direccion
            // 
            this.label_direccion.AutoSize = true;
            this.label_direccion.Location = new System.Drawing.Point(459, 31);
            this.label_direccion.Name = "label_direccion";
            this.label_direccion.Size = new System.Drawing.Size(52, 13);
            this.label_direccion.TabIndex = 10;
            this.label_direccion.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Nacimiento";
            // 
            // dateTimePicker_Fecha_de_Nacimiento
            // 
            this.dateTimePicker_Fecha_de_Nacimiento.Location = new System.Drawing.Point(131, 99);
            this.dateTimePicker_Fecha_de_Nacimiento.Name = "dateTimePicker_Fecha_de_Nacimiento";
            this.dateTimePicker_Fecha_de_Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Fecha_de_Nacimiento.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre";
            // 
            // groupBox_Datos_Bancarios
            // 
            this.groupBox_Datos_Bancarios.Controls.Add(this.button1_Limpiar);
            this.groupBox_Datos_Bancarios.Controls.Add(this.button_Ejecutar);
            this.groupBox_Datos_Bancarios.Controls.Add(this.groupBox_Operacion);
            this.groupBox_Datos_Bancarios.Controls.Add(this.textBox_Saldo);
            this.groupBox_Datos_Bancarios.Controls.Add(this.textBox_Cantidad);
            this.groupBox_Datos_Bancarios.Controls.Add(this.dateTimePicker_Fecha_de_Ejecucion);
            this.groupBox_Datos_Bancarios.Controls.Add(this.label_Fecha_de_Ejecucion);
            this.groupBox_Datos_Bancarios.Controls.Add(this.label_Saldo);
            this.groupBox_Datos_Bancarios.Controls.Add(this.label_Cantidad);
            this.groupBox_Datos_Bancarios.Location = new System.Drawing.Point(23, 246);
            this.groupBox_Datos_Bancarios.Name = "groupBox_Datos_Bancarios";
            this.groupBox_Datos_Bancarios.Size = new System.Drawing.Size(688, 204);
            this.groupBox_Datos_Bancarios.TabIndex = 1;
            this.groupBox_Datos_Bancarios.TabStop = false;
            this.groupBox_Datos_Bancarios.Text = "Datos Bancarios";
            this.groupBox_Datos_Bancarios.Enter += new System.EventHandler(this.groupBox_Datos_Bancarios_Enter);
            // 
            // groupBox_Sexo
            // 
            this.groupBox_Sexo.Controls.Add(this.radioButton_Otro);
            this.groupBox_Sexo.Controls.Add(this.radioButton_Masculino);
            this.groupBox_Sexo.Controls.Add(this.radioButton_Femenino);
            this.groupBox_Sexo.Location = new System.Drawing.Point(20, 145);
            this.groupBox_Sexo.Name = "groupBox_Sexo";
            this.groupBox_Sexo.Size = new System.Drawing.Size(281, 60);
            this.groupBox_Sexo.TabIndex = 12;
            this.groupBox_Sexo.TabStop = false;
            this.groupBox_Sexo.Text = "Sexo:";
            // 
            // radioButton_Femenino
            // 
            this.radioButton_Femenino.AutoSize = true;
            this.radioButton_Femenino.Location = new System.Drawing.Point(6, 19);
            this.radioButton_Femenino.Name = "radioButton_Femenino";
            this.radioButton_Femenino.Size = new System.Drawing.Size(71, 17);
            this.radioButton_Femenino.TabIndex = 0;
            this.radioButton_Femenino.TabStop = true;
            this.radioButton_Femenino.Text = "Femenino";
            this.radioButton_Femenino.UseVisualStyleBackColor = true;
            // 
            // radioButton_Masculino
            // 
            this.radioButton_Masculino.AutoSize = true;
            this.radioButton_Masculino.Location = new System.Drawing.Point(84, 19);
            this.radioButton_Masculino.Name = "radioButton_Masculino";
            this.radioButton_Masculino.Size = new System.Drawing.Size(73, 17);
            this.radioButton_Masculino.TabIndex = 1;
            this.radioButton_Masculino.TabStop = true;
            this.radioButton_Masculino.Text = "Masculino";
            this.radioButton_Masculino.UseVisualStyleBackColor = true;
            // 
            // radioButton_Otro
            // 
            this.radioButton_Otro.AutoSize = true;
            this.radioButton_Otro.Location = new System.Drawing.Point(163, 19);
            this.radioButton_Otro.Name = "radioButton_Otro";
            this.radioButton_Otro.Size = new System.Drawing.Size(45, 17);
            this.radioButton_Otro.TabIndex = 2;
            this.radioButton_Otro.TabStop = true;
            this.radioButton_Otro.Text = "Otro";
            this.radioButton_Otro.UseVisualStyleBackColor = true;
            // 
            // label_Cantidad
            // 
            this.label_Cantidad.AutoSize = true;
            this.label_Cantidad.Location = new System.Drawing.Point(17, 31);
            this.label_Cantidad.Name = "label_Cantidad";
            this.label_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.label_Cantidad.TabIndex = 7;
            this.label_Cantidad.Text = "Cantidad";
            // 
            // label_Saldo
            // 
            this.label_Saldo.AutoSize = true;
            this.label_Saldo.Location = new System.Drawing.Point(17, 64);
            this.label_Saldo.Name = "label_Saldo";
            this.label_Saldo.Size = new System.Drawing.Size(34, 13);
            this.label_Saldo.TabIndex = 8;
            this.label_Saldo.Text = "Saldo";
            // 
            // label_Fecha_de_Ejecucion
            // 
            this.label_Fecha_de_Ejecucion.AutoSize = true;
            this.label_Fecha_de_Ejecucion.Location = new System.Drawing.Point(17, 95);
            this.label_Fecha_de_Ejecucion.Name = "label_Fecha_de_Ejecucion";
            this.label_Fecha_de_Ejecucion.Size = new System.Drawing.Size(102, 13);
            this.label_Fecha_de_Ejecucion.TabIndex = 9;
            this.label_Fecha_de_Ejecucion.Text = "Fecha de Ejecucion";
            // 
            // dateTimePicker_Fecha_de_Ejecucion
            // 
            this.dateTimePicker_Fecha_de_Ejecucion.Location = new System.Drawing.Point(131, 95);
            this.dateTimePicker_Fecha_de_Ejecucion.Name = "dateTimePicker_Fecha_de_Ejecucion";
            this.dateTimePicker_Fecha_de_Ejecucion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Fecha_de_Ejecucion.TabIndex = 13;
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(68, 34);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(263, 20);
            this.textBox_Nombre.TabIndex = 13;
            // 
            // textBox_Apellido
            // 
            this.textBox_Apellido.Location = new System.Drawing.Point(68, 71);
            this.textBox_Apellido.Name = "textBox_Apellido";
            this.textBox_Apellido.Size = new System.Drawing.Size(263, 20);
            this.textBox_Apellido.TabIndex = 14;
            // 
            // textBox_Cantidad
            // 
            this.textBox_Cantidad.Location = new System.Drawing.Point(72, 28);
            this.textBox_Cantidad.Name = "textBox_Cantidad";
            this.textBox_Cantidad.Size = new System.Drawing.Size(263, 20);
            this.textBox_Cantidad.TabIndex = 15;
            // 
            // textBox_Saldo
            // 
            this.textBox_Saldo.Location = new System.Drawing.Point(72, 64);
            this.textBox_Saldo.Name = "textBox_Saldo";
            this.textBox_Saldo.Size = new System.Drawing.Size(263, 20);
            this.textBox_Saldo.TabIndex = 16;
            // 
            // groupBox_Operacion
            // 
            this.groupBox_Operacion.Controls.Add(this.radioButton_COnsulta);
            this.groupBox_Operacion.Controls.Add(this.radioButton_Retiro);
            this.groupBox_Operacion.Controls.Add(this.radioButton_deposito);
            this.groupBox_Operacion.Location = new System.Drawing.Point(26, 144);
            this.groupBox_Operacion.Name = "groupBox_Operacion";
            this.groupBox_Operacion.Size = new System.Drawing.Size(340, 42);
            this.groupBox_Operacion.TabIndex = 17;
            this.groupBox_Operacion.TabStop = false;
            this.groupBox_Operacion.Text = "Operacion:";
            // 
            // radioButton_deposito
            // 
            this.radioButton_deposito.AutoSize = true;
            this.radioButton_deposito.Location = new System.Drawing.Point(6, 19);
            this.radioButton_deposito.Name = "radioButton_deposito";
            this.radioButton_deposito.Size = new System.Drawing.Size(67, 17);
            this.radioButton_deposito.TabIndex = 3;
            this.radioButton_deposito.TabStop = true;
            this.radioButton_deposito.Text = "Deposito";
            this.radioButton_deposito.UseVisualStyleBackColor = true;
            // 
            // radioButton_Retiro
            // 
            this.radioButton_Retiro.AutoSize = true;
            this.radioButton_Retiro.Location = new System.Drawing.Point(84, 19);
            this.radioButton_Retiro.Name = "radioButton_Retiro";
            this.radioButton_Retiro.Size = new System.Drawing.Size(53, 17);
            this.radioButton_Retiro.TabIndex = 4;
            this.radioButton_Retiro.TabStop = true;
            this.radioButton_Retiro.Text = "Retiro";
            this.radioButton_Retiro.UseVisualStyleBackColor = true;
            // 
            // radioButton_COnsulta
            // 
            this.radioButton_COnsulta.AutoSize = true;
            this.radioButton_COnsulta.Location = new System.Drawing.Point(157, 19);
            this.radioButton_COnsulta.Name = "radioButton_COnsulta";
            this.radioButton_COnsulta.Size = new System.Drawing.Size(66, 17);
            this.radioButton_COnsulta.TabIndex = 5;
            this.radioButton_COnsulta.TabStop = true;
            this.radioButton_COnsulta.Text = "Consulta";
            this.radioButton_COnsulta.UseVisualStyleBackColor = true;
            this.radioButton_COnsulta.CheckedChanged += new System.EventHandler(this.radioButton_COnsulta_CheckedChanged);
            // 
            // button_Ejecutar
            // 
            this.button_Ejecutar.Location = new System.Drawing.Point(478, 46);
            this.button_Ejecutar.Name = "button_Ejecutar";
            this.button_Ejecutar.Size = new System.Drawing.Size(75, 23);
            this.button_Ejecutar.TabIndex = 18;
            this.button_Ejecutar.Text = "Ejecutar";
            this.button_Ejecutar.UseVisualStyleBackColor = true;
            this.button_Ejecutar.Click += new System.EventHandler(this.button_Ejecutar_Click);
            // 
            // button1_Limpiar
            // 
            this.button1_Limpiar.Location = new System.Drawing.Point(478, 84);
            this.button1_Limpiar.Name = "button1_Limpiar";
            this.button1_Limpiar.Size = new System.Drawing.Size(75, 23);
            this.button1_Limpiar.TabIndex = 19;
            this.button1_Limpiar.Text = "Limpiar";
            this.button1_Limpiar.UseVisualStyleBackColor = true;
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(717, 90);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 21;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // button_Edicion
            // 
            this.button_Edicion.Location = new System.Drawing.Point(717, 52);
            this.button_Edicion.Name = "button_Edicion";
            this.button_Edicion.Size = new System.Drawing.Size(75, 23);
            this.button_Edicion.TabIndex = 20;
            this.button_Edicion.Text = "Edicion";
            this.button_Edicion.UseVisualStyleBackColor = true;
            this.button_Edicion.Click += new System.EventHandler(this.button_Edicion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.groupBox_Datos_Bancarios);
            this.Controls.Add(this.button_Edicion);
            this.Controls.Add(this.groupBox_Datos_Personales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Datos_Personales.ResumeLayout(false);
            this.groupBox_Datos_Personales.PerformLayout();
            this.groupBox_Datos_Bancarios.ResumeLayout(false);
            this.groupBox_Datos_Bancarios.PerformLayout();
            this.groupBox_Sexo.ResumeLayout(false);
            this.groupBox_Sexo.PerformLayout();
            this.groupBox_Operacion.ResumeLayout(false);
            this.groupBox_Operacion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Datos_Personales;
        private System.Windows.Forms.TextBox textBox_Apellido;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.GroupBox groupBox_Sexo;
        private System.Windows.Forms.RadioButton radioButton_Otro;
        private System.Windows.Forms.RadioButton radioButton_Masculino;
        private System.Windows.Forms.RadioButton radioButton_Femenino;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_direccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha_de_Nacimiento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.GroupBox groupBox_Datos_Bancarios;
        private System.Windows.Forms.Button button1_Limpiar;
        private System.Windows.Forms.Button button_Ejecutar;
        private System.Windows.Forms.GroupBox groupBox_Operacion;
        private System.Windows.Forms.RadioButton radioButton_COnsulta;
        private System.Windows.Forms.RadioButton radioButton_Retiro;
        private System.Windows.Forms.RadioButton radioButton_deposito;
        private System.Windows.Forms.TextBox textBox_Saldo;
        private System.Windows.Forms.TextBox textBox_Cantidad;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fecha_de_Ejecucion;
        private System.Windows.Forms.Label label_Fecha_de_Ejecucion;
        private System.Windows.Forms.Label label_Saldo;
        private System.Windows.Forms.Label label_Cantidad;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.Button button_Edicion;
    }
}

