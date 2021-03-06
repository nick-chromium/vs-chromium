using System.Collections.Generic;
using VsChromium.Core.Files;
using VsChromium.Server.FileSystemNames;

namespace VsChromium.Server.FileSystemSnapshot {
  public interface IFileSystemSnapshotBuilder {
    FileSystemTreeSnapshot Compute(IFileSystemNameFactory fileNameFactory, IEnumerable<FullPath> filenames, int version);
  }
}