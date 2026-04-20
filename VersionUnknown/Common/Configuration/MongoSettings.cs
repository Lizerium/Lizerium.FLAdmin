/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
 */

namespace Common.Configuration;

public class MongoSettings
{
	public string ConnectionString { get; set; } = "mongodb://localhost:27017/";
	public string Host { get; set; } = "localhost";
	public int Port { get; set; } = 27017;
	public string Username { get; set; } = string.Empty;
	public string Password { get; set; } = string.Empty;
	public string AuthDatabase { get; set; } = string.Empty;
	public string PrimaryDatabaseName { get; set; } = "FLHook";
	public string AccountCollectionName { get; set; } = "accounts";
	public string JobCollection { get; set; } = "jobs";
	public string JobGroupCollection { get; set; } = "jobGroups";
}
