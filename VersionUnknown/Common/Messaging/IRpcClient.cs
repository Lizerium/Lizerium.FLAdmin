/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
 */

namespace Common.Messaging;
public interface IRpcClient<TResponse>
{
	Task<TResponse> SendRequest(RpcMessage message,
		Func<RpcMessage, TResponse> responseProcessor,
		Func<Exception, TResponse> errorHandler,
		CancellationToken cancellationToken);
}
