/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 20 апреля 2026 16:21:55
 * Version: 1.0.179
 */

namespace Common.State.ModalInfo;
using Fluxor;

public static class ModalInfoReducers
{
	[ReducerMethod]
	public static ModalInfoState ReduceModalInfoUpdate(ModalInfoState _, ModalInfoAction action) => new(action.Text, action.IsError);
}
