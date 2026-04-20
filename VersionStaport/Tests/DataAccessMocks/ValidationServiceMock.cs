/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
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