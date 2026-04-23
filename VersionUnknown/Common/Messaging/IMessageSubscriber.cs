/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 23 апреля 2026 06:52:58
 * Version: 1.0.182
 */

namespace Common.Messaging;
using RabbitMQ.Client.Events;

public interface IMessageSubscriber
{
	void Complete(string queueName, BasicDeliverEventArgs ea);
	void Reject(string queueName, BasicDeliverEventArgs ea, bool requeue);
	void Subscribe(string queueName, AsyncEventHandler<BasicDeliverEventArgs> action);
	void Unsubscribe(string queueName);
}
