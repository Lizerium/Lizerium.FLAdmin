/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

namespace FlAdmin.Common.Models.Error;

public enum MongoErrorCodes
{
    DuplicateKey = 11000,
    WriteConflict = 112,
    MongoIsUnreachable = 211,
    MongoIsUnreachable2 = 11600
}