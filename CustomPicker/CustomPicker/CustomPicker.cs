using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomPicker
{
    public class CustomPicker:Picker
    {
		//addded attached property image
		public static readonly BindableProperty ImageProperty =
			BindableProperty.Create(nameof(Image), typeof(string), typeof(CustomPicker), string.Empty);
		public string Image
		{
			get { return (string)GetValue(ImageProperty); }
			set { SetValue(ImageProperty, value); }
		}
	}
}
