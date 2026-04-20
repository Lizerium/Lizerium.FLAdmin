/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models;

public class OnlinePlayer
{
    [BsonElement("clientId")] public int ClientId { get; set; }
    [BsonElement("playerName")] public int PlayerName { get; set; }
    [BsonElement("systemName")] public required string SystemName { get; set; }
    [BsonElement("systemNick")] public required string SystemNick { get; set; }
    [BsonElement("ipAddress")] public int IpAddress { get; set; }
}

public class OnlinePlayerPayload
{
    [BsonElement("players")] public required List<OnlinePlayer> OnlinePlayers { get; set; }
    [BsonElement("memUsage")] private long MemoryUsage { get; set; }
    [BsonElement("npcsEnabled")] private bool NpcsEnabled { get; set; }
}