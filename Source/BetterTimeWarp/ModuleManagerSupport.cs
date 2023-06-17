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
using System.Collections.Generic;

namespace BetterTimeWarp
{
	public class ModuleManagerSupport : UnityEngine.MonoBehaviour
	{
		public static IEnumerable<string> ModuleManagerAddToModList()
		{
			string[] r = { typeof(Version).Namespace };
			return r;
		}
	}
}
