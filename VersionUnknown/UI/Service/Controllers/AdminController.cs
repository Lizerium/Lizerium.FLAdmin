/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

using FlAdmin.Common.Models.Auth;
using FlAdmin.Logic.Services;
using Microsoft.AspNetCore.Mvc;

namespace FlAdmin.Service.Controllers;

[ApiController]
[Route("api/admin")]
[AdminAuthorize(Role.SuperAdmin)]
public class AdminController : ControllerBase
{
}