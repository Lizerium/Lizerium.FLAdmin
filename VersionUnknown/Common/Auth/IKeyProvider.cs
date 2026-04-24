/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 24 апреля 2026 06:52:11
 * Version: 1.0.183
 */

namespace Common.Auth;
public interface IKeyProvider
{
	byte[] GetSigningKey();
	byte[] GetEncryptionKey();
}
