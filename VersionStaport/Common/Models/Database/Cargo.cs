/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
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