using TableOfContentGenerator.SDK.DirectoryExplorator;

namespace TableOfContentGenerator.SDK;

public record ExplorationInfos(List<ExplorationFileInfos> Files, DateTime LastExcecution, string Path)
{
}
