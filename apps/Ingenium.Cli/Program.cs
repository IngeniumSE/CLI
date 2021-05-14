// Copyright (c) 2021 Ingenium Software Engineering. All rights reserved.
// This work is licensed under the terms of the MIT license.
// For a copy, see <https://opensource.org/licenses/MIT>.

namespace Ingenium.Cli
{
	using System.Threading.Tasks;

	using Spectre.Console.Cli;

	class Program
	{
		static Task Main(string[] args)
		{
			var app = new CommandApp();

			app.Configure(c =>
			{

			});

			return app.RunAsync(args);
		}
	}
}
