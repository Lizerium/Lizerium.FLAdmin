/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
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