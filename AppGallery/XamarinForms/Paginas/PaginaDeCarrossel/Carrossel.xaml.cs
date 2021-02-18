using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppGallery.XamarinForms.Paginas.PaginaDeCarrossel
{
	public partial class Carrossel : CarouselPage
	{
		public Carrossel()
		{
			InitializeComponent();

			// para setar a pagina que será exibida primeiro no carrossel
			CurrentPage = Children[1];
		}
	}
}