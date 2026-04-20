/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using MongoDB.Bson;

namespace FlAdmin.Common.Models;

public class CharacterSummary
{
    public required ObjectId Id { get; set; }
    public required string Name { get; set; }
    public required int Money { get; set; }
    public string AccountId { get; set; }
    public int Base { get; set; }
    public string Rep { get; set; }
}