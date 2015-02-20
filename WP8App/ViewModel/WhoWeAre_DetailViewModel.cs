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
    /// Implementation of WhoWeAre_Detail ViewModel.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public partial class WhoWeAre_DetailViewModel : ViewModelsBase.VMBase, IViewModels.IWhoWeAre_DetailViewModel, ViewModelsBase.INavigable
    {       

		private readonly IServices.IDialogService _dialogService;
		private readonly IServices.INavigationService _navigationService;
		private readonly IServices.ISpeechService _speechService;
		private readonly IServices.IShareService _shareService;
		private readonly IServices.ILiveTileService _liveTileService;
		
        /// <summary>
        /// Initializes a new instance of the <see cref="WhoWeAre_DetailViewModel" /> class.
        /// </summary>
        /// <param name="dialogService">The Dialog Service.</param>
        /// <param name="navigationService">The Navigation Service.</param>
        /// <param name="speechService">The Speech Service.</param>
        /// <param name="shareService">The Share Service.</param>
        /// <param name="liveTileService">The Live Tile Service.</param>
        public WhoWeAre_DetailViewModel(IServices.IDialogService dialogService, IServices.INavigationService navigationService, IServices.ISpeechService speechService, IServices.IShareService shareService, IServices.ILiveTileService liveTileService)
        {
			_dialogService = dialogService;
			_navigationService = navigationService;
			_speechService = speechService;
			_shareService = shareService;
			_liveTileService = liveTileService;
        }
		
	
		private Entities.WhoWeAreSchema _currentWhoWeAreSchema;

        /// <summary>
        /// CurrentWhoWeAreSchema property.
        /// </summary>		
        public Entities.WhoWeAreSchema CurrentWhoWeAreSchema
        {
            get
            {
				return _currentWhoWeAreSchema;
            }
            set
            {
                SetProperty(ref _currentWhoWeAreSchema, value);
            }
        }

        /// <summary>
        /// Delegate method for the TextToSpeechWhoWeAre_DetailStaticControlCommand command.
        /// </summary>
        public  void TextToSpeechWhoWeAre_DetailStaticControlCommandDelegate() 
        {
				_speechService.TextToSpeech(CurrentWhoWeAreSchema.Subtitle + " " + CurrentWhoWeAreSchema.Description);
        }
		

        private ICommand _textToSpeechWhoWeAre_DetailStaticControlCommand;

        /// <summary>
        /// Gets the TextToSpeechWhoWeAre_DetailStaticControlCommand command.
        /// </summary>
        public ICommand TextToSpeechWhoWeAre_DetailStaticControlCommand
        {
            get { return _textToSpeechWhoWeAre_DetailStaticControlCommand = _textToSpeechWhoWeAre_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(TextToSpeechWhoWeAre_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the ShareWhoWeAre_DetailStaticControlCommand command.
        /// </summary>
        public  void ShareWhoWeAre_DetailStaticControlCommandDelegate() 
        {
				_shareService.Share(CurrentWhoWeAreSchema.Subtitle, CurrentWhoWeAreSchema.Description, "", CurrentWhoWeAreSchema.Image);
        }
		

        private ICommand _shareWhoWeAre_DetailStaticControlCommand;

        /// <summary>
        /// Gets the ShareWhoWeAre_DetailStaticControlCommand command.
        /// </summary>
        public ICommand ShareWhoWeAre_DetailStaticControlCommand
        {
            get { return _shareWhoWeAre_DetailStaticControlCommand = _shareWhoWeAre_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(ShareWhoWeAre_DetailStaticControlCommandDelegate); }
        }

        /// <summary>
        /// Delegate method for the PinToStartWhoWeAre_DetailStaticControlCommand command.
        /// </summary>
        public  void PinToStartWhoWeAre_DetailStaticControlCommandDelegate() 
        {
				_liveTileService.PinToStart(typeof(IViewModels.IWhoWeAre_DetailViewModel), CreateTileInfoWhoWeAre_DetailStaticControl());
        }
		

        private ICommand _pinToStartWhoWeAre_DetailStaticControlCommand;

        /// <summary>
        /// Gets the PinToStartWhoWeAre_DetailStaticControlCommand command.
        /// </summary>
        public ICommand PinToStartWhoWeAre_DetailStaticControlCommand
        {
            get { return _pinToStartWhoWeAre_DetailStaticControlCommand = _pinToStartWhoWeAre_DetailStaticControlCommand ?? new ViewModelsBase.DelegateCommand(PinToStartWhoWeAre_DetailStaticControlCommandDelegate); }
        }
		public object NavigationContext
        {
            set
            {              
                if (!(value is Entities.WhoWeAreSchema)) { return; }
                
                CurrentWhoWeAreSchema = value as Entities.WhoWeAreSchema;
            }
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the WhoWeAre_DetailStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoWhoWeAre_DetailStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = CurrentWhoWeAreSchema.Subtitle,
                Title = CurrentWhoWeAreSchema.Subtitle,
                BackTitle = CurrentWhoWeAreSchema.Subtitle,
                BackContent = CurrentWhoWeAreSchema.Description,
                Count = 0,
                BackgroundImagePath = CurrentWhoWeAreSchema.Image,
                BackBackgroundImagePath = CurrentWhoWeAreSchema.Image,
                LogoPath = "Logo-89401204-353b-44fd-86c0-eeff17be5801.png"
            };
            return tileInfo;
        }
        /// <summary>
        /// Initializes a <see cref="Services.TileInfo" /> object for the infoStaticControl control.
        /// </summary>
		/// <returns>A <see cref="Services.TileInfo" /> object.</returns>
        public Services.TileInfo CreateTileInfoinfoStaticControl()
        {
            var tileInfo = new Services.TileInfo
            {
                CurrentId = string.Empty,
                Title = string.Empty,
                BackTitle = string.Empty,
                BackContent = CurrentWhoWeAreSchema.Description,
                Count = 0,
                BackgroundImagePath = string.Empty,
                BackBackgroundImagePath = string.Empty,
                LogoPath = "Logo-89401204-353b-44fd-86c0-eeff17be5801.png"
            };
            return tileInfo;
        }
    }
}
