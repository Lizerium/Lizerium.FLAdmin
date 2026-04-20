/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 03:06:43
 * Version: 1.0.178
 */

namespace Common.Messaging;
public class RpcMessage
{
	public RpcMessage(IDictionary<string, object> data) => Data = data;

	public IDictionary<string, object> Data { get; }
}
