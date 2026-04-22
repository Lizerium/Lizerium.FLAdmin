/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

namespace Common.Messaging;
public class RpcMessage
{
	public RpcMessage(IDictionary<string, object> data) => Data = data;

	public IDictionary<string, object> Data { get; }
}
