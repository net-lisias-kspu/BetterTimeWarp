# Better Time Warp /L Unleashed :: Change Log

* 2019-0625: 2.3.11.4 (LinuxGuruGamer) for KSP 1.7.2
	+ Version bump for 1.7.2
* 2019-0328: 2.3.11.3 (LinuxGuruGamer) for KSP 1.6.1
* 2019-0109: 2.3.11.2 (LinuxGuruGamer) for KSP 1.6.0
* 2018-1211: 2.3.11.1 (LinuxGuruGamer) for KSP 1.5.1
	+ Fixed stupid bug which caused nullrefs in the editor
* 2018-1211: 2.3.11 (LinuxGuruGamer) for KSP 1.5.1
	+ Bug fix for lossless physics causing issues, both after warp is done and while warp was in progress
	+ Removed max version from .version file
* 2018-1020: 2.3.10.2 (LinuxGuruGamer) for KSP 1.5.1
	+ Version bump for 1.5 rebuild
* 2018-0620: 2.3.10.1 (LinuxGuruGamer) for KSP 1.4.3
	+ Updated for all 1.4
	+ Updated to use updated ToolbarControl
	+ Removed blizzy options
* 2018-0319: 2.3.10 (LinuxGuruGamer) for KSP 1.4.1
	+ updated for 1.4.1
	+ Added support for ToolbarControl
	+ Added support for ClickThroughBlocker
* 2017-1008: 2.3.9 (LinuxGuruGamer) for KSP 1.3.1
	+ Updated for KSP 1.3.1
* 2017-0526: 2.3.8 (LinuxGuruGamer) for KSP 1.3.0
	+ updated for 1.3
		- Updated dialog calls for new 1.3 parameter
		- Added DisplaySection function, will need to localize it
* 2017-0417: 2.3.7.4 (LinuxGuruGamer) for KSP 1.2.2
	+ Fixed mod not saving custom values
* 2017-0413: 2.3.7.3 (LinuxGuruGamer) for KSP 1.2.2
	+ Fixed display of very large values to not use scientific notation
	+ Fixed issue where sometimes, with high warp, vessels using the ResourceConverter were being unpacked after the fix for the high warp issue was done.  Thanks to forum user @eech for helping to test this.
	+ Added code to deal with someone turning on a ResourceConverter while in warp
	+ Changed code from being started every scene to only being started at the spacecenter, and set not to destroy
	+ Renamed config file in release to defaults, will not overwrite existing configs after this release
* 2017-0412: 2.3.7.1 (LinuxGuruGamer) for KSP 1.2.2
	+ Now looks at all vesselsLoaded when fixing the ResourceConverter problem
* 2017-0412: 2.3.7 (LinuxGuruGamer) for KSP 1.2.2
	+ Fixed dropdown offset for when no probe control
	+ Fixed issue when timewarping >stock max, Inactive Resource Convertors could use fuel more rapidly
* 2017-0328: 2.3.6.3 (LinuxGuruGamer) for KSP 1.2.2
	+ Replaced "s" button with icons
	+ Fixed Physicless warp so that all use the same timestep
* 2017-0305: 2.3.6.1 (LinuxGuruGamer) for KSP 1.2.2
	+ Fixed nullref when no comms are available, affected positioning of dropdown button
* 2017-0305: 2.3.6 (LinuxGuruGamer) for KSP 1.2.2
	+ Fixed nullrefs in orbit when no control
* 2017-0301: 2.3.5.4 (LinuxGuruGamer) for KSP 1.2.2
	+ removed some log spam
* 2017-0301: 2.3.5.3 (LinuxGuruGamer) for KSP 1.2.2
	+ Fixed nullrefs which were occuring during startup
* 2017-0301: 2.3.5.2 (LinuxGuruGamer) for KSP 1.2.2
```
Changed checks from circumstances to seeing if the icons are being displayed.
Fixed nullrefs when Commnet not enabled in flight scene
```
* 2017-0228: 2.3.5.1 (LinuxGuruGamer) for KSP 1.2.2
	+ Added check for relay when adjusting dropdown
* 2017-0228: 2.3.5 (LinuxGuruGamer) for KSP 1.2.2
```
Fixed button not appearing on map view and in tracking screen
Fixed dropdown location when Kerbal is on EVA
Fixed dropdown location when Commnet is not active
Added option to disable dropdown in settings
```
* 2017-0207: 2.3.4 (LinuxGuruGamer) for KSP 1.2.2
	+ Fixed the dropdown icon from covering up the Commnet icons
* 2017-0207: 2.3.3 (LinuxGuruGamer) for KSP 1.2.2
	+ Moved enabled setting into standard system settings
	+ Fixed window from staying open on the main menu
	+ Made windows movable
	+ Changed mod activation from gameObject.AddComponent<BetterTimeWarp> (); to using the   [KSPAddon(KSPAddon.Startup.FlightAndKSC | KSPAddon.Startup.TrackingStation, false)]
	+ Added setting to hide button in all scenes
	+ Added setting to hide button in flight
	+ Added setting to  lock window positions in Flight
	+ Added setting to lock window positions everywhere else
	+ Fixed dialogs which didn't have an OK button
* 2017-0206: 2.3.2 (LinuxGuruGamer) for KSP 1.2.2
	+ Renamed distributed settings file
* 2017-0114: 2.3.1 (LinuxGuruGamer) for KSP 1.2.2
	+ Changed settings file to live in PluginData as a true .cfg file
	+ Fixed "enabled" setting in cfg file to be in a node
	+ Updated link in Readme.md file
* 2017-0113: 2.3.0 (LinuxGuruGamer) for KSP 1.2.2
	+ Initial Release
* 2015-1116: 2.2 (MrHappyFace) for KSP 1.0.5
	+ Changelog:
		- Updated to 1.0.5
		- Fixed spelling errors
		- Fixed configuration error
* 2015-0805: 2.1 (MrHappyFace) for KSP 1.0.5
	+ Changelog:
		- Added persistent time warp selections.
		- Added the GUI to the space center and tracking station
		- Minor bugfixes
		- 1.0.4 support
* 2015-0510: 2.0 (MrHappyFace) for KSP 1.0.5
	+ Changes:
		- Completely overhauled UI
		- Added Lossless Physics, which allows you to keep accurate physics simulation even at high warp
		- Scrolling on the UI no longer affects the camera
		- The camera no longer is slow and laggy in lower time warp
		- Fixed the issue where the button did not scale with the rest of the UI properly
		- Fixed many more issues as well :octopus:
* 2015-0509: 1.2 (MrHappyFace) for KSP 1.0.5
	+ compatibility for 1.0.X
	+ cleaned up the UI a bit
* 2014-0716: 1.1 (MrHappyFace) for KSP 1.0.5
	+ added F2 making the UI disappear
* 2014-0714: 1.0 (MrHappyFace) for KSP 1.0.5
	+ First release!
