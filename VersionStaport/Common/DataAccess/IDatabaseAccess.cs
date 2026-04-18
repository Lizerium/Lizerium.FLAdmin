/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

using FlAdmin.Common.Models;
using FlAdmin.Common.Models.Error;
using LanguageExt;
using MongoDB.Bson;
using MongoDB.Driver;

namespace FlAdmin.Common.DataAccess;

public interface IDatabaseAccess
{
    IMongoCollection<T> GetCollection<T>(string collectionName);

    MongoClient GetClient();

    Task<Either<ErrorResult, Guid>> StartSession();

    Task<Option<ErrorResult>> EndSession(bool commit);

    Task<Either<ErrorResult, BsonDocument>> SubmitQuery(BsonDocument query, Guid sessionId);
}