/*
	This file is part of Better Time Warp /L Unleashed
		© 2023 Lisias T : http://lisias.net <support@lisias.net>

	THIS FILE is licensed to you under:

	* WTFPL - http://www.wtfpl.net
		* Everyone is permitted to copy and distribute verbatim or modified
 			copies of this license document, and changing it is allowed as long
			as the name is changed.

	THIS FILE is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
*/
using System;
using System.Collections;
using System.Diagnostics;

using Logger = KSPe.Util.Log.Logger;

namespace BetterTimeWarp
{
	public static class Log
	{
		private static readonly Logger LOG = Logger.CreateForType<BetterTimeWarp>();

		public static int debuglevel
		{
			get => (int)LOG.level;
			set => LOG.level = (KSPe.Util.Log.Level)(value % 6);
		}

		public static void force(string format, params object[] @parms)
		{
			LOG.force(format, parms);
		}

		public static void trace(string format, params object[] @parms)
		{
			LOG.trace(format, parms);
		}

		public static void detail(string format, params object[] @parms)
		{
			LOG.detail(format, parms);
		}

		public static void info(string format, params object[] @parms)
		{
			LOG.info(format, parms);
		}

		public static void warn(string format, params object[] @parms)
		{
			LOG.warn(format, parms);
		}

		public static void err(string format, params object[] parms)
		{
			LOG.error(format, parms);
		}

		public static void ex(object offended, System.Exception e)
		{
			LOG.error(offended, e);
		}

		[Conditional("DEBUG")]
		public static void dbg(string format, params object[] @parms)
		{
			LOG.dbg(format, parms);
		}

		static Stack funcStack = new Stack();
		[ConditionalAttribute("DEBUG")]
		public static void PushStackInfo(string funcName, string msg)
		{
			funcStack.Push(funcName);
			Log.detail(msg);
		}

		[ConditionalAttribute("DEBUG")]
		public static void PopStackInfo(string msg)
		{
			if (funcStack.Count > 0)
			{
				string f = (string)funcStack.Pop();
			}
			else
				Log.warn("Pop failed, no values on stack");
			Log.dbg(msg);
		}

		[ConditionalAttribute("DEBUG")]
		public static void ShowStackInfo()
		{
			int cnt = 0;
			Log.dbg("Stack size: " + funcStack.Count.ToString());
			foreach (var obj in funcStack)
			{
				Log.dbg("Stack[" + cnt.ToString() + "] = " + (string)obj);
				cnt++;
			}
		}

	}
}
