/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
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