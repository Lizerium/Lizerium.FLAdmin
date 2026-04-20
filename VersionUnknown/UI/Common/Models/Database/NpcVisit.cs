/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class NpcVisit
{
    [BsonElement("npcId")] public long NpcId { get; set; }

    [BsonElement("baseId")] public long BaseId { get; set; }

    [BsonElement("interactionCount")] public int InteractionCount { get; set; }

    [BsonElement("missionStatus")] public int MissionStatus { get; set; }
}