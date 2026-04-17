/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class Cargo
{
    [BsonElement("cargoId")] public long CargoId { get; set; }

    [BsonElement("amount")] public long Amount { get; set; }

    [BsonElement("health")] public long Health { get; set; }

    [BsonElement("isMissionCargo")] public bool IsMissionCargo { get; set; }
}