namespace pryChalimondSP2
{
    partial class frmReserva
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReserva));
            cmbTipo = new ComboBox();
            cmbPersonas = new ComboBox();
            chkCocina = new CheckBox();
            chkHeladera = new CheckBox();
            chkTelevisor = new CheckBox();
            optEfectivo = new RadioButton();
            optTarjeta = new RadioButton();
            txtNombre = new TextBox();
            txtTelefonos = new TextBox();
            btnAceptar = new Button();
            lblPeople = new Label();
            lblDays = new Label();
            lblPaymentTypes = new Label();
            cmbTarjeta = new ComboBox();
            lblCreditCards = new Label();
            lblName = new Label();
            lblTitular = new Label();
            lblPhone = new Label();
            lblAditional = new Label();
            lblType = new Label();
            pnlShackType = new Panel();
            txtDias = new TextBox();
            tagShackType = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            pnlShackType.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { resources.GetString("cmbTipo.Items"), resources.GetString("cmbTipo.Items1") });
            resources.ApplyResources(cmbTipo, "cmbTipo");
            cmbTipo.Name = "cmbTipo";
            cmbTipo.SelectedIndexChanged += cmbTipo_SelectedIndexChanged;
            // 
            // cmbPersonas
            // 
            cmbPersonas.FormattingEnabled = true;
            resources.ApplyResources(cmbPersonas, "cmbPersonas");
            cmbPersonas.Name = "cmbPersonas";
            // 
            // chkCocina
            // 
            resources.ApplyResources(chkCocina, "chkCocina");
            chkCocina.Name = "chkCocina";
            chkCocina.UseVisualStyleBackColor = true;
            // 
            // chkHeladera
            // 
            resources.ApplyResources(chkHeladera, "chkHeladera");
            chkHeladera.Name = "chkHeladera";
            chkHeladera.UseVisualStyleBackColor = true;
            // 
            // chkTelevisor
            // 
            resources.ApplyResources(chkTelevisor, "chkTelevisor");
            chkTelevisor.Name = "chkTelevisor";
            chkTelevisor.UseVisualStyleBackColor = true;
            // 
            // optEfectivo
            // 
            resources.ApplyResources(optEfectivo, "optEfectivo");
            optEfectivo.Name = "optEfectivo";
            optEfectivo.TabStop = true;
            optEfectivo.UseVisualStyleBackColor = true;
            optEfectivo.CheckedChanged += optEfectivo_CheckedChanged;
            // 
            // optTarjeta
            // 
            resources.ApplyResources(optTarjeta, "optTarjeta");
            optTarjeta.Name = "optTarjeta";
            optTarjeta.TabStop = true;
            optTarjeta.UseVisualStyleBackColor = true;
            optTarjeta.CheckedChanged += optTarjeta_CheckedChanged;
            // 
            // txtNombre
            // 
            resources.ApplyResources(txtNombre, "txtNombre");
            txtNombre.Name = "txtNombre";
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // txtTelefonos
            // 
            resources.ApplyResources(txtTelefonos, "txtTelefonos");
            txtTelefonos.Name = "txtTelefonos";
            txtTelefonos.TextChanged += txtTelefonos_TextChanged;
            // 
            // btnAceptar
            // 
            resources.ApplyResources(btnAceptar, "btnAceptar");
            btnAceptar.Name = "btnAceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // lblPeople
            // 
            resources.ApplyResources(lblPeople, "lblPeople");
            lblPeople.Name = "lblPeople";
            // 
            // lblDays
            // 
            resources.ApplyResources(lblDays, "lblDays");
            lblDays.Name = "lblDays";
            // 
            // lblPaymentTypes
            // 
            resources.ApplyResources(lblPaymentTypes, "lblPaymentTypes");
            lblPaymentTypes.Name = "lblPaymentTypes";
            // 
            // cmbTarjeta
            // 
            cmbTarjeta.FormattingEnabled = true;
            resources.ApplyResources(cmbTarjeta, "cmbTarjeta");
            cmbTarjeta.Name = "cmbTarjeta";
            // 
            // lblCreditCards
            // 
            resources.ApplyResources(lblCreditCards, "lblCreditCards");
            lblCreditCards.Name = "lblCreditCards";
            // 
            // lblName
            // 
            resources.ApplyResources(lblName, "lblName");
            lblName.Name = "lblName";
            // 
            // lblTitular
            // 
            resources.ApplyResources(lblTitular, "lblTitular");
            lblTitular.Name = "lblTitular";
            // 
            // lblPhone
            // 
            resources.ApplyResources(lblPhone, "lblPhone");
            lblPhone.Name = "lblPhone";
            // 
            // lblAditional
            // 
            resources.ApplyResources(lblAditional, "lblAditional");
            lblAditional.Name = "lblAditional";
            // 
            // lblType
            // 
            resources.ApplyResources(lblType, "lblType");
            lblType.Name = "lblType";
            // 
            // pnlShackType
            // 
            pnlShackType.Controls.Add(txtDias);
            pnlShackType.Controls.Add(lblType);
            pnlShackType.Controls.Add(lblDays);
            pnlShackType.Controls.Add(lblPeople);
            pnlShackType.Controls.Add(cmbPersonas);
            pnlShackType.Controls.Add(cmbTipo);
            resources.ApplyResources(pnlShackType, "pnlShackType");
            pnlShackType.Name = "pnlShackType";
            pnlShackType.Tag = "";
            // 
            // txtDias
            // 
            resources.ApplyResources(txtDias, "txtDias");
            txtDias.Name = "txtDias";
            txtDias.TextChanged += txtDias_TextChanged;
            // 
            // tagShackType
            // 
            resources.ApplyResources(tagShackType, "tagShackType");
            tagShackType.Name = "tagShackType";
            // 
            // panel1
            // 
            panel1.Controls.Add(chkTelevisor);
            panel1.Controls.Add(chkHeladera);
            panel1.Controls.Add(chkCocina);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCreditCards);
            panel2.Controls.Add(cmbTarjeta);
            panel2.Controls.Add(optTarjeta);
            panel2.Controls.Add(optEfectivo);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPhone);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(txtTelefonos);
            panel3.Controls.Add(txtNombre);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // frmReserva
            // 
            AcceptButton = btnAceptar;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(tagShackType);
            Controls.Add(pnlShackType);
            Controls.Add(lblAditional);
            Controls.Add(lblTitular);
            Controls.Add(lblPaymentTypes);
            Controls.Add(btnAceptar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmReserva";
            Load += frmReserva_Load;
            pnlShackType.ResumeLayout(false);
            pnlShackType.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbTipo;
        private ComboBox cmbPersonas;
        private CheckBox chkCocina;
        private CheckBox chkHeladera;
        private CheckBox chkTelevisor;
        private RadioButton optEfectivo;
        private RadioButton optTarjeta;
        private ComboBox comboBox3;
        private TextBox txtNombre;
        private TextBox txtTelefonos;
        private Button btnAceptar;
        private Label tagShackType;
        private Label lblPeople;
        private Label lblDays;
        private Label label4;
        private Label lblPaymentTypes;
        private ComboBox cmbTarjeta;
        private Label lblCreditCards;
        private Label lblName;
        private Label lblTitular;
        private Label lblPhone;
        private Label lblAditional;
        private Label lblType;
        private Panel pnlShackType;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtDias;
    }
}
