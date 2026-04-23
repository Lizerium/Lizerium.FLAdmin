/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

namespace Common.Messaging;
public class RpcMessage
{
	public RpcMessage(IDictionary<string, object> data) => Data = data;

	public IDictionary<string, object> Data { get; }
}
