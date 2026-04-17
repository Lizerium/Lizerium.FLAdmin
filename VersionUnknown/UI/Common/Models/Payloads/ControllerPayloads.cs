/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

namespace FlAdmin.Common.Models.Payloads;

public record RolePayload
{
    public required string AccountId { get; set; }
    public required string[] Roles { get; set; }
}