/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 18 апреля 2026 14:44:32
 * Version: 1.0.177
 */

namespace Common.State.ModalInfo;
public class ModalInfoAction
{
	public string Text { get; set; }
	public bool IsError { get; set; }

	public ModalInfoAction(string text, bool isError = false)
	{
		Text = text;
		IsError = isError;
	}
}
