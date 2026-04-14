/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

using FlAdmin.Common.DataAccess;
using FlAdmin.Common.Models.Database;
using FlAdmin.Common.Services;
using LibreLancer.Data;
using Microsoft.Extensions.Logging;

namespace FlAdmin.Logic.Services;

public class ValidationService : IValidationService
{
    private readonly ILogger _logger;
    private FreelancerData _freelancerData;

    public ValidationService(IFreelancerDataProvider freelancerDataProvider, ILogger<IValidationService> logger)
    {
        _logger = logger;

        if (freelancerDataProvider.GetFreelancerData() is null)
        {
            logger.LogCritical("No freelancer data available for validation service.");
            throw new Exception("No freelancer data available for validation service.");
        }

        _freelancerData = freelancerDataProvider.GetFreelancerData()!;
    }

    public bool ValidateCharacter(Character character)
    {
        return true;
    }
}