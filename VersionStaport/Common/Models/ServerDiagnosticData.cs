/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
 */

namespace FlAdmin.Common.Models;

public struct ServerDiagnosticData
{
    public long Memory;
    public int PlayerCount;
    public DateTimeOffset TimeStamp;
    public TimeSpan ServerUptime;
}