/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class Cargo
{
    [BsonElement("cargoId")] public int CargoId { get; set; }

    [BsonElement("amount")] public int Amount { get; set; }

    [BsonElement("health")] public int Health { get; set; }

    [BsonElement("isMissionCargo")] public bool IsMissionCargo { get; set; }
}