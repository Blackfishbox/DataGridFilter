using MahAppsTestApplication.Model;
using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;

namespace MahAppsTestApplication.ViewModels
{
    public class ShellViewModel : BindableBase
    {
        public ShellViewModel()
        {
            Documents = new ObservableCollection<Document>
            {
                new Document { Medium = MediumNames.EMail },
                new Document { Medium = MediumNames.EMail },
                new Document { Medium = MediumNames.EMail },
                new Document { Medium = MediumNames.EMail },
                new Document { Medium = MediumNames.Fax },
                new Document { Medium = MediumNames.Fax },
                new Document { Medium = MediumNames.Fax },
                new Document { Medium = MediumNames.Post },
                new Document { Medium = MediumNames.Post },
                new Document { Medium = MediumNames.Post },
                new Document { Medium = MediumNames.Post },
                new Document { Medium = MediumNames.Post },
                new Document { Medium = MediumNames.Post }
            };

            DocumentsView = CollectionViewSource.GetDefaultView(Documents);
        }

        public ObservableCollection<Document> Documents { get; }

        public ICollectionView DocumentsView { get; }
    }
}
