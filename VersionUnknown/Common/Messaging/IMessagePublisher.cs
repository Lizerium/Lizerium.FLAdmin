/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
 */

namespace Common.Messaging;
public interface IMessagePublisher
{
	void Publish<T>(QueueName queue, T message);
	void Publish<T>(ExchangeName exchange, T message);
}
