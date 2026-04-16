/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

namespace Common.Storage;

using Jobs;

public interface IJobStorage
{
	Task<List<JobGroup>> GetJobsByTrigger(JobTrigger trigger);
	Task<Job?> GetJobByName(string name);
	Task UpdateJob(Job jobUpdate);
}
