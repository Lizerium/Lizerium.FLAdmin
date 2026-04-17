/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

namespace Common.Messaging;
public interface IRpcClient<TResponse>
{
	Task<TResponse> SendRequest(RpcMessage message,
		Func<RpcMessage, TResponse> responseProcessor,
		Func<Exception, TResponse> errorHandler,
		CancellationToken cancellationToken);
}
