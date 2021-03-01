using System;
using System.Collections.Generic;
$if$ ($targetframeworkversion$ >= 3.5)using System.Linq;
$endif$using System.Text;
using System.Threading;
using Connexion.Core;
using Connexion.Core.HL7;
using System.Threading.Tasks;

namespace $safeprojectname$
{
	/// <summary>
	/// Update the attribute below to include a device name, input and output types (object if your device accepts any type), and device configuration type.
	/// </summary>
	[DevicePlugin("$safeprojectname$","$safeprojectname$ Connexion Device", DeviceDefinitionFlags.None, typeof(object), typeof(object), typeof($safeprojectname$Factory))]
	public class $safeprojectname$ : BaseDevice<$safeprojectname$Configuration>
	{
        /// <summary>
	    /// Called once when the channel is started. Place any custom startup logic you need here.
	    /// </summary>
		public override void Start()
		{
			MessageChannel.Logger.Write(EventSeverity.Info, "Device is starting");
		}

        /// <summary>
        /// Called once when the channel is stopped. Place any custom cleanup logic you need here.
        /// </summary>
        public override void Stop()
		{
			MessageChannel.Logger.Write(EventSeverity.Info, "Device is stopping");
		}

        // Please use the async version if possible. this will be called for each message that is being sent through the system.
        //public override void ProcessMessage(IMessageContext context)
        //{
        //  // get and cast the message to the desired type
        //  var message = context.Message;        
        //  // you can write processing events which are tied to the current message
        //  context.WriteEvent(EventSeverity.Info, "Some text");
        //}        
        // 

        /// <summary>
        ///  A method which is called for each message that is being sent through the system.
        ///  It allows you to inspect and react to a message using custom logic
        ///  or by writing one of several predefined processing events which are tied to the current message.
        /// </summary>
        /// <param name="context">The IMessageContext</param>
        /// <param name="token">A token that monitors for attempts to cancel message processing.</param>
        /// <returns></returns>
        public override async Task ProcessMessageAsync(IMessageContext context, CancellationToken token)
		{
			// get and cast the message to the desired type
			var message = context.Message;

			// you can write processing events which are tied to the current message
			context.WriteEvent(EventSeverity.Info, "Some text");
		}

        /// <summary>
        /// Called when an exception occurs in ProcessMessage (or the async version).
		/// Add custom error logging here.
		/// Set the device's retry delay and/or backing-off strategy here.
        /// </summary>
        /// <param name="context"></param>
        /// <param name="args"></param>
        public override void OnError(IMessageContext context, ErrorEventArgs args)
		{
			// retry the message?
			args.ShouldRetry = true;

			// todo: write something to the context and/or log

			// wait before trying again?
			args.SleepTime = TimeSpan.FromSeconds(args.TotalRetries > 2 ? 30 : 5);
		}
	}
}
