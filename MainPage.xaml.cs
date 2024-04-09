namespace jcordovat1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            double salario = Convert.ToDouble(txtSalario.Text);
            double aporte_iess = Math.Round((salario*0.0945),2);

            DisplayAlert("Bienvenido," + nombre + " " + apellido, "\nTienes: " + edad + " años" + "\nTu aporte al iess es de: $" + aporte_iess, "Aceptar");
        }
    }

}
