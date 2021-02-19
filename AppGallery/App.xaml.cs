using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppGallery
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			//var pagina = new NavigationPage(
			//	new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01()
			//);

			// var pagina = new XamarinForms.Paginas.Modal.Conteudo01();

			//var pagina = new CarouselPage();
			//pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo01());
			//pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo02());
			//pagina.Children.Add(new XamarinForms.Paginas.PaginaDeCarrossel.Conteudo03());

			//pagina.CurrentPage = pagina.Children[1] - Caso queira iniciar com uma página diferente da primeira adicionada

			//var pagina = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();

			//var pagina = new XamarinForms.Paginas.PaginaDeAbas.Abas();

			//var pagina = new MasterDetailPage(); // obsoleta
			//var pagina = new FlyoutPage(); // mais recente v5.0.0

			var pagina = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();

			MainPage = pagina;
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}