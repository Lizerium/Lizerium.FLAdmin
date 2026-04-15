/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:12
 * Version: 1.0.173
 */

namespace FlAdmin.Common.Configs;

public class ServerConfig
{
    public string FreelancerPath { get; set; } =
        Environment.GetEnvironmentVariable("FL_PATH") ?? string.Empty;

    public int Port { get; set; } = 5577;

    public string LaunchArgs { get; set; } = "";

    public bool AutoStart { get; set; } = true;
}