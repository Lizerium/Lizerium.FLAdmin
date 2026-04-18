/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace Common.State.ModalInfo;
using Fluxor;

public static class ModalInfoReducers
{
	[ReducerMethod]
	public static ModalInfoState ReduceModalInfoUpdate(ModalInfoState _, ModalInfoAction action) => new(action.Text, action.IsError);
}
