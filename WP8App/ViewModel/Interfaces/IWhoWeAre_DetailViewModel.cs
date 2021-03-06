// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IViewModel.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;

namespace WPAppStudio.ViewModel.Interfaces
{
    /// <summary>
    /// WhoWeAre_Detail ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IWhoWeAre_DetailViewModel
    {		
        /// <summary>
        /// Gets/Sets the CurrentWhoWeAreSchema property.
        /// </summary>
		Entities.WhoWeAreSchema CurrentWhoWeAreSchema { get; set; }
        
        /// <summary>
        /// Gets the TextToSpeechWhoWeAre_DetailStaticControlCommand command.
        /// </summary>
		ICommand TextToSpeechWhoWeAre_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the ShareWhoWeAre_DetailStaticControlCommand command.
        /// </summary>
		ICommand ShareWhoWeAre_DetailStaticControlCommand { get; }

        
        /// <summary>
        /// Gets the PinToStartWhoWeAre_DetailStaticControlCommand command.
        /// </summary>
		ICommand PinToStartWhoWeAre_DetailStaticControlCommand { get; }

	}
}
