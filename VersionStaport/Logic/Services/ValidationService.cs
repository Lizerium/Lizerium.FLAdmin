/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
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
            _logger.LogCritical("No freelancer data available for validation service.");
            throw new Exception("No freelancer data available for validation service.");
        }
        _freelancerData = freelancerDataProvider.GetFreelancerData()!;
    }

    //TODO:Proper validation
    public bool ValidateCharacter(Character character)
    {
        return true;
    }
}