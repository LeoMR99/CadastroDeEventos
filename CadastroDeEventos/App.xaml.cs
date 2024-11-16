using CadastroDeEventos.Models;

namespace CadastroDeEventos
{
    public partial class App : Application
    {
        public List<Salao> lista_salao = new List<Salao>
        {
            new Salao()
            {
                Descricao = "Salao Premium",
                Valor = 2000.0
            },

            new Salao()
            {
                Descricao = "Salao Expanded",
                Valor = 1000.0
            },

            new Salao()
            {
                Descricao = "Salao Economy",
                Valor = 500.0
            },
        };
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.Selecao());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 400;
            window.Height = 600;

            return window;
        }
    }
}