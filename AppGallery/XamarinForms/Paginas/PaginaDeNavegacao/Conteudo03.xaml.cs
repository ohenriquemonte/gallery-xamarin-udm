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
	}
}