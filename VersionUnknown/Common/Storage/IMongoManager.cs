/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

namespace Common.Storage;

using MongoDB.Driver;

public interface IMongoManager
{
	Task<bool> ConnectAsync();
	IMongoDatabase GetDatabase(string database);
	IMongoCollection<T> GetCollection<T>(string collection);
}
