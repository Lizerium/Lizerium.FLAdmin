/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

namespace Common.State.ServerStats;

using Fluxor;

public static class ServerStatsReducers
{
	[ReducerMethod]
	public static ServerStatsState ReduceServerStatsUpdate(ServerStatsState _, ServerStatsAction action) => new();
}
