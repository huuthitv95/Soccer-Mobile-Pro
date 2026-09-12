using System.IO;

namespace SoccerMobilePro.MatchCore.Tests
{
    /// <summary>Doc fixture rule set P1-06 tu cay project, dung chung cho cac test EditMode.</summary>
    internal static class PlayerItemsSquadRulesFixture
    {
        internal static string ReadJson()
        {
            string path = ResolvePath();
            if (path == null) throw new FileNotFoundException("Squad rules fixture was not found from the working directory.", PlayerItems.PlayerItemsFixtureFactory.SquadRulesFixtureRelativePath);
            return File.ReadAllText(path);
        }

        internal static string ResolvePath()
        {
            string relative = PlayerItems.PlayerItemsFixtureFactory.SquadRulesFixtureRelativePath.Replace('/', Path.DirectorySeparatorChar);
            var directory = new DirectoryInfo(Directory.GetCurrentDirectory());
            while (directory != null)
            {
                string candidate = Path.Combine(directory.FullName, relative);
                if (File.Exists(candidate)) return candidate;
                directory = directory.Parent;
            }

            return null;
        }
    }
}
