/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:11
 * Version: 1.0.183
 */

namespace Common.Configuration;

public class LoggingSettings
{
	public bool EnableDebugLogs { get; set; }
	// ReSharper disable twice InconsistentNaming
	public string? LogFileFLHook { get; set; }
	public string? LogFileFLAdmin { get; set; }
	public FluentDOptions FluentDOptions { get; set; } = new();
}

public class FluentDOptions
{
	public bool Enable { get; set; }
	public int Port { get; set; } = 24224;
	public string? Host { get; set; } = "localhost";
	public string? UnixSocket { get; set; }
}
