/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace Common.State.ModalInfo;

using Fluxor;

[FeatureState]
public class ModalInfoState
{
	public string Text { get; set; } = string.Empty;
	public bool IsError { get; set; }

	public ModalInfoState(string text, bool isError = false)
	{
		Text = text;
		IsError = isError;
	}

	public ModalInfoState()
	{
	}
}
