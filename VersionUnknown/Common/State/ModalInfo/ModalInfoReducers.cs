/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 16 апреля 2026 11:43:48
 * Version: 1.0.174
 */

namespace Common.State.ModalInfo;
using Fluxor;

public static class ModalInfoReducers
{
	[ReducerMethod]
	public static ModalInfoState ReduceModalInfoUpdate(ModalInfoState _, ModalInfoAction action) => new(action.Text, action.IsError);
}
