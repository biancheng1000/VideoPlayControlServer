using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace VideoPlayControlServer.Business.PlayList
{
	/// <summary>
	/// 视频播放信息
	/// </summary>
	public class VideoPlayInfo:BindableBase
	{
		string  playTime;
		string fileName;
		Double duration;
		string stopTime;

		/// <summary>
		/// 播放开始时间，因为是每天的时间，所以用分钟
		/// </summary>
		public string PlayTime { get => playTime; set => playTime = value; }

		/// <summary>
		/// 文件名称
		/// </summary>
		public string FileName { get => fileName; set => fileName = value; }

		/// <summary>
		/// 持续时间 单位秒
		/// </summary>
		public double Duration { get => duration; set => duration = value; }

		/// <summary>
		/// 预计播放停止时间
		/// </summary>
		public string StopTime { get => stopTime; set => stopTime = value; }
	}
}
