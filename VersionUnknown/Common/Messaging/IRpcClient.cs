/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:11
 * Version: 1.0.183
 */

namespace Common.Messaging;
public interface IRpcClient<TResponse>
{
	Task<TResponse> SendRequest(RpcMessage message,
		Func<RpcMessage, TResponse> responseProcessor,
		Func<Exception, TResponse> errorHandler,
		CancellationToken cancellationToken);
}
