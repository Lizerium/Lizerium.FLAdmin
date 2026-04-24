/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:11
 * Version: 1.0.183
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