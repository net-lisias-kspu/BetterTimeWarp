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
using System.Collections;
using System.Reflection;

// http://forum.kerbalspaceprogram.com/index.php?/topic/147576-modders-notes-for-ksp-12/#comment-2754813
// search for "Mod integration into Stock Settings

using USER = KSPe.IO.Data<BetterTimeWarp.BetterTimeWarp>;

namespace BetterTimeWarp
{
    public class BTWCustomParams : GameParameters.CustomParameterNode
    {
        const string CONFIG_FILE = "BetterTimeWarp.cfg";
        internal static readonly USER.ConfigNode USER_CONFIG = USER.ConfigNode.For(typeof(BetterTimeWarp).Namespace, CONFIG_FILE);

        public override string Title { get { return "Better Time Warp"; } }
        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override string Section { get { return "Better Time Warp"; } }
        public override string DisplaySection { get { return "Better Time Warp"; } }
        public override int SectionOrder { get { return 1; } }
        public override bool HasPresets { get { return true; } }

        [GameParameters.CustomParameterUI("Mod Enabled?",
            toolTip ="Changing this requires restarting the game")]
        public bool enabled = true;

        [GameParameters.CustomParameterUI("Always hide the button?")]
        public bool hideButton = false;

        [GameParameters.CustomParameterUI("Hide the button in the flight scene?")]
        public bool hideButtonInFlight = true;

        [GameParameters.CustomParameterUI("Hide the dropdown button in the flight scene?")]
        public bool hideDropdownButtonInFlight = false;

        [GameParameters.CustomParameterUI("Lock window positions in flight?")]
        public bool lockWindowPosInFlight = true;

        [GameParameters.CustomParameterUI("Lock window positions (other than flight)?")]
        public bool lockWindowPos = true;

        public override void SetDifficultyPreset(GameParameters.Preset preset)
        {        }
        public override bool Enabled(MemberInfo member, GameParameters parameters)
        {
            if (member.Name == "hideButtonInFlight" && hideButton)
            {
                hideButtonInFlight = true;
                return false;
            }
            return true;
        }
        public override bool Interactible(MemberInfo member, GameParameters parameters)
        {
            return true;
        }
        public override IList ValidValues(MemberInfo member)
        {
            return null;
        }
    }


    public class BTWCustomParams2 : GameParameters.CustomParameterNode
    {
        public override string Title { get { return "Better Time Warp"; } }
        public override GameParameters.GameMode GameMode { get { return GameParameters.GameMode.ANY; } }
        public override string Section { get { return "Better Time Warp"; } }
        public override string DisplaySection { get { return "Better Time Warp"; } }
        public override int SectionOrder { get { return 2; } }
        public override bool HasPresets { get { return false; } }

        [GameParameters.CustomStringParameterUI("Stock autosave settings (persistent.sfs)", toolTip = "", lines = 2)]
        public string note1 = "";

        [GameParameters.CustomIntParameterUI("Autosave Interval (min)", 
            toolTip = 
            "Interval for autosave to persistent.sfs.\n"+
            "It shrinks with the Physics Time Warp",
            minValue = 1, maxValue = 180, stepSize = 1)]
        public int StockAutosaveInterval = 5;

        [GameParameters.CustomIntParameterUI("Autosave Short Interval (sec)",
            toolTip = 
            "That's the time interval for another attempt at saving,\n" +
            "in case the first attempt fails. If the auto save fails,\n" +
            "it will continuously retry on that interval until it's able to save again.",
            minValue = 10, maxValue = 1800, stepSize = 10)]
        public int StockAutosaveShortInterval = 30;

        [GameParameters.CustomParameterUI("Reset Intervals to Default",
            toolTip = "Reset autosave intervals and write to settings.cfg")]
        public bool ResetStockIntervalSettings = false;

        [GameParameters.CustomParameterUI("Write Intervals to settings.cfg",
            toolTip = "Don't forget to write changed intervals to settings.cfg")]
        public bool WriteStockIntervalSettings = false;

        public void ResetSettings()
        {
            StockAutosaveInterval = 5;
            StockAutosaveShortInterval = 30;

            WriteSettings();
        }
        public void WriteSettings()
        {
            GameSettings.AUTOSAVE_INTERVAL = StockAutosaveInterval * 60;
            GameSettings.AUTOSAVE_SHORT_INTERVAL = StockAutosaveShortInterval;
            GameSettings.SaveSettings();
            string message = String.Format("Intervals are updated: {0} min, {1} sec",
                 GameSettings.AUTOSAVE_INTERVAL / 60, GameSettings.AUTOSAVE_SHORT_INTERVAL);
            Log.dbg(message);
            ScreenMessages.PostScreenMessage(message);
        }
        public override bool Enabled(MemberInfo member, GameParameters parameters)
        {
            return true;
        }
        public override bool Interactible(MemberInfo member, GameParameters parameters)
        {
            if (member.Name == nameof(ResetStockIntervalSettings) && ResetStockIntervalSettings)
            {
                ResetSettings();
                ResetStockIntervalSettings = false;
            }
            if (member.Name == nameof(WriteStockIntervalSettings) && WriteStockIntervalSettings)
            {
                WriteSettings();
                WriteStockIntervalSettings = false;
            }
            return true;
        }
        public override IList ValidValues(MemberInfo member)
        {
            return null;
        }
    }
}
