using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.AppBase
{
	public partial class Menu : MasterDetailPage
	{
		public Menu()
		{
			InitializeComponent();
		}

		void AbrirContentPage(System.Object sender, System.EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeConteudo.Conteudo01();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		void AbrirNavigationPage(System.Object sender, System.EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new NavigationPage(new XamarinForms.Paginas.PaginaDeNavegacao.Conteudo01());
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		void AbrirTabbedPage(System.Object sender, System.EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeAbas.Abas();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		void AbrirCarouselPage(System.Object sender, System.EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeCarrossel.Carrossel();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		void AbrirMasterDetailPage(System.Object sender, System.EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.PaginaDeMenuLateral.MenuLateral();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}

		void AbrirPaginaModal(System.Object sender, System.EventArgs e)
		{
			((MasterDetailPage)App.Current.MainPage).Detail = new XamarinForms.Paginas.Modal.Conteudo01();
			((MasterDetailPage)App.Current.MainPage).IsPresented = false;
		}
	}
}