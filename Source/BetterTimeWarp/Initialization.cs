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
using UnityEngine;

using DEFAULT = KSPe.IO.Asset<BetterTimeWarp.BetterTimeWarp>;

namespace BetterTimeWarp
{
    [KSPAddon(KSPAddon.Startup.MainMenu, true)]
    public class BetterTimeWarpInitializer : MonoBehaviour
    {
        const string DEFAULT_FILE = "BetterTimeWarp_Defaults.cfg";

        static bool started = false;
        public void Start()
        {
            //only call this once at the beginning of the game
            if (!started)
            {
                DontDestroyOnLoad(this);
                ConfigNode node;
                //load the settings
                Log.dbg("Loading Configuration");

                if (BTWCustomParams.USER_CONFIG.IsLoadable)
                {
                    BTWCustomParams.USER_CONFIG.Load();
                    Log.detail("Config loaded");
                }
                else
                {
                    DEFAULT.ConfigNode @default = DEFAULT.ConfigNode.For(this.GetType().Namespace, DEFAULT_FILE);
                    BTWCustomParams.USER_CONFIG.Save( @default.Load().Node);
                    Log.detail("Default configs loaded");
                }

                node = BTWCustomParams.USER_CONFIG.Node;

#if false
                if (!HighLogic.CurrentGame.Parameters.CustomParams<BTWCustomParams>().enabled)
				{
					Debug.LogError ("[BetterTimeWarp]: enabled = false in settings, disabling BetterTimeWarp");
					return;
				}
#endif

                //subscribe to the events so that the settings save and the UI can hide/show
                GameEvents.onGameStateSaved.Add(SaveSettings);
                GameEvents.onGameStateLoad.Add(onGameStateLoad);
                GameEvents.onShowUI.Add(ShowUI);
                GameEvents.onHideUI.Add(HideUI);

                //make the physical time warp warning not pop up
                GameSettings.SHOW_PWARP_WARNING = false;

                //give every celestial body new time warp altitude limits
                foreach (CelestialBody body in FlightGlobals.Bodies)
                {
                    body.timeWarpAltitudeLimits = new float[] { 0f, 0f, 0f, 0f, 0f, 0f, 100000f, 2000000f };
                }

                //	GameEvents.onLevelWasLoadedGUIReady.Add (OnLevelLoaded);

                started = true;
            }
        }

        void OnDestroy()
        {
            GameEvents.onGameStateSaved.Remove(SaveSettings);
            GameEvents.onGameStateLoad.Remove(onGameStateLoad);
            GameEvents.onShowUI.Remove(ShowUI);
            GameEvents.onHideUI.Remove(HideUI);
        }

        private void onGameStateLoad(ConfigNode data)
        {
            Log.dbg("onGameStateLoad: Interval = " + GameSettings.AUTOSAVE_INTERVAL / 60.0 + " min");

            HighLogic.CurrentGame.Parameters.CustomParams<BTWCustomParams2>().StockAutosaveInterval =
                (int)(GameSettings.AUTOSAVE_INTERVAL / 60.0);
            HighLogic.CurrentGame.Parameters.CustomParams<BTWCustomParams2>().StockAutosaveShortInterval =
                (int)GameSettings.AUTOSAVE_SHORT_INTERVAL;
        }
#if false
        private void OnLevelLoaded(GameScenes scene)
		{
			//call this every scene that needs BetterTimeWarp
			if (scene == GameScenes.FLIGHT || scene == GameScenes.SPACECENTER || scene == GameScenes.TRACKSTATION)
			{
				BetterTimeWarp.Instance = gameObject.AddComponent<BetterTimeWarp> ();
			}
		}
#endif
        //called whenever the game autosaves/quicksaves
        void SaveSettings(Game game)
        {
            BTWCustomParams.USER_CONFIG.Save("BetterTimeWarp: Automatically saved at date " + System.DateTime.Now.ToString());
            Debug.Log("[BetterTimeWarp]: Settings saved");
        }

        //these are called when F2 is pressed to hide/show the UI
        void ShowUI()
        {
            BetterTimeWarp.ShowUI = true;
        }
        void HideUI()
        {
            BetterTimeWarp.ShowUI = false;
        }
    }
}

