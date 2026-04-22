/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

namespace Common.State.ServerStats;

using Fluxor;

public static class ServerStatsReducers
{
	[ReducerMethod]
	public static ServerStatsState ReduceServerStatsUpdate(ServerStatsState _, ServerStatsAction action) => new();
}
