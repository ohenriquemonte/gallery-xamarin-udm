using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Paginas.Modal
{
	public partial class PaginaDeModal : ContentPage
	{
		public PaginaDeModal()
		{
			InitializeComponent();
		}

		void FecharModal(System.Object sender, System.EventArgs e)
		{
			Navigation.PopModalAsync();
		}
	}
}
