/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

namespace FlAdmin.Common.Configs;

public class MongoConfig
{
    public string ConnectionString { get; set; } = "mongodb://localhost";
    
    public string DatabaseName { get; set; } = "Freelancer";
    public string AccountCollectionName { get; set; } = "accounts";
    public string CharacterCollectionName { get; set; } = "characters";

    public string FlAdminLogCollectionName { get; set; } = "fladminlogs";
    
    public string JobDatabaseName { get; set; } = "jobs";
}