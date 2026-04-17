/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

namespace FlAdmin.Common.Models.Payloads;

public struct BanAccountsPayload
{
    public List<PlayerBan> Bans;
}

public struct PlayerBan
{
    public string AccountId;
    public TimeSpan? Duration;
}