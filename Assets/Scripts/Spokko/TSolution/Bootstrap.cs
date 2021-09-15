using Spokko.TFramework;
using UnityEngine;

namespace Spokko.TSolution
{
	public class Bootstrap : TestMono
	{
		private POIManager _poiManager;
		
		protected override void OnStart()
		{
			_poiManager = new POIManager(MonsterInstances, MonstersBundle);
			
			AddTickable(_poiManager);
		}
	}
}
