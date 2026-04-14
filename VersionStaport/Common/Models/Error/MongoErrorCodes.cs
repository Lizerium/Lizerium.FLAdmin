/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

namespace FlAdmin.Common.Models.Error;

public enum MongoErrorCodes
{
    DuplicateKey = 11000,
    WriteConflict = 112,
    MongoIsUnreachable = 211,
    MongoIsUnreachable2 = 11600
}