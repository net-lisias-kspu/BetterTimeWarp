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
using System;
using System.Linq;

namespace BetterTimeWarp
{
	public class TimeWarpRates
	{
		public string Name;
		public float[] Rates;
		public bool Physics;

		public TimeWarpRates(string name, float[] rates, bool physics)
		{
			this.Name = name;
			this.Rates = rates;
			this.Physics = physics;
		}
		public TimeWarpRates()
		{
		}
        
        public static string rateFmt(float f)
        {
            
                if (f < 1000)
                    return "";
                else
                    return "N0";
            
        }

		public override string ToString ()
		{
			System.Collections.Generic.IEnumerable<string> rates = Rates.Select(z => z.ToString(rateFmt(z)));
			String ratesString = String.Join(", ", rates.ToArray());
			return this.Name + " - " + ratesString;
		}
	}
}

