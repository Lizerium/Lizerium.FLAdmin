/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

namespace Common.Messaging;
public interface IMessagePublisher
{
	void Publish<T>(QueueName queue, T message);
	void Publish<T>(ExchangeName exchange, T message);
}
