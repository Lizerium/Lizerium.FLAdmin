/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class Equipment
{
    [BsonElement("equipId")] public int EquipmentId { get; set; }

    [BsonElement("hardPoint")] public required string HardPoint { get; set; }

    [BsonElement("health")] public float Health { get; set; }
}