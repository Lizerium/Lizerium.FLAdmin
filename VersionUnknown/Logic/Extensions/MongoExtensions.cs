/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

namespace Logic.Extensions;

using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Driver;

public static class MongoExtensions
{
	public static BsonDocument RenderToBsonDocument<T>(this FilterDefinition<T> filter)
	{
		var serializerRegistry = BsonSerializer.SerializerRegistry;
		var documentSerializer = serializerRegistry.GetSerializer<T>();
		return filter.Render(documentSerializer, serializerRegistry);
	}
}
