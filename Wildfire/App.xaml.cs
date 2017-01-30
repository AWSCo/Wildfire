﻿using Xamarin.Forms;

namespace Wildfire
{
	public partial class App : Application
	{
		public App()
		{
			//I am a comment
			InitializeComponent();

			MainPage = new WildfirePage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
