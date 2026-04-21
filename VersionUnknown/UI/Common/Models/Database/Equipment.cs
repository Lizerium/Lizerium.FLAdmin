/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class Equipment
{
    [BsonElement("equipId")] public long EquipmentId { get; set; }

    [BsonElement("hardPoint")] public required string HardPoint { get; set; }

    [BsonElement("health")] public long Health { get; set; }
}