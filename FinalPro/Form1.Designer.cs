namespace FinalPro
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNP = new System.Windows.Forms.TextBox();
            this.textBoxAP = new System.Windows.Forms.TextBox();
            this.textBoxCT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btg = new System.Windows.Forms.Button();
            this.bta = new System.Windows.Forms.Button();
            this.textBoxCE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttoncargar = new System.Windows.Forms.Button();
            this.dataGridViewConetMysql = new System.Windows.Forms.DataGridView();
            this.buttoneliminar = new System.Windows.Forms.Button();
            this.numericUpDownEliminar = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownActualizar = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConetMysql)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActualizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "NOMBRE DEL PERSONAJE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ANIME QUE PERTENECE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "FECHA DE EMISION";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CANTIDAD DE EPISODIOS";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(223, 25);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(31, 20);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxNP
            // 
            this.textBoxNP.Location = new System.Drawing.Point(223, 53);
            this.textBoxNP.Name = "textBoxNP";
            this.textBoxNP.Size = new System.Drawing.Size(194, 20);
            this.textBoxNP.TabIndex = 6;
            // 
            // textBoxAP
            // 
            this.textBoxAP.Location = new System.Drawing.Point(223, 82);
            this.textBoxAP.Name = "textBoxAP";
            this.textBoxAP.Size = new System.Drawing.Size(194, 20);
            this.textBoxAP.TabIndex = 7;
            // 
            // textBoxCT
            // 
            this.textBoxCT.Location = new System.Drawing.Point(223, 176);
            this.textBoxCT.Name = "textBoxCT";
            this.textBoxCT.Size = new System.Drawing.Size(194, 20);
            this.textBoxCT.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(143, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "EMISION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "FINALIZADO";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(223, 208);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 12;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(223, 237);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(223, 113);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(194, 20);
            this.dateTimePicker.TabIndex = 15;
            // 
            // btg
            // 
            this.btg.Location = new System.Drawing.Point(12, 320);
            this.btg.Name = "btg";
            this.btg.Size = new System.Drawing.Size(106, 38);
            this.btg.TabIndex = 16;
            this.btg.Text = "ACTUALIZAR";
            this.btg.UseVisualStyleBackColor = true;
            this.btg.Click += new System.EventHandler(this.btg_Click);
            // 
            // bta
            // 
            this.bta.Location = new System.Drawing.Point(857, 19);
            this.bta.Name = "bta";
            this.bta.Size = new System.Drawing.Size(106, 38);
            this.bta.TabIndex = 17;
            this.bta.Text = "COMPROBAR CONEXIÓN";
            this.bta.UseVisualStyleBackColor = true;
            this.bta.Click += new System.EventHandler(this.bta_Click);
            // 
            // textBoxCE
            // 
            this.textBoxCE.Location = new System.Drawing.Point(223, 144);
            this.textBoxCE.Name = "textBoxCE";
            this.textBoxCE.Size = new System.Drawing.Size(194, 20);
            this.textBoxCE.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(55, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "CANTIDAD TEMPORADAS";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 38);
            this.button1.TabIndex = 20;
            this.button1.Text = "INSERTAR MODELO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttoncargar
            // 
            this.buttoncargar.Location = new System.Drawing.Point(12, 364);
            this.buttoncargar.Name = "buttoncargar";
            this.buttoncargar.Size = new System.Drawing.Size(106, 38);
            this.buttoncargar.TabIndex = 21;
            this.buttoncargar.Text = "CARGAR";
            this.buttoncargar.UseVisualStyleBackColor = true;
            this.buttoncargar.Click += new System.EventHandler(this.buttoncargar_Click);
            // 
            // dataGridViewConetMysql
            // 
            this.dataGridViewConetMysql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConetMysql.Location = new System.Drawing.Point(223, 286);
            this.dataGridViewConetMysql.Name = "dataGridViewConetMysql";
            this.dataGridViewConetMysql.Size = new System.Drawing.Size(842, 348);
            this.dataGridViewConetMysql.TabIndex = 22;
            // 
            // buttoneliminar
            // 
            this.buttoneliminar.Location = new System.Drawing.Point(12, 452);
            this.buttoneliminar.Name = "buttoneliminar";
            this.buttoneliminar.Size = new System.Drawing.Size(106, 38);
            this.buttoneliminar.TabIndex = 23;
            this.buttoneliminar.Text = "ELIMINAR";
            this.buttoneliminar.UseVisualStyleBackColor = true;
            this.buttoneliminar.Click += new System.EventHandler(this.buttoneliminar_Click);
            // 
            // numericUpDownEliminar
            // 
            this.numericUpDownEliminar.Location = new System.Drawing.Point(223, 260);
            this.numericUpDownEliminar.Name = "numericUpDownEliminar";
            this.numericUpDownEliminar.Size = new System.Drawing.Size(194, 20);
            this.numericUpDownEliminar.TabIndex = 24;
            // 
            // numericUpDownActualizar
            // 
            this.numericUpDownActualizar.Location = new System.Drawing.Point(580, 260);
            this.numericUpDownActualizar.Name = "numericUpDownActualizar";
            this.numericUpDownActualizar.Size = new System.Drawing.Size(194, 20);
            this.numericUpDownActualizar.TabIndex = 25;
            this.numericUpDownActualizar.ValueChanged += new System.EventHandler(this.numericUpDownActualizar_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "PERSONAJE A ELEMINAR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(423, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(151, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "PERSONAJE A ACTUALIZAR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.pictureBox1.Image = global::FinalPro.Properties.Resources.Naruto;
            this.pictureBox1.Location = new System.Drawing.Point(486, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 192);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1221, 646);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numericUpDownActualizar);
            this.Controls.Add(this.numericUpDownEliminar);
            this.Controls.Add(this.buttoneliminar);
            this.Controls.Add(this.dataGridViewConetMysql);
            this.Controls.Add(this.buttoncargar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxCE);
            this.Controls.Add(this.bta);
            this.Controls.Add(this.btg);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCT);
            this.Controls.Add(this.textBoxAP);
            this.Controls.Add(this.textBoxNP);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "LIBRERIA";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConetMysql)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownActualizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNP;
        private System.Windows.Forms.TextBox textBoxAP;
        private System.Windows.Forms.TextBox textBoxCT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btg;
        private System.Windows.Forms.Button bta;
        private System.Windows.Forms.TextBox textBoxCE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttoncargar;
        private System.Windows.Forms.DataGridView dataGridViewConetMysql;
        private System.Windows.Forms.Button buttoneliminar;
        private System.Windows.Forms.NumericUpDown numericUpDownEliminar;
        private System.Windows.Forms.NumericUpDown numericUpDownActualizar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

