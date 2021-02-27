using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$
using System.Text;
using Connexion.Core;

namespace $safeprojectname$
{
	public class $safeprojectname$UIViewModel : ViewModelBase
	{
		private $safeprojectname$Configuration m_Config;
		private IDeviceUIParams m_DeviceUIParams;

		public $safeprojectname$UIViewModel($safeprojectname$Configuration config, IDeviceUIParams deviceUIParams)
		{
			m_Config = config;
			m_DeviceUIParams = deviceUIParams;
		}

		public $safeprojectname$Configuration Configuration
		{
			get { return m_Config; }
		}
	}
}
