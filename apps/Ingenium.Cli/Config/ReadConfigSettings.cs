// Copyright (c) 2021 Ingenium Software Engineering. All rights reserved.
// This work is licensed under the terms of the MIT license.
// For a copy, see <https://opensource.org/licenses/MIT>.

namespace Ingenium.Cli.Config
{
	using Spectre.Console.Cli;

	/// <summary>
	/// Defines settings used to read from the CLI configuration file.
	/// </summary>
	public class ReadConfigSettings : CommandSettings
	{
		[CommandArgument(0, "[PATH]")]
		public string Path { get; set; }
	}
}
