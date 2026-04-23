/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

namespace Common.Messaging;

using RabbitMQ.Client.Events;

public interface IExchangeSubscriber
{
	string GetQueueName(ExchangeName name);
	void Subscribe(ExchangeName name, string queueName, AsyncEventHandler<BasicDeliverEventArgs> action);
	void EnsureDeclared(ExchangeName name, string type, bool durable = true);
	void Unsubscribe(ExchangeName name);
}
