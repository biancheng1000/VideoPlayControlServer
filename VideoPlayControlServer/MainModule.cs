using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Modularity;
using Prism.Regions;
using VideoPlayControlServer.Business.PlayList;
using VideoPlayControlServer.Business.VideoList;

namespace VideoPlayControlServer
{
	/// <summary>
	/// 主模块目前唯一,如果以后功能需要扩展，可以添加新的模块
	/// </summary>
	public class MainModule : IModule
	{

		IRegionManager regionManager;
		public MainModule(IRegionManager regionManager)
		{
			this.regionManager = regionManager;
		}
		public void Initialize()
		{
			regionManager.RegisterViewWithRegion("LeftMainRegion",typeof(PlayListView));
			regionManager.RegisterViewWithRegion("RightMainRegion", typeof(VideoBrowserView));
		}
	}
}
