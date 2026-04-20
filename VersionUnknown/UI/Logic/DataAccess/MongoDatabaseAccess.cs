/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using FlAdmin.Common.Configs;
using FlAdmin.Common.DataAccess;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;

namespace FlAdmin.Logic.DataAccess;

public class MongoDatabaseAccess : IDatabaseAccess
{
    private readonly MongoClient _client;
    private readonly IMongoDatabase _database;
    private readonly ILogger<MongoDatabaseAccess> _logger;

    public MongoDatabaseAccess(FlAdminConfig config, ILogger<MongoDatabaseAccess> logger)
    {
        _client = new MongoClient(config.Mongo.ConnectionString);
        _logger = logger;
        //TODO: Configurable. 
        _database = _client.GetDatabase(config.Mongo.DatabaseName);
    }

    public IMongoCollection<T> GetCollection<T>(string collectionName)
    {
        return _database.GetCollection<T>(collectionName);
    }

    public MongoClient GetClient()
    {
        return _client;
    }
}