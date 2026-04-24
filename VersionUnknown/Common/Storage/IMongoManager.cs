/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:11
 * Version: 1.0.183
 */

namespace Common.Storage;

using MongoDB.Driver;

public interface IMongoManager
{
	Task<bool> ConnectAsync();
	IMongoDatabase GetDatabase(string database);
	IMongoCollection<T> GetCollection<T>(string collection);
}
