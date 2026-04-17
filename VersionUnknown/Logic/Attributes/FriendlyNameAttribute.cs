/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

namespace Logic.Attributes;

[AttributeUsage(AttributeTargets.Enum)]
public class FriendlyNameAttribute : Attribute
{
	public required string Name { get; set; }
}
