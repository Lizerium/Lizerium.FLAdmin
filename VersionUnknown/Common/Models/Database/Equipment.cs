/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

namespace Common.Models.Database;

using MongoDB.Bson.Serialization.Attributes;

public class Equipment
{
	[BsonElement("equipId")]
	public long EquipmentId { get; set; }
	[BsonElement("hardPoint")]
	public required string HardPoint { get; set; }
	[BsonElement("health")]
	public long Health { get; set; }
}
