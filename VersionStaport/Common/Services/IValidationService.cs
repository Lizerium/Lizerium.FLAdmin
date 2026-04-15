/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:12
 * Version: 1.0.173
 */

using FlAdmin.Common.Models.Database;

namespace FlAdmin.Common.Services;

public interface IValidationService
{
    public bool ValidateCharacter(Character character);
}