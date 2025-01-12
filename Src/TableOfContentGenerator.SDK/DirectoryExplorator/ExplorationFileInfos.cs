namespace TableOfContentGenerator.SDK.DirectoryExplorator;

public record ExplorationFileInfos(
    DateTime LastModificationDate,
    bool Modified,
    string Name,
    string Path,
    TimeSpan Time)
{
}
