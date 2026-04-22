/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

using MongoDB.Bson.Serialization.Attributes;

namespace FlAdmin.Common.Models.Database;

public class Costume
{
    [BsonElement("body")] public int Body { get; set; }

    [BsonElement("head")] public int Head { get; set; }

    [BsonElement("leftHand")] public int LeftHand { get; set; }

    [BsonElement("rightHand")] public int RightHand { get; set; }
    
    [BsonElement("accessories")]
    public List<int> Accessories { get; set; } = [];
}