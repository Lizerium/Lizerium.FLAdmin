/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace FlAdmin.Common.Configs;

public enum LoggingLocation
{
    Console,
    File,
    Aggregator
}

public class LoggingConfig
{
    public LoggingLocation LoggingLocation { get; set; } = LoggingLocation.Console;
    public string LogFilePath { get; set; } = "/logs.txt";
}