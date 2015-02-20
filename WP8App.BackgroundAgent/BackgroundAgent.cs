// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   BackgroundProcess.tt
/*
 * Uncomment it to easily test the agent
 * 
#define DEBUG_AGENT
*/
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using Microsoft.Phone.Scheduler;
using WPAppStudio.BackgroundProcess.Agents;
using WPAppStudio.BackgroundProcess.Ioc;
using WPAppStudio.BackgroundProcess.Ioc.Interfaces;
using WPAppStudio.Entities;
using WPAppStudio.Entities.Base;
using WPAppStudio.Repositories;
using WPAppStudio.Repositories.Base;

namespace WPAppStudio.BackgroundProcess
{
    public class BackgroundAgent : ScheduledTaskAgent
    {
        private static IContainer backgroundContainer;

        /// <remarks>
        /// BackgroundAgent constructor, initializes the UnhandledException handler
        /// </remarks>
        static BackgroundAgent()
        {
            // Subscribe to the managed exception handler
            Deployment.Current.Dispatcher.BeginInvoke(delegate
            {
                Application.Current.UnhandledException += UnhandledException;
            });
			backgroundContainer = new BackgroundProcessContainer();
        }

        /// Code to execute on Unhandled Exceptions
        private static void UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            if (Debugger.IsAttached)
            {
                // An unhandled exception has occurred; break into the debugger
                Debugger.Break();
            }
        }

        /// <summary>
        /// Agent that runs a scheduled task
        /// </summary>
        /// <param name="task">
        /// The invoked task
        /// </param>
        /// <remarks>
        /// This method is called when a periodic or resource intensive task is invoked
        /// </remarks>
        protected override void OnInvoke(ScheduledTask task)
        {
			UpdateCycleTileData();

#if DEBUG_AGENT
            ScheduledActionService.LaunchForTest(task.Name, TimeSpan.FromSeconds(60));
#endif
        }
        protected async void UpdateCycleTileData()
        {
            var agent = new CycleTileAgent();
			var newImagesFiles = new List<string>();
            var whoWeAre_WhoWeAreCollection = backgroundContainer.Resolve<IWhoWeAre_WhoWeAreCollection>();
			var whoWeAre_WhoWeAreCollectionItems = new List<WhoWeAreSchema>();
			var whoWeAre_WhoWeAreCollectionData = await whoWeAre_WhoWeAreCollection.GetData();
			whoWeAre_WhoWeAreCollectionItems.AddRange(whoWeAre_WhoWeAreCollectionData);
            newImagesFiles.AddRange(whoWeAre_WhoWeAreCollectionItems.Select(i => i.Image).ToList());
            agent.UpdateCycleTile(newImagesFiles);
			NotifyComplete();
        }
    }
}
