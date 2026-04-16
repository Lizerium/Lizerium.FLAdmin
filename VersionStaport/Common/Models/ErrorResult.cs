/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

using FlAdmin.Common.Models.Error;

namespace FlAdmin.Common.Models;
/// <summary>
/// Error result object, first error in the list is the "primary error".
/// </summary>
public class ErrorResult
{
    public ErrorResult(FLAdminErrorCode err, string errMsg = "")
    {
        Errors =
        [
            new FlAdminError(err, errMsg)
        ];
    }

    public ErrorResult()
    {
        Errors = [];
    }

    public List<FlAdminError> Errors { get; }

    public void AddError(FLAdminErrorCode err, string errMsg)
    {
        Errors.Add(new FlAdminError(err, errMsg));
    }

    public bool HasErrorCode(FLAdminErrorCode error)
    {
        return Errors.Any(err => err.ErrorCode == error);
    }
    
}

public struct FlAdminError(FLAdminErrorCode err, string errMsg)
{
    public FLAdminErrorCode ErrorCode { get; set; } = err;
    public string Message { get; set; } = errMsg;
}