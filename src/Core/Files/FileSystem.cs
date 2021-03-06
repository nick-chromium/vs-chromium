using System;
using System.ComponentModel.Composition;
using System.IO;

namespace VsChromium.Core.Files {
  [Export(typeof(IFileSystem))]
  public class FileSystem : IFileSystem {
    public bool FileExists(FullPath path) {
      return File.Exists(path.Value);
    }

    public bool DirectoryExists(FullPath path) {
      return Directory.Exists(path.Value);
    }

    public DateTime GetFileLastWriteTimeUtc(FullPath path) {
      return File.GetLastWriteTimeUtc(path.Value);
    }

    public string[] ReadAllLines(FullPath path) {
      return File.ReadAllLines(path.Value);
    }
  }
}