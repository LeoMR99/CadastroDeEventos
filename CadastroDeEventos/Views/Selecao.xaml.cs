using CadastroDeEventos.Models;

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

    private async void finalizar_Clicked(object sender, EventArgs e)
    {
		try
		{

			Calculo c = new Calculo
			{

				TipoSalao = (Salao)pck_salao.SelectedItem,
				QntPessoas = Convert.ToInt32(stp_participantes.Value),
				DataInicio = dtpck_inicio.Date,
				DataTermino = dtpck_termino.Date,

			};

			await Navigation.PushAsync(new Resumo()
			{

				BindingContext = c

			});
				}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "OK");
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