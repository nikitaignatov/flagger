using System.Collections.Generic;
using System.Linq;

namespace Flagger
{
    public static class FlagExtensions
    {
        /// <summary>
        /// checks if list of flags contains a flag of the specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flags"></param>
        /// <returns></returns>
        public static bool HasFlag<T>(this IEnumerable<IFlag> flags) where T : IFlag => flags.OfType<T>().Any();

        /// <summary>
        /// checks if the object that implements IHaveFlags interface contains flag of specified type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="item"></param>
        /// <returns></returns>
        public static bool HasFlag<T>(this IHaveFlags item) where T : IFlag => (item.FlagsAll ?? item.Flags).HasFlag<T>();
    }
}