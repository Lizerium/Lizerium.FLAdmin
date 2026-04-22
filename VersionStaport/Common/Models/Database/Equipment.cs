/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class Equipment
{
    [BsonElement("equipId")] public int EquipmentId { get; set; }

    [BsonElement("hardPoint")] public required string HardPoint { get; set; }

    [BsonElement("health")] public float Health { get; set; }
}