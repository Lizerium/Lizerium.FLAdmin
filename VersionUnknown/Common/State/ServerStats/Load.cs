/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

namespace Common.State.ServerStats;

public class Load
{
	public int MS { get; }
	public string Time { get; }

	public Load(int ms)
	{
		MS = ms;
		Time = DateTime.UtcNow.ToLongTimeString();
	}
}
