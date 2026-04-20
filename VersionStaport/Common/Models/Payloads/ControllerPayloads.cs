/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using MongoDB.Bson;

namespace FlAdmin.Common.Models.Payloads;

public record RolePayload
{
    public required string AccountId { get; set; }
    public required string[] Roles { get; set; }
}

public record CommandPayload
{
    public required BsonDocument Command { get; set; }
    public required Guid SessionId { get; set; }
}