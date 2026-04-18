/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace Common.State.ServerStats;

public class Usage
{
	public int UsageBytes { get; }
	public string Time { get; }

	public double UsageDenomination
	{
		get
		{
			var bytes = UsageBytes;
			int i;
			double dblSByte = bytes;
			for (i = 0; i < 3 && bytes >= 1024; i++, bytes /= 1024)
			{
				dblSByte = bytes / 1024.0;
			}

			return dblSByte;
		}
	}

	public Usage(int usage)
	{
		UsageBytes = usage;
		Time = DateTime.UtcNow.ToLongTimeString();
	}
}
