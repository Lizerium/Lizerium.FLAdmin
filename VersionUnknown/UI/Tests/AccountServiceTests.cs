/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

using FlAdmin.Common.Configs;
using FlAdmin.Common.Models.Database;
using FlAdmin.Logic.Services.Database;
using FlAdmin.Tests.DataAccessMocks;
using FluentAssertions;
using Microsoft.Extensions.Logging.Abstractions;

namespace FlAdmin.Tests;

public class AccountServiceTests : IDisposable
{
    private readonly AccountDataAccessMock _accountDataAccess;
    private readonly AccountService _service;
    private readonly FlAdminConfig config;


    public AccountServiceTests()
    {
        _accountDataAccess = new AccountDataAccessMock();
        config = new FlAdminConfig();
        _service = new AccountService(_accountDataAccess, config, new NullLogger<AccountService>());
    }


    public void Dispose()
    {
        _accountDataAccess.Dispose();
    }

    [Fact]
    public async Task When_Adding_Valid_Id_Account_Should_Succeed()
    {
        var account = new Account
        {
            Id = "123abc"
        };

        var result = await _service.CreateAccounts(account);

        result.IsNone.Should().BeTrue();
    }
}