using CadastroDeEventos.Models;

namespace CadastroDeEventos
{
    public partial class App : Application
    {
        public List<Salao> lista_salao = new List<Salao>
        {
            new Salao()
            {
                Descricao = "Salão Premium",
                Valor = 200.0
            },

            new Salao()
            {
                Descricao = "Salão Expanded",
                Valor = 100.0
            },

            new Salao()
            {
                Descricao = "Salão Economy",
                Valor = 50.0
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