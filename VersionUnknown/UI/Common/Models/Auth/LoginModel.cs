/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

namespace FlAdmin.Common.Models.Auth;

public class LoginModel
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}