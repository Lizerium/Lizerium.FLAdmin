/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

namespace Common.State.ServerStats;

using Fluxor;

public static class ServerStatsReducers
{
	[ReducerMethod]
	public static ServerStatsState ReduceServerStatsUpdate(ServerStatsState _, ServerStatsAction action) => new();
}
