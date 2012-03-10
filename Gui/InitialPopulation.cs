using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Gui
{
    public static class InitialPopulation
    {
        public static IEnumerable<IEnumerable<bool>> Glider() {
            yield return new[] { false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { true, true, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        }

        public static IEnumerable<IEnumerable<bool>> Acorn() {
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, true, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, true, true, false, false, true, true, true, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
            yield return new[] { false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false, false };
        }
    }
}
