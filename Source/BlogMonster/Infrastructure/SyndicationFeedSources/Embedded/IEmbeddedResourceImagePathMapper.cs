namespace BlogMonster.Infrastructure.SyndicationFeedSources.Embedded
{
    public interface IEmbeddedResourceImagePathMapper
    {
        string ReMapImagePaths(string markdown, string baseResourceName);
    }
}