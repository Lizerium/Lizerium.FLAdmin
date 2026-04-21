/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
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
