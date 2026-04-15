/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:12
 * Version: 1.0.173
 */

using LibreLancer.Data;

namespace FlAdmin.Common.DataAccess;

public interface IFreelancerDataProvider
{
    bool Loaded();
    void Reload();
    FreelancerData? GetFreelancerData();
}