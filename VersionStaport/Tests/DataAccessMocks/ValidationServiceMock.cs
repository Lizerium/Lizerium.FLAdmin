/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

using FlAdmin.Common.Models.Database;
using FlAdmin.Common.Services;

namespace FlAdmin.Tests.DataAccessMocks;

public class ValidationServiceMock : IValidationService
{
    public bool ValidateCharacter(Character character)
    {
        return true;
    }
}