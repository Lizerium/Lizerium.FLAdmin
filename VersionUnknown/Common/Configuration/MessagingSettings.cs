/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:11
 * Version: 1.0.183
 */

namespace Common.Configuration;

[Serializable]
public class MessagingSettings
{
	public bool EnableMessaging { get; set; } = true;
	public string Username { get; set; } = "guest";
	public string Password { get; set; } = "guest";
	public int Port { get; set; } = 5672;
	public string HostName { get; set; } = "localhost";
}
