/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 22 апреля 2026 18:37:32
 * Version: 1.0.181
 */

using LibreLancer.Data;

namespace FlAdmin.Common.DataAccess;

public interface IFreelancerDataProvider
{
    bool Loaded();
    void Reload();
    FreelancerData? GetFreelancerData();
    
    
    
}