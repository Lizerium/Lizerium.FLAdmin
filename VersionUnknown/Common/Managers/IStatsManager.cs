/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
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
