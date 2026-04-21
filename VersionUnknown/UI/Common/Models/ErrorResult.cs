/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
 */

using FlAdmin.Common.Models.Error;

namespace FlAdmin.Common.Models;

public class ErrorResult
{
    private List<Tuple<FLAdminError, string>> Errors { get; set; } = new();
}