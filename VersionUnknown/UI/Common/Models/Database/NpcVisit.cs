/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
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