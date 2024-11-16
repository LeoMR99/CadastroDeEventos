namespace CadastroDeEventos.Views;

public partial class Selecao : ContentPage
{
	App PropriedadesApp;

	public Selecao()
	{
        InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_salao.ItemsSource = PropriedadesApp.lista_salao;

		dtpck_inicio.MinimumDate = DateTime.Now;
		dtpck_inicio.MaximumDate = new DateTime(DateTime.Now.Year + 1, DateTime.Now.Month - 7, DateTime.Now.Day);

		dtpck_termino.MinimumDate = dtpck_inicio.Date.AddDays(1);
		dtpck_termino.MaximumDate = dtpck_inicio.Date.AddMonths(7);
		    }

    private void finalizar_Clicked(object sender, EventArgs e)
    {
		try
		{
			Navigation.PushAsync(new Resumo());
				}
		catch (Exception ex)
		{
			DisplayAlert("Ops", ex.Message, "OK");
		}
    }

    private void dtpck_inicio_DateSelected(object sender, DateChangedEventArgs e)
    {
		DatePicker elemento = sender as DatePicker;

		DateTime data_selecionada_inicio = elemento.Date;

		dtpck_termino.MinimumDate = data_selecionada_inicio.AddDays(1);
		dtpck_termino.MaximumDate = data_selecionada_inicio.AddMonths(7);
    }
}