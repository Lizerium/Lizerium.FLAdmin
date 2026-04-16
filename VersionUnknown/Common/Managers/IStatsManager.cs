/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

namespace Common.Managers;
using Common.Messaging.Messages;
using Common.State.ServerStats;

public interface IStatsManager
{
	void UpdateServerStats(ServerStats stats);
	IEnumerable<Usage> GetMemoryUsage();
	IEnumerable<Load> GetServerLoad();
	IEnumerable<PlayerInfo> GetOnlinePlayers();
	IEnumerable<KeyValuePair<string, uint>> GetPlayerTrend();
	void Clear();
}
