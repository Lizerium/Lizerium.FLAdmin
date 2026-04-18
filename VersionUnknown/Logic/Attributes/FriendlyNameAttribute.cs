/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace Logic.Attributes;

[AttributeUsage(AttributeTargets.Enum)]
public class FriendlyNameAttribute : Attribute
{
	public required string Name { get; set; }
}
