namespace mperugachiExamen.Vistas;

public partial class vLogin : ContentPage
{
    List<string> usuarios = new List<string>()
    {
        "estudiante2024:uisrael2024",
        "examen1:parcial1",
        "Mario:2024",
    };
    public vLogin()
	{
		InitializeComponent();
	}
    public vLogin(string usuario, string contrase�a)
    {
        InitializeComponent();
        //usuario1 = usuario;
        //contrase�a1 = contrase�a;
    }
    private void btnInicio_Clicked(object sender, EventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrase�a = txtContrase�a.Text;

        bool credencialesValidas = false;
        foreach (string user in usuarios)
        {
            string[] credenciales = user.Split(':');
            if (credenciales[0] == usuario && credenciales[1] == contrase�a)
            {
                credencialesValidas = true;
                break;
            }
        }


        if (credencialesValidas)
        {
            Navigation.PushAsync(new vRegistro(usuario));
        }
        else
        {
            DisplayAlert("Alerta", "Usuario / Contrase�a incorrectos", "Cerrar");
        }
    }

    private void btnAcerca_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new vAcerca());
    }
}