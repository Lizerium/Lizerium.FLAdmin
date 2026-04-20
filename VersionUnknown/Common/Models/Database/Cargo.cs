/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
 */

namespace Common.Models.Database;

using MongoDB.Bson.Serialization.Attributes;

public class Cargo
{
	[BsonElement("cargoId")]
	public long CargoId { get; set; }
	[BsonElement("amount")]
	public long Amount { get; set; }
	[BsonElement("health")]
	public long Health { get; set; }
	[BsonElement("isMissionCargo")]
	public bool IsMissionCargo { get; set; }
}
