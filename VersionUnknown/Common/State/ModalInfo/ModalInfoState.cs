/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 15 апреля 2026 01:16:00
 * Version: 1.0.172
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
