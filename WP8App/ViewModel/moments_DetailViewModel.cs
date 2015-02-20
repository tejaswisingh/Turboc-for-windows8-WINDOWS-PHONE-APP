// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   ViewModel.tt
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Input;
using Controls=WPAppStudio.Controls;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using IServices=WPAppStudio.Services.Interfaces;
using IViewModels=WPAppStudio.ViewModel.Interfaces;
using Localization=WPAppStudio.Localization;
using Repositories=WPAppStudio.Repositories;
using Services=WPAppStudio.Services;
using ViewModelsBase=WPAppStudio.ViewModel.Base;
using WPAppStudio;
using WPAppStudio.Shared;

namespace WPAppStudio.ViewModel
{
    /// <summary>
    /// Implementation of moments_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class moments_DetailViewModel : ViewModelsBase.VMBase, IViewModels.Imoments_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly Repositories.moments_momentsCollection _moments_momentsCollection;
		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="moments_DetailViewModel" /> class.
        /// </summary>
        /// <param name="moments_momentsCollection">The Moments_moments Collection.</param>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public moments_DetailViewModel(Repositories.moments_momentsCollection moments_momentsCollection, IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_moments_momentsCollection = moments_momentsCollection;
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.momentsSchema _currentmomentsSchema;

        /// <summary>
        /// CurrentmomentsSchema property.
        /// </summary>		
        public Entities.momentsSchema CurrentmomentsSchema
        {
            get
            {
				return _currentmomentsSchema;
            }
            set
            {
                SetProperty(ref _currentmomentsSchema, value);
            }
        }
	
		private bool _hasNextpanoramamoments_Detail0;

        /// <summary>
        /// HasNextpanoramamoments_Detail0 property.
        /// </summary>		
        public bool HasNextpanoramamoments_Detail0
        {
            get
            {
				return _hasNextpanoramamoments_Detail0;
            }
            set
            {
                SetProperty(ref _hasNextpanoramamoments_Detail0, value);
            }
        }
	
		private bool _hasPreviouspanoramamoments_Detail0;

        /// <summary>
        /// HasPreviouspanoramamoments_Detail0 property.
        /// </summary>		
        public bool HasPreviouspanoramamoments_Detail0
        {
            get
            {
				return _hasPreviouspanoramamoments_Detail0;
            }
            set
            {
                SetProperty(ref _hasPreviouspanoramamoments_Detail0, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechmoments_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechmoments_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentmomentsSchema.Subtitle + " " + CurrentmomentsSchema.Description);
        }
		

        private ICommand _textToSpeechmoments_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechmoments_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechmoments_DetailStaticControlCommand
        {
            get { return _textToSpeechmoments_DetailStaticControlCommand = _textToSpeechmoments_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechmoments_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the Sharemoments_DetailStaticControlCommand command.
        /// </summary>
        public  void Sharemoments_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentmomentsSchema.Subtitle, CurrentmomentsSchema.Description, "", CurrentmomentsSchema.Image);
        }
		

        private ICommand _sharemoments_DetailStaticControlCommand;

        /// <summary>
        /// Gets the Sharemoments_DetailStaticControlCommand command.
        /// </summary>
        public ICommand Sharemoments_DetailStaticControlCommand
        {
            get { return _sharemoments_DetailStaticControlCommand = _sharemoments_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(Sharemoments_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartmoments_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartmoments_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.Imoments_DetailViewModel), CreateTileInfomoments_DetailStaticControl());
        }
		

        private ICommand _pinToStartmoments_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartmoments_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartmoments_DetailStaticControlCommand
        {
            get { return _pinToStartmoments_DetailStaticControlCommand = _pinToStartmoments_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartmoments_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the Nextpanoramamoments_Detail0 command.
        /// </summary>
        public async void Nextpanoramamoments_Detail0Delegate() 
        {
				LoadingCurrentmomentsSchema = true;
			var next = await  _moments_momentsCollection.Next(CurrentmomentsSchema);

			if(next != null)
				CurrentmomentsSchema = next;

			RefreshHasPrevNext();
        }
		
		
        private bool _loadingCurrentmomentsSchema;
		
        public bool LoadingCurrentmomentsSchema
        {
            get { return _loadingCurrentmomentsSchema; }
            set { SetProperty(ref _loadingCurrentmomentsSchema, value); }
        }

        private ICommand _nextpanoramamoments_Detail0;

        /// <summary>
        /// Gets the Nextpanoramamoments_Detail0 command.
        /// </summary>
        public ICommand Nextpanoramamoments_Detail0
        {
            get { return _nextpanoramamoments_Detail0 = _nextpanoramamoments_Detail0 ?? new ViewModelsBase.DelegateCommand(Nextpanoramamoments_Detail0Delegate); }
        }

        /// <summary>
        /// Delegate method for the Previouspanoramamoments_Detail0 command.
        /// </summary>
        public  void Previouspanoramamoments_Detail0Delegate() 
        {
			var prev =  _moments_momentsCollection.Previous(CurrentmomentsSchema);

			if(prev != null)
				CurrentmomentsSchema = prev;

			RefreshHasPrevNext();
        }
		

        private ICommand _previouspanoramamoments_Detail0;

        /// <summary>
        /// Gets the Previouspanoramamoments_Detail0 command.
        /// </summary>
        public ICommand Previouspanoramamoments_Detail0
        {
            get { return _previouspanoramamoments_Detail0 = _previouspanoramamoments_Detail0 ?? new ViewModelsBase.DelegateCommand(Previouspanoramamoments_Detail0Delegate); }
        }

        private async void RefreshHasPrevNext()
        {
            HasPreviouspanoramamoments_Detail0 = _moments_momentsCollection.HasPrevious(CurrentmomentsSchema);
			HasNextpanoramamoments_Detail0 = await _moments_momentsCollection.HasNext(CurrentmomentsSchema);
			LoadingCurrentmomentsSchema = false;
		}
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.momentsSchema)) { return; }
                
                CurrentmomentsSchema = value as Entities.momentsSchema;
                RefreshHasPrevNext();
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the moments_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfomoments_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentmomentsSchema.Subtitle,
                Title = CurrentmomentsSchema.Subtitle,
                BackTitle = CurrentmomentsSchema.Subtitle,
                BackContent = CurrentmomentsSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentmomentsSchema.Image,
                BackBackgroundImagePath = CurrentmomentsSchema.Image,
                LogoPath = "Logo-89401204-353b-44fd-86c0-eeff17be5801.png"
            };
            return tileInfo;
        }
    }
}
