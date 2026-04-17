/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

namespace Common.Models;

public class Pagination<T>
{
	public required IReadOnlyList<T> Data { get; init; }
	public required int PageCount { get; init; }
	public required int CurrentPage { get; init; }
}
