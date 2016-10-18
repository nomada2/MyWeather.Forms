﻿using NUnit.Framework;

using Xamarin.UITest;

namespace MyWeather.UITests
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class ReplTests : BaseTest
	{
		public ReplTests(Platform platform) : base(platform)
		{
		}

		[Ignore]
		[Test]
		public void ReplTest()
		{
			App.Repl();
		}
	}
}
