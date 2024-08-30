namespace ConexionEjemplo
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
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.tbFiltro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.tboxCustomerID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxCompanyName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxContactTitle = new System.Windows.Forms.TextBox();
            this.lbContactTitle = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.tboxContacName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(12, 83);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(765, 271);
            this.dataGrid.TabIndex = 0;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.OliveDrab;
            this.btnCargar.Location = new System.Drawing.Point(336, 370);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(96, 34);
            this.btnCargar.TabIndex = 1;
            this.btnCargar.Text = "Cargar Informaciòn";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // tbFiltro
            // 
            this.tbFiltro.BackColor = System.Drawing.Color.Red;
            this.tbFiltro.Location = new System.Drawing.Point(79, 29);
            this.tbFiltro.Name = "tbFiltro";
            this.tbFiltro.Size = new System.Drawing.Size(100, 20);
            this.tbFiltro.TabIndex = 2;
            this.tbFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filtrar";
            this.label1.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Cyan;
            this.btnBuscar.Location = new System.Drawing.Point(962, 104);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(199, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar Cliente";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Customers ID";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(902, 21);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(126, 20);
            this.txtBuscar.TabIndex = 6;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // tboxCustomerID
            // 
            this.tboxCustomerID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tboxCustomerID.Location = new System.Drawing.Point(998, 147);
            this.tboxCustomerID.Name = "tboxCustomerID";
            this.tboxCustomerID.Size = new System.Drawing.Size(126, 20);
            this.tboxCustomerID.TabIndex = 8;
            this.tboxCustomerID.TextChanged += new System.EventHandler(this.tboxCustomerID_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(922, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customers ID";
            // 
            // tboxCompanyName
            // 
            this.tboxCompanyName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tboxCompanyName.Location = new System.Drawing.Point(998, 182);
            this.tboxCompanyName.Name = "tboxCompanyName";
            this.tboxCompanyName.Size = new System.Drawing.Size(126, 20);
            this.tboxCompanyName.TabIndex = 10;
            this.tboxCompanyName.TextChanged += new System.EventHandler(this.tboxCompanyName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(913, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CompanyName";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tboxContactTitle
            // 
            this.tboxContactTitle.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tboxContactTitle.Location = new System.Drawing.Point(998, 273);
            this.tboxContactTitle.Name = "tboxContactTitle";
            this.tboxContactTitle.Size = new System.Drawing.Size(126, 20);
            this.tboxContactTitle.TabIndex = 12;
            this.tboxContactTitle.TextChanged += new System.EventHandler(this.tboxContactTitle_TextChanged);
            // 
            // lbContactTitle
            // 
            this.lbContactTitle.AutoSize = true;
            this.lbContactTitle.Location = new System.Drawing.Point(913, 276);
            this.lbContactTitle.Name = "lbContactTitle";
            this.lbContactTitle.Size = new System.Drawing.Size(64, 13);
            this.lbContactTitle.TabIndex = 11;
            this.lbContactTitle.Text = "ContactTitle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Customers ID";
            // 
            // tboxAddress
            // 
            this.tboxAddress.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tboxAddress.Location = new System.Drawing.Point(998, 315);
            this.tboxAddress.Name = "tboxAddress";
            this.tboxAddress.Size = new System.Drawing.Size(126, 20);
            this.tboxAddress.TabIndex = 16;
            this.tboxAddress.TextChanged += new System.EventHandler(this.tboxAddress_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(922, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Address";
            // 
            // tboxCity
            // 
            this.tboxCity.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tboxCity.Location = new System.Drawing.Point(998, 355);
            this.tboxCity.Name = "tboxCity";
            this.tboxCity.Size = new System.Drawing.Size(126, 20);
            this.tboxCity.TabIndex = 18;
            this.tboxCity.TextChanged += new System.EventHandler(this.tboxCity_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(922, 355);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "City";
            // 
            // btnInsertar
            // 
            this.btnInsertar.BackColor = System.Drawing.SystemColors.Info;
            this.btnInsertar.Location = new System.Drawing.Point(834, 398);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(199, 23);
            this.btnInsertar.TabIndex = 19;
            this.btnInsertar.Text = "Ingresar ";
            this.btnInsertar.UseVisualStyleBackColor = false;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // tboxContacName
            // 
            this.tboxContacName.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tboxContacName.ForeColor = System.Drawing.Color.Moccasin;
            this.tboxContacName.Location = new System.Drawing.Point(998, 231);
            this.tboxContacName.Name = "tboxContacName";
            this.tboxContacName.Size = new System.Drawing.Size(126, 20);
            this.tboxContacName.TabIndex = 21;
            this.tboxContacName.TextChanged += new System.EventHandler(this.tboxContacName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(909, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "ContactName";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.SystemColors.Info;
            this.btModificar.Location = new System.Drawing.Point(1039, 398);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(199, 23);
            this.btModificar.TabIndex = 22;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.CadetBlue;
            this.btnEliminar.Location = new System.Drawing.Point(811, 446);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(427, 39);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Text = "Eliminar usuario ";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 514);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.tboxContacName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.tboxCity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tboxAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tboxContactTitle);
            this.Controls.Add(this.lbContactTitle);
            this.Controls.Add(this.tboxCompanyName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tboxCustomerID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFiltro);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox tbFiltro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox tboxCustomerID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxCompanyName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxContactTitle;
        private System.Windows.Forms.Label lbContactTitle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tboxAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxCity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox tboxContacName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

