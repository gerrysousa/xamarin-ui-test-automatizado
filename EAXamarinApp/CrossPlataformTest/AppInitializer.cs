﻿using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CrossPlataformTest
{
	public class AppInitializer
	{
		public static IApp StartApp(Platform platform)
		{
			if (platform == Platform.Android)
			{

                return ConfigureApp
                    .Android
                    .InstalledApp("com.companyname.EAXamarinApp")
                    .StartApp();
			}

			return ConfigureApp.iOS.StartApp();
		}
	}
}