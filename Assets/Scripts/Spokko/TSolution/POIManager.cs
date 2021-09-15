using System;
using System.Collections.Generic;
using Spokko.TFramework;
using UnityEngine;
using Object = UnityEngine.Object;
using Random = UnityEngine.Random;

namespace Spokko.TSolution
{
	public class POIManager : ITickable
	{
		private static readonly DateTime EPOCH = new DateTime(1970,1,1,0,0,0,DateTimeKind.Utc);
		private static long NOW => (long)(DateTime.Now - EPOCH).TotalSeconds;

		public POIManager(MonsterInstance[] monsterInstances, AssetBundle monstersBundle)
		{
		}

		public void Tick()
		{
		}
	}
}
