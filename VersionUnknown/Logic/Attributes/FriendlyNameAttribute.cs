/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
 */

namespace Logic.Attributes;

[AttributeUsage(AttributeTargets.Enum)]
public class FriendlyNameAttribute : Attribute
{
	public required string Name { get; set; }
}
