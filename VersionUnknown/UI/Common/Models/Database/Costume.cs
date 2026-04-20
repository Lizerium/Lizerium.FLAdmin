/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class Costume
{
    [BsonElement("body")] public long Body { get; set; }

    [BsonElement("head")] public long Head { get; set; }

    [BsonElement("leftHand")] public long LeftHand { get; set; }

    [BsonElement("rightHand")] public long RightHand { get; set; }
}