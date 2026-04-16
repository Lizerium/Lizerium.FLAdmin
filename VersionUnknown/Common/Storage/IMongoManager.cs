/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

namespace Common.Storage;

using MongoDB.Driver;

public interface IMongoManager
{
	Task<bool> ConnectAsync();
	IMongoDatabase GetDatabase(string database);
	IMongoCollection<T> GetCollection<T>(string collection);
}
