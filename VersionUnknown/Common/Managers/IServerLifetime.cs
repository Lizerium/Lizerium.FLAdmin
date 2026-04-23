/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

namespace Common.Managers;

public interface IServerLifetime
{
	bool IsAlive();
	bool ReadyToStart();
	void Start();
	int GetMessageCount();
	IEnumerable<string> GetConsoleMessages(int page);
	void SendCommandToConsole(string command);
	void Terminate();
}
