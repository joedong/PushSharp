﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PushSharp.Common;

namespace PushSharp.Android
{
	public class AndroidPushService : PushServiceBase
	{
		public AndroidPushService(PushChannelSettings channelSettings, PushServiceSettings serviceSettings = null)
			: base(channelSettings, serviceSettings)
		{
		}

		protected override PushChannelBase CreateChannel(PushChannelSettings channelSettings)
		{
			return new AndroidPushChannel(channelSettings as AndroidPushChannelSettings);
		}
	}
}
