namespace Dna.Core.Framework
{
    /// <summary>
    /// A set of helper methods related to flat file systems, directories, paths and so on
    /// </summary>
    public static class FileHelpers
    {
        #region Paths

        /// <summary>
        /// Find the file or folder name from a full path.
        /// If the path has no folders (\ or /) then the path itself is returned
        /// </summary>
        /// <param name="path">The full path</param>
        /// <returns></returns>
        public static string FileFolderName(this string path)
        {
            // If we have no path, return empty
            if (string.IsNullOrEmpty(path))
                return string.Empty;

            // Make all slashes back slashes
            var normalizedPath = path.Replace('/', '\\');

            // Find the last backslash in the path
            var lastIndex = normalizedPath.LastIndexOf('\\');

            // If we don't find a backslash, return the path itself
            if (lastIndex <= 0)
                return path;

            // Return the name after the last back slash
            return path.Substring(lastIndex + 1);
        }

        #endregion
    }
}
