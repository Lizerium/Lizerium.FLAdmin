/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace FlAdmin.Common.Models.Auth;

public class LoginModel
{
    public required string Username { get; set; }
    public required string Password { get; set; }
}