using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$
using System.Text;
using System.Runtime.Serialization;
using Connexion.Core;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.ComponentModel;

namespace $safeprojectname$
{
    /// <summary>
	/// Connexion Device Configuration class.
	/// </summary>
	[DataContract(IsReference = true)]
	public class $safeprojectname$Configuration : NotifyBase, IDataErrorInfo
	{
		/// <summary>
		/// Define all the properties which will be used to configure your device. All members marked with [DataMember] will be
		/// persisted in the Connexion database.
		/// If you will be handling sensitive data, you can use the [Encrypted] attribute. This attribute must decorate each property
		/// to be encrypted, as well as this configuration class.
		/// </summary>
		private string m_AConfigurationProperty = string.Empty;
		[DataMember]
		public string AConfigurationProperty
		{
			get { return m_AConfigurationProperty; }
			set
			{
				// When the property changes, call RaisePropertyChanged to inform the UI to refresh.
				// The main window will automatically pick up changes and set the save button icon state. If
				// you do not want to cause the channel show changes, do not call RaisePropertyChanged.
				if (m_AConfigurationProperty != value)
				{
					m_AConfigurationProperty = value;
					RaisePropertyChanged();
				}
			}
		}

		#region IDataErrorInfo Members

        /// <summary>
		/// Returns the aggregate configuration error messages string.
		/// </summary>
		public string Error
		{
			get { throw new NotImplementedException(); }
		}

        /// <summary>
		/// Gets the configuration error message for the specified configuration member name.
		/// </summary>
		public string this[string columnName]
		{
			get
			{
				string result = null;

				switch (columnName)
				{
					case "AConfigurationProperty":
						if (AConfigurationProperty.Length > 20)
							result = "AConfigurationProperty must be 20 characters or less.";
						break;
				}

				return result;
			}
		}

		#endregion

	}
}



