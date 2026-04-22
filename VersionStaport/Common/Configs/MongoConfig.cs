/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
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