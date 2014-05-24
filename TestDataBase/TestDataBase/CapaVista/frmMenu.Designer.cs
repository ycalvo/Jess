namespace TestDataBase.CapaVista
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAccion = new System.Windows.Forms.Button();
            this.txtSno = new System.Windows.Forms.TextBox();
            this.txtEid = new System.Windows.Forms.TextBox();
            this.sno = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.chkAcepto = new System.Windows.Forms.CheckBox();
            this.txtDate1 = new System.Windows.Forms.DateTimePicker();
            this.txtDate2 = new System.Windows.Forms.DateTimePicker();
            this.txtSid = new System.Windows.Forms.TextBox();
            this.dtgInfo = new System.Windows.Forms.DataGridView();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccion
            // 
            this.btnAccion.Location = new System.Drawing.Point(367, 100);
            this.btnAccion.Name = "btnAccion";
            this.btnAccion.Size = new System.Drawing.Size(82, 30);
            this.btnAccion.TabIndex = 0;
            this.btnAccion.Text = "Enviar";
            this.btnAccion.UseVisualStyleBackColor = true;
            this.btnAccion.Click += new System.EventHandler(this.btnAccion_Click);
            // 
            // txtSno
            // 
            this.txtSno.Location = new System.Drawing.Point(129, 56);
            this.txtSno.Name = "txtSno";
            this.txtSno.Size = new System.Drawing.Size(100, 20);
            this.txtSno.TabIndex = 1;
            // 
            // txtEid
            // 
            this.txtEid.Location = new System.Drawing.Point(129, 83);
            this.txtEid.Name = "txtEid";
            this.txtEid.Size = new System.Drawing.Size(100, 20);
            this.txtEid.TabIndex = 2;
            // 
            // sno
            // 
            this.sno.AutoSize = true;
            this.sno.Location = new System.Drawing.Point(69, 62);
            this.sno.Name = "sno";
            this.sno.Size = new System.Drawing.Size(35, 13);
            this.sno.TabIndex = 7;
            this.sno.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "label5";
            // 
            // chkAcepto
            // 
            this.chkAcepto.AutoSize = true;
            this.chkAcepto.Location = new System.Drawing.Point(129, 190);
            this.chkAcepto.Name = "chkAcepto";
            this.chkAcepto.Size = new System.Drawing.Size(60, 17);
            this.chkAcepto.TabIndex = 13;
            this.chkAcepto.Text = "Acepto";
            this.chkAcepto.UseVisualStyleBackColor = true;
            // 
            // txtDate1
            // 
            this.txtDate1.Location = new System.Drawing.Point(129, 110);
            this.txtDate1.Name = "txtDate1";
            this.txtDate1.Size = new System.Drawing.Size(200, 20);
            this.txtDate1.TabIndex = 14;
            // 
            // txtDate2
            // 
            this.txtDate2.Location = new System.Drawing.Point(129, 136);
            this.txtDate2.Name = "txtDate2";
            this.txtDate2.Size = new System.Drawing.Size(200, 20);
            this.txtDate2.TabIndex = 15;
            // 
            // txtSid
            // 
            this.txtSid.Location = new System.Drawing.Point(129, 162);
            this.txtSid.Name = "txtSid";
            this.txtSid.Size = new System.Drawing.Size(100, 20);
            this.txtSid.TabIndex = 5;
            // 
            // dtgInfo
            // 
            this.dtgInfo.AllowUserToAddRows = false;
            this.dtgInfo.AllowUserToDeleteRows = false;
            this.dtgInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgInfo.Location = new System.Drawing.Point(0, 275);
            this.dtgInfo.Name = "dtgInfo";
            this.dtgInfo.ReadOnly = true;
            this.dtgInfo.Size = new System.Drawing.Size(679, 207);
            this.dtgInfo.TabIndex = 16;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(266, 222);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 17;
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(367, 221);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 18;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 482);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.dtgInfo);
            this.Controls.Add(this.txtDate2);
            this.Controls.Add(this.txtDate1);
            this.Controls.Add(this.chkAcepto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sno);
            this.Controls.Add(this.txtSid);
            this.Controls.Add(this.txtEid);
            this.Controls.Add(this.txtSno);
            this.Controls.Add(this.btnAccion);
            this.Name = "frmMenu";
            this.Text = "Conexion";
            ((System.ComponentModel.ISupportInitialize)(this.dtgInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccion;
        private System.Windows.Forms.TextBox txtSno;
        private System.Windows.Forms.TextBox txtEid;
        private System.Windows.Forms.Label sno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkAcepto;
        private System.Windows.Forms.DateTimePicker txtDate1;
        private System.Windows.Forms.DateTimePicker txtDate2;
        private System.Windows.Forms.TextBox txtSid;
        private System.Windows.Forms.DataGridView dtgInfo;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btneliminar;
    }
}

