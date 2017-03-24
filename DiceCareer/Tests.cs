﻿using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace DiceCareer
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void FirstTest()
		{
			app.Tap("intro_btn_next");
			app.Tap("intro_btn_skip");

			app.Tap("ll_dashboard_search_main");
			app.Back();

			app.Tap("navigation");
			app.Screenshot("We Tapped on the 'Hamburger Icon' Button");

			app.Tap("Job Search");
			app.ScrollDown();
			app.Back();

			app.Tap("Settings");
			app.Tap("tl_notification");
			app.Tap("tl_loc_service");

			app.Tap("tv_privacy_policy");
			app.ScrollDown();
		}
	}
}
