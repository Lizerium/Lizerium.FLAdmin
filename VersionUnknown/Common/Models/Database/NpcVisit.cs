/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:12
 * Version: 1.0.173
 */

namespace Common.Models.Database;

using MongoDB.Bson.Serialization.Attributes;

public class NpcVisit
{
	[BsonElement("npcId")]
	public long NpcId { get; set; }
	[BsonElement("baseId")]
	public long BaseId { get; set; }
	[BsonElement("interactionCount")]
	public int InteractionCount { get; set; }
	[BsonElement("missionStatus")]
	public int MissionStatus { get; set; }
}
