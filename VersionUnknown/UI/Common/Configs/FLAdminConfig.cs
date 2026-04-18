/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace FlAdmin.Common.Configs;

public class FlAdminConfig
{
    public MongoConfig Mongo { get; set; } = new();
    public AuthenticationConfig Authentication { get; set; } = new();
    public ServerConfig Server { get; set; } = new();
    public LoggingConfig Logging { get; set; } = new();

    public FlHookConfig FlHook { get; set; } = new();

    public string SuperAdminName { get; set; } = "SuperAdmin";

    public int MaxCharactersPerAccount { get; set; } = 5;
}