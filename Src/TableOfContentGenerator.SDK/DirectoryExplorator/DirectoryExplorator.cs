using System.IO.Abstractions;

namespace TableOfContentGenerator.SDK.DirectoryExplorator;

public sealed class DirectoryExplorator(
    string PathFrom,
    DateTime RefDate,
    string[] ExcludedDirectories,
    string[] ExcludedFiles,
    IFileSystem? FileSystem)
{
    private readonly IFileSystem _fileSystem = FileSystem ?? new FileSystem();
    public ExplorationInfos Explore(string path)
    {
        return new ExplorationInfos([], DateTime.Now, path);
    }
}
