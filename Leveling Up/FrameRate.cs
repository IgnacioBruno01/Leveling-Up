using SFML.System;
using System;
using System.Collections.Generic;
using System.Text;

namespace Leveling_Up
{
	public static class FrameRate
	{
		public static readonly uint FRAMERATE_LIMIT = 60;
		private static Clock clock;
		private static Time previousTime;
		private static Time currentTime;
		private static float fps;
		private static float deltaTime;
		public static void InitFrameRateSystem()
		{
			clock = new Clock();
			previousTime = clock.ElapsedTime;
		}

		public static void OnFrameEnd()
		{
			currentTime = clock.ElapsedTime;
			deltaTime = currentTime.AsSeconds() - previousTime.AsSeconds();
			fps = 1.0f / deltaTime;
			previousTime = currentTime;
		}

		public static float GetCurrentFPS()
		{
			return fps;
		}

		public static float GetDeltaTime()
		{
			return deltaTime;
		}
	}
}
