// ------------------------------------------------------------------------
// ========================================================================
// THIS CODE AND INFORMATION ARE GENERATED BY AUTOMATIC CODE GENERATOR
// ========================================================================
// Template:   IDataSource.tt
using System.CodeDom.Compiler;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Entities=WPAppStudio.Entities;
using EntitiesBase=WPAppStudio.Entities.Base;
using WPAppStudio.Shared;

namespace WPAppStudio.Repositories
{
    /// <summary>
    /// WhoWeAre_WhoWeAreCollection interface.
    /// </summary>
    [CompilerGenerated]
    [GeneratedCode("Radarc", "4.0")]
    public interface IWhoWeAre_WhoWeAreCollection
    {
		Task<ObservableCollection<Entities.WhoWeAreSchema>> GetData(int pageNumber = 0);
        Task<ObservableCollection<Entities.WhoWeAreSchema>> Refresh();
		Entities.WhoWeAreSchema Previous(Entities.WhoWeAreSchema current);
		Task<Entities.WhoWeAreSchema> Next(Entities.WhoWeAreSchema current);
    }
}