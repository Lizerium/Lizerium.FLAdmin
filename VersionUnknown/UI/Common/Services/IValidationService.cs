/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

using FlAdmin.Common.Models.Database;

namespace FlAdmin.Common.Services;

public interface IValidationService
{
    public bool ValidateCharacter(Character character);
}