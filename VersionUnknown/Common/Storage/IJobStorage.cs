/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace Common.Storage;

using Jobs;

public interface IJobStorage
{
	Task<List<JobGroup>> GetJobsByTrigger(JobTrigger trigger);
	Task<Job?> GetJobByName(string name);
	Task UpdateJob(Job jobUpdate);
}
