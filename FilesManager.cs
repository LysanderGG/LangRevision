using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LangRevision
{
    class FilesManager
    {
        public static bool IsValidFileName(String _fileName) {
            return !String.IsNullOrEmpty(_fileName.Trim());
        }

        public static bool ExistsFileInDirectory(String _dirPath, String _fileName) {
            String[] filePaths = Directory.GetFiles(_dirPath);

            foreach(String filePath in filePaths) {
                String fileName = filePath.Remove(0, _dirPath.Length + 1);
                if(fileName.Equals(_fileName)) {
                    return true;
                }
            }

            return false;
        }

    }
}
