/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

using FlAdmin.Common.Models.Error;

namespace FlAdmin.Common.Models;

public class ErrorResult
{
    private List<Tuple<FLAdminError, string>> Errors { get; set; } = new();
}