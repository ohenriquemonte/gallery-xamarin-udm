using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Paginas.PaginaDeNavegacao
{
	public partial class Conteudo03 : ContentPage
	{
		public Conteudo03()
		{
			InitializeComponent();
		}

		// Desabilita botão de voltar do dispositivo
		protected override bool OnBackButtonPressed()
		{
			return true;
		}

		void VoltarParaPaginaAnterior(System.Object sender, System.EventArgs e)
		{
			Navigation.PopAsync();
		}

		void VoltarParaOInicio(System.Object sender, System.EventArgs e)
		{
			Navigation.PopToRootAsync();
		}

		void InserirPaginaPilha(System.Object sender, System.EventArgs e)
		{
			//Navigation.InsertPageBefore(
			//	new Conteudo01(),
			//	this // inserir antes da instancia atual
			//);

			Navigation.InsertPageBefore(
				new PaginaInserida(),
				Navigation.NavigationStack[0]
			);
		}

		void RemoverPaginaPilha(System.Object sender, System.EventArgs e)
		{
			Navigation.RemovePage(Navigation.NavigationStack[0]);
		}
	}
}