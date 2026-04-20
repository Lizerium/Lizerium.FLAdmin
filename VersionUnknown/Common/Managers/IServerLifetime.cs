/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
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
