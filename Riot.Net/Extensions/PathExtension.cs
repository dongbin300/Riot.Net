namespace Riot.Net.Extensions
{
    public static class PathExtension
    {
        public static string CombineUri(this string baseUri, params string[] relativeUris)
        {
            baseUri = baseUri.TrimEnd('/');
            var _relativeUris = relativeUris.Select(u => u.TrimStart('/')).ToArray();
            string[] uris = new string[_relativeUris.Length + 1];
            uris[0] = baseUri;
            _relativeUris.CopyTo(uris, 1);

            return string.Join("/", uris);
        }
    }
}
