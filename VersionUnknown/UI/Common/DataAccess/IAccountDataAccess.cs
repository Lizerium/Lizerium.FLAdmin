/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

using System.Linq.Expressions;
using FlAdmin.Common.Models.Database;
using FlAdmin.Common.Models.Error;
using LanguageExt;
using MongoDB.Bson;

namespace FlAdmin.Common.DataAccess;

public interface IAccountDataAccess
{
    Task<Option<FLAdminError>> CreateAccounts(params Account[] accounts);
    Task<Option<FLAdminError>> UpdateAccount(BsonDocument account);
    Task<Option<FLAdminError>> DeleteAccounts(params string[] ids);
    Task<Either<FLAdminError, Account>> GetAccount(string accountId);
    Task<Option<FLAdminError>> UpdateFieldOnAccount<T>(string accountId, string fieldName, T value);
    Task<Option<FLAdminError>> CreateNewFieldOnAccount<T>(string accountId, string fieldName, T value);
    Task<Option<FLAdminError>> RemoveFieldOnAccount(string accountId, string fieldName);

    Task<List<Account>> GetAccountsByFilter(Expression<Func<Account, bool>> filter, int page = 1, int pageSize = 100);
    Task<Option<FLAdminError>> ReplaceAccount(Account account);
}