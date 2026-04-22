/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
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
