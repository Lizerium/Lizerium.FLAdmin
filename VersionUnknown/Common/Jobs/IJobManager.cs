/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
 */

namespace Common.Jobs;

public interface IJobManager
{
	public Task ExecuteTrigger(JobTrigger trigger, CancellationToken token);
}
