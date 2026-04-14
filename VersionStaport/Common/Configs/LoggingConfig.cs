/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
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