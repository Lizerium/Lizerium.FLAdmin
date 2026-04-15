/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 06:52:12
 * Version: 1.0.173
 */

namespace Common.State.ModalInfo;
using Fluxor;

public static class ModalInfoReducers
{
	[ReducerMethod]
	public static ModalInfoState ReduceModalInfoUpdate(ModalInfoState _, ModalInfoAction action) => new(action.Text, action.IsError);
}
