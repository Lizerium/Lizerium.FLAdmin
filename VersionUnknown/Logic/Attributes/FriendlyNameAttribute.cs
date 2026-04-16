/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

namespace Logic.Attributes;

[AttributeUsage(AttributeTargets.Enum)]
public class FriendlyNameAttribute : Attribute
{
	public required string Name { get; set; }
}
