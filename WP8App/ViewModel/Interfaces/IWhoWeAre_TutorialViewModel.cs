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
    /// WhoWeAre_Tutorial ViewModel interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IWhoWeAre_TutorialViewModel
    {		
	    /// <summary>
        /// IsInternetAvalaible property.
        /// </summary>		
        Visibility IsInternetAvalaible { get; }
        /// <summary>
        /// Gets/Sets the WhoWeAre_TutorialListControlCollection property.
        /// </summary>
		ObservableCollection<Entities.WhoWeAreSchema> WhoWeAre_TutorialListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the WhoWeAre_TutorialListControlCollectionPageNumber property.
        /// </summary>
		int WhoWeAre_TutorialListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedWhoWeAre_TutorialListControlCollection property.
        /// </summary>
		Entities.WhoWeAreSchema SelectedWhoWeAre_TutorialListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the PhotoAlbum_TutorialPhotosListControlCollection property.
        /// </summary>
		ObservableCollection<Entities.PhotoAlbumCollectionSchema> PhotoAlbum_TutorialPhotosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the PhotoAlbum_TutorialPhotosListControlCollectionPageNumber property.
        /// </summary>
		int PhotoAlbum_TutorialPhotosListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the SelectedPhotoAlbum_TutorialPhotosListControlCollection property.
        /// </summary>
		Entities.PhotoAlbumCollectionSchema SelectedPhotoAlbum_TutorialPhotosListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Moments_AuthorListControlCollection property.
        /// </summary>
		ObservableCollection<Entities.momentsSchema> Moments_AuthorListControlCollection { get; set; }
        /// <summary>
        /// Gets/Sets the Moments_AuthorListControlCollectionPageNumber property.
        /// </summary>
		int Moments_AuthorListControlCollectionPageNumber { get; set; }
        /// <summary>
        /// Gets/Sets the Selectedmoments_AuthorListControlCollection property.
        /// </summary>
		Entities.momentsSchema Selectedmoments_AuthorListControlCollection { get; set; }
        
        /// <summary>
        /// Gets the RefreshWhoWeAre_TutorialListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshWhoWeAre_TutorialListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetWhoWeAre_TutorialListControlCollectionCommand command.
        /// </summary>
		ICommand GetWhoWeAre_TutorialListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the RefreshPhotoAlbum_TutorialPhotosListControlCollectionCommand command.
        /// </summary>
		ICommand RefreshPhotoAlbum_TutorialPhotosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the GetPhotoAlbum_TutorialPhotosListControlCollectionCommand command.
        /// </summary>
		ICommand GetPhotoAlbum_TutorialPhotosListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the Refreshmoments_AuthorListControlCollectionCommand command.
        /// </summary>
		ICommand Refreshmoments_AuthorListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the Getmoments_AuthorListControlCollectionCommand command.
        /// </summary>
		ICommand Getmoments_AuthorListControlCollectionCommand { get; }

        
        /// <summary>
        /// Gets the SetLockScreenCommand command.
        /// </summary>
		ICommand SetLockScreenCommand { get; }

        
        /// <summary>
        /// Gets the AboutCommand command.
        /// </summary>
		ICommand AboutCommand { get; }

	}
}
