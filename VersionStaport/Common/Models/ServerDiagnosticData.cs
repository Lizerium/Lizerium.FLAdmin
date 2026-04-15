/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:12
 * Version: 1.0.173
 */

namespace FlAdmin.Common.Models;

public struct ServerDiagnosticData
{
    public long Memory;
    public int PlayerCount;
    public DateTimeOffset TimeStamp;
    public TimeSpan ServerUptime;
}