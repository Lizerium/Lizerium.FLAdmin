/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

namespace FlAdmin.Common.Models.Auth;

public class LoginModel
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}