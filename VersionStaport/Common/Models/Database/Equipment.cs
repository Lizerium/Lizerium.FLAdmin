/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class Equipment
{
    [BsonElement("equipId")] public int EquipmentId { get; set; }

    [BsonElement("hardPoint")] public required string HardPoint { get; set; }

    [BsonElement("health")] public float Health { get; set; }
}