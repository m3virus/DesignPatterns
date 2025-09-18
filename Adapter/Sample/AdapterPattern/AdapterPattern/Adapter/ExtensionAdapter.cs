using AdapterPattern.FolderExtension;

namespace AdapterPattern.Adapter
{
    internal class ExtensionAdapter : ExcelFiles
    {
        private readonly PDFFIles _pdfFiles = new PDFFIles();

        public new void ExcelCreate()
        {
            _pdfFiles.PDFFIlesCreate();
        }
    }
}
