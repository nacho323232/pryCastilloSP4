namespace pryCastilloSP4
{
    partial class frmPrincipal
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
            dgvDatos = new DataGridView();
            colComida = new DataGridViewTextBoxColumn();
            colBebidaNo = new DataGridViewTextBoxColumn();
            colBebida = new DataGridViewTextBoxColumn();
            colPostres = new DataGridViewTextBoxColumn();
            btnValidarDatos = new Button();
            btnMozo = new Button();
            btnTotal = new Button();
            btnCerrar = new Button();
            lblMozo = new Label();
            lblTotal = new Label();
            lstTotales = new ListBox();
            txtNombreMozo = new TextBox();
            txtImporteMozo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colComida, colBebidaNo, colBebida, colPostres });
            dgvDatos.Location = new Point(30, 21);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.Size = new Size(689, 203);
            dgvDatos.TabIndex = 0;
            // 
            // colComida
            // 
            colComida.HeaderText = "Comida";
            colComida.Name = "colComida";
            // 
            // colBebidaNo
            // 
            colBebidaNo.HeaderText = "Bebida sin alchol";
            colBebidaNo.Name = "colBebidaNo";
            // 
            // colBebida
            // 
            colBebida.HeaderText = "Bebida Con Alcohol";
            colBebida.Name = "colBebida";
            // 
            // colPostres
            // 
            colPostres.HeaderText = "Postres";
            colPostres.Name = "colPostres";
            // 
            // btnValidarDatos
            // 
            btnValidarDatos.Font = new Font("Segoe UI", 10F);
            btnValidarDatos.Location = new Point(468, 366);
            btnValidarDatos.Name = "btnValidarDatos";
            btnValidarDatos.Size = new Size(116, 32);
            btnValidarDatos.TabIndex = 1;
            btnValidarDatos.Text = "Validar Datos";
            btnValidarDatos.UseVisualStyleBackColor = true;
            btnValidarDatos.Click += btnValidarDatos_Click;
            // 
            // btnMozo
            // 
            btnMozo.Font = new Font("Segoe UI", 10F);
            btnMozo.Location = new Point(603, 366);
            btnMozo.Name = "btnMozo";
            btnMozo.Size = new Size(116, 32);
            btnMozo.TabIndex = 2;
            btnMozo.Text = "Mozo del dia";
            btnMozo.UseVisualStyleBackColor = true;
            btnMozo.Click += btnMozo_Click;
            // 
            // btnTotal
            // 
            btnTotal.Font = new Font("Segoe UI", 10F);
            btnTotal.Location = new Point(468, 406);
            btnTotal.Name = "btnTotal";
            btnTotal.Size = new Size(116, 32);
            btnTotal.TabIndex = 3;
            btnTotal.Text = "Totales";
            btnTotal.UseVisualStyleBackColor = true;
            btnTotal.Click += btnTotal_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.Location = new Point(603, 406);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(116, 32);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // lblMozo
            // 
            lblMozo.AutoSize = true;
            lblMozo.Font = new Font("Segoe UI", 10F);
            lblMozo.Location = new Point(30, 289);
            lblMozo.Name = "lblMozo";
            lblMozo.Size = new Size(88, 19);
            lblMozo.TabIndex = 5;
            lblMozo.Text = "Mozo del dia";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F);
            lblTotal.Location = new Point(30, 366);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(89, 19);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total General";
            // 
            // lstTotales
            // 
            lstTotales.Font = new Font("Segoe UI", 10F);
            lstTotales.FormattingEnabled = true;
            lstTotales.ItemHeight = 17;
            lstTotales.Location = new Point(125, 366);
            lstTotales.Name = "lstTotales";
            lstTotales.Size = new Size(312, 55);
            lstTotales.TabIndex = 7;
            lstTotales.SelectedIndexChanged += lstTotales_SelectedIndexChanged;
            // 
            // txtNombreMozo
            // 
            txtNombreMozo.Font = new Font("Segoe UI", 10F);
            txtNombreMozo.Location = new Point(158, 289);
            txtNombreMozo.Name = "txtNombreMozo";
            txtNombreMozo.Size = new Size(213, 25);
            txtNombreMozo.TabIndex = 8;
            // 
            // txtImporteMozo
            // 
            txtImporteMozo.Font = new Font("Segoe UI", 10F);
            txtImporteMozo.Location = new Point(406, 289);
            txtImporteMozo.Name = "txtImporteMozo";
            txtImporteMozo.Size = new Size(213, 25);
            txtImporteMozo.TabIndex = 9;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 465);
            Controls.Add(txtImporteMozo);
            Controls.Add(txtNombreMozo);
            Controls.Add(lstTotales);
            Controls.Add(lblTotal);
            Controls.Add(lblMozo);
            Controls.Add(btnCerrar);
            Controls.Add(btnTotal);
            Controls.Add(btnMozo);
            Controls.Add(btnValidarDatos);
            Controls.Add(dgvDatos);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvDatos;
        private Button btnValidarDatos;
        private Button btnMozo;
        private Button btnTotal;
        private Button btnCerrar;
        private Label lblMozo;
        private Label lblTotal;
        private ListBox lstTotales;
        private TextBox txtNombreMozo;
        private TextBox txtImporteMozo;
        private DataGridViewTextBoxColumn colComida;
        private DataGridViewTextBoxColumn colBebidaNo;
        private DataGridViewTextBoxColumn colBebida;
        private DataGridViewTextBoxColumn colPostres;
    }
}