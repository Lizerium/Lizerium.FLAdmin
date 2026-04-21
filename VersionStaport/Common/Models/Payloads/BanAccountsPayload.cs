/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
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