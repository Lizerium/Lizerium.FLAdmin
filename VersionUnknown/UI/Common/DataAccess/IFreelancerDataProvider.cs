/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

using LibreLancer.Data;

namespace FlAdmin.Common.DataAccess;

public interface IFreelancerDataProvider
{
    bool Loaded();
    void Reload();
    FreelancerData? GetFreelancerData();
}