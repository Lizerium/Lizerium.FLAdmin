/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

namespace FlAdmin.Common.Configs;

public class MongoConfig
{
    public string ConnectionString { get; set; } = "mongodb://localhost";
    public string DatabaseName { get; set; } = "FLHook";
    public string AccountCollectionName { get; set; } = "accounts";
    public string CharacterCollectionName { get; set; } = "characters";

    public string FlAdminLogCollectionName { get; set; } = "fladminlogs";
}