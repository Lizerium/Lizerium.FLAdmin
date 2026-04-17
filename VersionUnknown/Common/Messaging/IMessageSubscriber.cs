/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
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
