/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

namespace Common.Messaging;
public class RpcMessage
{
	public RpcMessage(IDictionary<string, object> data) => Data = data;

	public IDictionary<string, object> Data { get; }
}
