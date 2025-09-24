namespace pryChalimondSP2
{
    public partial class frmReserva : Form
    {



        enum Prices
        {
            A = 20,
            B = 34,
            DailyValue = 1,
            TvValue=2,
            KitchenValue=1,


        };
        const  float fridgeValue = 1.50f;

        public frmReserva()
        {
            InitializeComponent();
        }



        private void frmReserva_Load(object sender, EventArgs e)
        
         {
            // cargar los items en el primer control combobox
            lstShackType.Items.Clear();
            lstShackType.Items.Add("Tipo A");
            lstShackType.Items.Add("Tipo B");
            // esta acción provoca el disparo del evento "SelectedIndexChanged"
            lstShackType.SelectedIndex = 0;
                // se inicializa la cantidad de días en 1
                numDays.Text = "1";
                // inicialzar los demás controles de la interfaz
                chkKitchen.Checked = false;
                chkFridge.Checked = false;
                chkTv.Checked = false;
                // en los radiobuttons se asigna sólo el que debe quedar en true
                radioCash.Checked = true;
                txtName.Text = "";
                txtPhone.Text = "";
                // cargar los items del combo de tarjetas
                lstCardList.Items.Clear();
            lstCardList.Items.Add("Card Red");
            lstCardList.Items.Add("Card Green");
            lstCardList.Items.Add("Card Blue");
                // deshabiliar el botón "Aceptar"
                btnSumbit.Enabled = false;
         }

        


    }
}
