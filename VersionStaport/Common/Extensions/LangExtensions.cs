/*
 * Author: Nikolay Dvurechensky and TheStarport
 * Site: https://dvurechensky.pro/
 * Gmail: dvurechenskysoft@gmail.com
 * Last Updated: 17 апреля 2026 06:51:49
 * Version: 1.0.176
 */

using System.Linq.Expressions;
using LanguageExt;

namespace FlAdmin.Common.Extensions;

public static class LangExtensions
{
    public static T GetLeft<T, TOther>(this Either<T, TOther> either)
    {
        if (!either.IsLeft)
        {
            throw new ArgumentException("Either is not left");
        }

        return either.Match(Left: x => x, Right: _ => default!);
    }
    
    public static T GetRight<TOther, T>(this Either<TOther, T> either)
    {
        if (!either.IsRight)
        {
            throw new ArgumentException("Either is not right");
        }

        return either.Match(Left: _ => default!, Right: x => x);
    }
}
