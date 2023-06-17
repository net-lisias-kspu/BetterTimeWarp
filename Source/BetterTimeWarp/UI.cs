/*
	This file is part of Better Time Warp /L Unleashed
		© 2023 Lisias T : http://lisias.net <support@lisias.net>
		© 2017-2023 LinuxGuruGamer
		© 2014-2017 MrHappyFace

	Better Time Warp /L Unleashed is licensed as follows:
		* GPL 3.0 : https://www.gnu.org/licenses/gpl-3.0.txt

	Better Time Warp /L Unleashed is distributed in the hope that
	it will be useful, but WITHOUT ANY WARRANTY; without even the implied
	warranty of	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.

	You should have received a copy of the GNU General Public License 3.0
	along with Better Time Warp /L Unleashed.
	If not, see <https://www.gnu.org/licenses/>.

*/
using UnityEngine;

namespace BetterTimeWarp
{
    using Asset = KSPe.IO.Asset<Startup>;

    public static class UI
    {
        internal static readonly Texture2D application_38 = Asset.Texture2D.LoadFromFile("Icons", "application_38");
        internal static readonly Texture2D application_24 = Asset.Texture2D.LoadFromFile("Icons", "application_24");
        internal static readonly Texture2D upArrow = Asset.Texture2D.LoadFromFile("Icons", "up");
        internal static readonly Texture2D downArrow = Asset.Texture2D.LoadFromFile("Icons", "down");
   }
}
