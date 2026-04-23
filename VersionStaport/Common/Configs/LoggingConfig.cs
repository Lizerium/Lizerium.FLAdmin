/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
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