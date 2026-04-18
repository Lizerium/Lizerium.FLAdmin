/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

using FlAdmin.Common.Models.Error;

namespace FlAdmin.Common.Models;

public class ErrorResult
{
    private List<Tuple<FLAdminError, string>> Errors { get; set; } = new();
}