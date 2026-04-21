/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
 */

namespace Common.State.ServerEvents;

using Fluxor;

public class ConsoleMessageAction
{
	public string LastMessage { get; }
	public ConsoleMessageAction(string lastMessage) => LastMessage = lastMessage;
}

[FeatureState]
public class ConsoleMessageState
{
	public string LastMessage { get; } = string.Empty;
	public ConsoleMessageState()
	{
	}

	public ConsoleMessageState(string lastMessage) => LastMessage = lastMessage;
}

public static class ConsoleMessageReducers
{
	[ReducerMethod]
	public static ConsoleMessageState ReduceServerStatsUpdate(ConsoleMessageState _, ConsoleMessageAction action) => new(action.LastMessage);
}
