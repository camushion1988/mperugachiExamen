namespace mperugachiExamen.Vistas;

public partial class vRegistro : ContentPage
{
    private const double vCurso = 1500;
	public vRegistro(string usuario)
	{
		InitializeComponent();
        DisplayAlert("Alerta", "Bienvenido " + usuario, "Cerrar");
        lblUsuario.Text = "Usuario conectado: " + usuario;
    }

    private void btnCalcular_Clicked(object sender, EventArgs e)
    {
        double mIni = double.Parse(txtMIni.Text);
        double mDif = vCurso - mIni;
        double pMensual = (mDif + (mDif * 0.04)) / 4;
        lblPago.Text = "$" + pMensual.ToString("F2");
    }

    private void btnResumen_Clicked(object sender, EventArgs e)
    {
        string nombre = txtNombre.Text;
        
    }
}