/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

namespace Common.Messaging;
public interface IRpcClient<TResponse>
{
	Task<TResponse> SendRequest(RpcMessage message,
		Func<RpcMessage, TResponse> responseProcessor,
		Func<Exception, TResponse> errorHandler,
		CancellationToken cancellationToken);
}
