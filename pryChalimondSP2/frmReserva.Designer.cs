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
            lstShackType = new ComboBox();
            lstQuantity = new ComboBox();
            numDays = new NumericUpDown();
            chkKitchen = new CheckBox();
            chkFridge = new CheckBox();
            chkTv = new CheckBox();
            radioCash = new RadioButton();
            radioCard = new RadioButton();
            txtName = new TextBox();
            txtPhone = new TextBox();
            btnSumbit = new Button();
            lblPeople = new Label();
            lblDays = new Label();
            lblPaymentTypes = new Label();
            lstCardList = new ComboBox();
            lblCreditCards = new Label();
            lblName = new Label();
            lblTitular = new Label();
            lblPhone = new Label();
            lblAditional = new Label();
            lblType = new Label();
            pnlShackType = new Panel();
            tagShackType = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)numDays).BeginInit();
            pnlShackType.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lstShackType
            // 
            lstShackType.FormattingEnabled = true;
            lstShackType.Items.AddRange(new object[] { resources.GetString("lstShackType.Items"), resources.GetString("lstShackType.Items1") });
            resources.ApplyResources(lstShackType, "lstShackType");
            lstShackType.Name = "lstShackType";
            // 
            // lstQuantity
            // 
            lstQuantity.FormattingEnabled = true;
            resources.ApplyResources(lstQuantity, "lstQuantity");
            lstQuantity.Name = "lstQuantity";
            // 
            // numDays
            // 
            resources.ApplyResources(numDays, "numDays");
            numDays.Name = "numDays";
            // 
            // chkKitchen
            // 
            resources.ApplyResources(chkKitchen, "chkKitchen");
            chkKitchen.Name = "chkKitchen";
            chkKitchen.UseVisualStyleBackColor = true;
            // 
            // chkFridge
            // 
            resources.ApplyResources(chkFridge, "chkFridge");
            chkFridge.Name = "chkFridge";
            chkFridge.UseVisualStyleBackColor = true;
            // 
            // chkTv
            // 
            resources.ApplyResources(chkTv, "chkTv");
            chkTv.Name = "chkTv";
            chkTv.UseVisualStyleBackColor = true;
            // 
            // radioCash
            // 
            resources.ApplyResources(radioCash, "radioCash");
            radioCash.Name = "radioCash";
            radioCash.TabStop = true;
            radioCash.UseVisualStyleBackColor = true;
            // 
            // radioCard
            // 
            resources.ApplyResources(radioCard, "radioCard");
            radioCard.Name = "radioCard";
            radioCard.TabStop = true;
            radioCard.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            resources.ApplyResources(txtName, "txtName");
            txtName.Name = "txtName";
            // 
            // txtPhone
            // 
            resources.ApplyResources(txtPhone, "txtPhone");
            txtPhone.Name = "txtPhone";
            // 
            // btnSumbit
            // 
            resources.ApplyResources(btnSumbit, "btnSumbit");
            btnSumbit.Name = "btnSumbit";
            btnSumbit.UseVisualStyleBackColor = true;
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
            // lstCardList
            // 
            lstCardList.FormattingEnabled = true;
            resources.ApplyResources(lstCardList, "lstCardList");
            lstCardList.Name = "lstCardList";
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
            pnlShackType.Controls.Add(lblType);
            pnlShackType.Controls.Add(lblDays);
            pnlShackType.Controls.Add(lblPeople);
            pnlShackType.Controls.Add(numDays);
            pnlShackType.Controls.Add(lstQuantity);
            pnlShackType.Controls.Add(lstShackType);
            resources.ApplyResources(pnlShackType, "pnlShackType");
            pnlShackType.Name = "pnlShackType";
            pnlShackType.Tag = "";
            // 
            // tagShackType
            // 
            resources.ApplyResources(tagShackType, "tagShackType");
            tagShackType.Name = "tagShackType";
            // 
            // panel1
            // 
            panel1.Controls.Add(chkTv);
            panel1.Controls.Add(chkFridge);
            panel1.Controls.Add(chkKitchen);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // panel2
            // 
            panel2.Controls.Add(lblCreditCards);
            panel2.Controls.Add(lstCardList);
            panel2.Controls.Add(radioCard);
            panel2.Controls.Add(radioCash);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // panel3
            // 
            panel3.Controls.Add(lblPhone);
            panel3.Controls.Add(lblName);
            panel3.Controls.Add(txtPhone);
            panel3.Controls.Add(txtName);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // frmReserva
            // 
            AcceptButton = btnSumbit;
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
            Controls.Add(btnSumbit);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmReserva";
            Load += frmReserva_Load;
            ((System.ComponentModel.ISupportInitialize)numDays).EndInit();
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

        private ComboBox lstShackType;
        private ComboBox lstQuantity;
        private NumericUpDown numDays;
        private CheckBox chkKitchen;
        private CheckBox chkFridge;
        private CheckBox chkTv;
        private RadioButton radioCash;
        private RadioButton radioCard;
        private ComboBox comboBox3;
        private TextBox txtName;
        private TextBox txtPhone;
        private Button btnSumbit;
        private Label tagShackType;
        private Label lblPeople;
        private Label lblDays;
        private Label label4;
        private Label lblPaymentTypes;
        private ComboBox lstCardList;
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
    }
}
