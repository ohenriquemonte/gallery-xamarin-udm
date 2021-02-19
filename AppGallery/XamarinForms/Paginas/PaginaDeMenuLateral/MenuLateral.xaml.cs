using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Paginas.PaginaDeMenuLateral
{
	public partial class MenuLateral : MasterDetailPage
	{
		public MenuLateral()
		{
			InitializeComponent();
		}

		void AbrirPagina01(System.Object sender, System.EventArgs e)
		{
			//Detail = new Conteudo01(); // sem barra de navegacao
			Detail = new NavigationPage(new Conteudo01()); // com barra de navegacao
			IsPresented = false; // fechar menu lateral
		}

		void AbrirPagina02(System.Object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Conteudo02());
			IsPresented = false;
		}

		void AbrirPagina03(System.Object sender, System.EventArgs e)
		{
			Detail = new NavigationPage(new Conteudo03());
			IsPresented = false;
		}
	}
}