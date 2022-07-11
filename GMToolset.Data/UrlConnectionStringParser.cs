namespace GMToolset.Data
{
    public class UrlConnectionStringParser
    {
		public string GetConnectionString(string dbUrl)
		{
			bool isUrl = Uri.TryCreate(dbUrl, UriKind.Absolute, out Uri uri);
			if (isUrl && uri != null)
			{
				var connectionUrl = $"host={uri.Host};username={uri.UserInfo.Split(':')[0]};password={uri.UserInfo.Split(':')[1]};database={uri.LocalPath.Substring(1)};pooling=true;";
				return connectionUrl;
			}
			else
			{
				return string.Empty;
			}
		}
	}
}
