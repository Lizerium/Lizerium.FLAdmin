/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

namespace Common.Messaging;
public interface IMessagePublisher
{
	void Publish<T>(QueueName queue, T message);
	void Publish<T>(ExchangeName exchange, T message);
}
