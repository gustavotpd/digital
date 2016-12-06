﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace digital
{
	public partial class SwitchboardButton : ContentView
	{
		public SwitchboardButton()
		{
			InitializeComponent();
		}

		public ImageSource Icon
		{
			get { return SwitchboardIcon.Source; }
			set { SwitchboardIcon.Source = value; }
		}

		public string Label
		{
			get { return SwitchboardLabel.Text; }
			set { SwitchboardLabel.Text = value; }
		}


	}
}
