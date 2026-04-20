/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models;

public class FreelancerClient
{
    [BsonElement("accountId")] public string AccountId { get; set; }
    [BsonElement("activeCharacter")] public string ActiveCharacter { get; set; }
    [BsonElement("characterId")] public ObjectId CharacterId { get; set; }
    [BsonElement("ipAddress")] public string IPAddress { get; set; }
    [BsonElement("username")] public string? Username { get; set; }
    [BsonElement("admin")] public bool Admin { get; set; }
    [BsonElement("systemId")] public int SystemId { get; set; }
    [BsonElement("shipId")] public int ShipId { get; set; }
    [BsonElement("groupNumber")] public int GroupNumber { get; set; }
}