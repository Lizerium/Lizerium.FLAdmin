/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
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