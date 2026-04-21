/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
 */

namespace FlAdmin.Common.Models.Error;

public enum MongoErrorCodes
{
    DuplicateKey = 11000,
    WriteConflict = 112,
    MongoIsUnreachable = 211,
    MongoIsUnreachable2 = 11600
}