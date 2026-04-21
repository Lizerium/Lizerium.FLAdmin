/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
 */

namespace Common.State.ServerStats;

using Fluxor;

public static class ServerStatsReducers
{
	[ReducerMethod]
	public static ServerStatsState ReduceServerStatsUpdate(ServerStatsState _, ServerStatsAction action) => new();
}
