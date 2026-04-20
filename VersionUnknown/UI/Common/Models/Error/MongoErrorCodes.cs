/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
 */

namespace FlAdmin.Common.Models.Error;

public enum MongoErrorCodes
{
    DuplicateKey = 11000,
    WriteConflict = 112,
    MongoIsUnreachable = 211,
    MongoIsUnreachable2 = 11600
}