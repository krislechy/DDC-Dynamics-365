using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDC.BL.Services
{
    public class FolderCreator
    {
        private readonly string rootFolder;
        private readonly string organizationFolder;
        private readonly string objectFolder;
        private readonly string typeDocFolder;
        private readonly string nameDocFolder;
        private readonly string dateStatusFolder;
        public string FullPath { get => rootFolder + "\\" + organizationFolder + "\\" + objectFolder + "\\" + typeDocFolder + "\\" + nameDocFolder + "\\" + dateStatusFolder; }
        public FolderCreator(string rootFolder, string organizationFolder, string objectFolder, string typeDocFolder, string nameDocFolder, string dateStatusFolder)
        {
            this.rootFolder = rootFolder;
            this.organizationFolder = UnscapeFromInvalidFileName(organizationFolder);
            this.objectFolder = UnscapeFromInvalidFileName(objectFolder);
            this.typeDocFolder = UnscapeFromInvalidFileName(typeDocFolder);
            this.nameDocFolder = UnscapeFromInvalidFileName(nameDocFolder);
            this.dateStatusFolder = UnscapeFromInvalidFileName(dateStatusFolder);
        }

        public void CreateFolderChain() =>
            Directory.CreateDirectory(UnscapeFromInvalidPath(FullPath));

        public string UnscapeFromInvalidPath(string path) =>
            string.Join("_", path.Split(Path.GetInvalidPathChars()));

        public string UnscapeFromInvalidFileName(string filename) =>
            string.Join("_", filename.Split(Path.GetInvalidFileNameChars()));
    }
}
