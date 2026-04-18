/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace FlAdmin.Common.Models;

public struct ServerDiagnosticData
{
    public long Memory;
    public int PlayerCount;
    public DateTimeOffset TimeStamp;
    public TimeSpan ServerUptime;
}