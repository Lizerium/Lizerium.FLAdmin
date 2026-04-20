/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
 */

namespace Common.Models;

public class Pagination<T>
{
	public required IReadOnlyList<T> Data { get; init; }
	public required int PageCount { get; init; }
	public required int CurrentPage { get; init; }
}
