/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class NpcVisit
{
    [BsonElement("npcId")] public int NpcId { get; set; }

    [BsonElement("baseId")] public int BaseId { get; set; }

    [BsonElement("interactionCount")] public int InteractionCount { get; set; }

    [BsonElement("missionStatus")] public int MissionStatus { get; set; }
}