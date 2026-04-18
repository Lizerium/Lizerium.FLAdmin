/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace Common.Configuration;

public class FLServerSettings
{
	public int Port { get; set; } = 2302;
	public bool AutoStartFLServer { get; set; } = true;
	public string FreelancerPath { get; set; } = string.Empty;
	public string LaunchArgs { get; set; } = string.Empty;
	public bool UseFLHook { get; set; } = true;
	public bool CheckForFLHookUpdates { get; set; } = true;
	public bool AutoDownloadLatestFLHook { get; set; } = true;
	public string FLHookRepositry { get; set; } = "https://github.com/TheStarport/FLHook";
}
