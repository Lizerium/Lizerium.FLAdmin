/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 21 апреля 2026 06:52:16
 * Version: 1.0.180
 */

using LibreLancer.Data;

namespace FlAdmin.Common.DataAccess;

public interface IFreelancerDataProvider
{
    bool Loaded();
    void Reload();
    FreelancerData? GetFreelancerData();
}