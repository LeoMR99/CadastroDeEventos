namespace CadastroDeEventos.Views;

public partial class Resumo : ContentPage
{
	public Resumo()
	{
		InitializeComponent();
	}

    private void corrigir_Clicked(object sender, EventArgs e)
    {
        try
        {
            Navigation.PopAsync();

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }

    private void confirmar_Clicked(object sender, EventArgs e)
    {
        try
        {
            string msg = "";
            msg = "Seu Cadastro de Evento Foi Concluído";

            DisplayAlert("Status de Cadastro", msg, "OK");

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}